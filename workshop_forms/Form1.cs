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

namespace workshop_forms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      dt = new Dictionary<String, DateTime>();

      labels = new List<(Button, TextBox)> {
        (attackDirButton,    attackDirTextBox),
        (spriteDirButton,    spriteDirTextBox),
        (characterDirButton, characterDirTextBox),
        (asepriteDirButton,  asepriteDirTextBox)
      };

      foreach ((Button b, TextBox tb) in labels) {
        /*
        rtb.ContentsResized += ResizeRTBToContents;
        rtb.Rtf = "{\\rtf1\\ansi " + rtb.Text + "}";
        // rtb.Rtf = "{\\rtf1\\ansi\\uld " + rtb.Text + "}";
        rtb.MouseDown += focusTB;
        rtb.MouseUp += focusTB;
        */
        b.Click += (object o, EventArgs e) => PickDirToTextBox(tb);
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
        spriteHurtboxCheckBox.Enabled =
        spriteHurtboxLabel.Enabled =
          spriteDirSearchCheckBox.Checked;

      // attackDirTextBox.Text = Properties.Settings.Default.attacksDir;
      // spriteDirTextBox.Text = Properties.Settings.Default.spritesDir;
      // characterDirTextBox.Text = Properties.Settings.Default.characterDir;
      // attackDirSearchCheckBox.Checked = Properties.Settings.Default.attacksDirSearch;
      // spriteDirSearchCheckBox.Checked = Properties.Settings.Default.spritesDirSearch;

      fd = new CommonOpenFileDialog();
      fd.IsFolderPicker = true;

      InitWatcher(out atkWatcher, "*.atk", AtkFileChanged);
      InitWatcher(out spriteWatcher, "*.aseprite", SpriteFileChanged);
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

    private readonly List<(Button, TextBox)> labels;
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
        (attackDirSearchCheckBox.Checked && Directory.Exists(labels[0].Item2.Text)) ||
        (spriteDirSearchCheckBox.Checked && Directory.Exists(labels[1].Item2.Text))
      )
      && Directory.Exists(labels[2].Item2.Text);

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

    private void ToolStripItem_UpdateStatusBarText(object o, EventArgs e)
    {
      var c = (ToolStripItem)o;
      UpdateStatusBarText(c.Tag.ToString());
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

    private void DeleteStatusBarText(object o, EventArgs e)
    {
      if (CanStartWatching()) {
        statusLabel.Text = "";
      } else {
        statusLabel.Text = "A directory is not valid or no directories are checked to watch.";
      }
    }

    private void PickDirToTextBox(TextBox tb)
    {
      fd.InitialDirectory = tb.Text;
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
  }
}
