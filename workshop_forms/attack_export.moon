-- inspect = dofile "inspect.lua"
atk = dofile "atk.lua"

basename = (str) ->
  name = string.gsub str, "(.*[\\/])(.*)%..+", "%2"
  name

readfile = (file) ->
  f = assert io.open(file, 'r')
  ret = f\read "*all"
  f\close!
  ret

fmts =
  attack_sprite: 'set_attack_value(%s, %s, sprite_get("%s"));'
  attack:        'set_attack_value(%s, %s, %s);'
  window:        'set_window_value(%s, %i, %s, %s)'
  window_sfx:    'set_window_value(%s, %i, %s, asset_get("%s"))'
  hitbox:        'set_hitbox_value(%s, %i, %s, %s)'
  hitbox_sfx:    'set_hitbox_value(%s, %i, %s, asset_get("%s"))'

class AttackParser
  new: (bname) =>
    @atk_name = "AT_#{string.upper bname}"
    @atk_vals = {}
    @hbx_vals = {}
    @win_vals = {}
    @hbx_count = 0
    @win_count = 0
    @atk_bname = bname

  iterate_hitbox: (h) =>
    for k, v in pairs h
      vtype = 'hitbox'
      if k == 'HG_HIT_SFX'
        vtype = 'hitbox_sfx'
      table.insert @hbx_vals, @as_gml {t:vtype, @hbx_count, k, v}

  as_gml: (tbl) =>
    string.format fmts[ tbl['t'] ], @atk_name, table.unpack tbl

  iterate_windows: (ws) =>
    for _, w in ipairs ws
      @win_count += 1
      for wk, wv in pairs w
        if wk == 'hitboxes'
          for _, h in ipairs wv
            @hbx_count += 1
            table.insert @hbx_vals, @as_gml {t:'hitbox', @hbx_count, 'HG_WINDOW', @win_count}
            @iterate_hitbox h
        else
          vtype = 'window'
          if wk == 'AG_WINDOW_SFX'
            vtype = 'window_sfx'
            table.insert @win_vals, @as_gml {t:'window', @win_count, 'AG_WINDOW_HAS_SFX', 1}
          table.insert @win_vals, @as_gml {t:vtype, @win_count, wk, wv}

  parse: (attack) =>
    table.insert @atk_vals, @as_gml {t:'attack_sprite', 'AG_SPRITE', @atk_bname}
    table.insert @atk_vals, @as_gml {t:'attack_sprite', 'AG_HURTBOX_SPRITE', "#{@atk_bname}_hurt"}
    for k, v in pairs attack
      -- print k
      if k == 'hitboxes'
        for _, h in ipairs v
          @hbx_count += 1
          @iterate_hitbox h
      elseif k == 'windows'
        @iterate_windows v
      else
        table.insert @atk_vals, @as_gml {t:'attack', k, v}
    if attack['AG_NUM_WINDOWS'] == nil
      table.insert @atk_vals, @as_gml {t:'attack', 'AG_NUM_WINDOWS', @win_count}
    table.insert @atk_vals, "set_num_hitboxes(#{@atk_name},#{@hbx_count})"

    -- print inspect {@atk_vals, @win_vals, @hbx_vals}
    ret = {}
    for _, vals in ipairs {@atk_vals, @win_vals, @hbx_vals}
      for _, v in ipairs vals
        table.insert ret, v
    table.concat ret, '\n'

attack_count = tonumber app.params["attack_count"]
for i=1, attack_count
  file = app.params["attack_#{tostring i}"]

  f = assert io.open file, 'r'
  a = atk!
  ran, y = pcall(a\parse, f\read("*all"))
  if not ran then
    error "\27[31min file \27[0m#{file}\27[31m:\27[0m\n#{y}"
  f\close!
  bname = basename file

  a = AttackParser bname
  o = a\parse y

  f_out = assert io.open "#{app.params["attack_out_path"]}/#{bname}.gml", 'w'
  f_out\write o
  f_out\close!
