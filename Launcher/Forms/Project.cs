using Ionic.Zip;
using Newtonsoft.Json;

namespace Launcher.Forms
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();

            foreach (Project project in Program.Projects)
            {
                ProjectsListView.Items.Add(project.Name, 0);
            }
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {

        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            if (addProject.ShowDialog() == DialogResult.Continue)
            {
                Directory.CreateDirectory($@"{addProject.Folder}\{addProject.ProjName}");

                Program.Projects.Add(new Project(addProject.ProjName, addProject.Version, $@"{addProject.Folder}\{addProject.ProjName}"));
                ProjectsListView.Items.Add(addProject.ProjName, 0);
                Program.SaveJSON();
            }
        }
    }
}
