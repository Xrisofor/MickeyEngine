namespace Editor.Components
{
    partial class LogicComponent
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
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            EditButton = new Button();
            NewButton = new Button();
            RemoveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 37, 41);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Trigger" });
            comboBox1.Location = new Point(45, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.trigger;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(33, 37, 41);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 242);
            listBox1.TabIndex = 30;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(33, 37, 41);
            EditButton.Enabled = false;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(12, 330);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(271, 29);
            EditButton.TabIndex = 31;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.FromArgb(33, 37, 41);
            NewButton.Enabled = false;
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Location = new Point(12, 295);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(133, 29);
            NewButton.TabIndex = 32;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(33, 37, 41);
            RemoveButton.Enabled = false;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Location = new Point(151, 295);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(133, 29);
            RemoveButton.TabIndex = 33;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            // 
            // LogicComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(RemoveButton);
            Controls.Add(NewButton);
            Controls.Add(EditButton);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogicComponent";
            Text = "LogicComponent";
            Shown += LogicComponent_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button EditButton;
        private Button NewButton;
        private Button RemoveButton;
    }
}