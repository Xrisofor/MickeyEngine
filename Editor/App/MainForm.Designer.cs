namespace Editor.App
{
    partial class MainForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            ConsoleListBox = new ListBox();
            ConsoleLabel = new Label();
            ManagerListBox = new ListBox();
            label2 = new Label();
            sfmlPanel = new Panel();
            panel3 = new Panel();
            ComponentPanel = new Panel();
            ComponentLabel = new Label();
            ComponentNameLabel = new Label();
            pictureBox1 = new PictureBox();
            RotationTextBox = new TextBox();
            label3 = new Label();
            SelectTextureButton = new Button();
            TextureTextBox = new TextBox();
            label8 = new Label();
            ScaleYTextBox = new TextBox();
            ScaleXTextBox = new TextBox();
            label5 = new Label();
            PosYTextBox = new TextBox();
            PosXTextBox = new TextBox();
            label4 = new Label();
            ObjectPictureBox = new PictureBox();
            VisibleCheckBox = new CheckBox();
            NameTextBox = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewButton_TSM = new ToolStripMenuItem();
            OpenButton_TSM = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveButton_TSM = new ToolStripMenuItem();
            SaveAsButton_TSM = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            CloseButton_TSM = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ExitButton_TSM = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ShowConsole_TSM = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            ShowFPS_TSM = new ToolStripMenuItem();
            ResetCSize_TSM = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            ShowGrid_TSM = new ToolStripMenuItem();
            gridSettingsToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            GridSize20_TSM = new ToolStripMenuItem();
            GridSize25_TSM = new ToolStripMenuItem();
            GridSize30_TSM = new ToolStripMenuItem();
            GridSize35_TSM = new ToolStripMenuItem();
            GridSize40_TSM = new ToolStripMenuItem();
            GridSize45_TSM = new ToolStripMenuItem();
            GridSize50_TSM = new ToolStripMenuItem();
            GridColorButton_TSM = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            AudioManager_TSM = new ToolStripMenuItem();
            FontsManager_TSM = new ToolStripMenuItem();
            PluginsManager_TSM = new ToolStripMenuItem();
            SpriteManager_TSM = new ToolStripMenuItem();
            gameObjectToolStripMenuItem = new ToolStripMenuItem();
            AddGameObjectButton_TSM = new ToolStripMenuItem();
            AddPlugGameObjectButton_TSM = new ToolStripMenuItem();
            noneToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            AddASGameObjectButton_TSM = new ToolStripMenuItem();
            AddAGameObjectButton_TSM = new ToolStripMenuItem();
            AddDLGameObjectButton_TSM = new ToolStripMenuItem();
            AddLGGameObjectButton_TSM = new ToolStripMenuItem();
            AddPCGameObjectButton_TSM = new ToolStripMenuItem();
            AddPrefabGameObjectButton_TSM = new ToolStripMenuItem();
            AddSpriteGameObjectButton_TSM = new ToolStripMenuItem();
            AddSGameObjectButton_TSM = new ToolStripMenuItem();
            AddTextGameObjectButton_TSM = new ToolStripMenuItem();
            AddTargetGameObjectButton_TSM = new ToolStripMenuItem();
            RemoveGameObjectButton_TSM = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            checkUpdateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            AboutButton_TSM = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ComponentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 58, 64);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ManagerListBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 715);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ConsoleListBox);
            panel2.Controls.Add(ConsoleLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 166);
            panel2.TabIndex = 3;
            // 
            // ConsoleListBox
            // 
            ConsoleListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConsoleListBox.BackColor = Color.FromArgb(33, 37, 41);
            ConsoleListBox.BorderStyle = BorderStyle.FixedSingle;
            ConsoleListBox.ForeColor = Color.White;
            ConsoleListBox.FormattingEnabled = true;
            ConsoleListBox.ItemHeight = 20;
            ConsoleListBox.Location = new Point(12, 32);
            ConsoleListBox.Name = "ConsoleListBox";
            ConsoleListBox.SelectionMode = SelectionMode.None;
            ConsoleListBox.Size = new Size(270, 122);
            ConsoleListBox.TabIndex = 3;
            // 
            // ConsoleLabel
            // 
            ConsoleLabel.BackColor = Color.FromArgb(33, 37, 41);
            ConsoleLabel.Dock = DockStyle.Top;
            ConsoleLabel.Location = new Point(0, 0);
            ConsoleLabel.Name = "ConsoleLabel";
            ConsoleLabel.Size = new Size(295, 28);
            ConsoleLabel.TabIndex = 2;
            ConsoleLabel.Text = "Console";
            ConsoleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManagerListBox
            // 
            ManagerListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManagerListBox.BackColor = Color.FromArgb(33, 37, 41);
            ManagerListBox.BorderStyle = BorderStyle.FixedSingle;
            ManagerListBox.ForeColor = Color.White;
            ManagerListBox.FormattingEnabled = true;
            ManagerListBox.ItemHeight = 20;
            ManagerListBox.Location = new Point(12, 41);
            ManagerListBox.Name = "ManagerListBox";
            ManagerListBox.Size = new Size(270, 502);
            ManagerListBox.TabIndex = 1;
            ManagerListBox.SelectedIndexChanged += ManagerListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(33, 37, 41);
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 0;
            label2.Text = "Map Manager";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sfmlPanel
            // 
            sfmlPanel.BackColor = Color.Black;
            sfmlPanel.Dock = DockStyle.Fill;
            sfmlPanel.Location = new Point(295, 28);
            sfmlPanel.Name = "sfmlPanel";
            sfmlPanel.Size = new Size(1010, 715);
            sfmlPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 58, 64);
            panel3.Controls.Add(ComponentPanel);
            panel3.Controls.Add(ComponentNameLabel);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(RotationTextBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SelectTextureButton);
            panel3.Controls.Add(TextureTextBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(ScaleYTextBox);
            panel3.Controls.Add(ScaleXTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(PosYTextBox);
            panel3.Controls.Add(PosXTextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(ObjectPictureBox);
            panel3.Controls.Add(VisibleCheckBox);
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1305, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 715);
            panel3.TabIndex = 2;
            // 
            // ComponentPanel
            // 
            ComponentPanel.AutoScroll = true;
            ComponentPanel.Controls.Add(ComponentLabel);
            ComponentPanel.Dock = DockStyle.Bottom;
            ComponentPanel.Location = new Point(0, 351);
            ComponentPanel.Name = "ComponentPanel";
            ComponentPanel.Size = new Size(295, 364);
            ComponentPanel.TabIndex = 34;
            // 
            // ComponentLabel
            // 
            ComponentLabel.Dock = DockStyle.Fill;
            ComponentLabel.Location = new Point(0, 0);
            ComponentLabel.Name = "ComponentLabel";
            ComponentLabel.Size = new Size(295, 364);
            ComponentLabel.TabIndex = 0;
            ComponentLabel.Text = "This object does not have any components";
            ComponentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComponentNameLabel
            // 
            ComponentNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComponentNameLabel.Location = new Point(6, 326);
            ComponentNameLabel.Name = "ComponentNameLabel";
            ComponentNameLabel.Size = new Size(277, 22);
            ComponentNameLabel.TabIndex = 16;
            ComponentNameLabel.Text = "Component";
            ComponentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.render_texture;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 251);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // RotationTextBox
            // 
            RotationTextBox.BackColor = Color.FromArgb(33, 37, 41);
            RotationTextBox.BorderStyle = BorderStyle.FixedSingle;
            RotationTextBox.Enabled = false;
            RotationTextBox.ForeColor = Color.White;
            RotationTextBox.Location = new Point(6, 141);
            RotationTextBox.Name = "RotationTextBox";
            RotationTextBox.Size = new Size(277, 27);
            RotationTextBox.TabIndex = 32;
            RotationTextBox.Text = "0";
            RotationTextBox.TextAlign = HorizontalAlignment.Center;
            RotationTextBox.TextChanged += RotationTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(5, 116);
            label3.Name = "label3";
            label3.Size = new Size(278, 22);
            label3.TabIndex = 31;
            label3.Text = "Rotation";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectTextureButton
            // 
            SelectTextureButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectTextureButton.Enabled = false;
            SelectTextureButton.FlatStyle = FlatStyle.Flat;
            SelectTextureButton.Location = new Point(6, 284);
            SelectTextureButton.Name = "SelectTextureButton";
            SelectTextureButton.Size = new Size(277, 29);
            SelectTextureButton.TabIndex = 30;
            SelectTextureButton.Text = "Select";
            SelectTextureButton.UseVisualStyleBackColor = false;
            SelectTextureButton.Click += SelectTextureButton_Click;
            // 
            // TextureTextBox
            // 
            TextureTextBox.BackColor = Color.FromArgb(33, 37, 41);
            TextureTextBox.BorderStyle = BorderStyle.FixedSingle;
            TextureTextBox.ForeColor = Color.White;
            TextureTextBox.Location = new Point(39, 251);
            TextureTextBox.Name = "TextureTextBox";
            TextureTextBox.ReadOnly = true;
            TextureTextBox.Size = new Size(244, 27);
            TextureTextBox.TabIndex = 29;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Location = new Point(5, 226);
            label8.Name = "label8";
            label8.Size = new Size(278, 22);
            label8.TabIndex = 28;
            label8.Text = "Texture";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScaleYTextBox
            // 
            ScaleYTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScaleYTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScaleYTextBox.Enabled = false;
            ScaleYTextBox.ForeColor = Color.White;
            ScaleYTextBox.Location = new Point(147, 196);
            ScaleYTextBox.Name = "ScaleYTextBox";
            ScaleYTextBox.Size = new Size(135, 27);
            ScaleYTextBox.TabIndex = 27;
            ScaleYTextBox.Text = "0";
            ScaleYTextBox.TextAlign = HorizontalAlignment.Center;
            ScaleYTextBox.TextChanged += ScaleYTextBox_TextChanged;
            // 
            // ScaleXTextBox
            // 
            ScaleXTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScaleXTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScaleXTextBox.Enabled = false;
            ScaleXTextBox.ForeColor = Color.White;
            ScaleXTextBox.Location = new Point(9, 196);
            ScaleXTextBox.Name = "ScaleXTextBox";
            ScaleXTextBox.Size = new Size(132, 27);
            ScaleXTextBox.TabIndex = 26;
            ScaleXTextBox.Text = "0";
            ScaleXTextBox.TextAlign = HorizontalAlignment.Center;
            ScaleXTextBox.TextChanged += ScaleXTextBox_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Location = new Point(5, 171);
            label5.Name = "label5";
            label5.Size = new Size(278, 22);
            label5.TabIndex = 25;
            label5.Text = "Scale";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PosYTextBox
            // 
            PosYTextBox.BackColor = Color.FromArgb(33, 37, 41);
            PosYTextBox.BorderStyle = BorderStyle.FixedSingle;
            PosYTextBox.Enabled = false;
            PosYTextBox.ForeColor = Color.White;
            PosYTextBox.Location = new Point(147, 86);
            PosYTextBox.Name = "PosYTextBox";
            PosYTextBox.Size = new Size(135, 27);
            PosYTextBox.TabIndex = 24;
            PosYTextBox.Text = "0";
            PosYTextBox.TextAlign = HorizontalAlignment.Center;
            PosYTextBox.TextChanged += PosYTextBox_TextChanged;
            // 
            // PosXTextBox
            // 
            PosXTextBox.BackColor = Color.FromArgb(33, 37, 41);
            PosXTextBox.BorderStyle = BorderStyle.FixedSingle;
            PosXTextBox.Enabled = false;
            PosXTextBox.ForeColor = Color.White;
            PosXTextBox.Location = new Point(6, 86);
            PosXTextBox.Name = "PosXTextBox";
            PosXTextBox.Size = new Size(135, 27);
            PosXTextBox.TabIndex = 23;
            PosXTextBox.Text = "0";
            PosXTextBox.TextAlign = HorizontalAlignment.Center;
            PosXTextBox.TextChanged += PosXTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(6, 61);
            label4.Name = "label4";
            label4.Size = new Size(277, 22);
            label4.TabIndex = 22;
            label4.Text = "Position";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ObjectPictureBox
            // 
            ObjectPictureBox.BackgroundImage = ImageList._object;
            ObjectPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ObjectPictureBox.Location = new Point(6, 31);
            ObjectPictureBox.Name = "ObjectPictureBox";
            ObjectPictureBox.Size = new Size(27, 27);
            ObjectPictureBox.TabIndex = 21;
            ObjectPictureBox.TabStop = false;
            // 
            // VisibleCheckBox
            // 
            VisibleCheckBox.AutoSize = true;
            VisibleCheckBox.BackColor = Color.FromArgb(52, 58, 64);
            VisibleCheckBox.Enabled = false;
            VisibleCheckBox.Location = new Point(265, 36);
            VisibleCheckBox.Name = "VisibleCheckBox";
            VisibleCheckBox.Size = new Size(18, 17);
            VisibleCheckBox.TabIndex = 20;
            VisibleCheckBox.UseVisualStyleBackColor = false;
            VisibleCheckBox.CheckedChanged += VisibleCheckBox_CheckedChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Enabled = false;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(39, 31);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(220, 27);
            NameTextBox.TabIndex = 19;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(33, 37, 41);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 1;
            label1.Text = "Inspector";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(33, 37, 41);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, mapToolStripMenuItem, gameObjectToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1600, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewButton_TSM, OpenButton_TSM, toolStripSeparator1, SaveButton_TSM, SaveAsButton_TSM, toolStripSeparator2, CloseButton_TSM, toolStripSeparator3, ExitButton_TSM });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewButton_TSM
            // 
            NewButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            NewButton_TSM.ForeColor = Color.White;
            NewButton_TSM.Name = "NewButton_TSM";
            NewButton_TSM.Size = new Size(141, 26);
            NewButton_TSM.Text = "New";
            NewButton_TSM.Click += NewButton_TSM_Click;
            // 
            // OpenButton_TSM
            // 
            OpenButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            OpenButton_TSM.ForeColor = Color.White;
            OpenButton_TSM.Name = "OpenButton_TSM";
            OpenButton_TSM.Size = new Size(141, 26);
            OpenButton_TSM.Text = "Open";
            OpenButton_TSM.Click += OpenButton_TSM_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            toolStripSeparator1.Paint += toolStripSeparator1_Paint;
            // 
            // SaveButton_TSM
            // 
            SaveButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            SaveButton_TSM.Enabled = false;
            SaveButton_TSM.ForeColor = Color.White;
            SaveButton_TSM.Name = "SaveButton_TSM";
            SaveButton_TSM.Size = new Size(141, 26);
            SaveButton_TSM.Text = "Save";
            SaveButton_TSM.Click += SaveButton_TSM_Click;
            // 
            // SaveAsButton_TSM
            // 
            SaveAsButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            SaveAsButton_TSM.Enabled = false;
            SaveAsButton_TSM.ForeColor = Color.White;
            SaveAsButton_TSM.Name = "SaveAsButton_TSM";
            SaveAsButton_TSM.Size = new Size(141, 26);
            SaveAsButton_TSM.Text = "Save as";
            SaveAsButton_TSM.Click += SaveAsButton_TSM_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(138, 6);
            toolStripSeparator2.Paint += toolStripSeparator2_Paint;
            // 
            // CloseButton_TSM
            // 
            CloseButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            CloseButton_TSM.Enabled = false;
            CloseButton_TSM.ForeColor = Color.White;
            CloseButton_TSM.Name = "CloseButton_TSM";
            CloseButton_TSM.Size = new Size(141, 26);
            CloseButton_TSM.Text = "Close";
            CloseButton_TSM.Click += CloseButton_TSM_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(138, 6);
            toolStripSeparator3.Paint += toolStripSeparator3_Paint;
            // 
            // ExitButton_TSM
            // 
            ExitButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ExitButton_TSM.ForeColor = Color.White;
            ExitButton_TSM.Name = "ExitButton_TSM";
            ExitButton_TSM.Size = new Size(141, 26);
            ExitButton_TSM.Text = "Exit";
            ExitButton_TSM.Click += ExitButton_TSM_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowConsole_TSM, toolStripSeparator7, ShowFPS_TSM, ResetCSize_TSM });
            viewToolStripMenuItem.ForeColor = Color.White;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // ShowConsole_TSM
            // 
            ShowConsole_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ShowConsole_TSM.Checked = true;
            ShowConsole_TSM.CheckState = CheckState.Checked;
            ShowConsole_TSM.ForeColor = Color.White;
            ShowConsole_TSM.Name = "ShowConsole_TSM";
            ShowConsole_TSM.Size = new Size(214, 26);
            ShowConsole_TSM.Text = "Show Console";
            ShowConsole_TSM.Click += ShowConsole_TSM_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(211, 6);
            toolStripSeparator7.Paint += toolStripSeparator7_Paint;
            // 
            // ShowFPS_TSM
            // 
            ShowFPS_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ShowFPS_TSM.ForeColor = Color.White;
            ShowFPS_TSM.Name = "ShowFPS_TSM";
            ShowFPS_TSM.Size = new Size(214, 26);
            ShowFPS_TSM.Text = "Show FPS";
            ShowFPS_TSM.Click += ShowFPS_TSM_Click;
            // 
            // ResetCSize_TSM
            // 
            ResetCSize_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ResetCSize_TSM.ForeColor = Color.White;
            ResetCSize_TSM.Name = "ResetCSize_TSM";
            ResetCSize_TSM.Size = new Size(214, 26);
            ResetCSize_TSM.Text = "Reset Camera Size";
            ResetCSize_TSM.Click += ResetCSize_TSM_Click;
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowGrid_TSM, gridSettingsToolStripMenuItem, toolStripSeparator6, AudioManager_TSM, FontsManager_TSM, PluginsManager_TSM, SpriteManager_TSM });
            mapToolStripMenuItem.ForeColor = Color.White;
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(53, 24);
            mapToolStripMenuItem.Text = "Map";
            // 
            // ShowGrid_TSM
            // 
            ShowGrid_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ShowGrid_TSM.Checked = true;
            ShowGrid_TSM.CheckState = CheckState.Checked;
            ShowGrid_TSM.ForeColor = Color.White;
            ShowGrid_TSM.Name = "ShowGrid_TSM";
            ShowGrid_TSM.Size = new Size(202, 26);
            ShowGrid_TSM.Text = "Show Grid";
            ShowGrid_TSM.Click += ShowGrid_TSM_Click;
            // 
            // gridSettingsToolStripMenuItem
            // 
            gridSettingsToolStripMenuItem.BackColor = Color.FromArgb(33, 37, 41);
            gridSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sizeToolStripMenuItem, GridColorButton_TSM });
            gridSettingsToolStripMenuItem.ForeColor = Color.White;
            gridSettingsToolStripMenuItem.Name = "gridSettingsToolStripMenuItem";
            gridSettingsToolStripMenuItem.Size = new Size(202, 26);
            gridSettingsToolStripMenuItem.Text = "Grid Settings";
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.BackColor = Color.FromArgb(33, 37, 41);
            sizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GridSize20_TSM, GridSize25_TSM, GridSize30_TSM, GridSize35_TSM, GridSize40_TSM, GridSize45_TSM, GridSize50_TSM });
            sizeToolStripMenuItem.ForeColor = Color.White;
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(128, 26);
            sizeToolStripMenuItem.Text = "Size";
            // 
            // GridSize20_TSM
            // 
            GridSize20_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize20_TSM.ForeColor = Color.White;
            GridSize20_TSM.Name = "GridSize20_TSM";
            GridSize20_TSM.Size = new Size(108, 26);
            GridSize20_TSM.Text = "20";
            GridSize20_TSM.Click += GridSize20_TSM_Click;
            // 
            // GridSize25_TSM
            // 
            GridSize25_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize25_TSM.ForeColor = Color.White;
            GridSize25_TSM.Name = "GridSize25_TSM";
            GridSize25_TSM.Size = new Size(108, 26);
            GridSize25_TSM.Text = "25";
            GridSize25_TSM.Click += GridSize25_TSM_Click;
            // 
            // GridSize30_TSM
            // 
            GridSize30_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize30_TSM.ForeColor = Color.White;
            GridSize30_TSM.Name = "GridSize30_TSM";
            GridSize30_TSM.Size = new Size(108, 26);
            GridSize30_TSM.Text = "30";
            GridSize30_TSM.Click += GridSize30_TSM_Click;
            // 
            // GridSize35_TSM
            // 
            GridSize35_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize35_TSM.ForeColor = Color.White;
            GridSize35_TSM.Name = "GridSize35_TSM";
            GridSize35_TSM.Size = new Size(108, 26);
            GridSize35_TSM.Text = "35";
            GridSize35_TSM.Click += GridSize35_TSM_Click;
            // 
            // GridSize40_TSM
            // 
            GridSize40_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize40_TSM.ForeColor = Color.White;
            GridSize40_TSM.Name = "GridSize40_TSM";
            GridSize40_TSM.Size = new Size(108, 26);
            GridSize40_TSM.Text = "40";
            GridSize40_TSM.Click += GridSize40_TSM_Click;
            // 
            // GridSize45_TSM
            // 
            GridSize45_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize45_TSM.ForeColor = Color.White;
            GridSize45_TSM.Name = "GridSize45_TSM";
            GridSize45_TSM.Size = new Size(108, 26);
            GridSize45_TSM.Text = "45";
            GridSize45_TSM.Click += GridSize45_TSM_Click;
            // 
            // GridSize50_TSM
            // 
            GridSize50_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridSize50_TSM.ForeColor = Color.White;
            GridSize50_TSM.Name = "GridSize50_TSM";
            GridSize50_TSM.Size = new Size(108, 26);
            GridSize50_TSM.Text = "50";
            GridSize50_TSM.Click += GridSize50_TSM_Click;
            // 
            // GridColorButton_TSM
            // 
            GridColorButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GridColorButton_TSM.ForeColor = Color.White;
            GridColorButton_TSM.Name = "GridColorButton_TSM";
            GridColorButton_TSM.Size = new Size(128, 26);
            GridColorButton_TSM.Text = "Color";
            GridColorButton_TSM.Click += GridColorButton_TSM_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(199, 6);
            toolStripSeparator6.Paint += toolStripSeparator6_Paint;
            // 
            // AudioManager_TSM
            // 
            AudioManager_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AudioManager_TSM.ForeColor = Color.White;
            AudioManager_TSM.Name = "AudioManager_TSM";
            AudioManager_TSM.Size = new Size(202, 26);
            AudioManager_TSM.Text = "Audio Manager";
            AudioManager_TSM.Click += AudioManager_TSM_Click;
            // 
            // FontsManager_TSM
            // 
            FontsManager_TSM.BackColor = Color.FromArgb(33, 37, 41);
            FontsManager_TSM.ForeColor = Color.White;
            FontsManager_TSM.Name = "FontsManager_TSM";
            FontsManager_TSM.Size = new Size(202, 26);
            FontsManager_TSM.Text = "Fonts Manager";
            FontsManager_TSM.Click += FontsManager_TSM_Click;
            // 
            // PluginsManager_TSM
            // 
            PluginsManager_TSM.BackColor = Color.FromArgb(33, 37, 41);
            PluginsManager_TSM.ForeColor = Color.White;
            PluginsManager_TSM.Name = "PluginsManager_TSM";
            PluginsManager_TSM.Size = new Size(202, 26);
            PluginsManager_TSM.Text = "Plugins Manager";
            PluginsManager_TSM.Click += PluginsManager_TSM_Click;
            // 
            // SpriteManager_TSM
            // 
            SpriteManager_TSM.BackColor = Color.FromArgb(33, 37, 41);
            SpriteManager_TSM.ForeColor = Color.White;
            SpriteManager_TSM.Name = "SpriteManager_TSM";
            SpriteManager_TSM.Size = new Size(202, 26);
            SpriteManager_TSM.Text = "Sprite Manager";
            SpriteManager_TSM.Click += SpriteManager_TSM_Click;
            // 
            // gameObjectToolStripMenuItem
            // 
            gameObjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddGameObjectButton_TSM, RemoveGameObjectButton_TSM });
            gameObjectToolStripMenuItem.ForeColor = Color.White;
            gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            gameObjectToolStripMenuItem.Size = new Size(106, 24);
            gameObjectToolStripMenuItem.Text = "GameObject";
            // 
            // AddGameObjectButton_TSM
            // 
            AddGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddGameObjectButton_TSM.DropDownItems.AddRange(new ToolStripItem[] { AddPlugGameObjectButton_TSM, toolStripSeparator5, AddASGameObjectButton_TSM, AddAGameObjectButton_TSM, AddDLGameObjectButton_TSM, AddLGGameObjectButton_TSM, AddPCGameObjectButton_TSM, AddPrefabGameObjectButton_TSM, AddSpriteGameObjectButton_TSM, AddSGameObjectButton_TSM, AddTextGameObjectButton_TSM, AddTargetGameObjectButton_TSM });
            AddGameObjectButton_TSM.Enabled = false;
            AddGameObjectButton_TSM.ForeColor = Color.White;
            AddGameObjectButton_TSM.Name = "AddGameObjectButton_TSM";
            AddGameObjectButton_TSM.Size = new Size(224, 26);
            AddGameObjectButton_TSM.Text = "Add";
            // 
            // AddPlugGameObjectButton_TSM
            // 
            AddPlugGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddPlugGameObjectButton_TSM.DropDownItems.AddRange(new ToolStripItem[] { noneToolStripMenuItem });
            AddPlugGameObjectButton_TSM.ForeColor = Color.White;
            AddPlugGameObjectButton_TSM.Name = "AddPlugGameObjectButton_TSM";
            AddPlugGameObjectButton_TSM.Size = new Size(224, 26);
            AddPlugGameObjectButton_TSM.Text = "Plugin";
            // 
            // noneToolStripMenuItem
            // 
            noneToolStripMenuItem.BackColor = Color.FromArgb(33, 37, 41);
            noneToolStripMenuItem.ForeColor = Color.White;
            noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            noneToolStripMenuItem.Size = new Size(128, 26);
            noneToolStripMenuItem.Text = "None";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(221, 6);
            toolStripSeparator5.Paint += toolStripSeparator5_Paint;
            // 
            // AddASGameObjectButton_TSM
            // 
            AddASGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddASGameObjectButton_TSM.ForeColor = Color.White;
            AddASGameObjectButton_TSM.Name = "AddASGameObjectButton_TSM";
            AddASGameObjectButton_TSM.Size = new Size(224, 26);
            AddASGameObjectButton_TSM.Text = "Audio Source";
            AddASGameObjectButton_TSM.Click += AddASGameObjectButton_TSM_Click;
            // 
            // AddAGameObjectButton_TSM
            // 
            AddAGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddAGameObjectButton_TSM.ForeColor = Color.White;
            AddAGameObjectButton_TSM.Name = "AddAGameObjectButton_TSM";
            AddAGameObjectButton_TSM.Size = new Size(224, 26);
            AddAGameObjectButton_TSM.Text = "Animation";
            // 
            // AddDLGameObjectButton_TSM
            // 
            AddDLGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddDLGameObjectButton_TSM.ForeColor = Color.White;
            AddDLGameObjectButton_TSM.Name = "AddDLGameObjectButton_TSM";
            AddDLGameObjectButton_TSM.Size = new Size(224, 26);
            AddDLGameObjectButton_TSM.Text = "Dialog";
            AddDLGameObjectButton_TSM.Click += AddDLGameObjectButton_TSM_Click;
            // 
            // AddLGGameObjectButton_TSM
            // 
            AddLGGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddLGGameObjectButton_TSM.ForeColor = Color.White;
            AddLGGameObjectButton_TSM.Name = "AddLGGameObjectButton_TSM";
            AddLGGameObjectButton_TSM.Size = new Size(224, 26);
            AddLGGameObjectButton_TSM.Text = "Logic";
            AddLGGameObjectButton_TSM.Click += AddLGGameObjectButton_TSM_Click;
            // 
            // AddPCGameObjectButton_TSM
            // 
            AddPCGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddPCGameObjectButton_TSM.ForeColor = Color.White;
            AddPCGameObjectButton_TSM.Name = "AddPCGameObjectButton_TSM";
            AddPCGameObjectButton_TSM.Size = new Size(224, 26);
            AddPCGameObjectButton_TSM.Text = "Player Controller";
            AddPCGameObjectButton_TSM.Click += AddPCGameObjectButton_TSM_Click;
            // 
            // AddPrefabGameObjectButton_TSM
            // 
            AddPrefabGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddPrefabGameObjectButton_TSM.ForeColor = Color.White;
            AddPrefabGameObjectButton_TSM.Name = "AddPrefabGameObjectButton_TSM";
            AddPrefabGameObjectButton_TSM.Size = new Size(224, 26);
            AddPrefabGameObjectButton_TSM.Text = "Prefab";
            AddPrefabGameObjectButton_TSM.Click += AddPrefabGameObjectButton_TSM_Click;
            // 
            // AddSpriteGameObjectButton_TSM
            // 
            AddSpriteGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddSpriteGameObjectButton_TSM.ForeColor = Color.White;
            AddSpriteGameObjectButton_TSM.Name = "AddSpriteGameObjectButton_TSM";
            AddSpriteGameObjectButton_TSM.Size = new Size(224, 26);
            AddSpriteGameObjectButton_TSM.Text = "Sprite";
            AddSpriteGameObjectButton_TSM.Click += AddSpriteGameObjectButton_TSM_Click;
            // 
            // AddSGameObjectButton_TSM
            // 
            AddSGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddSGameObjectButton_TSM.ForeColor = Color.White;
            AddSGameObjectButton_TSM.Name = "AddSGameObjectButton_TSM";
            AddSGameObjectButton_TSM.Size = new Size(224, 26);
            AddSGameObjectButton_TSM.Text = "Script";
            AddSGameObjectButton_TSM.Click += AddSGameObjectButton_TSM_Click;
            // 
            // AddTextGameObjectButton_TSM
            // 
            AddTextGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddTextGameObjectButton_TSM.ForeColor = Color.White;
            AddTextGameObjectButton_TSM.Name = "AddTextGameObjectButton_TSM";
            AddTextGameObjectButton_TSM.Size = new Size(224, 26);
            AddTextGameObjectButton_TSM.Text = "Text";
            AddTextGameObjectButton_TSM.Click += AddTextGameObjectButton_TSM_Click;
            // 
            // AddTargetGameObjectButton_TSM
            // 
            AddTargetGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AddTargetGameObjectButton_TSM.ForeColor = Color.White;
            AddTargetGameObjectButton_TSM.Name = "AddTargetGameObjectButton_TSM";
            AddTargetGameObjectButton_TSM.Size = new Size(224, 26);
            AddTargetGameObjectButton_TSM.Text = "Target";
            AddTargetGameObjectButton_TSM.Click += AddTargetGameObjectButton_TSM_Click;
            // 
            // RemoveGameObjectButton_TSM
            // 
            RemoveGameObjectButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            RemoveGameObjectButton_TSM.Enabled = false;
            RemoveGameObjectButton_TSM.ForeColor = Color.White;
            RemoveGameObjectButton_TSM.Name = "RemoveGameObjectButton_TSM";
            RemoveGameObjectButton_TSM.Size = new Size(224, 26);
            RemoveGameObjectButton_TSM.Text = "Remove";
            RemoveGameObjectButton_TSM.Click += RemoveGameObjectButton_TSM_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkUpdateToolStripMenuItem, toolStripSeparator4, AboutButton_TSM });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // checkUpdateToolStripMenuItem
            // 
            checkUpdateToolStripMenuItem.BackColor = Color.FromArgb(33, 37, 41);
            checkUpdateToolStripMenuItem.ForeColor = Color.White;
            checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            checkUpdateToolStripMenuItem.Size = new Size(184, 26);
            checkUpdateToolStripMenuItem.Text = "Check Update";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(181, 6);
            toolStripSeparator4.Paint += toolStripSeparator4_Paint;
            // 
            // AboutButton_TSM
            // 
            AboutButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AboutButton_TSM.ForeColor = Color.White;
            AboutButton_TSM.Name = "AboutButton_TSM";
            AboutButton_TSM.Size = new Size(184, 26);
            AboutButton_TSM.Text = "About";
            AboutButton_TSM.Click += AboutButton_TSM_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.White;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1600, 743);
            Controls.Add(sfmlPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mickey Editor";
            Shown += MainForm_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ComponentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel sfmlPanel;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewButton_TSM;
        private ToolStripMenuItem OpenButton_TSM;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ExitButton_TSM;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem ShowGrid_TSM;
        private ToolStripMenuItem gridSettingsToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem GridColorButton_TSM;
        private ToolStripMenuItem GridSize20_TSM;
        private ToolStripMenuItem GridSize25_TSM;
        private ToolStripMenuItem GridSize30_TSM;
        private ToolStripMenuItem GridSize35_TSM;
        private ToolStripMenuItem GridSize40_TSM;
        private ToolStripMenuItem GridSize45_TSM;
        private ToolStripMenuItem GridSize50_TSM;
        private ToolStripMenuItem gameObjectToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutButton_TSM;
        private ToolStripMenuItem AddASGameObjectButton_TSM;
        private ToolStripMenuItem AddAGameObjectButton_TSM;
        private ToolStripMenuItem AddDLGameObjectButton_TSM;
        private ToolStripMenuItem AddLGGameObjectButton_TSM;
        private ToolStripMenuItem AddPCGameObjectButton_TSM;
        private ToolStripMenuItem AddSGameObjectButton_TSM;
        private ToolStripMenuItem AddPrefabGameObjectButton_TSM;
        private ToolStripMenuItem AddTextGameObjectButton_TSM;
        private ColorDialog colorDialog1;
        private PictureBox ObjectPictureBox;
        private CheckBox VisibleCheckBox;
        public TextBox NameTextBox;
        private PictureBox pictureBox1;
        public TextBox RotationTextBox;
        private Label label3;
        private Button SelectTextureButton;
        public TextBox TextureTextBox;
        private Label label8;
        public TextBox ScaleYTextBox;
        public TextBox ScaleXTextBox;
        private Label label5;
        public TextBox PosYTextBox;
        public TextBox PosXTextBox;
        private Label label4;
        private Label ComponentNameLabel;
        private Panel ComponentPanel;
        private Label ComponentLabel;
        private ToolStripMenuItem checkUpdateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem AddPlugGameObjectButton_TSM;
        private ToolStripMenuItem noneToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private Label ConsoleLabel;
        private Panel panel2;
        private ListBox ConsoleListBox;
        private ToolStripMenuItem AddSpriteGameObjectButton_TSM;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem SpriteManager_TSM;
        private ToolStripMenuItem AddTargetGameObjectButton_TSM;
        public ListBox ManagerListBox;
        public ToolStripMenuItem SaveButton_TSM;
        public ToolStripMenuItem SaveAsButton_TSM;
        public ToolStripMenuItem CloseButton_TSM;
        public ToolStripMenuItem AddGameObjectButton_TSM;
        public ToolStripMenuItem RemoveGameObjectButton_TSM;
        private ToolStripMenuItem PluginsManager_TSM;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem ShowFPS_TSM;
        private ToolStripMenuItem ShowConsole_TSM;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem ResetCSize_TSM;
        private ToolStripMenuItem AudioManager_TSM;
        private ToolStripMenuItem FontsManager_TSM;
    }
}