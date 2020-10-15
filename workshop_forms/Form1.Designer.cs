namespace workshop_forms
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.dirPicker = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.splitContainer_main = new System.Windows.Forms.SplitContainer();
      this.consoleTextBox = new System.Windows.Forms.RichTextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageOptions = new System.Windows.Forms.TabPage();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.asepriteDirButton = new System.Windows.Forms.Button();
      this.attackDirSearchCheckBox = new System.Windows.Forms.CheckBox();
      this.attackDirTextBox = new System.Windows.Forms.TextBox();
      this.attackDirButton = new System.Windows.Forms.Button();
      this.spriteDirSearchCheckBox = new System.Windows.Forms.CheckBox();
      this.spriteDirTextBox = new System.Windows.Forms.TextBox();
      this.spriteDirButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.spriteHurtboxCheckBox = new System.Windows.Forms.CheckBox();
      this.spriteHurtboxLabel = new System.Windows.Forms.Label();
      this.characterDirTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.characterDirButton = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.asepriteDirTextBox = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.statusBarTable = new System.Windows.Forms.TableLayoutPanel();
      this.warningLabel = new System.Windows.Forms.Label();
      this.watchButton = new System.Windows.Forms.Button();
      this.statusLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
      this.splitContainer_main.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageOptions.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.statusBarTable.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      // 
      // splitContainer_main
      // 
      this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer_main.IsSplitterFixed = true;
      this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
      this.splitContainer_main.Name = "splitContainer_main";
      this.splitContainer_main.Panel1MinSize = 200;
      this.splitContainer_main.Panel2Collapsed = true;
      this.splitContainer_main.Panel2MinSize = 200;
      this.splitContainer_main.Size = new System.Drawing.Size(474, 318);
      this.splitContainer_main.SplitterDistance = 200;
      this.splitContainer_main.TabIndex = 2;
      this.splitContainer_main.TabStop = false;
      // 
      // consoleTextBox
      // 
      this.consoleTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.consoleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
      this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.consoleTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.consoleTextBox.Location = new System.Drawing.Point(3, 3);
      this.consoleTextBox.Name = "consoleTextBox";
      this.consoleTextBox.ReadOnly = true;
      this.consoleTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
      this.consoleTextBox.Size = new System.Drawing.Size(460, 286);
      this.consoleTextBox.TabIndex = 5;
      this.consoleTextBox.Text = "";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(5, 5);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer_main);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.statusBarTable);
      this.splitContainer1.Panel2MinSize = 32;
      this.splitContainer1.Size = new System.Drawing.Size(474, 351);
      this.splitContainer1.SplitterDistance = 318;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 17;
      this.splitContainer1.TabStop = false;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageOptions);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(474, 318);
      this.tabControl1.TabIndex = 14;
      // 
      // tabPageOptions
      // 
      this.tabPageOptions.Controls.Add(this.tableLayoutPanel2);
      this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
      this.tabPageOptions.Name = "tabPageOptions";
      this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOptions.Size = new System.Drawing.Size(466, 292);
      this.tabPageOptions.TabIndex = 0;
      this.tabPageOptions.Text = "Options";
      this.tabPageOptions.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.Controls.Add(this.asepriteDirButton, 2, 1);
      this.tableLayoutPanel2.Controls.Add(this.attackDirSearchCheckBox, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.attackDirTextBox, 1, 3);
      this.tableLayoutPanel2.Controls.Add(this.attackDirButton, 2, 3);
      this.tableLayoutPanel2.Controls.Add(this.spriteDirSearchCheckBox, 0, 5);
      this.tableLayoutPanel2.Controls.Add(this.spriteDirTextBox, 1, 5);
      this.tableLayoutPanel2.Controls.Add(this.spriteDirButton, 2, 5);
      this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.spriteHurtboxCheckBox, 0, 6);
      this.tableLayoutPanel2.Controls.Add(this.spriteHurtboxLabel, 1, 6);
      this.tableLayoutPanel2.Controls.Add(this.characterDirTextBox, 0, 8);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
      this.tableLayoutPanel2.Controls.Add(this.characterDirButton, 2, 8);
      this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.asepriteDirTextBox, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 10;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 286);
      this.tableLayoutPanel2.TabIndex = 14;
      // 
      // asepriteDirButton
      // 
      this.asepriteDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.asepriteDirButton.Image = ((System.Drawing.Image)(resources.GetObject("asepriteDirButton.Image")));
      this.asepriteDirButton.Location = new System.Drawing.Point(435, 25);
      this.asepriteDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.asepriteDirButton.Name = "asepriteDirButton";
      this.asepriteDirButton.Size = new System.Drawing.Size(25, 25);
      this.asepriteDirButton.TabIndex = 24;
      this.asepriteDirButton.UseVisualStyleBackColor = true;
      // 
      // attackDirSearchCheckBox
      // 
      this.attackDirSearchCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.attackDirSearchCheckBox.AutoSize = true;
      this.attackDirSearchCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.attacksDirSearch;
      this.attackDirSearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.attackDirSearchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "attacksDirSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.attackDirSearchCheckBox.Location = new System.Drawing.Point(3, 78);
      this.attackDirSearchCheckBox.Name = "attackDirSearchCheckBox";
      this.attackDirSearchCheckBox.Size = new System.Drawing.Size(14, 19);
      this.attackDirSearchCheckBox.TabIndex = 1;
      this.attackDirSearchCheckBox.Tag = "Whether or not to watch for, and transpile, *.atk files.";
      this.attackDirSearchCheckBox.Text = "checkBox1";
      this.attackDirSearchCheckBox.UseVisualStyleBackColor = true;
      this.attackDirSearchCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirSearchCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // attackDirTextBox
      // 
      this.attackDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.attackDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "attacksDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.attackDirTextBox.Location = new System.Drawing.Point(23, 78);
      this.attackDirTextBox.Name = "attackDirTextBox";
      this.attackDirTextBox.ReadOnly = true;
      this.attackDirTextBox.Size = new System.Drawing.Size(409, 20);
      this.attackDirTextBox.TabIndex = 2;
      this.attackDirTextBox.Tag = "Directory containing *.atk files to transpile into GML.";
      this.attackDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.attacksDir;
      this.attackDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // attackDirButton
      // 
      this.attackDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.attackDirButton.Image = ((System.Drawing.Image)(resources.GetObject("attackDirButton.Image")));
      this.attackDirButton.Location = new System.Drawing.Point(435, 75);
      this.attackDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.attackDirButton.Name = "attackDirButton";
      this.attackDirButton.Size = new System.Drawing.Size(25, 25);
      this.attackDirButton.TabIndex = 3;
      this.attackDirButton.UseVisualStyleBackColor = true;
      // 
      // spriteDirSearchCheckBox
      // 
      this.spriteDirSearchCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.spriteDirSearchCheckBox.AutoSize = true;
      this.spriteDirSearchCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.spritesDirSearch;
      this.spriteDirSearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.spriteDirSearchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "spritesDirSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteDirSearchCheckBox.Location = new System.Drawing.Point(3, 128);
      this.spriteDirSearchCheckBox.Name = "spriteDirSearchCheckBox";
      this.spriteDirSearchCheckBox.Size = new System.Drawing.Size(14, 19);
      this.spriteDirSearchCheckBox.TabIndex = 4;
      this.spriteDirSearchCheckBox.Tag = "Whether or not to watch for, and convert, *.aseprite files.";
      this.spriteDirSearchCheckBox.Text = "checkBox2";
      this.spriteDirSearchCheckBox.UseVisualStyleBackColor = true;
      this.spriteDirSearchCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirSearchCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // spriteDirTextBox
      // 
      this.spriteDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.spriteDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "spritesDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteDirTextBox.Location = new System.Drawing.Point(23, 128);
      this.spriteDirTextBox.Name = "spriteDirTextBox";
      this.spriteDirTextBox.ReadOnly = true;
      this.spriteDirTextBox.Size = new System.Drawing.Size(409, 20);
      this.spriteDirTextBox.TabIndex = 5;
      this.spriteDirTextBox.Tag = "Directory containing Aseprite sprite files (*.aseprite) to convert into strip fil" +
    "es.";
      this.spriteDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.spritesDir;
      this.spriteDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // spriteDirButton
      // 
      this.spriteDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spriteDirButton.Image = ((System.Drawing.Image)(resources.GetObject("spriteDirButton.Image")));
      this.spriteDirButton.Location = new System.Drawing.Point(435, 125);
      this.spriteDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.spriteDirButton.Name = "spriteDirButton";
      this.spriteDirButton.Size = new System.Drawing.Size(25, 25);
      this.spriteDirButton.TabIndex = 6;
      this.spriteDirButton.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
      this.label1.Location = new System.Drawing.Point(0, 62);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Attacks";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
      this.label2.Location = new System.Drawing.Point(0, 112);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Sprites";
      // 
      // spriteHurtboxCheckBox
      // 
      this.spriteHurtboxCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.spriteHurtboxCheckBox.AutoSize = true;
      this.spriteHurtboxCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.spritesHurtboxGeneration;
      this.spriteHurtboxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.spriteHurtboxCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "spritesHurtboxGeneration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteHurtboxCheckBox.Location = new System.Drawing.Point(3, 154);
      this.spriteHurtboxCheckBox.Name = "spriteHurtboxCheckBox";
      this.spriteHurtboxCheckBox.Size = new System.Drawing.Size(14, 17);
      this.spriteHurtboxCheckBox.TabIndex = 20;
      this.spriteHurtboxCheckBox.Tag = "Whether or not to generate hurtboxes by using the layer group \"hurtbox\".";
      this.spriteHurtboxCheckBox.Text = "checkBox1";
      this.spriteHurtboxCheckBox.UseVisualStyleBackColor = true;
      this.spriteHurtboxCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteHurtboxCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // spriteHurtboxLabel
      // 
      this.spriteHurtboxLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.spriteHurtboxLabel.AutoSize = true;
      this.spriteHurtboxLabel.Location = new System.Drawing.Point(20, 156);
      this.spriteHurtboxLabel.Margin = new System.Windows.Forms.Padding(0);
      this.spriteHurtboxLabel.Name = "spriteHurtboxLabel";
      this.spriteHurtboxLabel.Size = new System.Drawing.Size(97, 13);
      this.spriteHurtboxLabel.TabIndex = 21;
      this.spriteHurtboxLabel.Text = "Hurtbox generation";
      // 
      // characterDirTextBox
      // 
      this.characterDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.SetColumnSpan(this.characterDirTextBox, 2);
      this.characterDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "characterDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.characterDirTextBox.Location = new System.Drawing.Point(3, 203);
      this.characterDirTextBox.Name = "characterDirTextBox";
      this.characterDirTextBox.ReadOnly = true;
      this.characterDirTextBox.Size = new System.Drawing.Size(429, 20);
      this.characterDirTextBox.TabIndex = 7;
      this.characterDirTextBox.Tag = "The target Workshop character\'s root directory. Should contain init.gml, as well " +
    "as the sprites/ and scripts/ subdirectories.";
      this.characterDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.characterDir;
      this.characterDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.characterDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
      this.label3.Location = new System.Drawing.Point(0, 187);
      this.label3.Margin = new System.Windows.Forms.Padding(0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 19;
      this.label3.Text = "Character";
      // 
      // characterDirButton
      // 
      this.characterDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.characterDirButton.Image = ((System.Drawing.Image)(resources.GetObject("characterDirButton.Image")));
      this.characterDirButton.Location = new System.Drawing.Point(435, 200);
      this.characterDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.characterDirButton.Name = "characterDirButton";
      this.characterDirButton.Size = new System.Drawing.Size(25, 25);
      this.characterDirButton.TabIndex = 8;
      this.characterDirButton.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
      this.label4.Location = new System.Drawing.Point(0, 12);
      this.label4.Margin = new System.Windows.Forms.Padding(0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 13);
      this.label4.TabIndex = 22;
      this.label4.Text = "Aseprite Dir";
      // 
      // asepriteDirTextBox
      // 
      this.asepriteDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.SetColumnSpan(this.asepriteDirTextBox, 2);
      this.asepriteDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "asepriteDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.asepriteDirTextBox.Location = new System.Drawing.Point(3, 28);
      this.asepriteDirTextBox.Name = "asepriteDirTextBox";
      this.asepriteDirTextBox.ReadOnly = true;
      this.asepriteDirTextBox.Size = new System.Drawing.Size(429, 20);
      this.asepriteDirTextBox.TabIndex = 23;
      this.asepriteDirTextBox.Tag = "Directory containing aseprite.exe. Usually C:\\Program Files\\Aseprite.";
      this.asepriteDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.asepriteDir;
      this.asepriteDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.asepriteDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.consoleTextBox);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(466, 292);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Output";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // statusBarTable
      // 
      this.statusBarTable.ColumnCount = 3;
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.statusBarTable.Controls.Add(this.warningLabel, 0, 0);
      this.statusBarTable.Controls.Add(this.watchButton, 2, 0);
      this.statusBarTable.Controls.Add(this.statusLabel, 0, 0);
      this.statusBarTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.statusBarTable.Location = new System.Drawing.Point(0, 0);
      this.statusBarTable.Name = "statusBarTable";
      this.statusBarTable.RowCount = 1;
      this.statusBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.statusBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.statusBarTable.Size = new System.Drawing.Size(474, 32);
      this.statusBarTable.TabIndex = 2;
      // 
      // warningLabel
      // 
      this.warningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.warningLabel.Image = ((System.Drawing.Image)(resources.GetObject("warningLabel.Image")));
      this.warningLabel.Location = new System.Drawing.Point(377, 0);
      this.warningLabel.Name = "warningLabel";
      this.warningLabel.Size = new System.Drawing.Size(94, 12);
      this.warningLabel.TabIndex = 1;
      this.warningLabel.Visible = false;
      // 
      // watchButton
      // 
      this.watchButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.watchButton.Location = new System.Drawing.Point(0, 12);
      this.watchButton.Margin = new System.Windows.Forms.Padding(0);
      this.watchButton.Name = "watchButton";
      this.watchButton.Size = new System.Drawing.Size(32, 20);
      this.watchButton.TabIndex = 0;
      this.watchButton.Tag = "Begin watching the enabled directories.";
      this.watchButton.Text = "Watch";
      this.watchButton.UseVisualStyleBackColor = true;
      this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
      this.watchButton.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.watchButton.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.watchButton.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.watchButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // statusLabel
      // 
      this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.statusLabel.AutoSize = true;
      this.statusBarTable.SetColumnSpan(this.statusLabel, 2);
      this.statusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.statusLabel.Location = new System.Drawing.Point(3, 0);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(61, 12);
      this.statusLabel.TabIndex = 0;
      this.statusLabel.Text = "statusLabel";
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 361);
      this.Controls.Add(this.splitContainer1);
      this.MinimumSize = new System.Drawing.Size(500, 400);
      this.Name = "Form1";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Rivals Workshop Tool";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
      this.splitContainer_main.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPageOptions.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.statusBarTable.ResumeLayout(false);
      this.statusBarTable.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog dirPicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.SplitContainer splitContainer_main;
    private System.Windows.Forms.RichTextBox consoleTextBox;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button watchButton;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.TableLayoutPanel statusBarTable;
    private System.Windows.Forms.Label warningLabel;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageOptions;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.CheckBox attackDirSearchCheckBox;
    private System.Windows.Forms.TextBox attackDirTextBox;
    private System.Windows.Forms.Button attackDirButton;
    private System.Windows.Forms.CheckBox spriteDirSearchCheckBox;
    private System.Windows.Forms.TextBox spriteDirTextBox;
    private System.Windows.Forms.Button spriteDirButton;
    private System.Windows.Forms.TextBox characterDirTextBox;
    private System.Windows.Forms.Button characterDirButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox spriteHurtboxCheckBox;
    private System.Windows.Forms.Label spriteHurtboxLabel;
    private System.Windows.Forms.Button asepriteDirButton;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox asepriteDirTextBox;
  }
}

