namespace Editor.Forms.Components
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
            FontComboBox = new ComboBox();
            CharacterSizeBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)CharacterSizeBox).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(12, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(253, 27);
            NameTextBox.TabIndex = 26;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // FontComboBox
            // 
            FontComboBox.BackColor = Color.FromArgb(33, 37, 41);
            FontComboBox.ForeColor = Color.White;
            FontComboBox.FormattingEnabled = true;
            FontComboBox.Items.AddRange(new object[] { "Arial" });
            FontComboBox.Location = new Point(12, 45);
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(253, 28);
            FontComboBox.TabIndex = 27;
            FontComboBox.Text = "Arial";
            // 
            // CharacterSizeBox
            // 
            CharacterSizeBox.BackColor = Color.FromArgb(33, 37, 41);
            CharacterSizeBox.BorderStyle = BorderStyle.FixedSingle;
            CharacterSizeBox.ForeColor = Color.White;
            CharacterSizeBox.Location = new Point(12, 79);
            CharacterSizeBox.Name = "CharacterSizeBox";
            CharacterSizeBox.Size = new Size(253, 27);
            CharacterSizeBox.TabIndex = 28;
            CharacterSizeBox.TextAlign = HorizontalAlignment.Center;
            CharacterSizeBox.ValueChanged += CharacterSizeBox_ValueChanged;
            // 
            // GUIText
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(277, 389);
            Controls.Add(CharacterSizeBox);
            Controls.Add(FontComboBox);
            Controls.Add(NameTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GUIText";
            Text = "GUIText";
            Shown += GUIText_Shown;
            ((System.ComponentModel.ISupportInitialize)CharacterSizeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox NameTextBox;
        private ComboBox FontComboBox;
        private NumericUpDown CharacterSizeBox;
    }
}