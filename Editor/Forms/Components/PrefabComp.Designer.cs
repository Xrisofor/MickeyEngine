namespace Editor.Components
{
    partial class PrefabComp
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
            pictureBox1 = new PictureBox();
            SelectFileButton = new Button();
            FileTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            NameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.file;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // SelectFileButton
            // 
            SelectFileButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectFileButton.FlatStyle = FlatStyle.Flat;
            SelectFileButton.Location = new Point(12, 78);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(271, 29);
            SelectFileButton.TabIndex = 25;
            SelectFileButton.Text = "Select";
            SelectFileButton.UseVisualStyleBackColor = false;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // FileTextBox
            // 
            FileTextBox.BackColor = Color.FromArgb(33, 37, 41);
            FileTextBox.BorderStyle = BorderStyle.FixedSingle;
            FileTextBox.Enabled = false;
            FileTextBox.ForeColor = Color.White;
            FileTextBox.Location = new Point(45, 45);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.ReadOnly = true;
            FileTextBox.Size = new Size(238, 27);
            FileTextBox.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Mickey Map; Mickey Prefab|*.mickeymap; *.mickeyprefab";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(12, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(271, 27);
            NameTextBox.TabIndex = 27;
            NameTextBox.Text = "None";
            NameTextBox.TextAlign = HorizontalAlignment.Center;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // PrefabComp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(NameTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(SelectFileButton);
            Controls.Add(FileTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrefabComp";
            Text = "PrefabComp";
            Shown += PrefabComp_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button SelectFileButton;
        public TextBox FileTextBox;
        private OpenFileDialog openFileDialog1;
        public TextBox NameTextBox;
    }
}