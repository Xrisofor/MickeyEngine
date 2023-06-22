namespace Editor.Components
{
    partial class PlayerController
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
            SpeedTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            HorizontalTextBox = new TextBox();
            VerticalTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // SpeedTextBox
            // 
            SpeedTextBox.BackColor = Color.FromArgb(33, 37, 41);
            SpeedTextBox.BorderStyle = BorderStyle.FixedSingle;
            SpeedTextBox.ForeColor = Color.White;
            SpeedTextBox.Location = new Point(12, 34);
            SpeedTextBox.Name = "SpeedTextBox";
            SpeedTextBox.Size = new Size(271, 27);
            SpeedTextBox.TabIndex = 24;
            SpeedTextBox.Text = "0";
            SpeedTextBox.TextAlign = HorizontalAlignment.Center;
            SpeedTextBox.TextChanged += SpeedTextBox_TextChanged;
            SpeedTextBox.KeyPress += SpeedTextBox_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(271, 22);
            label2.TabIndex = 25;
            label2.Text = "Speed";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(271, 22);
            label1.TabIndex = 26;
            label1.Text = "Controllers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HorizontalTextBox
            // 
            HorizontalTextBox.BackColor = Color.FromArgb(33, 37, 41);
            HorizontalTextBox.BorderStyle = BorderStyle.FixedSingle;
            HorizontalTextBox.ForeColor = Color.White;
            HorizontalTextBox.Location = new Point(129, 96);
            HorizontalTextBox.Name = "HorizontalTextBox";
            HorizontalTextBox.Size = new Size(154, 27);
            HorizontalTextBox.TabIndex = 27;
            HorizontalTextBox.Text = "Horizontal";
            HorizontalTextBox.TextAlign = HorizontalAlignment.Center;
            HorizontalTextBox.TextChanged += HorizontalTextBox_TextChanged;
            // 
            // VerticalTextBox
            // 
            VerticalTextBox.BackColor = Color.FromArgb(33, 37, 41);
            VerticalTextBox.BorderStyle = BorderStyle.FixedSingle;
            VerticalTextBox.ForeColor = Color.White;
            VerticalTextBox.Location = new Point(129, 129);
            VerticalTextBox.Name = "VerticalTextBox";
            VerticalTextBox.Size = new Size(154, 27);
            VerticalTextBox.TabIndex = 28;
            VerticalTextBox.Text = "Vertical";
            VerticalTextBox.TextAlign = HorizontalAlignment.Center;
            VerticalTextBox.TextChanged += VerticalTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 29;
            label3.Text = "Horizontal";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 30;
            label4.Text = "Vertical";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VerticalTextBox);
            Controls.Add(HorizontalTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(SpeedTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayerController";
            Text = "PlayerController";
            Shown += PlayerController_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox SpeedTextBox;
        private Label label2;
        private Label label1;
        public TextBox HorizontalTextBox;
        public TextBox VerticalTextBox;
        private Label label3;
        private Label label4;
    }
}