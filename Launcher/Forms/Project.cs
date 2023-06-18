using Newtonsoft.Json;
using Editor.Project;
using System.Diagnostics;

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

        #region Paint | Region
        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            Editor.App.Paint.PaintForm.Separator_Paint(sender, e);
        }

        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            Editor.App.Paint.PaintForm.Separator_Paint(sender, e);
        }
        #endregion

        private void AddProjectButton_Click(object sender, EventArgs e)
        {

        }

        List<string> ProjectFolderDirs = new List<string> {
            "content",
            "content/images",
            "content/audio",
            "content/maps",
            "plugins",
            "config"
        };

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            if (addProject.ShowDialog() == DialogResult.Continue)
            {
                Directory.CreateDirectory($@"{addProject.Folder}\{addProject.ProjName}");

                for (int i = 0; i < ProjectFolderDirs.Count; i++)
                {
                    Directory.CreateDirectory($@"{addProject.Folder}\{addProject.ProjName}\{ProjectFolderDirs[i]}");
                }

                Structur structur = new Structur(addProject.ProjName, $@"{addProject.Folder}\{addProject.ProjName}\content\images\sprites.json");

                using (StreamWriter file = File.CreateText($@"{addProject.Folder}\{addProject.ProjName}\info.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    serializer.Serialize(file, structur);
                }

                Program.Projects.Add(new Project(addProject.ProjName, addProject.Version, $@"{addProject.Folder}\{addProject.ProjName}"));
                ProjectsListView.Items.Add(addProject.ProjName, 0);
                Program.SaveJSON();
            }
        }

        #region TSM Buttons | Region
        private void DeleteTSMButton_Click(object sender, EventArgs e)
        {
            if (ProjectsListView.SelectedItems.Count != 0)
            {
                Directory.Delete(Program.Projects[ProjectsListView.SelectedItems[0].Index].Path, true);
                Program.Projects.RemoveAt(ProjectsListView.SelectedItems[0].Index);
                ProjectsListView.Items.Remove(ProjectsListView.SelectedItems[0]);
                Program.SaveJSON();
            }
        }

        void OpenEditor(string args)
        {
            if (ProjectsListView.SelectedItems.Count != 0)
            {
                string EngineV = Program.Projects[ProjectsListView.SelectedItems[0].Index].EngineV;
                #pragma warning disable
                string EditorP = $@"{Program.EngineVersions.Find(engine => engine.Number == EngineV).Path}\editor\editor.exe";
                #pragma warning restore
                ProcessStartInfo startInfo = new ProcessStartInfo(EditorP, args);
                Process.Start(startInfo);
            }
        }

        private void OpenTSMButton_Click(object sender, EventArgs e)
        {
            if (ProjectsListView.SelectedItems.Count != 0)
                OpenEditor($"-project \"{Program.Projects[ProjectsListView.SelectedItems[0].Index].Path}/info.json\"");
        }

        private void ProjectsListView_ItemActivate(object sender, EventArgs e)
        {
            if (ProjectsListView.SelectedItems.Count != 0)
                OpenEditor($"-project \"{Program.Projects[ProjectsListView.SelectedItems[0].Index].Path}/info.json\"");
        }

        private void BuildTSMButton_Click(object sender, EventArgs e)
        {
            if (ProjectsListView.SelectedItems.Count != 0)
                OpenEditor($"-project \"{Program.Projects[ProjectsListView.SelectedItems[0].Index].Path}/info.json\" -build");
        }

        private void SwitchEVTSMButton_Click(object sender, EventArgs e)
        {
            if(ProjectsListView.SelectedItems.Count != 0)
            {
                SwitchEngineVersion switchEngineVersion = new SwitchEngineVersion();
                if (switchEngineVersion.ShowDialog() == DialogResult.OK)
                {
                    Program.Projects[ProjectsListView.SelectedIndices[0]].EngineV = switchEngineVersion.Version;
                    Program.SaveJSON();
                }
            }
        }
        #endregion
    }
}
