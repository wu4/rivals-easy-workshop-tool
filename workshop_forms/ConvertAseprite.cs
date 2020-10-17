using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace workshop_forms
{
  partial class Convert
  {
    private static string EscapePath(string path) =>
      path.Replace(@"\", @"\\").Replace(@"""", @"\""");

    private static string UnescapePath(string path) =>
      path.Replace(@"\""", @"""").Replace(@"\\", @"\");

    public static bool AsepriteIsHurtboxOrHurtboxExists(string filename)
    {
      string bname = Path.GetFileNameWithoutExtension(filename);

      // if the sprite in question is a hurtbox, do not generate [attack]_hurt_hurt_strip*.png
      // if a user-created hurtbox sprite exists, do not overwrite it
      return bname.EndsWith("_hurt")
          || File.Exists(Path.Combine(Properties.Settings.Default.spritesDir,
                                      $"{bname}_hurt.aseprite"));
    }

    public static string Aseprite(List<string> filenames)
    {
      int filenameCount = 0;
      var filenameArgs = string.Join(" ", from filename in filenames
                                          where filenameCount++ >= 0
                                          select $"--script-param sprite_{filenameCount}=\"{EscapePath(filename)}\" " +
                                                 $"--script-param sprite_genhurt_{filenameCount}=" +
                                                 ((
                                                   Properties.Settings.Default.spritesHurtboxGeneration
                                                   && !AsepriteIsHurtboxOrHurtboxExists(filename)
                                                 ) ? "1" : "0"));


      var pi = new ProcessStartInfo {
        FileName = $"{Properties.Settings.Default.asepriteDir}/aseprite.exe",
        Arguments =
          $"-b " +
          $"{filenameArgs} " +
          $"--script-param sprite_count={filenameCount} " +
          $"--script-param sprite_out_path=\"{EscapePath(Properties.Settings.Default.characterDir)}/sprites\" " +
          $"--script \"{EscapePath(AppDomain.CurrentDomain.BaseDirectory)}strip_export.lua\"",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true,
      };

      var p = Process.Start(pi);
      p.WaitForExit();
      return p.StandardOutput.ReadToEnd();
    }
  }
}
