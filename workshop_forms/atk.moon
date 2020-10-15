HITBOXSHORTCUT =
  type:  'hitbox_type'
  x:     'hitbox_x'
  y:     'hitbox_y'
  w:     'width'
  h:     'height'
  bkb:   'base_knockback'
  kbg:   'knockback_scaling'
  dmg:   'damage'
  vfx:   'visual_effect'
  sfx:   'hit_sfx'
  group: 'hitbox_group'
  frame: 'window_creation_frame'

magiclines = (s) ->
  if s\sub(-1) != "\n" then s=s.."\n"
  s\gmatch "(.-)\n"

as_atk_val = (str) -> 'AG_' .. string.upper str

as_win_val = (str) -> 'AG_WINDOW_' .. string.upper str

as_hbx_val = (str) ->
  str = HITBOXSHORTCUT[str] != nil and HITBOXSHORTCUT[str] or str
  'HG_' .. string.upper str

class Parser
  new: =>
    @hbx_concat = {}
    @win_concat = hitboxes: {}
    @total_concat = windows: {}, hitboxes: {}
    @in_window = false
    @in_hitbox = false
    @just_entered_window = false
    @entered_win_or_hbx_last_line = false
    @line_num = 0
    @indents = {0}
    @line_indent = 0

  line_err_msg: (str) =>
    "\27[31m#{str}
at line #{@line_num}:\27[0m
#{@line_orig}
#{string.rep(' ', @line_cursor - 1)}\27[31m^\27[0m"

  process_dedents: (str) =>
    assert not @entered_win_or_hbx_last_line, @line_err_msg 'improper indent'
    while @line_indent < @indents[#@indents]
      if @in_hitbox
        @in_hitbox = false
        if @in_window
          table.insert @win_concat["hitboxes"], @hbx_concat
        else
          table.insert @total_concat["hitboxes"], @hbx_concat
        @hbx_concat = {}
      elseif @in_window
        @in_window = false
        table.insert @total_concat["windows"], @win_concat
        @win_concat = hitboxes: {}
      table.remove @indents, #@indents
    assert @line_indent == @indents[#@indents], @line_err_msg 'improper indent'

  parse_comments: (line) =>
    _, commentmatch = line\find "^%-%-.*"
    if commentmatch != nil
      _, commentblockmatch = line\find "^%-%-%[%[.*"
      if commentblockmatch != nil
        @in_comment_block = true
        s, commentblockendmatch = line\find "%]%]"
        if commentblockendmatch != nil
          @line_cursor += s+commentblockmatch+1
          return line\sub(s+commentblockendmatch+1), false
      return line, true
    return line, false

  parse: (str) =>
    str = str .. "\n--"
    for line in magiclines str
      @line_num += 1
      if line\match("^%s*$") then continue
      @just_entered_window = false

      @line_cursor = 0
      @line_orig = line

      _,@line_indent = line\find '^%s+'
      if @line_indent != nil
        @line_cursor += @line_indent+1
        line = line\sub @line_indent+1
      else
        @line_indent = 0

      line, cont = @parse_comments line
      if cont then continue

      if @line_indent > @indents[#@indents]
        if not @entered_win_or_hbx_last_line
          return nil, @line_err_msg 'improper indent'
        table.insert @indents, @line_indent
      else
        @process_dedents!

      @entered_win_or_hbx_last_line = false

      while #line > 0 do
        successful_token = false

        -- comment
        line, cont = @parse_comments line
        if cont then continue

        -- window start
        _, winmatch = line\find "^>%s+"
        if winmatch != nil
          successful_token = true
          assert not @in_hitbox, @line_err_msg 'window inside hitbox'
          assert not @in_window, @line_err_msg 'nested window'
          @in_window = true
          @just_entered_window = true
          @entered_win_or_hbx_last_line = true
          @line_cursor += winmatch+1
          line = line\sub winmatch+1

        -- hitbox start
        _, hbxmatch = line\find "^-%s+"
        if hbxmatch != nil
          successful_token = true
          assert not @just_entered_window, @line_err_msg 'hitbox declared on same line as window'
          assert not @in_hitbox, @line_err_msg 'nested hitbox'
          @in_hitbox = true
          @entered_win_or_hbx_last_line = true
          @line_cursor += hbxmatch+1
          line = line\sub hbxmatch+1

        -- key-value pair
        _, varmatch = line\find "^[A-Za-z0-9_]+:%s+.+"
        if varmatch != nil
          successful_token = true
          k, v = line\match "^([A-Za-z0-9_]+):%s+(.+)"

          _, var_offset = line\find "^[A-Za-z0-9_]+:"
          @line_cursor += var_offset+1
          ran, val = pcall load 'return ' .. v
          if not ran then
            error @line_err_msg val

          if     @in_hitbox then @hbx_concat[as_hbx_val(k)] = val
          elseif @in_window then @win_concat[as_win_val(k)] = val
          else                   @total_concat[as_atk_val(k)] = val

          line = '' -- messy but should always consume the line

        assert successful_token, @line_err_msg 'invalid token'

    @process_dedents!
    assert not @in_comment_block, 'unterminated block comment'
    @total_concat

return Parser
