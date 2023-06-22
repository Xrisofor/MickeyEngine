using Editor.App;
using System.Runtime.InteropServices;

namespace Editor.Forms
{
    public partial class EditScript : Form
    {
        #region DllImportAttribute | Region
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Init | Region
        private string Path;

        public EditScript()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        public void UpdateForm(string Path, FastColoredTextBoxNS.Language Language = FastColoredTextBoxNS.Language.Lua)
        {
            ScriptTextBox.Text = File.ReadAllText(Path);
            this.Text = $"Script Editor - {Path.Replace("/", @"\")}";
            label1.Text = $"Script Editor - {Path.Replace("/", @"\")}";
            this.Path = Path;
            ScriptTextBox.Language = Language;
            EditScriptTextBotInfo();
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Click | Region
        private void ExitButton_TSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UndoButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Undo();
        }

        private void RedoButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Redo();
        }

        private void FindButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.ShowFindDialog();
        }

        private void ReplaceButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.ShowReplaceDialog();
        }

        private void CutButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Cut();
        }

        private void CopyButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Copy();
        }

        private void PasteButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Paste();
        }

        private void SelectAllButton_TSM_Click(object sender, EventArgs e)
        {
            ScriptTextBox.SelectAll();
        }

        private void SaveButton_TSM_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = File.CreateText(Path))
            {
                file.Write(ScriptTextBox.Text);
            }
        }
        #endregion

        #region Paint | Region
        private void Separator_Paint(Object sender, PaintEventArgs e)
        {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(33, 37, 41)), 0, 0, width, height);
            e.Graphics.DrawLine(new Pen(Color.White), 4, height / 2, width - 4, height / 2);
        }
        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }
        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }
        private void toolStripSeparator3_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }
        #endregion

        #region ScriptTextBox and Click | Region
        private void ScriptTextBox_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            EditScriptTextBotInfo();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = File.CreateText(Path))
            {
                file.Write(ScriptTextBox.Text);
            }
        }

        private void ScriptTextBox_Click(object sender, EventArgs e)
        {
            EditScriptTextBotInfo();
        }

        private void EditScriptTextBotInfo()
        {
            ScriptTextBoxInfo.Text = $"Line: {ScriptTextBox.Selection.ToLine} | Lines: {ScriptTextBox.LinesCount} | Total text: {ScriptTextBox.TextLength} | Language: {ScriptTextBox.Language}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MunimazeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ScriptTextBox.ShowFindDialog();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ScriptTextBox.ShowReplaceDialog();
        }
        #endregion
    }
}
