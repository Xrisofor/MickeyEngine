namespace Launcher.Forms
{
    partial class Projects
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            label1 = new Label();
            AddProjectButton = new Button();
            ProjectsListView = new ListView();
            ProjectsMenuStrip = new ContextMenuStrip(components);
            OpenTSMButton = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            BuildTSMButton = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteTSMButton = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            NewProjectButton = new Button();
            SwitchEVTSMButton = new ToolStripMenuItem();
            ProjectsMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 0;
            label1.Text = "Projects Library";
            // 
            // AddProjectButton
            // 
            AddProjectButton.FlatAppearance.BorderSize = 0;
            AddProjectButton.FlatStyle = FlatStyle.Flat;
            AddProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddProjectButton.Location = new Point(725, 12);
            AddProjectButton.Name = "AddProjectButton";
            AddProjectButton.Size = new Size(145, 38);
            AddProjectButton.TabIndex = 2;
            AddProjectButton.Text = "Add Project";
            AddProjectButton.UseVisualStyleBackColor = true;
            AddProjectButton.Click += AddProjectButton_Click;
            // 
            // ProjectsListView
            // 
            ProjectsListView.Activation = ItemActivation.TwoClick;
            ProjectsListView.BackColor = Color.FromArgb(31, 31, 31);
            ProjectsListView.BorderStyle = BorderStyle.FixedSingle;
            ProjectsListView.ContextMenuStrip = ProjectsMenuStrip;
            ProjectsListView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectsListView.ForeColor = Color.White;
            ProjectsListView.GroupImageList = imageList1;
            ProjectsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ProjectsListView.LargeImageList = imageList1;
            ProjectsListView.Location = new Point(12, 69);
            ProjectsListView.MultiSelect = false;
            ProjectsListView.Name = "ProjectsListView";
            ProjectsListView.Size = new Size(858, 580);
            ProjectsListView.TabIndex = 3;
            ProjectsListView.UseCompatibleStateImageBehavior = false;
            ProjectsListView.ItemActivate += ProjectsListView_ItemActivate;
            // 
            // ProjectsMenuStrip
            // 
            ProjectsMenuStrip.ImageScalingSize = new Size(20, 20);
            ProjectsMenuStrip.Items.AddRange(new ToolStripItem[] { OpenTSMButton, toolStripSeparator1, BuildTSMButton, SwitchEVTSMButton, toolStripSeparator2, DeleteTSMButton });
            ProjectsMenuStrip.Name = "ProjectsMenuStrip";
            ProjectsMenuStrip.Size = new Size(223, 140);
            // 
            // OpenTSMButton
            // 
            OpenTSMButton.BackColor = Color.FromArgb(26, 26, 26);
            OpenTSMButton.ForeColor = Color.White;
            OpenTSMButton.Name = "OpenTSMButton";
            OpenTSMButton.Size = new Size(222, 24);
            OpenTSMButton.Text = "Open";
            OpenTSMButton.Click += OpenTSMButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(219, 6);
            toolStripSeparator1.Paint += toolStripSeparator1_Paint;
            // 
            // BuildTSMButton
            // 
            BuildTSMButton.BackColor = Color.FromArgb(26, 26, 26);
            BuildTSMButton.ForeColor = Color.White;
            BuildTSMButton.Name = "BuildTSMButton";
            BuildTSMButton.Size = new Size(222, 24);
            BuildTSMButton.Text = "Build";
            BuildTSMButton.Click += BuildTSMButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(219, 6);
            toolStripSeparator2.Paint += toolStripSeparator2_Paint;
            // 
            // DeleteTSMButton
            // 
            DeleteTSMButton.BackColor = Color.FromArgb(26, 26, 26);
            DeleteTSMButton.ForeColor = Color.White;
            DeleteTSMButton.Name = "DeleteTSMButton";
            DeleteTSMButton.Size = new Size(222, 24);
            DeleteTSMButton.Text = "Delete";
            DeleteTSMButton.Click += DeleteTSMButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-box-512.png");
            // 
            // NewProjectButton
            // 
            NewProjectButton.FlatAppearance.BorderSize = 0;
            NewProjectButton.FlatStyle = FlatStyle.Flat;
            NewProjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewProjectButton.Location = new Point(574, 12);
            NewProjectButton.Name = "NewProjectButton";
            NewProjectButton.Size = new Size(145, 38);
            NewProjectButton.TabIndex = 6;
            NewProjectButton.Text = "New Project";
            NewProjectButton.UseVisualStyleBackColor = true;
            NewProjectButton.Click += NewProjectButton_Click;
            // 
            // SwitchEVTSMButton
            // 
            SwitchEVTSMButton.BackColor = Color.FromArgb(26, 26, 26);
            SwitchEVTSMButton.ForeColor = Color.White;
            SwitchEVTSMButton.Name = "SwitchEVTSMButton";
            SwitchEVTSMButton.Size = new Size(222, 24);
            SwitchEVTSMButton.Text = "Switch Engine Version";
            SwitchEVTSMButton.Click += SwitchEVTSMButton_Click;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(882, 661);
            Controls.Add(NewProjectButton);
            Controls.Add(ProjectsListView);
            Controls.Add(AddProjectButton);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Projects";
            Text = "Engine";
            ProjectsMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddProjectButton;
        private ListView ProjectsListView;
        private ImageList imageList1;
        private Button NewProjectButton;
        private ContextMenuStrip ProjectsMenuStrip;
        private ToolStripMenuItem OpenTSMButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem BuildTSMButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem DeleteTSMButton;
        private ToolStripMenuItem SwitchEVTSMButton;
    }
}