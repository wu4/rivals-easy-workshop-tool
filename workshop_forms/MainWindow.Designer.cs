namespace workshop_forms
{
  partial class MainWindow
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.dirPicker = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.splitContainer_main = new System.Windows.Forms.SplitContainer();
      this.consoleTextBox = new System.Windows.Forms.RichTextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageOptions = new System.Windows.Forms.TabPage();
      this.optionsTable = new System.Windows.Forms.TableLayoutPanel();
      this.asepriteDirButton = new System.Windows.Forms.Button();
      this.attackDirTextBox = new System.Windows.Forms.TextBox();
      this.attackDirButton = new System.Windows.Forms.Button();
      this.spriteDirTextBox = new System.Windows.Forms.TextBox();
      this.spriteDirButton = new System.Windows.Forms.Button();
      this.characterDirTextBox = new System.Windows.Forms.TextBox();
      this.characterLabel = new System.Windows.Forms.Label();
      this.characterDirButton = new System.Windows.Forms.Button();
      this.asepriteLabel = new System.Windows.Forms.Label();
      this.asepriteDirTextBox = new System.Windows.Forms.TextBox();
      this.spriteFileFormatFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.asepriteFileFormatButton = new System.Windows.Forms.RadioButton();
      this.gifFileFormatButton = new System.Windows.Forms.RadioButton();
      this.spriteFileFormatLabel = new System.Windows.Forms.Label();
      this.spriteHurtboxCheckBox = new System.Windows.Forms.CheckBox();
      this.spriteDirSearchCheckBox = new System.Windows.Forms.CheckBox();
      this.attackDirSearchCheckBox = new System.Windows.Forms.CheckBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.statusBarTable = new System.Windows.Forms.TableLayoutPanel();
      this.updateButton = new System.Windows.Forms.Button();
      this.watchButton = new System.Windows.Forms.Button();
      this.statusLabel = new System.Windows.Forms.Label();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.aboutButton = new System.Windows.Forms.ToolStripButton();
      this.wikiButton = new System.Windows.Forms.ToolStripButton();
      this.attackDirTextBoxError = new System.Windows.Forms.ErrorProvider(this.components);
      this.spriteDirTextBoxError = new System.Windows.Forms.ErrorProvider(this.components);
      this.asepriteDirTextBoxError = new System.Windows.Forms.ErrorProvider(this.components);
      this.characterDirTextBoxError = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
      this.splitContainer_main.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPageOptions.SuspendLayout();
      this.optionsTable.SuspendLayout();
      this.spriteFileFormatFlowPanel.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.statusBarTable.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.attackDirTextBoxError)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spriteDirTextBoxError)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.asepriteDirTextBoxError)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.characterDirTextBoxError)).BeginInit();
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
      this.splitContainer_main.Size = new System.Drawing.Size(484, 348);
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
      this.consoleTextBox.Size = new System.Drawing.Size(470, 316);
      this.consoleTextBox.TabIndex = 5;
      this.consoleTextBox.Text = "";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabControl);
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer_main);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.statusBarTable);
      this.splitContainer1.Panel2MinSize = 37;
      this.splitContainer1.Size = new System.Drawing.Size(484, 386);
      this.splitContainer1.SplitterDistance = 348;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 0;
      this.splitContainer1.TabStop = false;
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPageOptions);
      this.tabControl.Controls.Add(this.tabPage2);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(484, 348);
      this.tabControl.TabIndex = 0;
      // 
      // tabPageOptions
      // 
      this.tabPageOptions.Controls.Add(this.optionsTable);
      this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
      this.tabPageOptions.Name = "tabPageOptions";
      this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageOptions.Size = new System.Drawing.Size(476, 322);
      this.tabPageOptions.TabIndex = 0;
      this.tabPageOptions.Text = "Options";
      this.tabPageOptions.UseVisualStyleBackColor = true;
      // 
      // optionsTable
      // 
      this.optionsTable.ColumnCount = 3;
      this.optionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.optionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.optionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.Controls.Add(this.asepriteDirButton, 2, 8);
      this.optionsTable.Controls.Add(this.attackDirTextBox, 1, 1);
      this.optionsTable.Controls.Add(this.attackDirButton, 2, 1);
      this.optionsTable.Controls.Add(this.spriteDirTextBox, 1, 3);
      this.optionsTable.Controls.Add(this.spriteDirButton, 2, 3);
      this.optionsTable.Controls.Add(this.characterDirTextBox, 0, 10);
      this.optionsTable.Controls.Add(this.characterLabel, 0, 9);
      this.optionsTable.Controls.Add(this.characterDirButton, 2, 10);
      this.optionsTable.Controls.Add(this.asepriteLabel, 1, 7);
      this.optionsTable.Controls.Add(this.asepriteDirTextBox, 1, 8);
      this.optionsTable.Controls.Add(this.spriteFileFormatFlowPanel, 1, 5);
      this.optionsTable.Controls.Add(this.spriteFileFormatLabel, 1, 4);
      this.optionsTable.Controls.Add(this.spriteHurtboxCheckBox, 1, 6);
      this.optionsTable.Controls.Add(this.spriteDirSearchCheckBox, 0, 2);
      this.optionsTable.Controls.Add(this.attackDirSearchCheckBox, 0, 0);
      this.optionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.optionsTable.Location = new System.Drawing.Point(3, 3);
      this.optionsTable.Name = "optionsTable";
      this.optionsTable.RowCount = 12;
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.optionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.optionsTable.Size = new System.Drawing.Size(470, 316);
      this.optionsTable.TabIndex = 0;
      // 
      // asepriteDirButton
      // 
      this.asepriteDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.asepriteDirButton.Image = ((System.Drawing.Image)(resources.GetObject("asepriteDirButton.Image")));
      this.asepriteDirButton.Location = new System.Drawing.Point(445, 182);
      this.asepriteDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.asepriteDirButton.Name = "asepriteDirButton";
      this.asepriteDirButton.Size = new System.Drawing.Size(25, 25);
      this.asepriteDirButton.TabIndex = 9;
      this.asepriteDirButton.UseVisualStyleBackColor = true;
      // 
      // attackDirTextBox
      // 
      this.attackDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.attackDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "attacksDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.attackDirTextBox.Location = new System.Drawing.Point(23, 28);
      this.attackDirTextBox.Name = "attackDirTextBox";
      this.attackDirTextBox.ReadOnly = true;
      this.attackDirTextBox.Size = new System.Drawing.Size(419, 20);
      this.attackDirTextBox.TabIndex = 2;
      this.attackDirTextBox.Tag = "Directory containing *.atk files to transpile into GML.";
      this.attackDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.attacksDir;
      this.attackDirTextBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirTextBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.attackDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      this.attackDirTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.attackDirTextBox_Validating);
      // 
      // attackDirButton
      // 
      this.attackDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.attackDirButton.Image = ((System.Drawing.Image)(resources.GetObject("attackDirButton.Image")));
      this.attackDirButton.Location = new System.Drawing.Point(445, 25);
      this.attackDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.attackDirButton.Name = "attackDirButton";
      this.attackDirButton.Size = new System.Drawing.Size(25, 25);
      this.attackDirButton.TabIndex = 3;
      this.attackDirButton.UseVisualStyleBackColor = true;
      // 
      // spriteDirTextBox
      // 
      this.spriteDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.spriteDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "spritesDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteDirTextBox.Location = new System.Drawing.Point(23, 78);
      this.spriteDirTextBox.Name = "spriteDirTextBox";
      this.spriteDirTextBox.ReadOnly = true;
      this.spriteDirTextBox.Size = new System.Drawing.Size(419, 20);
      this.spriteDirTextBox.TabIndex = 5;
      this.spriteDirTextBox.Tag = "Directory containing sprite files to convert into strip files.";
      this.spriteDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.spritesDir;
      this.spriteDirTextBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirTextBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.spriteDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      this.spriteDirTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.spriteDirTextBox_Validating);
      // 
      // spriteDirButton
      // 
      this.spriteDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spriteDirButton.Image = ((System.Drawing.Image)(resources.GetObject("spriteDirButton.Image")));
      this.spriteDirButton.Location = new System.Drawing.Point(445, 75);
      this.spriteDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.spriteDirButton.Name = "spriteDirButton";
      this.spriteDirButton.Size = new System.Drawing.Size(25, 25);
      this.spriteDirButton.TabIndex = 6;
      this.spriteDirButton.UseVisualStyleBackColor = true;
      // 
      // characterDirTextBox
      // 
      this.characterDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.optionsTable.SetColumnSpan(this.characterDirTextBox, 2);
      this.characterDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "characterDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.characterDirTextBox.Location = new System.Drawing.Point(3, 235);
      this.characterDirTextBox.Name = "characterDirTextBox";
      this.characterDirTextBox.ReadOnly = true;
      this.characterDirTextBox.Size = new System.Drawing.Size(439, 20);
      this.characterDirTextBox.TabIndex = 10;
      this.characterDirTextBox.Tag = "The target Workshop character\'s root directory. Contains init.gml, as well as the" +
    " sprites/ and scripts/ subdirectories.";
      this.characterDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.characterDir;
      this.characterDirTextBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.characterDirTextBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.characterDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.characterDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      this.characterDirTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.characterDirTextBox_Validating);
      // 
      // characterLabel
      // 
      this.characterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.characterLabel.AutoSize = true;
      this.optionsTable.SetColumnSpan(this.characterLabel, 2);
      this.characterLabel.Location = new System.Drawing.Point(0, 219);
      this.characterLabel.Margin = new System.Windows.Forms.Padding(0);
      this.characterLabel.Name = "characterLabel";
      this.characterLabel.Size = new System.Drawing.Size(53, 13);
      this.characterLabel.TabIndex = 19;
      this.characterLabel.Text = "Character";
      // 
      // characterDirButton
      // 
      this.characterDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.characterDirButton.Image = ((System.Drawing.Image)(resources.GetObject("characterDirButton.Image")));
      this.characterDirButton.Location = new System.Drawing.Point(445, 232);
      this.characterDirButton.Margin = new System.Windows.Forms.Padding(0);
      this.characterDirButton.Name = "characterDirButton";
      this.characterDirButton.Size = new System.Drawing.Size(25, 25);
      this.characterDirButton.TabIndex = 11;
      this.characterDirButton.UseVisualStyleBackColor = true;
      // 
      // asepriteLabel
      // 
      this.asepriteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.asepriteLabel.AutoSize = true;
      this.asepriteLabel.Location = new System.Drawing.Point(20, 169);
      this.asepriteLabel.Margin = new System.Windows.Forms.Padding(0);
      this.asepriteLabel.Name = "asepriteLabel";
      this.asepriteLabel.Size = new System.Drawing.Size(90, 13);
      this.asepriteLabel.TabIndex = 22;
      this.asepriteLabel.Text = "Aseprite Directory";
      // 
      // asepriteDirTextBox
      // 
      this.asepriteDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.asepriteDirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::workshop_forms.Properties.Settings.Default, "asepriteDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.asepriteDirTextBox.Location = new System.Drawing.Point(23, 185);
      this.asepriteDirTextBox.Name = "asepriteDirTextBox";
      this.asepriteDirTextBox.ReadOnly = true;
      this.asepriteDirTextBox.Size = new System.Drawing.Size(419, 20);
      this.asepriteDirTextBox.TabIndex = 8;
      this.asepriteDirTextBox.Tag = "Directory containing aseprite.exe. Usually C:\\Program Files\\Aseprite.";
      this.asepriteDirTextBox.Text = global::workshop_forms.Properties.Settings.Default.asepriteDir;
      this.asepriteDirTextBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.asepriteDirTextBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.asepriteDirTextBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.asepriteDirTextBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      this.asepriteDirTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.asepriteDirTextBox_Validating);
      // 
      // spriteFileFormatFlowPanel
      // 
      this.spriteFileFormatFlowPanel.Controls.Add(this.asepriteFileFormatButton);
      this.spriteFileFormatFlowPanel.Controls.Add(this.gifFileFormatButton);
      this.spriteFileFormatFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spriteFileFormatFlowPanel.Location = new System.Drawing.Point(20, 116);
      this.spriteFileFormatFlowPanel.Margin = new System.Windows.Forms.Padding(0);
      this.spriteFileFormatFlowPanel.Name = "spriteFileFormatFlowPanel";
      this.spriteFileFormatFlowPanel.Size = new System.Drawing.Size(425, 25);
      this.spriteFileFormatFlowPanel.TabIndex = 24;
      // 
      // asepriteFileFormatButton
      // 
      this.asepriteFileFormatButton.AutoSize = true;
      this.asepriteFileFormatButton.Checked = true;
      this.asepriteFileFormatButton.Location = new System.Drawing.Point(3, 3);
      this.asepriteFileFormatButton.Name = "asepriteFileFormatButton";
      this.asepriteFileFormatButton.Size = new System.Drawing.Size(116, 17);
      this.asepriteFileFormatButton.TabIndex = 0;
      this.asepriteFileFormatButton.TabStop = true;
      this.asepriteFileFormatButton.Tag = "Search for Aseprite sprite files (*.aseprite) in the sprites directory.";
      this.asepriteFileFormatButton.Text = "Aseprite (*.aseprite)";
      this.asepriteFileFormatButton.UseVisualStyleBackColor = true;
      this.asepriteFileFormatButton.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.asepriteFileFormatButton.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.asepriteFileFormatButton.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.asepriteFileFormatButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // gifFileFormatButton
      // 
      this.gifFileFormatButton.AutoSize = true;
      this.gifFileFormatButton.Location = new System.Drawing.Point(125, 3);
      this.gifFileFormatButton.Name = "gifFileFormatButton";
      this.gifFileFormatButton.Size = new System.Drawing.Size(69, 17);
      this.gifFileFormatButton.TabIndex = 1;
      this.gifFileFormatButton.Tag = "Search for GIF files (*.gif) in the sprites directory.";
      this.gifFileFormatButton.Text = "GIF (*.gif)";
      this.gifFileFormatButton.UseVisualStyleBackColor = true;
      this.gifFileFormatButton.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.gifFileFormatButton.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.gifFileFormatButton.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.gifFileFormatButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // spriteFileFormatLabel
      // 
      this.spriteFileFormatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.spriteFileFormatLabel.AutoSize = true;
      this.spriteFileFormatLabel.Location = new System.Drawing.Point(20, 103);
      this.spriteFileFormatLabel.Margin = new System.Windows.Forms.Padding(0);
      this.spriteFileFormatLabel.Name = "spriteFileFormatLabel";
      this.spriteFileFormatLabel.Size = new System.Drawing.Size(58, 13);
      this.spriteFileFormatLabel.TabIndex = 23;
      this.spriteFileFormatLabel.Text = "File Format";
      // 
      // spriteHurtboxCheckBox
      // 
      this.spriteHurtboxCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.spriteHurtboxCheckBox.AutoSize = true;
      this.spriteHurtboxCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.spritesHurtboxGeneration;
      this.spriteHurtboxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.spriteHurtboxCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "spritesHurtboxGeneration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteHurtboxCheckBox.Location = new System.Drawing.Point(23, 145);
      this.spriteHurtboxCheckBox.Name = "spriteHurtboxCheckBox";
      this.spriteHurtboxCheckBox.Size = new System.Drawing.Size(116, 17);
      this.spriteHurtboxCheckBox.TabIndex = 7;
      this.spriteHurtboxCheckBox.Tag = "Whether or not to generate hurtboxes by using the layer group \"hurtbox\", if it ex" +
    "ists.";
      this.spriteHurtboxCheckBox.Text = "Hurtbox generation";
      this.spriteHurtboxCheckBox.UseVisualStyleBackColor = true;
      this.spriteHurtboxCheckBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteHurtboxCheckBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.spriteHurtboxCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteHurtboxCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // spriteDirSearchCheckBox
      // 
      this.spriteDirSearchCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.spriteDirSearchCheckBox.AutoSize = true;
      this.spriteDirSearchCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.spritesDirSearch;
      this.spriteDirSearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.optionsTable.SetColumnSpan(this.spriteDirSearchCheckBox, 2);
      this.spriteDirSearchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "spritesDirSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.spriteDirSearchCheckBox.Location = new System.Drawing.Point(3, 58);
      this.spriteDirSearchCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
      this.spriteDirSearchCheckBox.Name = "spriteDirSearchCheckBox";
      this.spriteDirSearchCheckBox.Size = new System.Drawing.Size(58, 17);
      this.spriteDirSearchCheckBox.TabIndex = 4;
      this.spriteDirSearchCheckBox.Tag = "Whether or not to watch for, and convert, sprite files.";
      this.spriteDirSearchCheckBox.Text = "Sprites";
      this.spriteDirSearchCheckBox.UseVisualStyleBackColor = true;
      this.spriteDirSearchCheckBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirSearchCheckBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.spriteDirSearchCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.spriteDirSearchCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // attackDirSearchCheckBox
      // 
      this.attackDirSearchCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.attackDirSearchCheckBox.AutoSize = true;
      this.attackDirSearchCheckBox.Checked = global::workshop_forms.Properties.Settings.Default.attacksDirSearch;
      this.attackDirSearchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.optionsTable.SetColumnSpan(this.attackDirSearchCheckBox, 2);
      this.attackDirSearchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::workshop_forms.Properties.Settings.Default, "attacksDirSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.attackDirSearchCheckBox.Location = new System.Drawing.Point(3, 8);
      this.attackDirSearchCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
      this.attackDirSearchCheckBox.Name = "attackDirSearchCheckBox";
      this.attackDirSearchCheckBox.Size = new System.Drawing.Size(62, 17);
      this.attackDirSearchCheckBox.TabIndex = 1;
      this.attackDirSearchCheckBox.Tag = "Whether or not to watch for, and transpile, *.atk files.";
      this.attackDirSearchCheckBox.Text = "Attacks";
      this.attackDirSearchCheckBox.UseVisualStyleBackColor = true;
      this.attackDirSearchCheckBox.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirSearchCheckBox.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.attackDirSearchCheckBox.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.attackDirSearchCheckBox.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.consoleTextBox);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(476, 322);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Output";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // statusBarTable
      // 
      this.statusBarTable.ColumnCount = 4;
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.statusBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.statusBarTable.Controls.Add(this.updateButton, 2, 0);
      this.statusBarTable.Controls.Add(this.watchButton, 3, 0);
      this.statusBarTable.Controls.Add(this.statusLabel, 0, 0);
      this.statusBarTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.statusBarTable.Location = new System.Drawing.Point(0, 0);
      this.statusBarTable.Name = "statusBarTable";
      this.statusBarTable.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
      this.statusBarTable.RowCount = 1;
      this.statusBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.statusBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.statusBarTable.Size = new System.Drawing.Size(484, 37);
      this.statusBarTable.TabIndex = 2;
      // 
      // updateButton
      // 
      this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.updateButton.Location = new System.Drawing.Point(319, 0);
      this.updateButton.Margin = new System.Windows.Forms.Padding(0);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(60, 32);
      this.updateButton.TabIndex = 12;
      this.updateButton.Tag = "Perform a one-time check for changes by comparing write-times.";
      this.updateButton.Text = "Update";
      this.updateButton.UseVisualStyleBackColor = true;
      this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
      this.updateButton.Enter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.updateButton.Leave += new System.EventHandler(this.DeleteStatusBarText);
      this.updateButton.MouseEnter += new System.EventHandler(this.Control_UpdateStatusBarText);
      this.updateButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // watchButton
      // 
      this.watchButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.watchButton.Location = new System.Drawing.Point(379, 0);
      this.watchButton.Margin = new System.Windows.Forms.Padding(0);
      this.watchButton.Name = "watchButton";
      this.watchButton.Size = new System.Drawing.Size(100, 32);
      this.watchButton.TabIndex = 13;
      this.watchButton.Tag = "Begin watching the enabled directories for changes.";
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
      this.statusLabel.Location = new System.Drawing.Point(8, 0);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(0, 32);
      this.statusLabel.TabIndex = 0;
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // toolStrip1
      // 
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.wikiButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.toolStrip1.ShowItemToolTips = false;
      this.toolStrip1.Size = new System.Drawing.Size(484, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.TabStop = true;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // aboutButton
      // 
      this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
      this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Size = new System.Drawing.Size(60, 22);
      this.aboutButton.Tag = "View information about this program.";
      this.aboutButton.Text = "About";
      this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
      this.aboutButton.MouseEnter += new System.EventHandler(this.ToolStripItem_UpdateStatusBarText);
      this.aboutButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // wikiButton
      // 
      this.wikiButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.wikiButton.AutoToolTip = false;
      this.wikiButton.Image = ((System.Drawing.Image)(resources.GetObject("wikiButton.Image")));
      this.wikiButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.wikiButton.Name = "wikiButton";
      this.wikiButton.Size = new System.Drawing.Size(83, 22);
      this.wikiButton.Tag = "Opens the REWT Wiki in the default browser.";
      this.wikiButton.Text = "REWT Wiki";
      this.wikiButton.ToolTipText = "\r\n";
      this.wikiButton.Click += new System.EventHandler(this.wikiButton_Click);
      this.wikiButton.MouseEnter += new System.EventHandler(this.ToolStripItem_UpdateStatusBarText);
      this.wikiButton.MouseLeave += new System.EventHandler(this.DeleteStatusBarText);
      // 
      // attackDirTextBoxError
      // 
      this.attackDirTextBoxError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.attackDirTextBoxError.ContainerControl = this;
      this.attackDirTextBoxError.Icon = ((System.Drawing.Icon)(resources.GetObject("attackDirTextBoxError.Icon")));
      // 
      // spriteDirTextBoxError
      // 
      this.spriteDirTextBoxError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.spriteDirTextBoxError.ContainerControl = this;
      this.spriteDirTextBoxError.Icon = ((System.Drawing.Icon)(resources.GetObject("spriteDirTextBoxError.Icon")));
      // 
      // asepriteDirTextBoxError
      // 
      this.asepriteDirTextBoxError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.asepriteDirTextBoxError.ContainerControl = this;
      this.asepriteDirTextBoxError.Icon = ((System.Drawing.Icon)(resources.GetObject("asepriteDirTextBoxError.Icon")));
      // 
      // characterDirTextBoxError
      // 
      this.characterDirTextBoxError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.characterDirTextBoxError.ContainerControl = this;
      this.characterDirTextBoxError.Icon = ((System.Drawing.Icon)(resources.GetObject("characterDirTextBoxError.Icon")));
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.ClientSize = new System.Drawing.Size(484, 411);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(500, 450);
      this.Name = "MainWindow";
      this.Text = "Rivals Easy Workshop Tool";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
      this.splitContainer_main.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl.ResumeLayout(false);
      this.tabPageOptions.ResumeLayout(false);
      this.optionsTable.ResumeLayout(false);
      this.optionsTable.PerformLayout();
      this.spriteFileFormatFlowPanel.ResumeLayout(false);
      this.spriteFileFormatFlowPanel.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.statusBarTable.ResumeLayout(false);
      this.statusBarTable.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.attackDirTextBoxError)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spriteDirTextBoxError)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.asepriteDirTextBoxError)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.characterDirTextBoxError)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageOptions;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TableLayoutPanel optionsTable;
    private System.Windows.Forms.CheckBox attackDirSearchCheckBox;
    private System.Windows.Forms.TextBox attackDirTextBox;
    private System.Windows.Forms.Button attackDirButton;
    private System.Windows.Forms.CheckBox spriteDirSearchCheckBox;
    private System.Windows.Forms.TextBox spriteDirTextBox;
    private System.Windows.Forms.Button spriteDirButton;
    private System.Windows.Forms.TextBox characterDirTextBox;
    private System.Windows.Forms.Button characterDirButton;
    private System.Windows.Forms.Label characterLabel;
    private System.Windows.Forms.CheckBox spriteHurtboxCheckBox;
    private System.Windows.Forms.Button asepriteDirButton;
    private System.Windows.Forms.Label asepriteLabel;
    private System.Windows.Forms.TextBox asepriteDirTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton wikiButton;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.ErrorProvider attackDirTextBoxError;
        private System.Windows.Forms.ErrorProvider spriteDirTextBoxError;
        private System.Windows.Forms.ErrorProvider asepriteDirTextBoxError;
        private System.Windows.Forms.ErrorProvider characterDirTextBoxError;
        private System.Windows.Forms.Label spriteFileFormatLabel;
        private System.Windows.Forms.FlowLayoutPanel spriteFileFormatFlowPanel;
        private System.Windows.Forms.RadioButton asepriteFileFormatButton;
        private System.Windows.Forms.RadioButton gifFileFormatButton;
    }
}

