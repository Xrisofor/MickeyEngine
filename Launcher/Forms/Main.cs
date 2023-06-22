using Launcher.Forms;
using System.Reflection;

namespace Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (AssemblyVersion != Program.ServerLauncherVersion)
            {
                NewVersionLabel.Visible = true; UpdateLNButton.Visible = true;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }

        private void EngineButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Forms.Engine objForm = new Forms.Engine();
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

        private void UpdateLNButton_Click(object sender, EventArgs e)
        {

        }
    }
}