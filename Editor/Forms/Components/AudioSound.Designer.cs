namespace Editor.Components
{
    partial class AudioSound
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
            FileTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SelectFileButton = new Button();
            comboBox1 = new ComboBox();
            StopButton = new Button();
            PlayButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LoopCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FileTextBox
            // 
            FileTextBox.BackColor = Color.FromArgb(33, 37, 41);
            FileTextBox.BorderStyle = BorderStyle.FixedSingle;
            FileTextBox.Enabled = false;
            FileTextBox.ForeColor = Color.White;
            FileTextBox.Location = new Point(45, 9);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.ReadOnly = true;
            FileTextBox.Size = new Size(238, 27);
            FileTextBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Audio | *.wav; *.ogg";
            // 
            // SelectFileButton
            // 
            SelectFileButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectFileButton.FlatStyle = FlatStyle.Flat;
            SelectFileButton.Location = new Point(12, 76);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(271, 29);
            SelectFileButton.TabIndex = 17;
            SelectFileButton.Text = "Select";
            SelectFileButton.UseVisualStyleBackColor = false;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 37, 41);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sound", "Music" });
            comboBox1.Location = new Point(12, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 28);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "Sound";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.FromArgb(33, 37, 41);
            StopButton.Enabled = false;
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.Location = new Point(12, 323);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(271, 29);
            StopButton.TabIndex = 20;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.FromArgb(33, 37, 41);
            PlayButton.Enabled = false;
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.Location = new Point(12, 288);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(271, 29);
            PlayButton.TabIndex = 21;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 263);
            label2.Name = "label2";
            label2.Size = new Size(271, 22);
            label2.TabIndex = 22;
            label2.Text = "Controller";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.file;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // LoopCheckBox
            // 
            LoopCheckBox.AutoSize = true;
            LoopCheckBox.Location = new Point(12, 111);
            LoopCheckBox.Name = "LoopCheckBox";
            LoopCheckBox.Size = new Size(65, 24);
            LoopCheckBox.TabIndex = 24;
            LoopCheckBox.Text = "Loop";
            LoopCheckBox.UseVisualStyleBackColor = true;
            LoopCheckBox.CheckedChanged += LoopCheckBox_CheckedChanged;
            // 
            // AudioSound
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(LoopCheckBox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(PlayButton);
            Controls.Add(StopButton);
            Controls.Add(comboBox1);
            Controls.Add(SelectFileButton);
            Controls.Add(FileTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AudioSound";
            Text = "AudioSound";
            Shown += AudioSound_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox FileTextBox;
        private OpenFileDialog openFileDialog1;
        private Button SelectFileButton;
        private ComboBox comboBox1;
        private Button StopButton;
        private Button PlayButton;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox LoopCheckBox;
    }
}