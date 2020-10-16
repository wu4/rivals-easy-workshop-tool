using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace workshop_forms
{
  partial class Convert
  {
    private static string EscapePath(string path) =>
      path.Replace(@"\", @"\\").Replace(@"""", @"\""");

    private static string UnescapePath(string path) =>
      path.Replace(@"\""", @"""").Replace(@"\\", @"\");

    public static string Aseprite(List<string> filenames)
    {
      int filenameCount = 0;
      var filenameArgs = string.Join(" ", from filename in filenames
                                          where filenameCount++ >= 0
                                          select $"--script-param sprite_{filenameCount}=\"{EscapePath(filename)}\"");

      var pi = new ProcessStartInfo {
        FileName = $"{Properties.Settings.Default.asepriteDir}/aseprite.exe",
        Arguments =
          $"-b " +
          $"{filenameArgs} " +
          $"--script-param sprite_hurtboxes={(Properties.Settings.Default.spritesHurtboxGeneration ? 1 : 0)} " +
          $"--script-param sprite_count={filenameCount} " +
          $"--script-param sprite_out_path=\"{EscapePath(Properties.Settings.Default.characterDir)}/sprites\" " +
          $"--script \"{EscapePath(AppDomain.CurrentDomain.BaseDirectory)}strip_export.lua\"",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true,
      };

      // return pi.Arguments;

      var p = Process.Start(pi);
      p.WaitForExit();
      return p.StandardOutput.ReadToEnd();
    }

    /*
    public static string Atk(List<string> filenames)
    {
      int filenameCount = 0;
      var filenameArgs = string.Join(" ", from filename in filenames
                                          where filenameCount++ >= 0
                                          select $"--script-param attack_{filenameCount}=\"{EscapePath(filename)}\"");

      var pi = new ProcessStartInfo {
        FileName = $"{Properties.Settings.Default.asepriteDir}/aseprite.exe",
        Arguments =
          $"-b " +
          $"{filenameArgs} " +
          $"--script-param attack_count={filenameCount} " +
          $"--script-param attack_out_path=\"{EscapePath(Properties.Settings.Default.characterDir)}/scripts/attacks\" " +
          $"--script \"{EscapePath(AppDomain.CurrentDomain.BaseDirectory)}attack_export.lua\"",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true,
      };

      // return pi.Arguments;

      var p = Process.Start(pi);
      p.WaitForExit();
      return p.StandardOutput.ReadToEnd();
    }
    */
  }
}
