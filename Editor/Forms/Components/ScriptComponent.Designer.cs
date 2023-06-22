namespace Editor.Components
{
    partial class ScriptComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptComponent));
            pictureBox1 = new PictureBox();
            FileTextBox = new TextBox();
            ScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScriptTextBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ImageList.file;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // FileTextBox
            // 
            FileTextBox.BackColor = Color.FromArgb(33, 37, 41);
            FileTextBox.BorderStyle = BorderStyle.FixedSingle;
            FileTextBox.Enabled = false;
            FileTextBox.ForeColor = Color.White;
            FileTextBox.Location = new Point(45, 12);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.ReadOnly = true;
            FileTextBox.Size = new Size(238, 27);
            FileTextBox.TabIndex = 24;
            // 
            // ScriptTextBox
            // 
            ScriptTextBox.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            ScriptTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            ScriptTextBox.AutoScrollMinSize = new Size(31, 18);
            ScriptTextBox.BackBrush = null;
            ScriptTextBox.BackColor = Color.FromArgb(33, 37, 41);
            ScriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            ScriptTextBox.CharHeight = 18;
            ScriptTextBox.CharWidth = 10;
            ScriptTextBox.CommentPrefix = "--";
            ScriptTextBox.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            ScriptTextBox.IndentBackColor = Color.FromArgb(33, 37, 41);
            ScriptTextBox.IsReplaceMode = false;
            ScriptTextBox.Language = FastColoredTextBoxNS.Language.Lua;
            ScriptTextBox.LeftBracket = '(';
            ScriptTextBox.LeftBracket2 = '{';
            ScriptTextBox.LineNumberColor = Color.White;
            ScriptTextBox.Location = new Point(12, 45);
            ScriptTextBox.Name = "ScriptTextBox";
            ScriptTextBox.Paddings = new Padding(0);
            ScriptTextBox.ReadOnly = true;
            ScriptTextBox.RightBracket = ')';
            ScriptTextBox.RightBracket2 = '}';
            ScriptTextBox.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            ScriptTextBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("ScriptTextBox.ServiceColors");
            ScriptTextBox.Size = new Size(271, 276);
            ScriptTextBox.TabIndex = 26;
            ScriptTextBox.Zoom = 100;
            ScriptTextBox.Load += ScriptTextBox_Load;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(33, 37, 41);
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(12, 327);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(271, 29);
            EditButton.TabIndex = 27;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ScriptComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(295, 364);
            Controls.Add(EditButton);
            Controls.Add(ScriptTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(FileTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScriptComponent";
            Text = "ScriptComponent";
            Shown += ScriptComponent_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScriptTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public TextBox FileTextBox;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptTextBox;
        private Button EditButton;
    }
}