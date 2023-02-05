namespace Editor.Forms.Components
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
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HorizontalTextBox = new System.Windows.Forms.TextBox();
            this.VerticalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedTextBox.ForeColor = System.Drawing.Color.White;
            this.SpeedTextBox.Location = new System.Drawing.Point(12, 34);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(253, 27);
            this.SpeedTextBox.TabIndex = 24;
            this.SpeedTextBox.Text = "0";
            this.SpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeedTextBox.TextChanged += new System.EventHandler(this.SpeedTextBox_TextChanged);
            this.SpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpeedTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Controllers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HorizontalTextBox
            // 
            this.HorizontalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HorizontalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HorizontalTextBox.ForeColor = System.Drawing.Color.White;
            this.HorizontalTextBox.Location = new System.Drawing.Point(111, 95);
            this.HorizontalTextBox.Name = "HorizontalTextBox";
            this.HorizontalTextBox.Size = new System.Drawing.Size(154, 27);
            this.HorizontalTextBox.TabIndex = 27;
            this.HorizontalTextBox.Text = "Horizontal";
            this.HorizontalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HorizontalTextBox.TextChanged += new System.EventHandler(this.HorizontalTextBox_TextChanged);
            // 
            // VerticalTextBox
            // 
            this.VerticalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.VerticalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerticalTextBox.ForeColor = System.Drawing.Color.White;
            this.VerticalTextBox.Location = new System.Drawing.Point(111, 129);
            this.VerticalTextBox.Name = "VerticalTextBox";
            this.VerticalTextBox.Size = new System.Drawing.Size(154, 27);
            this.VerticalTextBox.TabIndex = 28;
            this.VerticalTextBox.Text = "Vertical";
            this.VerticalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VerticalTextBox.TextChanged += new System.EventHandler(this.VerticalTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Horizontal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Vertical";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VerticalTextBox);
            this.Controls.Add(this.HorizontalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerController";
            this.Text = "PlayerController";
            this.Shown += new System.EventHandler(this.PlayerController_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

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