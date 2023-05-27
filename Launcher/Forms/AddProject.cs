namespace Launcher.Forms
{
    public partial class AddProject : Form
    {
        public string Version { get; private set; } = "0.1.0";
        public string Folder { get; private set; }
        public string ProjName { get; private set; } = "My Project";
        public int SelectedIndex { get; private set; }

        public AddProject()
        {
            InitializeComponent();
            FolderTextBox.Text = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Mickey Engine Projects\";
            Folder = FolderTextBox.Text;
            VersionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            VersionComboBox.Items.Clear();
            foreach (EngineVersions version in Program.EngineVersions)
            {
                VersionComboBox.Items.Add(version.Number);
                Version = version.Number; VersionComboBox.SelectedItem = version.Number;
            }
        }


        private void ChouseFolderButton_Click(object sender, EventArgs e)
        {
            if (ChouseFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = ChouseFolderBrowser.SelectedPath;
                Folder = FolderTextBox.Text;
            }
        }

        private void VersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Version = VersionComboBox.Text;
        }

        private void TemplateListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = TemplateListView.SelectedIndices[0];
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProjName = NameTextBox.Text;
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            if (Program.EngineVersions.Count == 0)
            {
                MessageBox.Show("It is impossible to create a new project without an installed version of the engine!", "Mickey Engine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}