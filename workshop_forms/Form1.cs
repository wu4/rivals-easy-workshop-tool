using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Diagnostics;

namespace workshop_forms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      dt = new Dictionary<string, DateTime>();

      labels = new List<(Button, TextBox, string)> {
        (attackDirButton,    attackDirTextBox, "Choose attacks directory..."),
        (spriteDirButton,    spriteDirTextBox, "Choose sprites directory..."),
        (characterDirButton, characterDirTextBox, "Choose Workshop character directory..."),
        (asepriteDirButton,  asepriteDirTextBox, "Choose Aseprite directory...")
      };

      foreach ((Button b, TextBox tb, string l) in labels) {
        /*
        rtb.ContentsResized += ResizeRTBToContents;
        rtb.Rtf = "{\\rtf1\\ansi " + rtb.Text + "}";
        // rtb.Rtf = "{\\rtf1\\ansi\\uld " + rtb.Text + "}";
        rtb.MouseDown += focusTB;
        rtb.MouseUp += focusTB;
        */
        b.Click += (object o, EventArgs e) => PickDirToTextBox(tb, l);
        // void focusTB(object o, MouseEventArgs e) => ActiveControl = tb;
        tb.TextChanged += UpdateWatchButton;
      }

      attackDirSearchCheckBox.CheckedChanged += UpdateWatchButton;
      attackDirSearchCheckBox.CheckedChanged += (object o, EventArgs e) =>
        attackDirButton.Enabled =
        attackDirTextBox.Enabled =
          attackDirSearchCheckBox.Checked;

      spriteDirSearchCheckBox.CheckedChanged += UpdateWatchButton;
      spriteDirSearchCheckBox.CheckedChanged += (object o, EventArgs e) =>
        spriteDirButton.Enabled =
        spriteDirTextBox.Enabled =
        asepriteLabel.Enabled =
        asepriteDirButton.Enabled =
        asepriteDirTextBox.Enabled =
        spriteHurtboxCheckBox.Enabled =
        spriteHurtboxLabel.Enabled =
          spriteDirSearchCheckBox.Checked;

      spriteDirTextBox.TextChanged += UpdateWatchButton;
      spriteDirTextBox.TextChanged += DeleteStatusBarText;
      asepriteDirTextBox.TextChanged += UpdateWatchButton;
      asepriteDirTextBox.TextChanged += DeleteStatusBarText;
      attackDirTextBox.TextChanged += UpdateWatchButton;
      attackDirTextBox.TextChanged += DeleteStatusBarText;

      // attackDirTextBox.Text = Properties.Settings.Default.attacksDir;
      // spriteDirTextBox.Text = Properties.Settings.Default.spritesDir;
      // characterDirTextBox.Text = Properties.Settings.Default.characterDir;
      // attackDirSearchCheckBox.Checked = Properties.Settings.Default.attacksDirSearch;
      // spriteDirSearchCheckBox.Checked = Properties.Settings.Default.spritesDirSearch;

      fd = new CommonOpenFileDialog();
      fd.IsFolderPicker = true;

      InitWatcher(out atkWatcher, "*.atk", AtkFileChanged);
      InitWatcher(out spriteWatcher, "*.aseprite", SpriteFileChanged);

      DeleteStatusBarText(new object(), new EventArgs());
      UpdateWatchButton(new object(), new EventArgs());
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      // Properties.Settings.Default.attacksDir = attackDirTextBox.Text;
      // Properties.Settings.Default.spritesDir = spriteDirTextBox.Text;
      // Properties.Settings.Default.characterDir = characterDirTextBox.Text;
      // Properties.Settings.Default.attacksDirSearch = attackDirSearchCheckBox.Checked;
      // Properties.Settings.Default.spritesDirSearch = spriteDirSearchCheckBox.Checked;
      Properties.Settings.Default.Save();
    }

    private readonly List<(Button, TextBox, string)> labels;
    private readonly CommonOpenFileDialog fd;

    private readonly FileSystemWatcher atkWatcher;
    private readonly FileSystemWatcher spriteWatcher;

    private void InitWatcher(out FileSystemWatcher w, String filter, Action<object, FileSystemEventArgs> update)
    {
      w = new FileSystemWatcher {
        NotifyFilter = NotifyFilters.LastWrite
                     | NotifyFilters.FileName,

        Filter = filter
      };

      var fsHandler = new FileSystemEventHandler(update);
      var rnHandler = new RenamedEventHandler(update);
      w.Changed += fsHandler;
      w.Created += fsHandler;
      w.Renamed += rnHandler;
    }

    private bool currentlyWatching = false;

    private bool CanStartWatching() =>
      (
        (
          attackDirSearchCheckBox.Checked
          && Directory.Exists(Properties.Settings.Default.attacksDir)
        )
        ||
        (
          spriteDirSearchCheckBox.Checked
          && Directory.Exists(Properties.Settings.Default.spritesDir)
          && Directory.Exists(Properties.Settings.Default.asepriteDir)
          && File.Exists(Path.Combine(Properties.Settings.Default.asepriteDir, "aseprite.exe"))
        )
      )
      &&
      (
        Directory.Exists(Properties.Settings.Default.characterDir)
        && Directory.Exists(Path.Combine(Properties.Settings.Default.characterDir, "scripts/attacks"))
        && Directory.Exists(Path.Combine(Properties.Settings.Default.characterDir, "sprites"))
      );


    private void UpdateWatchButton(object o, EventArgs e)
    {
      if (CanStartWatching()) {
        watchButton.Enabled = true;
        warningLabel.Visible = false;
        statusBarTable.SetColumnSpan(statusLabel, 2);
        statusBarTable.SetColumn(statusLabel, 0);
        // statusLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
      } else {
        watchButton.Enabled = false;
        warningLabel.Visible = true;
        statusBarTable.SetColumnSpan(statusLabel, 1);
        statusBarTable.SetColumn(statusLabel, 1);
        // statusLabel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      }
    }

    private void UpdateStatusBarText(String s)
    {
      if (s.Length > 0) {
        statusLabel.Text = s;
      }
    }

    private void Control_UpdateStatusBarText(object o, EventArgs e)
    {
      var c = (Control)o;
      UpdateStatusBarText(c.Tag.ToString());
    }

    private void ToolStripItem_UpdateStatusBarText(object o, EventArgs e)
    {
      var c = (ToolStripItem)o;
      UpdateStatusBarText(c.Tag.ToString());
    }

    private void DeleteStatusBarText(object o, EventArgs e)
    {
      // this is a yanderedev moment
      if (attackDirSearchCheckBox.Checked) {
        if (!Directory.Exists(Properties.Settings.Default.attacksDir)) {
          statusLabel.Text = "Attacks directory does not exist.";
          return;
        }
      }
      if (spriteDirSearchCheckBox.Checked) {
        if (!Directory.Exists(Properties.Settings.Default.spritesDir)) {
          statusLabel.Text = "Sprites directory does not exist.";
          return;
        }
        if (!Directory.Exists(Properties.Settings.Default.asepriteDir)) {
          statusLabel.Text = "Aseprite directory does not exist.";
          return;
        }
        if (!File.Exists(Path.Combine(Properties.Settings.Default.asepriteDir, "aseprite.exe"))) {
          statusLabel.Text = "aseprite.exe does not exist.";
          return;
        }
      }
      if (!(attackDirSearchCheckBox.Checked || spriteDirSearchCheckBox.Checked)) {
        statusLabel.Text = "Neither directory is checked for searching.";
        return;
      }
      if (!Directory.Exists(Properties.Settings.Default.characterDir)) {
        statusLabel.Text = "Workshop character directory does not exist.";
        return;
      }
      if (!Directory.Exists(Path.Combine(Properties.Settings.Default.characterDir, "scripts/attacks"))) {
        statusLabel.Text = "Workshop character attacks directory does not exist.";
        return;
      }
      if (!Directory.Exists(Path.Combine(Properties.Settings.Default.characterDir, "sprites"))) {
        statusLabel.Text = "Workshop character sprites directory does not exist.";
        return;
      }
      statusLabel.Text = "";
    }

    private void PickDirToTextBox(TextBox tb, string title)
    {
      fd.InitialDirectory = tb.Text;
      fd.Title = title;
      if (fd.ShowDialog() == CommonFileDialogResult.Ok) {
        tb.Text = fd.FileName;
        // tb.Select(tb.Text.Length, 0);
      }
    }

    private readonly Dictionary<String, DateTime> dt;

    private void AtkFileChanged (object source, FileSystemEventArgs e)
    {
      // for some reason vim swap files are being watched
      if (!e.FullPath.EndsWith(".atk")) return;

      bool gotValue = dt.TryGetValue(e.FullPath, out _);
      if ((gotValue && dt[e.FullPath].AddSeconds(1) < DateTime.Now) || !gotValue) {
        dt[e.FullPath] = DateTime.Now;
        consoleTextBox.Invoke((Action)delegate {
          Thread.Sleep(300);
          consoleTextBox.AppendText($"Converting {e.Name}...\n");
          consoleTextBox.AppendText($"{Convert.Atk(new List<string> {e.FullPath})}");
          consoleTextBox.SelectionStart = consoleTextBox.Text.Length;
          consoleTextBox.ScrollToCaret();
        });
      }
    }

    private void SpriteFileChanged (object source, FileSystemEventArgs e)
    {
      // if (!e.FullPath.EndsWith(".aseprite")) return;


      bool gotValue = dt.TryGetValue(e.FullPath, out _);
      if ((gotValue && dt[e.FullPath].AddSeconds(1) < DateTime.Now) || !gotValue) {
        dt[e.FullPath] = DateTime.Now;
        consoleTextBox.Invoke((Action)delegate {
          //consoleTextBox.AppendText($"{e.FullPath}\n");
          consoleTextBox.AppendText($"Converting {e.Name}...\n");
          consoleTextBox.AppendText($"{Convert.Aseprite(new List<string> {e.FullPath})}");
          consoleTextBox.SelectionStart = consoleTextBox.Text.Length;
          consoleTextBox.ScrollToCaret();
        });
      }
    }

    private void ResizeRTBToContents (object sender, ContentsResizedEventArgs e) =>
      ((RichTextBox)sender).ClientSize = new Size(e.NewRectangle.Width, e.NewRectangle.Height);

    private void watchButton_Click(object sender, EventArgs e)
    {
      if (currentlyWatching) {
        currentlyWatching = false;
        tabPageOptions.Enabled = true;

        watchButton.Text = "Watch";
        watchButton.Tag = "Begin watching the enabled directories.";
        // statusBar.Tag = watchButton.Tag;
        Control_UpdateStatusBarText(sender, e);

        atkWatcher.EnableRaisingEvents = false;
        spriteWatcher.EnableRaisingEvents = false;
      } else {
        currentlyWatching = true;
        tabPageOptions.Enabled = false;

        watchButton.Text = "Stop Watching";
        watchButton.Tag = "Stop watching.";
        // statusBar.Tag = watchButton.Tag;
        Control_UpdateStatusBarText(sender, e);

        if (attackDirSearchCheckBox.Checked) {
          atkWatcher.Path = labels[0].Item2.Text;
          atkWatcher.EnableRaisingEvents = true;
        }

        if (spriteDirSearchCheckBox.Checked) {
          spriteWatcher.Path = labels[1].Item2.Text;
          spriteWatcher.EnableRaisingEvents = true;
        }
      }
    }

    private void wikiButton_Click(object sender, EventArgs e)
    {
      Process.Start("https://github.com/wu4/rivals-easy-workshop-tool/wiki");
    }
  }
}
