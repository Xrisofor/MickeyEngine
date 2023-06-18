namespace Launcher.Forms
{
    partial class SwitchEngineVersion
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
            VersionComboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // VersionComboBox
            // 
            VersionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VersionComboBox.BackColor = Color.FromArgb(31, 31, 31);
            VersionComboBox.FlatStyle = FlatStyle.Flat;
            VersionComboBox.ForeColor = Color.White;
            VersionComboBox.FormattingEnabled = true;
            VersionComboBox.Items.AddRange(new object[] { "0.1.0" });
            VersionComboBox.Location = new Point(12, 12);
            VersionComboBox.Name = "VersionComboBox";
            VersionComboBox.Size = new Size(369, 28);
            VersionComboBox.TabIndex = 13;
            VersionComboBox.Text = "0.1.0";
            VersionComboBox.SelectedIndexChanged += VersionComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(385, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 29);
            button1.TabIndex = 14;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(309, 47);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.DialogResult = DialogResult.OK;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(184, 47);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 16;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = true;
            // 
            // SwitchEngineVersion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(440, 87);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(VersionComboBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SwitchEngineVersion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Switch Mickey Engine Version";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox VersionComboBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}