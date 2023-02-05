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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BuildButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowGrid_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize20_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize25_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize30_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize35_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize40_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize45_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridSize50_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.GridColorButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.GameInfoButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveSelectObjectButton = new System.Windows.Forms.Button();
            this.AddNewObjectButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton_TSM,
            this.OpenButton_TSM,
            this.toolStripSeparator1,
            this.SaveButton_TSM,
            this.SaveAsButton_TSM,
            this.toolStripSeparator2,
            this.BuildButton_TSM,
            this.toolStripSeparator4,
            this.CloseButton_TSM,
            this.toolStripSeparator3,
            this.ExitButton_TSM});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewButton_TSM
            // 
            this.NewButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.NewButton_TSM.ForeColor = System.Drawing.Color.White;
            this.NewButton_TSM.Name = "NewButton_TSM";
            this.NewButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.NewButton_TSM.Text = "New";
            this.NewButton_TSM.Click += new System.EventHandler(this.NewButton_TSM_Click);
            // 
            // OpenButton_TSM
            // 
            this.OpenButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.OpenButton_TSM.ForeColor = System.Drawing.Color.White;
            this.OpenButton_TSM.Name = "OpenButton_TSM";
            this.OpenButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.OpenButton_TSM.Text = "Open";
            this.OpenButton_TSM.Click += new System.EventHandler(this.OpenButton_TSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator1_Paint);
            // 
            // SaveButton_TSM
            // 
            this.SaveButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SaveButton_TSM.Enabled = false;
            this.SaveButton_TSM.ForeColor = System.Drawing.Color.White;
            this.SaveButton_TSM.Name = "SaveButton_TSM";
            this.SaveButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.SaveButton_TSM.Text = "Save";
            this.SaveButton_TSM.Click += new System.EventHandler(this.SaveButton_TSM_Click);
            // 
            // SaveAsButton_TSM
            // 
            this.SaveAsButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SaveAsButton_TSM.Enabled = false;
            this.SaveAsButton_TSM.ForeColor = System.Drawing.Color.White;
            this.SaveAsButton_TSM.Name = "SaveAsButton_TSM";
            this.SaveAsButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.SaveAsButton_TSM.Text = "Save as";
            this.SaveAsButton_TSM.Click += new System.EventHandler(this.SaveAsButton_TSM_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // BuildButton_TSM
            // 
            this.BuildButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BuildButton_TSM.Enabled = false;
            this.BuildButton_TSM.ForeColor = System.Drawing.Color.White;
            this.BuildButton_TSM.Name = "BuildButton_TSM";
            this.BuildButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.BuildButton_TSM.Text = "Build";
            this.BuildButton_TSM.Click += new System.EventHandler(this.BuildButton_TSM_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator4.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator4_Paint);
            // 
            // CloseButton_TSM
            // 
            this.CloseButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CloseButton_TSM.Enabled = false;
            this.CloseButton_TSM.ForeColor = System.Drawing.Color.White;
            this.CloseButton_TSM.Name = "CloseButton_TSM";
            this.CloseButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.CloseButton_TSM.Text = "Close";
            this.CloseButton_TSM.Click += new System.EventHandler(this.CloseButton_TSM_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator3.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator3_Paint);
            // 
            // ExitButton_TSM
            // 
            this.ExitButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ExitButton_TSM.ForeColor = System.Drawing.Color.White;
            this.ExitButton_TSM.Name = "ExitButton_TSM";
            this.ExitButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.ExitButton_TSM.Text = "Exit";
            this.ExitButton_TSM.Click += new System.EventHandler(this.ExitButton_TSM_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowGrid_TSM,
            this.gridSettingsToolStripMenuItem,
            this.toolStripSeparator6,
            this.GameInfoButton_TSM});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.editToolStripMenuItem.Text = "Map";
            // 
            // ShowGrid_TSM
            // 
            this.ShowGrid_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ShowGrid_TSM.Checked = true;
            this.ShowGrid_TSM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowGrid_TSM.ForeColor = System.Drawing.Color.White;
            this.ShowGrid_TSM.Name = "ShowGrid_TSM";
            this.ShowGrid_TSM.Size = new System.Drawing.Size(177, 26);
            this.ShowGrid_TSM.Text = "Show Grid";
            this.ShowGrid_TSM.Click += new System.EventHandler(this.ShowGrid_TSM_Click);
            // 
            // gridSettingsToolStripMenuItem
            // 
            this.gridSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gridSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.GridColorButton_TSM});
            this.gridSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gridSettingsToolStripMenuItem.Name = "gridSettingsToolStripMenuItem";
            this.gridSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.gridSettingsToolStripMenuItem.Text = "Grid Settings";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridSize20_TSM,
            this.GridSize25_TSM,
            this.GridSize30_TSM,
            this.GridSize35_TSM,
            this.GridSize40_TSM,
            this.GridSize45_TSM,
            this.GridSize50_TSM});
            this.sizeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // GridSize20_TSM
            // 
            this.GridSize20_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize20_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize20_TSM.Name = "GridSize20_TSM";
            this.GridSize20_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize20_TSM.Text = "20";
            this.GridSize20_TSM.Click += new System.EventHandler(this.GridSize20_TSM_Click);
            // 
            // GridSize25_TSM
            // 
            this.GridSize25_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize25_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize25_TSM.Name = "GridSize25_TSM";
            this.GridSize25_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize25_TSM.Text = "25";
            this.GridSize25_TSM.Click += new System.EventHandler(this.GridSize25_TSM_Click);
            // 
            // GridSize30_TSM
            // 
            this.GridSize30_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize30_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize30_TSM.Name = "GridSize30_TSM";
            this.GridSize30_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize30_TSM.Text = "30";
            this.GridSize30_TSM.Click += new System.EventHandler(this.GridSize30_TSM_Click);
            // 
            // GridSize35_TSM
            // 
            this.GridSize35_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize35_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize35_TSM.Name = "GridSize35_TSM";
            this.GridSize35_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize35_TSM.Text = "35";
            this.GridSize35_TSM.Click += new System.EventHandler(this.GridSize35_TSM_Click);
            // 
            // GridSize40_TSM
            // 
            this.GridSize40_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize40_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize40_TSM.Name = "GridSize40_TSM";
            this.GridSize40_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize40_TSM.Text = "40";
            this.GridSize40_TSM.Click += new System.EventHandler(this.GridSize40_TSM_Click);
            // 
            // GridSize45_TSM
            // 
            this.GridSize45_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize45_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize45_TSM.Name = "GridSize45_TSM";
            this.GridSize45_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize45_TSM.Text = "45";
            this.GridSize45_TSM.Click += new System.EventHandler(this.GridSize45_TSM_Click);
            // 
            // GridSize50_TSM
            // 
            this.GridSize50_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize50_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize50_TSM.Name = "GridSize50_TSM";
            this.GridSize50_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize50_TSM.Text = "50";
            this.GridSize50_TSM.Click += new System.EventHandler(this.GridSize50_TSM_Click);
            // 
            // GridColorButton_TSM
            // 
            this.GridColorButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridColorButton_TSM.ForeColor = System.Drawing.Color.White;
            this.GridColorButton_TSM.Name = "GridColorButton_TSM";
            this.GridColorButton_TSM.Size = new System.Drawing.Size(128, 26);
            this.GridColorButton_TSM.Text = "Color";
            this.GridColorButton_TSM.Click += new System.EventHandler(this.GridColorButton_TSM_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(174, 6);
            this.toolStripSeparator6.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator6_Paint);
            // 
            // GameInfoButton_TSM
            // 
            this.GameInfoButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GameInfoButton_TSM.ForeColor = System.Drawing.Color.White;
            this.GameInfoButton_TSM.Name = "GameInfoButton_TSM";
            this.GameInfoButton_TSM.Size = new System.Drawing.Size(177, 26);
            this.GameInfoButton_TSM.Text = "GameInfo";
            this.GameInfoButton_TSM.Click += new System.EventHandler(this.GameInfoButton_TSM_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton_TSM});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutButton_TSM
            // 
            this.AboutButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AboutButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AboutButton_TSM.Name = "AboutButton_TSM";
            this.AboutButton_TSM.Size = new System.Drawing.Size(133, 26);
            this.AboutButton_TSM.Text = "About";
            this.AboutButton_TSM.Click += new System.EventHandler(this.AboutButton_TSM_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 602);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RemoveSelectObjectButton
            // 
            this.RemoveSelectObjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.RemoveSelectObjectButton.Enabled = false;
            this.RemoveSelectObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectObjectButton.Location = new System.Drawing.Point(12, 682);
            this.RemoveSelectObjectButton.Name = "RemoveSelectObjectButton";
            this.RemoveSelectObjectButton.Size = new System.Drawing.Size(253, 29);
            this.RemoveSelectObjectButton.TabIndex = 3;
            this.RemoveSelectObjectButton.Text = "Remove Select Object";
            this.RemoveSelectObjectButton.UseVisualStyleBackColor = false;
            this.RemoveSelectObjectButton.Click += new System.EventHandler(this.RemoveSelectObjectButton_Click);
            // 
            // AddNewObjectButton
            // 
            this.AddNewObjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddNewObjectButton.Enabled = false;
            this.AddNewObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewObjectButton.Location = new System.Drawing.Point(12, 647);
            this.AddNewObjectButton.Name = "AddNewObjectButton";
            this.AddNewObjectButton.Size = new System.Drawing.Size(253, 29);
            this.AddNewObjectButton.TabIndex = 4;
            this.AddNewObjectButton.Text = "Add New Object";
            this.AddNewObjectButton.UseVisualStyleBackColor = false;
            this.AddNewObjectButton.Click += new System.EventHandler(this.AddNewObjectButton_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 723);
            this.Controls.Add(this.AddNewObjectButton);
            this.Controls.Add(this.RemoveSelectObjectButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}