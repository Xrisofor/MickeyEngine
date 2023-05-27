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
            panel2.Controls.Clear();
            Engine objForm = new Engine();
            objForm.TopLevel = false;
            panel2.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Projects objForm = new Projects();
            objForm.TopLevel = false;
            panel2.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            News objForm = new News();
            objForm.TopLevel = false;
            panel2.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}