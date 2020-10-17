using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ImageMagick;

namespace workshop_forms
{
  partial class Convert
  {
    public static string Gif(List<string> filenames)
    {
      string sprite_out_path = Path.Combine(Properties.Settings.Default.characterDir, "sprites");

      var string_concat = new StringBuilder();
      foreach (string filename in filenames) {
        try {
          using (var gif = new MagickImageCollection(filename)) {
            // WHY is this not default behavior AAAAAAAAAAAAA
            gif.Coalesce();

            var img = gif.Montage(new MontageSettings{
              BackgroundColor = MagickColors.None,
              TileGeometry = new MagickGeometry(gif.Count, 1),
              // using percentages messes with the dimensions for some reason, so we hard code it here
              Geometry = new MagickGeometry(gif[0].Width, gif[0].Height)
            });

            img.Scale(new MagickGeometry(new Percentage(200), new Percentage(200)));
            img.Write(Path.Combine(sprite_out_path,
                                   $"{Path.GetFileNameWithoutExtension(filename)}_strip{gif.Count}.png"));

            string_concat.AppendLine($"Converted {Path.GetFileName(filename)}");
          }
        } catch (MagickException ex) {
          string_concat.AppendLine(ex.Message);
        }
      }

      return string_concat.ToString();
    }
  }
}
