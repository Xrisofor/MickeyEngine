namespace Editor.Forms
{
    partial class AddLogicItem
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            ActionComboBox = new ComboBox();
            label1 = new Label();
            ObjectNameTextBox = new TextBox();
            label3 = new Label();
            WaitComboBox = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            ActionValueTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(253, 19);
            label2.TabIndex = 6;
            label2.Text = "Component";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(33, 37, 41);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "GameObject";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ActionComboBox
            // 
            ActionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActionComboBox.BackColor = Color.FromArgb(33, 37, 41);
            ActionComboBox.FlatStyle = FlatStyle.Flat;
            ActionComboBox.ForeColor = Color.White;
            ActionComboBox.FormattingEnabled = true;
            ActionComboBox.Location = new Point(12, 156);
            ActionComboBox.Name = "ActionComboBox";
            ActionComboBox.Size = new Size(253, 28);
            ActionComboBox.TabIndex = 9;
            ActionComboBox.Text = "None";
            ActionComboBox.SelectedIndexChanged += ActionComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(253, 19);
            label1.TabIndex = 8;
            label1.Text = "Action";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ObjectNameTextBox
            // 
            ObjectNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ObjectNameTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ObjectNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ObjectNameTextBox.ForeColor = Color.White;
            ObjectNameTextBox.Location = new Point(12, 93);
            ObjectNameTextBox.Name = "ObjectNameTextBox";
            ObjectNameTextBox.Size = new Size(253, 27);
            ObjectNameTextBox.TabIndex = 11;
            ObjectNameTextBox.Text = "GameObject";
            ObjectNameTextBox.TextAlign = HorizontalAlignment.Center;
            ObjectNameTextBox.TextChanged += ObjectNameTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(253, 19);
            label3.TabIndex = 10;
            label3.Text = "Object Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WaitComboBox
            // 
            WaitComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WaitComboBox.BackColor = Color.FromArgb(33, 37, 41);
            WaitComboBox.FlatStyle = FlatStyle.Flat;
            WaitComboBox.ForeColor = Color.White;
            WaitComboBox.FormattingEnabled = true;
            WaitComboBox.Items.AddRange(new object[] { "None", "KeyPress" });
            WaitComboBox.Location = new Point(12, 251);
            WaitComboBox.Name = "WaitComboBox";
            WaitComboBox.Size = new Size(253, 28);
            WaitComboBox.TabIndex = 13;
            WaitComboBox.Text = "None";
            WaitComboBox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(253, 19);
            label4.TabIndex = 12;
            label4.Text = "Wait";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(143, 285);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 15;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // ActionValueTextBox
            // 
            ActionValueTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActionValueTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ActionValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            ActionValueTextBox.Enabled = false;
            ActionValueTextBox.ForeColor = Color.White;
            ActionValueTextBox.Location = new Point(12, 190);
            ActionValueTextBox.Name = "ActionValueTextBox";
            ActionValueTextBox.Size = new Size(253, 27);
            ActionValueTextBox.TabIndex = 16;
            ActionValueTextBox.TextAlign = HorizontalAlignment.Center;
            ActionValueTextBox.TextChanged += ActionValueTextBox_TextChanged;
            // 
            // AddLogicItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(277, 330);
            Controls.Add(ActionValueTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(WaitComboBox);
            Controls.Add(label4);
            Controls.Add(ObjectNameTextBox);
            Controls.Add(label3);
            Controls.Add(ActionComboBox);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddLogicItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creating a new item";
            Load += AddLogicItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private ComboBox ActionComboBox;
        private Label label1;
        private TextBox ObjectNameTextBox;
        private Label label3;
        private ComboBox WaitComboBox;
        private Label label4;
        private Button button2;
        private Button button1;
        private TextBox ActionValueTextBox;
    }
}