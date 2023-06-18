namespace Launcher.Forms
{
    public partial class SwitchEngineVersion : Form
    {
        public string Version { get; private set; } = "0.1.0";

        public SwitchEngineVersion()
        {
            InitializeComponent();
            VersionComboBox.Items.Clear();
            foreach (EngineVersions version in Program.EngineVersions)
            {
                VersionComboBox.Items.Add(version.Number);
                Version = version.Number; VersionComboBox.SelectedItem = version.Number;
            }
        }

        private void VersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Version = VersionComboBox.Text;
        }
    }
}
