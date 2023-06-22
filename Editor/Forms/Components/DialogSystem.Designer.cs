namespace Editor.Components
{
    partial class DialogSystem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSystem));
            NameSizeTextBox = new TextBox();
            DialogSizeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SelectNameColorButton = new Button();
            label4 = new Label();
            DialogSelectColorButton = new Button();
            colorDialog1 = new ColorDialog();
            EditButton = new Button();
            ScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)ScriptTextBox).BeginInit();
            SuspendLayout();
            // 
            // NameSizeTextBox
            // 
            NameSizeTextBox.BackColor = Color.FromArgb(33, 37, 41);
            NameSizeTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameSizeTextBox.ForeColor = Color.White;
            NameSizeTextBox.Location = new Point(107, 12);
            NameSizeTextBox.Name = "NameSizeTextBox";
            NameSizeTextBox.Size = new Size(176, 27);
            NameSizeTextBox.TabIndex = 27;
            NameSizeTextBox.Text = "28";
            NameSizeTextBox.TextAlign = HorizontalAlignment.Center;
            NameSizeTextBox.TextChanged += NameSizeTextBox_TextChanged;
            NameSizeTextBox.KeyPress += NameSizeTextBox_KeyPress;
            // 
            // DialogSizeTextBox
            // 
            DialogSizeTextBox.BackColor = Color.FromArgb(33, 37, 41);
            DialogSizeTextBox.BorderStyle = BorderStyle.FixedSingle;
            DialogSizeTextBox.ForeColor = Color.White;
            DialogSizeTextBox.Location = new Point(107, 45);
            DialogSizeTextBox.Name = "DialogSizeTextBox";
            DialogSizeTextBox.Size = new Size(176, 27);
            DialogSizeTextBox.TabIndex = 30;
            DialogSizeTextBox.Text = "24";
            DialogSizeTextBox.TextAlign = HorizontalAlignment.Center;
            DialogSizeTextBox.TextChanged += DialogSizeTextBox_TextChanged;
            DialogSizeTextBox.KeyPress += DialogSizeTextBox_KeyPress;
            // 
            // label1
            // 
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 31;
            label1.Text = "Name Size";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 32;
            label2.Text = "Dialog Size";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 33;
            label3.Text = "Name Color";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectNameColorButton
            // 
            SelectNameColorButton.BackColor = Color.FromArgb(33, 37, 41);
            SelectNameColorButton.FlatStyle = FlatStyle.Flat;
            SelectNameColorButton.Location = new Point(115, 81);
            SelectNameColorButton.Name = "SelectNameColorButton";
            SelectNameColorButton.Size = new Size(168, 29);
            SelectNameColorButton.TabIndex = 34;
            SelectNameColorButton.Text = "Select";
            SelectNameColorButton.UseVisualStyleBackColor = false;
            SelectNameColorButton.Click += SelectNameColorButton_Click;
            // 
            // label4
            // 
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 35;
            label4.Text = "Dialog Color";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DialogSelectColorButton
            // 
            DialogSelectColorButton.BackColor = Color.FromArgb(33, 37, 41);
            DialogSelectColorButton.FlatStyle = FlatStyle.Flat;
            DialogSelectColorButton.Location = new Point(115, 118);
            DialogSelectColorButton.Name = "DialogSelectColorButton";
            DialogSelectColorButton.Size = new Size(168, 29);
            DialogSelectColorButton.TabIndex = 36;
            DialogSelectColorButton.Text = "Select";
            DialogSelectColorButton.UseVisualStyleBackColor = false;
            DialogSelectColorButton.Click += DialogSelectColorButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(33, 37, 41);
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(12, 327);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(271, 29);
            EditButton.TabIndex = 39;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ScriptTextBox
            // 
            ScriptTextBox.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            ScriptTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            ScriptTextBox.AutoScrollMinSize = new Size(31, 18);
            ScriptTextBox.BackBrush = null;
            ScriptTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            ScriptTextBox.CharHeight = 18;
            ScriptTextBox.CharWidth = 10;
            ScriptTextBox.CommentPrefix = "--";
            ScriptTextBox.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            ScriptTextBox.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ScriptTextBox.IndentBackColor = Color.FromArgb(33, 37, 41);
            ScriptTextBox.IsReplaceMode = false;
            ScriptTextBox.Language = FastColoredTextBoxNS.Language.JSON;
            ScriptTextBox.LeftBracket = '[';
            ScriptTextBox.LeftBracket2 = '{';
            ScriptTextBox.LineNumberColor = Color.White;
            ScriptTextBox.Location = new Point(12, 153);
            ScriptTextBox.Name = "ScriptTextBox";
            ScriptTextBox.Paddings = new Padding(0);
            ScriptTextBox.ReadOnly = true;
            ScriptTextBox.RightBracket = ']';
            ScriptTextBox.RightBracket2 = '}';
            ScriptTextBox.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            ScriptTextBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("ScriptTextBox.ServiceColors");
            ScriptTextBox.Size = new Size(271, 168);
            ScriptTextBox.TabIndex = 38;
            ScriptTextBox.Zoom = 100;
            // 
            // DialogSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(EditButton);
            Controls.Add(ScriptTextBox);
            Controls.Add(DialogSelectColorButton);
            Controls.Add(label4);
            Controls.Add(SelectNameColorButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DialogSizeTextBox);
            Controls.Add(NameSizeTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DialogSystem";
            Text = "DialogSystem";
            Shown += DialogSystem_Shown;
            ((System.ComponentModel.ISupportInitialize)ScriptTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox NameSizeTextBox;
        public TextBox DialogSizeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SelectNameColorButton;
        private Label label4;
        private Button DialogSelectColorButton;
        private ColorDialog colorDialog1;
        private Button EditButton;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptTextBox;
    }
}