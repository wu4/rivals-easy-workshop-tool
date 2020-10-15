using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonSharp.Interpreter;
using System.IO;
using System.Text.RegularExpressions;

namespace workshop_forms
{
  class AtkFileParsing
  {
    public class Attack
    {
      public Dictionary<string, string> Values;

      public Attack()
      {
        Values = new Dictionary<string, string>();
        Hitboxes = new List<Hitbox>();
        Windows = new List<Window>();
      }

      public List<Hitbox> Hitboxes;
      public List<Window> Windows;
    }

    public class Window
    {
      public Dictionary<string, string> Values;

      public Window()
      {
        Values = new Dictionary<string, string>();
        Hitboxes = new List<Hitbox>();
      }

      public List<Hitbox> Hitboxes;
    }

    public class Hitbox
    {
      public Dictionary<string, string> Values;
      
      public Hitbox()
      {
        Values = new Dictionary<string, string>();
      }
    }

    public class ParserException : Exception
    {
        public ParserException()
        {
        }

        public ParserException(string message)
            : base(message)
        {
        }

        public ParserException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class Parser
    {
      private Hitbox curHbx;
      private Window curWin;
      private Attack curAtk;

      private bool inHbx = false;
      private bool inWin = false;

      private List<int> indents;
      private int lineNum = 0;
      private int lineCur = 0;
      private int lineIndent = 0;
      private string lineOrig;
      private bool justEnteredWin = false;
      private bool inCommentBlock = false;

      private bool justEnteredWinOrHbx = false;

      private readonly string filename;

      public Parser(string f)
      {
        filename = f;
      }

      private string HitboxShortcut(string val)
      {
        switch (val) {
          case "type":  return "hitbox_type";
          case "x":     return "hitbox_x";
          case "y":     return "hitbox_y";
          case "w":     return "width";
          case "h":     return "height";
          case "bkb":   return "base_knockback";
          case "kbg":   return "knockback_scaling";
          case "dmg":   return "damage";
          case "vfx":   return "visual_effect";
          case "sfx":   return "hit_sfx";
          case "group": return "hitbox_group";
          case "frame": return "window_creation_frame";
          default:      return val;
        }
      }

      private string AsHbxVal(string val) => $"HG_{HitboxShortcut(val)}".ToUpper();
      private string AsWinVal(string val) => $"AG_WINDOW_{val}".ToUpper();
      private string AsAtkVal(string val) => $"AG_{val}".ToUpper();

      private void ProcessDedents()
      {
        if (justEnteredWinOrHbx) throw new ParserException(FormatException("improper indent (just entered window or hitbox but did not indent)"));
        while (lineIndent < indents[indents.Count - 1]) {
          if (inHbx) {
            inHbx = false;
            if (inWin) {
              curWin.Hitboxes.Add(curHbx);
            } else {
              curAtk.Hitboxes.Add(curHbx);
            }
            curHbx = new Hitbox();
          } else if (inWin) {
            inWin = false;
            curAtk.Windows.Add(curWin);
            curWin = new Window();
          }
          indents.RemoveAt(indents.Count - 1);
        }
        if (lineIndent != indents[indents.Count - 1]) throw new ParserException(FormatException("improper indent (changed indent to unknown block level)"));
      }

      private bool EndsInBlockComment(ref string line)
      {
        Match comment_match = Regex.Match(line, @"^\s*\-\-");
        if (comment_match.Success) {
          Match comment_begin_match = Regex.Match(line, @"^\s*\-\-\[\[");
          if (comment_begin_match.Success) {
            inCommentBlock = true;
            Match comment_end_match = Regex.Match(line, @"\]\]");
            if (comment_end_match.Success) {
              lineCur += comment_end_match.Index + comment_end_match.Length;
              // single-line block comment
              line = line.Substring(comment_end_match.Index + comment_end_match.Length);
              return false;
            }
          }
          // regular comment or multiline block comment
          return true;
        }
        // no comment
        return false;
      }

      private string FormatException(string message) =>
        $"in {filename}\nat line {lineNum}: {message}\n{lineOrig}\n{new string(' ', Math.Max(lineCur, 0))}^\n";

      public Attack Parse()
      {
        curHbx = new Hitbox();
        curWin = new Window();
        curAtk = new Attack();

        indents = new List<int>() {0};

        var emptyLine = new Regex(@"^\s*$");
        foreach (string line_ in File.ReadLines(filename)) {
          string line = lineOrig = line_;
          lineNum++;
          if (emptyLine.IsMatch(line)) continue;

          lineCur = 0;

          { // comment, process before significant whitespace
            if (EndsInBlockComment(ref line)) {
              // justEnteredWinOrHbx = false;
              continue;
              //line = "";
            }
          }

          justEnteredWin = false;

          { // significant whitespace
            Match m = Regex.Match(line, @"^\s+");
            if (m.Success) {
              lineIndent = m.Length;
              lineCur += m.Length;
              line = line.Substring(m.Length);
            } else {
              lineIndent = 0;
            }
          }

          { // process indentation
            if (lineIndent > indents[indents.Count - 1]) {
              if (!justEnteredWinOrHbx) throw new ParserException(FormatException("improper indent (increased indent without entering window/hitbox)"));
              indents.Add(lineIndent);
            } else {
              ProcessDedents();
            }
          }

          justEnteredWinOrHbx = false;

          while (line.Length > 0) {
            bool successful_token = false;

            { // comment
              if (EndsInBlockComment(ref line)) {
                line = "";
                continue;
              }
            }

            { // window start
              Match m = Regex.Match(line, @"^\>\s+");
              if (m.Success) {
                successful_token = true;
                if (inHbx) throw new ParserException(FormatException("window inside hitbox"));
                if (inWin) throw new ParserException(FormatException("nested window"));
                justEnteredWinOrHbx = justEnteredWin = inWin = true;
                lineCur += m.Length;
                line = line.Substring(m.Length);
              }
            }

            { // hitbox start
              Match m = Regex.Match(line, @"^\-\s+");
              if (m.Success) {
                successful_token = true;
                if (justEnteredWin) throw new ParserException(FormatException("window inside hitbox"));
                if (inHbx)           throw new ParserException(FormatException("nested hitbox"));
                justEnteredWinOrHbx = inHbx = true;
                lineCur += m.Length;
                line = line.Substring(m.Length);
              }
            }

            { // key-value pair
              Match m = Regex.Match(line, @"^([A-Za-z0-9_]+):\s+(.+)$");
              if (m.Success) {
                successful_token = true;
                string key = m.Groups[1].Value;
                string val_lua = m.Groups[2].Value;
                lineCur += m.Groups[1].Length;

                try {
                  DynValue val = Script.RunString($"return {val_lua}");
                  string val_str;
                  switch (val.Type) {
                    case DataType.Boolean: val_str = val.Boolean ? "true" : "false"; break;
                    case DataType.Number:  val_str = val.CastToString(); break;
                    case DataType.String:  val_str = val.String; break;
                    default: throw new Exception($"unsupported data type {val.Type}");
                  }
                  if      (inHbx) curHbx.Values[AsHbxVal(key)] = val_str;
                  else if (inWin) curWin.Values[AsWinVal(key)] = val_str;
                  else            curAtk.Values[AsAtkVal(key)] = val_str;
                  line = "";
                } catch (InterpreterException ex) {
                  throw new ParserException(FormatException(ex.Message));
                }
              }
            }

            if (!successful_token) throw new ParserException(FormatException($"invalid token at '{line}'"));
          }
        }
        if (inCommentBlock) throw new ParserException(FormatException("unterminated block comment"));

        lineIndent = 0;
        ProcessDedents();

        return curAtk;
      }
    }
  }
}
