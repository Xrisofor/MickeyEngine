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
            NameTextBox = new TextBox();
            label2 = new Label();
            PosXTextBox = new TextBox();
            PosYTextBox = new TextBox();
            label5 = new Label();
            ScaleYTextBox = new TextBox();
            ScaleXTextBox = new TextBox();
            label8 = new Label();
            TextureTextBox = new TextBox();
            SelectTextureButton = new Button();
            ComponentNameLabel = new Label();
            VisibleCheckBox = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            ObjectPictureBox = new PictureBox();
            label1 = new Label();
            RotationTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            ComponentPanel = new Panel();
            ComponentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ComponentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Enabled = false;
            NameTextBox.ForeColor = Color.White;
            NameTextBox.Location = new Point(45, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(199, 27);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(253, 22);
            label2.TabIndex = 2;
            label2.Text = "Position";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PosXTextBox
            // 
            PosXTextBox.BackColor = Color.FromArgb(33, 37, 41);
            PosXTextBox.BorderStyle = BorderStyle.FixedSingle;
            PosXTextBox.Enabled = false;
            PosXTextBox.ForeColor = Color.White;
            PosXTextBox.Location = new Point(11, 67);
            PosXTextBox.Name = "PosXTextBox";
            PosXTextBox.Size = new Size(124, 27);
            PosXTextBox.TabIndex = 4;
            PosXTextBox.Text = "0";
            PosXTextBox.TextAlign = HorizontalAlignment.Center;
            PosXTextBox.TextChanged += PosXTextBox_TextChanged;
            PosXTextBox.KeyPress += PosXTextBox_KeyPress;
            // 
            // PosYTextBox
            // 
            PosYTextBox.BackColor = Color.FromArgb(33, 37, 41);
            PosYTextBox.BorderStyle = BorderStyle.FixedSingle;
            PosYTextBox.Enabled = false;
            PosYTextBox.ForeColor = Color.White;
            PosYTextBox.Location = new Point(144, 67);
            PosYTextBox.Name = "PosYTextBox";
            PosYTextBox.Size = new Size(124, 27);
            PosYTextBox.TabIndex = 6;
            PosYTextBox.Text = "0";
            PosYTextBox.TextAlign = HorizontalAlignment.Center;
            PosYTextBox.TextChanged += PosYTextBox_TextChanged;
            PosYTextBox.KeyPress += PosYTextBox_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Location = new Point(11, 152);
            label5.Name = "label5";
            label5.Size = new Size(257, 22);
            label5.TabIndex = 7;
            label5.Text = "Scale";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScaleYTextBox
            // 
            ScaleYTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScaleYTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScaleYTextBox.Enabled = false;
            ScaleYTextBox.ForeColor = Color.White;
            ScaleYTextBox.Location = new Point(144, 177);
            ScaleYTextBox.Name = "ScaleYTextBox";
            ScaleYTextBox.Size = new Size(121, 27);
            ScaleYTextBox.TabIndex = 11;
            ScaleYTextBox.Text = "0";
            ScaleYTextBox.TextAlign = HorizontalAlignment.Center;
            ScaleYTextBox.TextChanged += ScaleYTextBox_TextChanged;
            ScaleYTextBox.KeyPress += ScaleYTextBox_KeyPress;
            // 
            // ScaleXTextBox
            // 
            ScaleXTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScaleXTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScaleXTextBox.Enabled = false;
            ScaleXTextBox.ForeColor = Color.White;
            ScaleXTextBox.Location = new Point(12, 177);
            ScaleXTextBox.Name = "ScaleXTextBox";
            ScaleXTextBox.Size = new Size(123, 27);
            ScaleXTextBox.TabIndex = 9;
            ScaleXTextBox.Text = "0";
            ScaleXTextBox.TextAlign = HorizontalAlignment.Center;
            ScaleXTextBox.TextChanged += ScaleXTextBox_TextChanged;
            ScaleXTextBox.KeyPress += ScaleXTextBox_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Location = new Point(11, 207);
            label8.Name = "label8";
            label8.Size = new Size(254, 22);
            label8.TabIndex = 12;
            label8.Text = "Texture";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextureTextBox
            // 
            TextureTextBox.BackColor = Color.FromArgb(33, 37, 41);
            TextureTextBox.BorderStyle = BorderStyle.FixedSingle;
            TextureTextBox.ForeColor = Color.White;
            TextureTextBox.Location = new Point(45, 232);
            TextureTextBox.Name = "TextureTextBox";
            TextureTextBox.ReadOnly = true;
            TextureTextBox.Size = new Size(220, 27);
            TextureTextBox.TabIndex = 13;
            // 
            // SelectTextureButton
            // 
            SelectTextureButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectTextureButton.Enabled = false;
            SelectTextureButton.FlatStyle = FlatStyle.Flat;
            SelectTextureButton.Location = new Point(12, 265);
            SelectTextureButton.Name = "SelectTextureButton";
            SelectTextureButton.Size = new Size(253, 29);
            SelectTextureButton.TabIndex = 14;
            SelectTextureButton.Text = "Select";
            SelectTextureButton.UseVisualStyleBackColor = false;
            SelectTextureButton.Click += SelectTextureButton_Click;
            // 
            // ComponentNameLabel
            // 
            ComponentNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComponentNameLabel.Location = new Point(11, 309);
            ComponentNameLabel.Name = "ComponentNameLabel";
            ComponentNameLabel.Size = new Size(254, 22);
            ComponentNameLabel.TabIndex = 15;
            ComponentNameLabel.Text = "Component";
            ComponentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VisibleCheckBox
            // 
            VisibleCheckBox.AutoSize = true;
            VisibleCheckBox.BackColor = Color.FromArgb(52, 58, 64);
            VisibleCheckBox.Enabled = false;
            VisibleCheckBox.Location = new Point(250, 17);
            VisibleCheckBox.Name = "VisibleCheckBox";
            VisibleCheckBox.Size = new Size(18, 17);
            VisibleCheckBox.TabIndex = 16;
            VisibleCheckBox.UseVisualStyleBackColor = false;
            VisibleCheckBox.CheckedChanged += VisibleCheckBox_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Images | *.png; *.jpg; *.gif";
            // 
            // ObjectPictureBox
            // 
            ObjectPictureBox.BackgroundImage = ImageList._object;
            ObjectPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ObjectPictureBox.Location = new Point(12, 12);
            ObjectPictureBox.Name = "ObjectPictureBox";
            ObjectPictureBox.Size = new Size(27, 27);
            ObjectPictureBox.TabIndex = 18;
            ObjectPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(11, 97);
            label1.Name = "label1";
            label1.Size = new Size(257, 22);
            label1.TabIndex = 19;
            label1.Text = "Rotation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RotationTextBox
            // 
            RotationTextBox.BackColor = Color.FromArgb(33, 37, 41);
            RotationTextBox.BorderStyle = BorderStyle.FixedSingle;
            RotationTextBox.Enabled = false;
            RotationTextBox.ForeColor = Color.White;
            RotationTextBox.Location = new Point(12, 122);
            RotationTextBox.Name = "RotationTextBox";
            RotationTextBox.Size = new Size(256, 27);
            RotationTextBox.TabIndex = 20;
            RotationTextBox.Text = "0";
            RotationTextBox.TextAlign = HorizontalAlignment.Center;
            RotationTextBox.TextChanged += RotationTextBox_TextChanged;
            RotationTextBox.KeyPress += RotationTextBox_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.render_texture;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // ComponentPanel
            // 
            ComponentPanel.AutoScroll = true;
            ComponentPanel.Controls.Add(ComponentLabel);
            ComponentPanel.Dock = DockStyle.Bottom;
            ComponentPanel.Location = new Point(0, 334);
            ComponentPanel.Name = "ComponentPanel";
            ComponentPanel.Size = new Size(277, 389);
            ComponentPanel.TabIndex = 22;
            // 
            // ComponentLabel
            // 
            ComponentLabel.Dock = DockStyle.Fill;
            ComponentLabel.Location = new Point(0, 0);
            ComponentLabel.Name = "ComponentLabel";
            ComponentLabel.Size = new Size(277, 389);
            ComponentLabel.TabIndex = 0;
            ComponentLabel.Text = "This object does not have any components";
            ComponentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inspector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(277, 723);
            Controls.Add(ComponentPanel);
            Controls.Add(pictureBox1);
            Controls.Add(RotationTextBox);
            Controls.Add(label1);
            Controls.Add(ObjectPictureBox);
            Controls.Add(VisibleCheckBox);
            Controls.Add(ComponentNameLabel);
            Controls.Add(SelectTextureButton);
            Controls.Add(TextureTextBox);
            Controls.Add(label8);
            Controls.Add(ScaleYTextBox);
            Controls.Add(ScaleXTextBox);
            Controls.Add(label5);
            Controls.Add(PosYTextBox);
            Controls.Add(PosXTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inspector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inspector";
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ComponentPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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