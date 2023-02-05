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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sfmlPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddASGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDLGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLGGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPCGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveGameObjectButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 715);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Map Manager";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfmlPanel
            // 
            this.sfmlPanel.BackColor = System.Drawing.Color.Black;
            this.sfmlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfmlPanel.Location = new System.Drawing.Point(295, 28);
            this.sfmlPanel.Name = "sfmlPanel";
            this.sfmlPanel.Size = new System.Drawing.Size(1010, 715);
            this.sfmlPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1305, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 715);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inspector";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.gameObjectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 28);
            this.menuStrip1.TabIndex = 3;
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
            // 
            // OpenButton_TSM
            // 
            this.OpenButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.OpenButton_TSM.ForeColor = System.Drawing.Color.White;
            this.OpenButton_TSM.Name = "OpenButton_TSM";
            this.OpenButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.OpenButton_TSM.Text = "Open";
            // 
            // toolStripSeparator1
            // 
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
            // 
            // SaveAsButton_TSM
            // 
            this.SaveAsButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SaveAsButton_TSM.Enabled = false;
            this.SaveAsButton_TSM.ForeColor = System.Drawing.Color.White;
            this.SaveAsButton_TSM.Name = "SaveAsButton_TSM";
            this.SaveAsButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.SaveAsButton_TSM.Text = "Save as";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // CloseButton_TSM
            // 
            this.CloseButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CloseButton_TSM.Enabled = false;
            this.CloseButton_TSM.ForeColor = System.Drawing.Color.White;
            this.CloseButton_TSM.Name = "CloseButton_TSM";
            this.CloseButton_TSM.Size = new System.Drawing.Size(141, 26);
            this.CloseButton_TSM.Text = "Close";
            // 
            // toolStripSeparator3
            // 
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
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowGrid_TSM,
            this.gridSettingsToolStripMenuItem});
            this.mapToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.mapToolStripMenuItem.Text = "Map";
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
            // 
            // GridSize25_TSM
            // 
            this.GridSize25_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize25_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize25_TSM.Name = "GridSize25_TSM";
            this.GridSize25_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize25_TSM.Text = "25";
            // 
            // GridSize30_TSM
            // 
            this.GridSize30_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize30_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize30_TSM.Name = "GridSize30_TSM";
            this.GridSize30_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize30_TSM.Text = "30";
            // 
            // GridSize35_TSM
            // 
            this.GridSize35_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize35_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize35_TSM.Name = "GridSize35_TSM";
            this.GridSize35_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize35_TSM.Text = "35";
            // 
            // GridSize40_TSM
            // 
            this.GridSize40_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize40_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize40_TSM.Name = "GridSize40_TSM";
            this.GridSize40_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize40_TSM.Text = "40";
            // 
            // GridSize45_TSM
            // 
            this.GridSize45_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize45_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize45_TSM.Name = "GridSize45_TSM";
            this.GridSize45_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize45_TSM.Text = "45";
            // 
            // GridSize50_TSM
            // 
            this.GridSize50_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridSize50_TSM.ForeColor = System.Drawing.Color.White;
            this.GridSize50_TSM.Name = "GridSize50_TSM";
            this.GridSize50_TSM.Size = new System.Drawing.Size(108, 26);
            this.GridSize50_TSM.Text = "50";
            // 
            // GridColorButton_TSM
            // 
            this.GridColorButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridColorButton_TSM.ForeColor = System.Drawing.Color.White;
            this.GridColorButton_TSM.Name = "GridColorButton_TSM";
            this.GridColorButton_TSM.Size = new System.Drawing.Size(128, 26);
            this.GridColorButton_TSM.Text = "Color";
            // 
            // gameObjectToolStripMenuItem
            // 
            this.gameObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.RemoveGameObjectButton_TSM});
            this.gameObjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            this.gameObjectToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.gameObjectToolStripMenuItem.Text = "GameObject";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddASGameObjectButton_TSM,
            this.AddAGameObjectButton_TSM,
            this.AddDLGameObjectButton_TSM,
            this.AddLGGameObjectButton_TSM,
            this.AddPCGameObjectButton_TSM,
            this.AddSGameObjectButton_TSM});
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // AddASGameObjectButton_TSM
            // 
            this.AddASGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddASGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddASGameObjectButton_TSM.Name = "AddASGameObjectButton_TSM";
            this.AddASGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddASGameObjectButton_TSM.Text = "Audio Source";
            // 
            // AddAGameObjectButton_TSM
            // 
            this.AddAGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddAGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddAGameObjectButton_TSM.Name = "AddAGameObjectButton_TSM";
            this.AddAGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddAGameObjectButton_TSM.Text = "Animation";
            // 
            // AddDLGameObjectButton_TSM
            // 
            this.AddDLGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddDLGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddDLGameObjectButton_TSM.Name = "AddDLGameObjectButton_TSM";
            this.AddDLGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddDLGameObjectButton_TSM.Text = "Dialog";
            // 
            // AddLGGameObjectButton_TSM
            // 
            this.AddLGGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddLGGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddLGGameObjectButton_TSM.Name = "AddLGGameObjectButton_TSM";
            this.AddLGGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddLGGameObjectButton_TSM.Text = "Logic";
            // 
            // AddPCGameObjectButton_TSM
            // 
            this.AddPCGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddPCGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddPCGameObjectButton_TSM.Name = "AddPCGameObjectButton_TSM";
            this.AddPCGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddPCGameObjectButton_TSM.Text = "Player Controller";
            // 
            // AddSGameObjectButton_TSM
            // 
            this.AddSGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddSGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.AddSGameObjectButton_TSM.Name = "AddSGameObjectButton_TSM";
            this.AddSGameObjectButton_TSM.Size = new System.Drawing.Size(202, 26);
            this.AddSGameObjectButton_TSM.Text = "Script";
            // 
            // RemoveGameObjectButton_TSM
            // 
            this.RemoveGameObjectButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.RemoveGameObjectButton_TSM.Enabled = false;
            this.RemoveGameObjectButton_TSM.ForeColor = System.Drawing.Color.White;
            this.RemoveGameObjectButton_TSM.Name = "RemoveGameObjectButton_TSM";
            this.RemoveGameObjectButton_TSM.Size = new System.Drawing.Size(146, 26);
            this.RemoveGameObjectButton_TSM.Text = "Remove";
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
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 662);
            this.listBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1600, 743);
            this.Controls.Add(this.sfmlPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mickey Editor";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem SaveButton_TSM;
        private ToolStripMenuItem SaveAsButton_TSM;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem CloseButton_TSM;
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
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem AddASGameObjectButton_TSM;
        private ToolStripMenuItem AddAGameObjectButton_TSM;
        private ToolStripMenuItem AddDLGameObjectButton_TSM;
        private ToolStripMenuItem AddLGGameObjectButton_TSM;
        private ToolStripMenuItem AddPCGameObjectButton_TSM;
        private ToolStripMenuItem AddSGameObjectButton_TSM;
        private ToolStripMenuItem RemoveGameObjectButton_TSM;
        private ListBox listBox1;
    }
}