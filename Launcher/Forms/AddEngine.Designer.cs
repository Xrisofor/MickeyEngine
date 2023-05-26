namespace Launcher.Forms
{
    partial class AddEngine
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
            EngineCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            WindowsCheckBox = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            EditorCheckBox = new CheckBox();
            LinuxCheckBox = new CheckBox();
            panel1 = new Panel();
            ChouseFolderButton = new Button();
            CanButton = new Button();
            FolderTextBox = new TextBox();
            label7 = new Label();
            VersionComboBox = new ComboBox();
            label6 = new Label();
            InstallButton = new Button();
            ChouseFolderBrowser = new FolderBrowserDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EngineCheckBox
            // 
            EngineCheckBox.AutoSize = true;
            EngineCheckBox.Checked = true;
            EngineCheckBox.CheckState = CheckState.Checked;
            EngineCheckBox.Location = new Point(17, 88);
            EngineCheckBox.Name = "EngineCheckBox";
            EngineCheckBox.Size = new Size(76, 24);
            EngineCheckBox.TabIndex = 0;
            EngineCheckBox.Text = "Engine";
            EngineCheckBox.UseVisualStyleBackColor = true;
            EngineCheckBox.CheckedChanged += EngineCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 1;
            label1.Text = "Install Mickey Engine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Select program";
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
            // WindowsCheckBox
            // 
            WindowsCheckBox.AutoSize = true;
            WindowsCheckBox.Checked = true;
            WindowsCheckBox.CheckState = CheckState.Checked;
            WindowsCheckBox.Location = new Point(17, 191);
            WindowsCheckBox.Name = "WindowsCheckBox";
            WindowsCheckBox.Size = new Size(208, 24);
            WindowsCheckBox.TabIndex = 6;
            WindowsCheckBox.Text = "Windows (target platform)";
            WindowsCheckBox.UseVisualStyleBackColor = true;
            WindowsCheckBox.CheckedChanged += WindowsCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 5;
            label4.Text = "Select pacages";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(31, 31, 31);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(31, 31, 31);
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(776, 2);
            label5.TabIndex = 7;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditorCheckBox
            // 
            EditorCheckBox.AutoSize = true;
            EditorCheckBox.Checked = true;
            EditorCheckBox.CheckState = CheckState.Checked;
            EditorCheckBox.Location = new Point(17, 117);
            EditorCheckBox.Name = "EditorCheckBox";
            EditorCheckBox.Size = new Size(71, 24);
            EditorCheckBox.TabIndex = 8;
            EditorCheckBox.Text = "Editor";
            EditorCheckBox.UseVisualStyleBackColor = true;
            EditorCheckBox.CheckedChanged += EditorCheckBox_CheckedChanged;
            // 
            // LinuxCheckBox
            // 
            LinuxCheckBox.AutoSize = true;
            LinuxCheckBox.Location = new Point(17, 221);
            LinuxCheckBox.Name = "LinuxCheckBox";
            LinuxCheckBox.Size = new Size(181, 24);
            LinuxCheckBox.TabIndex = 9;
            LinuxCheckBox.Text = "Linux (target platform)";
            LinuxCheckBox.UseVisualStyleBackColor = true;
            LinuxCheckBox.CheckedChanged += LinuxCheckBox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
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
            VersionComboBox.Location = new Point(84, 11);
            VersionComboBox.Name = "VersionComboBox";
            VersionComboBox.Size = new Size(594, 28);
            VersionComboBox.TabIndex = 12;
            VersionComboBox.Text = "0.1.0";
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
            InstallButton.Text = "Install";
            InstallButton.UseVisualStyleBackColor = true;
            // 
            // ChouseFolderBrowser
            // 
            ChouseFolderBrowser.RootFolder = Environment.SpecialFolder.ProgramFilesX86;
            // 
            // AddEngine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(LinuxCheckBox);
            Controls.Add(EditorCheckBox);
            Controls.Add(label5);
            Controls.Add(WindowsCheckBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EngineCheckBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEngine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Install Mickey Engine";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox EngineCheckBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox WindowsCheckBox;
        private Label label4;
        private Label label5;
        private CheckBox EditorCheckBox;
        private CheckBox LinuxCheckBox;
        private Panel panel1;
        private Button InstallButton;
        private Label label6;
        private ComboBox VersionComboBox;
        private Label label7;
        private TextBox FolderTextBox;
        private Button CanButton;
        private Button ChouseFolderButton;
        private FolderBrowserDialog ChouseFolderBrowser;
    }
}