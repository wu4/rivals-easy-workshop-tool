using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace workshop_forms
{
  partial class Convert
  {
    public static string Atk(List<string> filenames)
    {
      var outputConcat = new List<string>();
      foreach (string f in filenames) {
        outputConcat.Add(ParseAtk(f));
      }
      return string.Join("\n", outputConcat);
    }

    private static string ParseAtk(string atkFilename)
    {
      var p = new AtkFileParsing.Parser(atkFilename);
      string bname = Path.GetFileNameWithoutExtension(atkFilename);
      string fileOut = Path.Combine(Properties.Settings.Default.characterDir, $"scripts/attacks/{bname}.gml");
      try {
        AtkFileParsing.Attack a = p.Parse();
        var g = new AttackToGML.Parser(bname, a);
        using (StreamWriter s = new StreamWriter(fileOut)) {
          s.Write(g.ToGML());
        }
        return "done\n";
      } catch (Exception ex) {//(AtkFileParsing.ParserException ex) {
        return ex.Message;
      }
    }
  }
}
