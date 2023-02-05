namespace Editor.Forms.Components
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptComponent));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.ScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Editor.ImageList.file;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FileTextBox
            // 
            this.FileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.FileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTextBox.Enabled = false;
            this.FileTextBox.ForeColor = System.Drawing.Color.White;
            this.FileTextBox.Location = new System.Drawing.Point(45, 12);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(220, 27);
            this.FileTextBox.TabIndex = 24;
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptTextBox.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.ScriptTextBox.BackBrush = null;
            this.ScriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptTextBox.CharHeight = 18;
            this.ScriptTextBox.CharWidth = 10;
            this.ScriptTextBox.CommentPrefix = "--";
            this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptTextBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScriptTextBox.IsReplaceMode = false;
            this.ScriptTextBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptTextBox.LeftBracket = '(';
            this.ScriptTextBox.LeftBracket2 = '{';
            this.ScriptTextBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptTextBox.Location = new System.Drawing.Point(12, 45);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptTextBox.ReadOnly = true;
            this.ScriptTextBox.RightBracket = ')';
            this.ScriptTextBox.RightBracket2 = '}';
            this.ScriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptTextBox.ServiceColors")));
            this.ScriptTextBox.Size = new System.Drawing.Size(253, 297);
            this.ScriptTextBox.TabIndex = 26;
            this.ScriptTextBox.Zoom = 100;
            this.ScriptTextBox.Load += new System.EventHandler(this.ScriptTextBox_Load);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(12, 348);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(253, 29);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ScriptComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 389);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FileTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScriptComponent";
            this.Text = "ScriptComponent";
            this.Shown += new System.EventHandler(this.ScriptComponent_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        public TextBox FileTextBox;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptTextBox;
        private Button EditButton;
    }
}