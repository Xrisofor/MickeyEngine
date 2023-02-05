namespace Editor.Forms
{
    partial class EditScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScript));
            this.ScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FindButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllButton_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MunimazeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ScriptTextBoxInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.ScriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ScriptTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptTextBox.CharHeight = 18;
            this.ScriptTextBox.CharWidth = 10;
            this.ScriptTextBox.CommentPrefix = "--";
            this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptTextBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ScriptTextBox.IsReplaceMode = false;
            this.ScriptTextBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptTextBox.LeftBracket = '(';
            this.ScriptTextBox.LeftBracket2 = '{';
            this.ScriptTextBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptTextBox.Location = new System.Drawing.Point(0, 28);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptTextBox.RightBracket = ')';
            this.ScriptTextBox.RightBracket2 = '}';
            this.ScriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptTextBox.ServiceColors")));
            this.ScriptTextBox.Size = new System.Drawing.Size(1252, 664);
            this.ScriptTextBox.TabIndex = 0;
            this.ScriptTextBox.Zoom = 100;
            this.ScriptTextBox.TextChanging += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.ScriptTextBox_TextChanging);
            this.ScriptTextBox.Click += new System.EventHandler(this.ScriptTextBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(103, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton_TSM,
            this.toolStripSeparator1,
            this.ExitButton_TSM});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveButton_TSM
            // 
            this.SaveButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SaveButton_TSM.ForeColor = System.Drawing.Color.White;
            this.SaveButton_TSM.Name = "SaveButton_TSM";
            this.SaveButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveButton_TSM.Size = new System.Drawing.Size(173, 26);
            this.SaveButton_TSM.Text = "Save";
            this.SaveButton_TSM.Click += new System.EventHandler(this.SaveButton_TSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            this.toolStripSeparator1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator1_Paint);
            // 
            // ExitButton_TSM
            // 
            this.ExitButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ExitButton_TSM.ForeColor = System.Drawing.Color.White;
            this.ExitButton_TSM.Name = "ExitButton_TSM";
            this.ExitButton_TSM.Size = new System.Drawing.Size(173, 26);
            this.ExitButton_TSM.Text = "Exit";
            this.ExitButton_TSM.Click += new System.EventHandler(this.ExitButton_TSM_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoButton_TSM,
            this.RedoButton_TSM,
            this.toolStripSeparator2,
            this.FindButton_TSM,
            this.ReplaceButton_TSM,
            this.toolStripSeparator3,
            this.CutButton_TSM,
            this.CopyButton_TSM,
            this.PasteButton_TSM,
            this.SelectAllButton_TSM});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // UndoButton_TSM
            // 
            this.UndoButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.UndoButton_TSM.ForeColor = System.Drawing.Color.White;
            this.UndoButton_TSM.Name = "UndoButton_TSM";
            this.UndoButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.UndoButton_TSM.Text = "Undo";
            this.UndoButton_TSM.Click += new System.EventHandler(this.UndoButton_TSM_Click);
            // 
            // RedoButton_TSM
            // 
            this.RedoButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.RedoButton_TSM.ForeColor = System.Drawing.Color.White;
            this.RedoButton_TSM.Name = "RedoButton_TSM";
            this.RedoButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.RedoButton_TSM.Text = "Redo";
            this.RedoButton_TSM.Click += new System.EventHandler(this.RedoButton_TSM_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            this.toolStripSeparator2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // FindButton_TSM
            // 
            this.FindButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.FindButton_TSM.ForeColor = System.Drawing.Color.White;
            this.FindButton_TSM.Name = "FindButton_TSM";
            this.FindButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.FindButton_TSM.Text = "Find";
            this.FindButton_TSM.Click += new System.EventHandler(this.FindButton_TSM_Click);
            // 
            // ReplaceButton_TSM
            // 
            this.ReplaceButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ReplaceButton_TSM.ForeColor = System.Drawing.Color.White;
            this.ReplaceButton_TSM.Name = "ReplaceButton_TSM";
            this.ReplaceButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReplaceButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.ReplaceButton_TSM.Text = "Replace";
            this.ReplaceButton_TSM.Click += new System.EventHandler(this.ReplaceButton_TSM_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            this.toolStripSeparator3.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator3_Paint);
            // 
            // CutButton_TSM
            // 
            this.CutButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CutButton_TSM.ForeColor = System.Drawing.Color.White;
            this.CutButton_TSM.Name = "CutButton_TSM";
            this.CutButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.CutButton_TSM.Text = "Cut";
            this.CutButton_TSM.Click += new System.EventHandler(this.CutButton_TSM_Click);
            // 
            // CopyButton_TSM
            // 
            this.CopyButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CopyButton_TSM.ForeColor = System.Drawing.Color.White;
            this.CopyButton_TSM.Name = "CopyButton_TSM";
            this.CopyButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.CopyButton_TSM.Text = "Copy";
            this.CopyButton_TSM.Click += new System.EventHandler(this.CopyButton_TSM_Click);
            // 
            // PasteButton_TSM
            // 
            this.PasteButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PasteButton_TSM.ForeColor = System.Drawing.Color.White;
            this.PasteButton_TSM.Name = "PasteButton_TSM";
            this.PasteButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.PasteButton_TSM.Text = "Paste";
            this.PasteButton_TSM.Click += new System.EventHandler(this.PasteButton_TSM_Click);
            // 
            // SelectAllButton_TSM
            // 
            this.SelectAllButton_TSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SelectAllButton_TSM.ForeColor = System.Drawing.Color.White;
            this.SelectAllButton_TSM.Name = "SelectAllButton_TSM";
            this.SelectAllButton_TSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllButton_TSM.Size = new System.Drawing.Size(206, 26);
            this.SelectAllButton_TSM.Text = "Select All";
            this.SelectAllButton_TSM.Click += new System.EventHandler(this.SelectAllButton_TSM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.MunimazeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 28);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Script Editor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // MunimazeButton
            // 
            this.MunimazeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MunimazeButton.FlatAppearance.BorderSize = 0;
            this.MunimazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MunimazeButton.Location = new System.Drawing.Point(1224, 0);
            this.MunimazeButton.Name = "MunimazeButton";
            this.MunimazeButton.Size = new System.Drawing.Size(28, 28);
            this.MunimazeButton.TabIndex = 4;
            this.MunimazeButton.Text = "-";
            this.MunimazeButton.UseVisualStyleBackColor = true;
            this.MunimazeButton.Click += new System.EventHandler(this.MunimazeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1252, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.ScriptTextBoxInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 692);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 28);
            this.panel2.TabIndex = 3;
            // 
            // ScriptTextBoxInfo
            // 
            this.ScriptTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScriptTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.ScriptTextBoxInfo.Name = "ScriptTextBoxInfo";
            this.ScriptTextBoxInfo.Size = new System.Drawing.Size(1250, 28);
            this.ScriptTextBoxInfo.TabIndex = 0;
            this.ScriptTextBoxInfo.Text = "Line: 0 | Lines: 0 | Total text: 0 | Language: Lua";
            this.ScriptTextBoxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.ReplaceButton);
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1252, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 664);
            this.panel3.TabIndex = 4;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.BackgroundImage = global::Editor.ImageList.replace;
            this.ReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReplaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReplaceButton.FlatAppearance.BorderSize = 0;
            this.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceButton.Location = new System.Drawing.Point(0, 58);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(28, 29);
            this.ReplaceButton.TabIndex = 1;
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::Editor.ImageList.search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(0, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 29);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::Editor.ImageList.save;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(28, 29);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditScript";
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTextBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox ScriptTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem SaveButton_TSM;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ExitButton_TSM;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem UndoButton_TSM;
        private ToolStripMenuItem RedoButton_TSM;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem FindButton_TSM;
        private ToolStripMenuItem ReplaceButton_TSM;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem CutButton_TSM;
        private ToolStripMenuItem CopyButton_TSM;
        private ToolStripMenuItem PasteButton_TSM;
        private ToolStripMenuItem SelectAllButton_TSM;
        private Panel panel1;
        private Button MunimazeButton;
        private Button CloseButton;
        private Label label1;
        private Panel panel2;
        private Label ScriptTextBoxInfo;
        private Panel panel3;
        private Button SearchButton;
        private Button ReplaceButton;
        private Button SaveButton;
    }
}