using Launcher.Forms;

namespace Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void EngineButton_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Engine objForm = new Engine();
            objForm.TopLevel = false;
            panel2.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}