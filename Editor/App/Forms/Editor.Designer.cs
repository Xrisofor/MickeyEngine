namespace Editor.App
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewButton_TSM = new ToolStripMenuItem();
            OpenButton_TSM = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveButton_TSM = new ToolStripMenuItem();
            SaveAsButton_TSM = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            BuildButton_TSM = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            CloseButton_TSM = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ExitButton_TSM = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
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
            GameInfoButton_TSM = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutButton_TSM = new ToolStripMenuItem();
            listBox1 = new ListBox();
            RemoveSelectObjectButton = new Button();
            AddNewObjectButton = new Button();
            colorDialog1 = new ColorDialog();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(33, 37, 41);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(277, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewButton_TSM, OpenButton_TSM, toolStripSeparator1, SaveButton_TSM, SaveAsButton_TSM, toolStripSeparator2, BuildButton_TSM, toolStripSeparator4, CloseButton_TSM, toolStripSeparator3, ExitButton_TSM, fileToolStripMenuItem1 });
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
            NewButton_TSM.Size = new Size(224, 26);
            NewButton_TSM.Text = "New";
            NewButton_TSM.Click += NewButton_TSM_Click;
            // 
            // OpenButton_TSM
            // 
            OpenButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            OpenButton_TSM.ForeColor = Color.White;
            OpenButton_TSM.Name = "OpenButton_TSM";
            OpenButton_TSM.Size = new Size(224, 26);
            OpenButton_TSM.Text = "Open";
            OpenButton_TSM.Click += OpenButton_TSM_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = Color.FromArgb(46, 46, 46);
            toolStripSeparator1.ForeColor = Color.White;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            toolStripSeparator1.Paint += toolStripSeparator1_Paint;
            // 
            // SaveButton_TSM
            // 
            SaveButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            SaveButton_TSM.Enabled = false;
            SaveButton_TSM.ForeColor = Color.White;
            SaveButton_TSM.Name = "SaveButton_TSM";
            SaveButton_TSM.Size = new Size(224, 26);
            SaveButton_TSM.Text = "Save";
            SaveButton_TSM.Click += SaveButton_TSM_Click;
            // 
            // SaveAsButton_TSM
            // 
            SaveAsButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            SaveAsButton_TSM.Enabled = false;
            SaveAsButton_TSM.ForeColor = Color.White;
            SaveAsButton_TSM.Name = "SaveAsButton_TSM";
            SaveAsButton_TSM.Size = new Size(224, 26);
            SaveAsButton_TSM.Text = "Save as";
            SaveAsButton_TSM.Click += SaveAsButton_TSM_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = Color.FromArgb(46, 46, 46);
            toolStripSeparator2.ForeColor = Color.White;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            toolStripSeparator2.Paint += toolStripSeparator2_Paint;
            // 
            // BuildButton_TSM
            // 
            BuildButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            BuildButton_TSM.Enabled = false;
            BuildButton_TSM.ForeColor = Color.White;
            BuildButton_TSM.Name = "BuildButton_TSM";
            BuildButton_TSM.Size = new Size(224, 26);
            BuildButton_TSM.Text = "Build";
            BuildButton_TSM.Click += BuildButton_TSM_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            toolStripSeparator4.Paint += toolStripSeparator4_Paint;
            // 
            // CloseButton_TSM
            // 
            CloseButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            CloseButton_TSM.Enabled = false;
            CloseButton_TSM.ForeColor = Color.White;
            CloseButton_TSM.Name = "CloseButton_TSM";
            CloseButton_TSM.Size = new Size(224, 26);
            CloseButton_TSM.Text = "Close";
            CloseButton_TSM.Click += CloseButton_TSM_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = Color.FromArgb(46, 46, 46);
            toolStripSeparator3.ForeColor = Color.White;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            toolStripSeparator3.Paint += toolStripSeparator3_Paint;
            // 
            // ExitButton_TSM
            // 
            ExitButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ExitButton_TSM.ForeColor = Color.White;
            ExitButton_TSM.Name = "ExitButton_TSM";
            ExitButton_TSM.Size = new Size(224, 26);
            ExitButton_TSM.Text = "Exit";
            ExitButton_TSM.Click += ExitButton_TSM_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowGrid_TSM, gridSettingsToolStripMenuItem, toolStripSeparator6, GameInfoButton_TSM });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 24);
            editToolStripMenuItem.Text = "Map";
            // 
            // ShowGrid_TSM
            // 
            ShowGrid_TSM.BackColor = Color.FromArgb(33, 37, 41);
            ShowGrid_TSM.Checked = true;
            ShowGrid_TSM.CheckState = CheckState.Checked;
            ShowGrid_TSM.ForeColor = Color.White;
            ShowGrid_TSM.Name = "ShowGrid_TSM";
            ShowGrid_TSM.Size = new Size(224, 26);
            ShowGrid_TSM.Text = "Show Grid";
            ShowGrid_TSM.Click += ShowGrid_TSM_Click;
            // 
            // gridSettingsToolStripMenuItem
            // 
            gridSettingsToolStripMenuItem.BackColor = Color.FromArgb(33, 37, 41);
            gridSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sizeToolStripMenuItem, GridColorButton_TSM });
            gridSettingsToolStripMenuItem.ForeColor = Color.White;
            gridSettingsToolStripMenuItem.Name = "gridSettingsToolStripMenuItem";
            gridSettingsToolStripMenuItem.Size = new Size(224, 26);
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
            toolStripSeparator6.Size = new Size(221, 6);
            toolStripSeparator6.Paint += toolStripSeparator6_Paint;
            // 
            // GameInfoButton_TSM
            // 
            GameInfoButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            GameInfoButton_TSM.ForeColor = Color.White;
            GameInfoButton_TSM.Name = "GameInfoButton_TSM";
            GameInfoButton_TSM.Size = new Size(224, 26);
            GameInfoButton_TSM.Text = "GameInfo";
            GameInfoButton_TSM.Click += GameInfoButton_TSM_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutButton_TSM });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutButton_TSM
            // 
            AboutButton_TSM.BackColor = Color.FromArgb(33, 37, 41);
            AboutButton_TSM.ForeColor = Color.White;
            AboutButton_TSM.Name = "AboutButton_TSM";
            AboutButton_TSM.Size = new Size(133, 26);
            AboutButton_TSM.Text = "About";
            AboutButton_TSM.Click += AboutButton_TSM_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(33, 37, 41);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(253, 602);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // RemoveSelectObjectButton
            // 
            RemoveSelectObjectButton.BackColor = Color.FromArgb(33, 37, 41);
            RemoveSelectObjectButton.Enabled = false;
            RemoveSelectObjectButton.FlatStyle = FlatStyle.Flat;
            RemoveSelectObjectButton.Location = new Point(12, 682);
            RemoveSelectObjectButton.Name = "RemoveSelectObjectButton";
            RemoveSelectObjectButton.Size = new Size(253, 29);
            RemoveSelectObjectButton.TabIndex = 3;
            RemoveSelectObjectButton.Text = "Remove Select Object";
            RemoveSelectObjectButton.UseVisualStyleBackColor = false;
            RemoveSelectObjectButton.Click += RemoveSelectObjectButton_Click;
            // 
            // AddNewObjectButton
            // 
            AddNewObjectButton.BackColor = Color.FromArgb(33, 37, 41);
            AddNewObjectButton.Enabled = false;
            AddNewObjectButton.FlatStyle = FlatStyle.Flat;
            AddNewObjectButton.Location = new Point(12, 647);
            AddNewObjectButton.Name = "AddNewObjectButton";
            AddNewObjectButton.Size = new Size(253, 29);
            AddNewObjectButton.TabIndex = 4;
            AddNewObjectButton.Text = "Add New Object";
            AddNewObjectButton.UseVisualStyleBackColor = false;
            AddNewObjectButton.Click += AddNewObjectButton_Click;
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(224, 26);
            fileToolStripMenuItem1.Text = "File";
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(277, 723);
            Controls.Add(AddNewObjectButton);
            Controls.Add(RemoveSelectObjectButton);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ListBox listBox1;
        private Button RemoveSelectObjectButton;
        private Button AddNewObjectButton;
        private ToolStripMenuItem NewButton_TSM;
        private ToolStripMenuItem OpenButton_TSM;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SaveButton_TSM;
        private ToolStripMenuItem SaveAsButton_TSM;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem CloseButton_TSM;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ExitButton_TSM;
        private ToolStripMenuItem BuildButton_TSM;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem GameInfoButton_TSM;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem ShowGrid_TSM;
        private ToolStripMenuItem gridSettingsToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem GridSize20_TSM;
        private ToolStripMenuItem GridSize25_TSM;
        private ToolStripMenuItem GridSize30_TSM;
        private ToolStripMenuItem GridSize35_TSM;
        private ToolStripMenuItem GridSize40_TSM;
        private ToolStripMenuItem GridSize45_TSM;
        private ToolStripMenuItem GridSize50_TSM;
        private ToolStripMenuItem GridColorButton_TSM;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutButton_TSM;
        private ToolStripMenuItem fileToolStripMenuItem1;
    }
}