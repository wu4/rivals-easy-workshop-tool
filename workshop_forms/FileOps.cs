using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace workshop_forms
{
  partial class MainWindow
  {
    public List<string> GetStrips(string bname) =>
      (from f in Directory.GetFiles(Path.Combine(Properties.Settings.Default.characterDir, "sprites"))
       where Regex.IsMatch(Path.GetFileName(f), @"^" + Regex.Escape(bname) + @"_strip\d+\.png$")
       select f).ToList();

    public List<string> GetHurtStrips(string bname) =>
      (from f in Directory.GetFiles(Path.Combine(Properties.Settings.Default.characterDir, "sprites"))
       where Regex.IsMatch(Path.GetFileName(f), @"^" + Regex.Escape(bname) + @"_hurt_strip\d+\.png$")
       select f).ToList();

    public void RemoveOldSprites(string bname)
    {
      foreach (string f in GetStrips(bname)) File.Delete(f);
      foreach (string f in GetHurtStrips(bname)) File.Delete(f);
    }

    public int CompareFileUpdateTime(string p1, string p2) =>
      File.GetLastWriteTime(p1).CompareTo(File.GetLastWriteTime(p2));
    
    public int CheckSprites(string f)
    {
      string spritesDir = Path.Combine(Properties.Settings.Default.characterDir, "sprites");
      string bname = Path.GetFileNameWithoutExtension(f);
      List<string> strips = GetStrips(bname);
      // sort by update time and remove the oldest ones
      strips.Sort(CompareFileUpdateTime);
      while (strips.Count > 1) {
        File.Delete(strips[0]);
        strips.RemoveAt(0);
      }
      int cmp = 1;
      if (strips.Count == 1) {
        cmp = CompareFileUpdateTime(f, strips[0]);
        if (cmp > 0) {
          File.Delete(strips[0]);
        }
      }

      if (Properties.Settings.Default.spritesHurtboxGeneration
       && Properties.Settings.Default.searchForAseprites
       && !Convert.AsepriteIsHurtboxOrHurtboxExists(f)) {
        List<string> hurt_strips = GetHurtStrips(bname);
        if (hurt_strips.Count > 1) {
          hurt_strips.Sort(CompareFileUpdateTime);
          while (hurt_strips.Count > 1) {
            File.Delete(hurt_strips[0]);
            hurt_strips.RemoveAt(0);
          }
        }
        if (hurt_strips.Count == 1) {
          if (cmp > 0) {
            File.Delete(hurt_strips[0]);
          }
        }
      }

      return cmp;
    }

    public List<string> SpritesToUpdate() =>
      (from f in Directory.GetFiles(Properties.Settings.Default.spritesDir,
                                    Properties.Settings.Default.searchForAseprites
                                      ? "*.aseprite"
                                      : "*.gif")
       where CheckSprites(f) > 0
       select f).ToList();

    public List<string> AtksToUpdate() =>
      (from f in Directory.GetFiles(Properties.Settings.Default.attacksDir, "*.atk")
       where CompareFileUpdateTime(
         f,
         Path.Combine(Properties.Settings.Default.characterDir,
                      $"scripts/attacks/{Path.GetFileNameWithoutExtension(f)}.gml")
       ) > 0
       select f).ToList();
  }
}
