namespace Launcher.Forms
{
    partial class AddProject
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
            ListViewItem listViewItem1 = new ListViewItem("Blank", "folder.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            NameTextBox = new TextBox();
            label2 = new Label();
            ChouseFolderButton = new Button();
            CanButton = new Button();
            FolderTextBox = new TextBox();
            label7 = new Label();
            VersionComboBox = new ComboBox();
            label6 = new Label();
            InstallButton = new Button();
            ChouseFolderBrowser = new FolderBrowserDialog();
            TemplateListView = new ListView();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 38);
            label1.TabIndex = 1;
            label1.Text = "Select new project template";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(31, 31, 31);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(31, 31, 31);
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(776, 2);
            label3.TabIndex = 3;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ChouseFolderButton);
            panel1.Controls.Add(CanButton);
            panel1.Controls.Add(FolderTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(VersionComboBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(InstallButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 81);
            panel1.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(31, 31, 31);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(425, 11);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(253, 27);
            NameTextBox.TabIndex = 18;
            NameTextBox.Text = "My Project";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 11);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 17;
            label2.Text = "Name:";
            // 
            // ChouseFolderButton
            // 
            ChouseFolderButton.FlatStyle = FlatStyle.Flat;
            ChouseFolderButton.Location = new Point(643, 48);
            ChouseFolderButton.Name = "ChouseFolderButton";
            ChouseFolderButton.Size = new Size(35, 27);
            ChouseFolderButton.TabIndex = 16;
            ChouseFolderButton.Text = "...";
            ChouseFolderButton.UseVisualStyleBackColor = true;
            ChouseFolderButton.Click += ChouseFolderButton_Click;
            // 
            // CanButton
            // 
            CanButton.DialogResult = DialogResult.Cancel;
            CanButton.FlatStyle = FlatStyle.Flat;
            CanButton.Location = new Point(684, 10);
            CanButton.Name = "CanButton";
            CanButton.Size = new Size(104, 28);
            CanButton.TabIndex = 15;
            CanButton.Text = "Cancel";
            CanButton.UseVisualStyleBackColor = true;
            // 
            // FolderTextBox
            // 
            FolderTextBox.BackColor = Color.FromArgb(31, 31, 31);
            FolderTextBox.BorderStyle = BorderStyle.FixedSingle;
            FolderTextBox.ForeColor = Color.White;
            FolderTextBox.Location = new Point(84, 48);
            FolderTextBox.Name = "FolderTextBox";
            FolderTextBox.ReadOnly = true;
            FolderTextBox.Size = new Size(553, 27);
            FolderTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 47);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 13;
            label7.Text = "Folder:";
            // 
            // VersionComboBox
            // 
            VersionComboBox.BackColor = Color.FromArgb(31, 31, 31);
            VersionComboBox.FlatStyle = FlatStyle.Flat;
            VersionComboBox.ForeColor = Color.White;
            VersionComboBox.FormattingEnabled = true;
            VersionComboBox.Items.AddRange(new object[] { "0.1.0" });
            VersionComboBox.Location = new Point(92, 11);
            VersionComboBox.Name = "VersionComboBox";
            VersionComboBox.Size = new Size(258, 28);
            VersionComboBox.TabIndex = 12;
            VersionComboBox.Text = "0.1.0";
            VersionComboBox.SelectedIndexChanged += VersionComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 11;
            label6.Text = "Version:";
            // 
            // InstallButton
            // 
            InstallButton.DialogResult = DialogResult.Continue;
            InstallButton.FlatStyle = FlatStyle.Flat;
            InstallButton.Location = new Point(684, 47);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(104, 28);
            InstallButton.TabIndex = 0;
            InstallButton.Text = "Create";
            InstallButton.UseVisualStyleBackColor = true;
            // 
            // ChouseFolderBrowser
            // 
            ChouseFolderBrowser.RootFolder = Environment.SpecialFolder.MyDocuments;
            // 
            // TemplateListView
            // 
            TemplateListView.BackColor = Color.FromArgb(31, 31, 31);
            TemplateListView.BorderStyle = BorderStyle.FixedSingle;
            TemplateListView.ForeColor = Color.White;
            TemplateListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            TemplateListView.LargeImageList = imageList1;
            TemplateListView.Location = new Point(12, 60);
            TemplateListView.MultiSelect = false;
            TemplateListView.Name = "TemplateListView";
            TemplateListView.Size = new Size(776, 303);
            TemplateListView.TabIndex = 11;
            TemplateListView.UseCompatibleStateImageBehavior = false;
            TemplateListView.SelectedIndexChanged += TemplateListView_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(TemplateListView);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create new project";
            Load += AddProject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Button InstallButton;
        private Label label6;
        private ComboBox VersionComboBox;
        private Label label7;
        private TextBox FolderTextBox;
        private Button CanButton;
        private Button ChouseFolderButton;
        private FolderBrowserDialog ChouseFolderBrowser;
        private TextBox NameTextBox;
        private Label label2;
        private ImageList imageList1;
        public ListView TemplateListView;
    }
}