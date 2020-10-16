using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop_forms
{
  class AttackToGML
  {
    public class Parser
    {
      private string atk_name;
      private string atk_name_orig;
      private AtkFileParsing.Attack atk;
      private StringBuilder atk_vals;
      private StringBuilder hbx_vals;
      private StringBuilder win_vals;
      private int hbx_count = 0;
      private int win_count = 0;
      
      const string G_ATTACK_SPRITE = "set_attack_value({0}, {1}, sprite_get(\"{2}\"));\n";
      const string G_ATTACK =        "set_attack_value({0}, {1}, {2});\n";
      const string G_WINDOW =        "set_window_value({0}, {1}, {2}, {3});\n";
      const string G_WINDOW_SFX =    "set_window_value({0}, {1}, {2}, asset_get(\"{3}\"));\n";
      const string G_HITBOX =        "set_hitbox_value({0}, {1}, {2}, {3});\n";
      const string G_HITBOX_SFX =    "set_hitbox_value({0}, {1}, {2}, asset_get(\"{3}\"));\n";

      private string AsGML(string vtype, params object[] args)
      {
        var argsL = args.ToList();
        argsL.Insert(0, atk_name);
        return string.Format(vtype, argsL.ToArray());
      }

      private void IterateHitbox(AtkFileParsing.Hitbox h)
      {
        foreach (KeyValuePair<string, string> entry in h.Values) {
          hbx_vals.Append(AsGML(entry.Key.Equals("HG_HIT_SFX") ? G_HITBOX_SFX : G_HITBOX, hbx_count, entry.Key, entry.Value));
        }
      }

      private void IterateWindow(AtkFileParsing.Window w)
      {
        foreach (AtkFileParsing.Hitbox h in w.Hitboxes) {
          hbx_count++;
          hbx_vals.Append('\n');
          hbx_vals.Append(AsGML(G_HITBOX, hbx_count, "HG_WINDOW", win_count.ToString()));
          IterateHitbox(h);
        }
        foreach (KeyValuePair<string, string> entry in w.Values) {
          string vtype = G_WINDOW;
          if (entry.Key.Equals("AG_WINDOW_SFX")) {
            vtype = G_WINDOW_SFX;
            win_vals.Append(AsGML(G_WINDOW, win_count, "AG_WINDOW_HAS_SFX", "1"));
          }
          win_vals.Append(AsGML(vtype, win_count, entry.Key, entry.Value));
        }
      }

      public string ToGML()
      {

        foreach (AtkFileParsing.Hitbox h in atk.Hitboxes) {
          hbx_count++;
          hbx_vals.Append('\n');
          IterateHitbox(h);
        }
        foreach (AtkFileParsing.Window w in atk.Windows) {
          win_count++;
          win_vals.Append('\n');
          IterateWindow(w);
        }
        foreach (KeyValuePair<string, string> entry in atk.Values) {
          string vtype = G_ATTACK;
          if (entry.Key.Equals("AG_SPRITE") || entry.Key.Equals("AG_HURTBOX_SPRITE")) {
            vtype = G_ATTACK_SPRITE;
          }
          atk_vals.Append(AsGML(vtype, entry.Key, entry.Value));
        }
        if (!atk.Values.ContainsKey("AG_SPRITE")) atk_vals.Append(AsGML(G_ATTACK_SPRITE, "AG_SPRITE", atk_name_orig));
        if (!atk.Values.ContainsKey("AG_HURTBOX_SPRITE")) atk_vals.Append(AsGML(G_ATTACK_SPRITE, "AG_HURTBOX_SPRITE", $"{atk_name_orig}_hurt"));
        if (!atk.Values.ContainsKey("AG_NUM_WINDOWS")) atk_vals.Append(AsGML(G_ATTACK, "AG_NUM_WINDOWS", win_count.ToString()));
        atk_vals.Append($"set_num_hitboxes({atk_name}, {hbx_count});\n");

        return atk_vals.Append(
          win_vals.Append(
            hbx_vals.ToString()
          ).ToString()
        ).ToString();
      }

      public Parser(string attack_name, AtkFileParsing.Attack attack)
      {
        atk_name_orig = attack_name;
        atk_name = $"AT_{attack_name.ToUpper()}";
        atk_vals = new StringBuilder();
        hbx_vals = new StringBuilder();
        win_vals = new StringBuilder();
        atk = attack;
      }
    }
  }
}
