namespace Editor
{
    partial class Inspector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspector));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PosXTextBox = new System.Windows.Forms.TextBox();
            this.PosYTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleYTextBox = new System.Windows.Forms.TextBox();
            this.ScaleXTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextureTextBox = new System.Windows.Forms.TextBox();
            this.SelectTextureButton = new System.Windows.Forms.Button();
            this.ComponentNameLabel = new System.Windows.Forms.Label();
            this.VisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ObjectPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RotationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComponentPanel = new System.Windows.Forms.Panel();
            this.ComponentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ComponentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(45, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PosXTextBox
            // 
            this.PosXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PosXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosXTextBox.Enabled = false;
            this.PosXTextBox.ForeColor = System.Drawing.Color.White;
            this.PosXTextBox.Location = new System.Drawing.Point(11, 67);
            this.PosXTextBox.Name = "PosXTextBox";
            this.PosXTextBox.Size = new System.Drawing.Size(124, 27);
            this.PosXTextBox.TabIndex = 4;
            this.PosXTextBox.Text = "0";
            this.PosXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PosXTextBox.TextChanged += new System.EventHandler(this.PosXTextBox_TextChanged);
            this.PosXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PosXTextBox_KeyPress);
            // 
            // PosYTextBox
            // 
            this.PosYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PosYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosYTextBox.Enabled = false;
            this.PosYTextBox.ForeColor = System.Drawing.Color.White;
            this.PosYTextBox.Location = new System.Drawing.Point(144, 67);
            this.PosYTextBox.Name = "PosYTextBox";
            this.PosYTextBox.Size = new System.Drawing.Size(124, 27);
            this.PosYTextBox.TabIndex = 6;
            this.PosYTextBox.Text = "0";
            this.PosYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PosYTextBox.TextChanged += new System.EventHandler(this.PosYTextBox_TextChanged);
            this.PosYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PosYTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(11, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Scale";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScaleYTextBox
            // 
            this.ScaleYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScaleYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScaleYTextBox.Enabled = false;
            this.ScaleYTextBox.ForeColor = System.Drawing.Color.White;
            this.ScaleYTextBox.Location = new System.Drawing.Point(144, 177);
            this.ScaleYTextBox.Name = "ScaleYTextBox";
            this.ScaleYTextBox.Size = new System.Drawing.Size(121, 27);
            this.ScaleYTextBox.TabIndex = 11;
            this.ScaleYTextBox.Text = "0";
            this.ScaleYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaleYTextBox.TextChanged += new System.EventHandler(this.ScaleYTextBox_TextChanged);
            this.ScaleYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScaleYTextBox_KeyPress);
            // 
            // ScaleXTextBox
            // 
            this.ScaleXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScaleXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScaleXTextBox.Enabled = false;
            this.ScaleXTextBox.ForeColor = System.Drawing.Color.White;
            this.ScaleXTextBox.Location = new System.Drawing.Point(12, 177);
            this.ScaleXTextBox.Name = "ScaleXTextBox";
            this.ScaleXTextBox.Size = new System.Drawing.Size(123, 27);
            this.ScaleXTextBox.TabIndex = 9;
            this.ScaleXTextBox.Text = "0";
            this.ScaleXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaleXTextBox.TextChanged += new System.EventHandler(this.ScaleXTextBox_TextChanged);
            this.ScaleXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScaleXTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(11, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Texture";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextureTextBox
            // 
            this.TextureTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TextureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextureTextBox.ForeColor = System.Drawing.Color.White;
            this.TextureTextBox.Location = new System.Drawing.Point(45, 232);
            this.TextureTextBox.Name = "TextureTextBox";
            this.TextureTextBox.ReadOnly = true;
            this.TextureTextBox.Size = new System.Drawing.Size(220, 27);
            this.TextureTextBox.TabIndex = 13;
            // 
            // SelectTextureButton
            // 
            this.SelectTextureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SelectTextureButton.Enabled = false;
            this.SelectTextureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTextureButton.Location = new System.Drawing.Point(12, 265);
            this.SelectTextureButton.Name = "SelectTextureButton";
            this.SelectTextureButton.Size = new System.Drawing.Size(253, 29);
            this.SelectTextureButton.TabIndex = 14;
            this.SelectTextureButton.Text = "Select";
            this.SelectTextureButton.UseVisualStyleBackColor = false;
            this.SelectTextureButton.Click += new System.EventHandler(this.SelectTextureButton_Click);
            // 
            // ComponentNameLabel
            // 
            this.ComponentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentNameLabel.Location = new System.Drawing.Point(11, 309);
            this.ComponentNameLabel.Name = "ComponentNameLabel";
            this.ComponentNameLabel.Size = new System.Drawing.Size(254, 22);
            this.ComponentNameLabel.TabIndex = 15;
            this.ComponentNameLabel.Text = "Component";
            this.ComponentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisibleCheckBox
            // 
            this.VisibleCheckBox.AutoSize = true;
            this.VisibleCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.VisibleCheckBox.Enabled = false;
            this.VisibleCheckBox.Location = new System.Drawing.Point(250, 17);
            this.VisibleCheckBox.Name = "VisibleCheckBox";
            this.VisibleCheckBox.Size = new System.Drawing.Size(18, 17);
            this.VisibleCheckBox.TabIndex = 16;
            this.VisibleCheckBox.UseVisualStyleBackColor = false;
            this.VisibleCheckBox.CheckedChanged += new System.EventHandler(this.VisibleCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images | *.png; *.jpg; *.gif";
            // 
            // ObjectPictureBox
            // 
            this.ObjectPictureBox.BackgroundImage = global::Editor.ImageList._object;
            this.ObjectPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ObjectPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ObjectPictureBox.Name = "ObjectPictureBox";
            this.ObjectPictureBox.Size = new System.Drawing.Size(27, 27);
            this.ObjectPictureBox.TabIndex = 18;
            this.ObjectPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rotation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotationTextBox
            // 
            this.RotationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.RotationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotationTextBox.Enabled = false;
            this.RotationTextBox.ForeColor = System.Drawing.Color.White;
            this.RotationTextBox.Location = new System.Drawing.Point(12, 122);
            this.RotationTextBox.Name = "RotationTextBox";
            this.RotationTextBox.Size = new System.Drawing.Size(256, 27);
            this.RotationTextBox.TabIndex = 20;
            this.RotationTextBox.Text = "0";
            this.RotationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RotationTextBox.TextChanged += new System.EventHandler(this.RotationTextBox_TextChanged);
            this.RotationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RotationTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Editor.ImageList.render_texture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.AutoScroll = true;
            this.ComponentPanel.Controls.Add(this.ComponentLabel);
            this.ComponentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComponentPanel.Location = new System.Drawing.Point(0, 334);
            this.ComponentPanel.Name = "ComponentPanel";
            this.ComponentPanel.Size = new System.Drawing.Size(277, 389);
            this.ComponentPanel.TabIndex = 22;
            // 
            // ComponentLabel
            // 
            this.ComponentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentLabel.Location = new System.Drawing.Point(0, 0);
            this.ComponentLabel.Name = "ComponentLabel";
            this.ComponentLabel.Size = new System.Drawing.Size(277, 389);
            this.ComponentLabel.TabIndex = 0;
            this.ComponentLabel.Text = "This object does not have any components";
            this.ComponentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 723);
            this.Controls.Add(this.ComponentPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RotationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjectPictureBox);
            this.Controls.Add(this.VisibleCheckBox);
            this.Controls.Add(this.ComponentNameLabel);
            this.Controls.Add(this.SelectTextureButton);
            this.Controls.Add(this.TextureTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ScaleYTextBox);
            this.Controls.Add(this.ScaleXTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PosYTextBox);
            this.Controls.Add(this.PosXTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inspector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspector";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ComponentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label5;
        public TextBox NameTextBox;
        public TextBox PosXTextBox;
        public TextBox PosYTextBox;
        public TextBox ScaleYTextBox;
        public TextBox ScaleXTextBox;
        private Label label8;
        public TextBox TextureTextBox;
        private Button SelectTextureButton;
        private Label ComponentNameLabel;
        private CheckBox VisibleCheckBox;
        private OpenFileDialog openFileDialog1;
        private PictureBox ObjectPictureBox;
        private Label label1;
        public TextBox RotationTextBox;
        private PictureBox pictureBox1;
        private Panel ComponentPanel;
        private Label ComponentLabel;
    }
}