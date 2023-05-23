using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Forms
{
    public partial class AddEngine : Form
    {
        public AddEngine()
        {
            InitializeComponent();
            FolderTextBox.Text = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)}\Mickey Engine\";
        }

        private void EngineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EngineCheckBox.Checked = true;
        }

        private void LinuxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LinuxCheckBox.Checked = false;
        }

        private void ChouseFolderButton_Click(object sender, EventArgs e)
        {
            if (ChouseFolderBrowser.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
