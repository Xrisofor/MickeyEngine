using System;
using System.Collections.Generic;
namespace Launcher.Forms
{
    public partial class AddEngine : Form
    {
        public string Version { get; private set; } = "0.1.0";
        public string Folder { get; private set; }

        public bool InstallEditor = true, InstallWindowPlatform = true, InstallLinuxPlatform;

        public AddEngine()
        {
            InitializeComponent();
            FolderTextBox.Text = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)}\Mickey Engine\";
            Folder = FolderTextBox.Text;
            VersionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            VersionComboBox.Items.Clear();
            foreach (Versions version in Program.Versions)
            {
                if (VersionComboBox.FindString(version.Number) == -1)
                    VersionComboBox.Items.Add(version.Number);
                Version = version.Number; VersionComboBox.SelectedItem = version.Number;
            }
        }

        private void EngineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EngineCheckBox.Checked = true;
        }

        private void ChouseFolderButton_Click(object sender, EventArgs e)
        {
            if (ChouseFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = ChouseFolderBrowser.SelectedPath;
                Folder = FolderTextBox.Text;
            }
        }

        #region Install | Region
        private void EditorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InstallEditor = EditorCheckBox.Checked;
        }

        private void LinuxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InstallLinuxPlatform = LinuxCheckBox.Checked;
            if (LinuxCheckBox.Checked) WindowsCheckBox.Checked = false;
            else WindowsCheckBox.Checked = true;
        }

        private void WindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InstallWindowPlatform = WindowsCheckBox.Checked;
            if (WindowsCheckBox.Checked) LinuxCheckBox.Checked = false;
            else LinuxCheckBox.Checked = true;
        }
        #endregion

        private void VersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Version = VersionComboBox.Text;
        }
    }
}