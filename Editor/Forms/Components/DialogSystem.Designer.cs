namespace Editor.Forms.Components
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSystem));
            this.NameSizeTextBox = new System.Windows.Forms.TextBox();
            this.DialogSizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectNameColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DialogSelectColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.EditButton = new System.Windows.Forms.Button();
            this.ScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameSizeTextBox
            // 
            this.NameSizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.NameSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameSizeTextBox.ForeColor = System.Drawing.Color.White;
            this.NameSizeTextBox.Location = new System.Drawing.Point(107, 12);
            this.NameSizeTextBox.Name = "NameSizeTextBox";
            this.NameSizeTextBox.Size = new System.Drawing.Size(158, 27);
            this.NameSizeTextBox.TabIndex = 27;
            this.NameSizeTextBox.Text = "28";
            this.NameSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameSizeTextBox.TextChanged += new System.EventHandler(this.NameSizeTextBox_TextChanged);
            this.NameSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameSizeTextBox_KeyPress);
            // 
            // DialogSizeTextBox
            // 
            this.DialogSizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.DialogSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DialogSizeTextBox.ForeColor = System.Drawing.Color.White;
            this.DialogSizeTextBox.Location = new System.Drawing.Point(107, 45);
            this.DialogSizeTextBox.Name = "DialogSizeTextBox";
            this.DialogSizeTextBox.Size = new System.Drawing.Size(158, 27);
            this.DialogSizeTextBox.TabIndex = 30;
            this.DialogSizeTextBox.Text = "24";
            this.DialogSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DialogSizeTextBox.TextChanged += new System.EventHandler(this.DialogSizeTextBox_TextChanged);
            this.DialogSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DialogSizeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dialog Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectNameColorButton
            // 
            this.SelectNameColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SelectNameColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectNameColorButton.Location = new System.Drawing.Point(115, 81);
            this.SelectNameColorButton.Name = "SelectNameColorButton";
            this.SelectNameColorButton.Size = new System.Drawing.Size(150, 29);
            this.SelectNameColorButton.TabIndex = 34;
            this.SelectNameColorButton.Text = "Select";
            this.SelectNameColorButton.UseVisualStyleBackColor = false;
            this.SelectNameColorButton.Click += new System.EventHandler(this.SelectNameColorButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Dialog Color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialogSelectColorButton
            // 
            this.DialogSelectColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.DialogSelectColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DialogSelectColorButton.Location = new System.Drawing.Point(115, 118);
            this.DialogSelectColorButton.Name = "DialogSelectColorButton";
            this.DialogSelectColorButton.Size = new System.Drawing.Size(150, 29);
            this.DialogSelectColorButton.TabIndex = 36;
            this.DialogSelectColorButton.Text = "Select";
            this.DialogSelectColorButton.UseVisualStyleBackColor = false;
            this.DialogSelectColorButton.Click += new System.EventHandler(this.DialogSelectColorButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(12, 348);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(253, 29);
            this.EditButton.TabIndex = 39;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.ScriptTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.ScriptTextBox.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.ScriptTextBox.BackBrush = null;
            this.ScriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptTextBox.CharHeight = 18;
            this.ScriptTextBox.CharWidth = 10;
            this.ScriptTextBox.CommentPrefix = "--";
            this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptTextBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScriptTextBox.IsReplaceMode = false;
            this.ScriptTextBox.Language = FastColoredTextBoxNS.Language.JSON;
            this.ScriptTextBox.LeftBracket = '[';
            this.ScriptTextBox.LeftBracket2 = '{';
            this.ScriptTextBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptTextBox.Location = new System.Drawing.Point(12, 153);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptTextBox.ReadOnly = true;
            this.ScriptTextBox.RightBracket = ']';
            this.ScriptTextBox.RightBracket2 = '}';
            this.ScriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptTextBox.ServiceColors")));
            this.ScriptTextBox.Size = new System.Drawing.Size(253, 189);
            this.ScriptTextBox.TabIndex = 38;
            this.ScriptTextBox.Zoom = 100;
            // 
            // DialogSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 389);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.DialogSelectColorButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectNameColorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DialogSizeTextBox);
            this.Controls.Add(this.NameSizeTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogSystem";
            this.Text = "DialogSystem";
            this.Shown += new System.EventHandler(this.DialogSystem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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