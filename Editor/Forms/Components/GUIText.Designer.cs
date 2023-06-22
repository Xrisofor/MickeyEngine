namespace Editor.Components
{
    partial class GUIText
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
            NameTextBox = new TextBox();
            CharacterSizeBox = new NumericUpDown();
            pictureBox1 = new PictureBox();
            SelectFileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CharacterSizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(12, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(271, 27);
            NameTextBox.TabIndex = 26;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CharacterSizeBox
            // 
            CharacterSizeBox.BackColor = Color.FromArgb(33, 37, 41);
            CharacterSizeBox.BorderStyle = BorderStyle.FixedSingle;
            CharacterSizeBox.ForeColor = Color.White;
            CharacterSizeBox.Location = new Point(12, 80);
            CharacterSizeBox.Name = "CharacterSizeBox";
            CharacterSizeBox.Size = new Size(271, 27);
            CharacterSizeBox.TabIndex = 28;
            CharacterSizeBox.TextAlign = HorizontalAlignment.Center;
            CharacterSizeBox.ValueChanged += CharacterSizeBox_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.font;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // SelectFileButton
            // 
            SelectFileButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectFileButton.FlatStyle = FlatStyle.Flat;
            SelectFileButton.Location = new Point(46, 45);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(237, 29);
            SelectFileButton.TabIndex = 31;
            SelectFileButton.Text = "Select";
            SelectFileButton.UseVisualStyleBackColor = false;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // GUIText
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(SelectFileButton);
            Controls.Add(pictureBox1);
            Controls.Add(CharacterSizeBox);
            Controls.Add(NameTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GUIText";
            Text = "GUIText";
            Shown += GUIText_Shown;
            ((System.ComponentModel.ISupportInitialize)CharacterSizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox NameTextBox;
        private NumericUpDown CharacterSizeBox;
        private PictureBox pictureBox1;
        private Button SelectFileButton;
    }
}