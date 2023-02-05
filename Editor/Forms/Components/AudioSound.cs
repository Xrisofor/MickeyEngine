using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editor.App;

namespace Editor.Forms.Components
{
    public partial class AudioSound : Form
    {
        public Engine.Classes.Components.AudioSource audioSource;

        public AudioSound()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (audioSource != null) audioSource.Stop(); StopButton.Enabled = false;
                audioSource = new Engine.Classes.Components.AudioSource(comboBox1.Text, openFileDialog1.FileName);
                FileTextBox.Text = openFileDialog1.FileName;
                audioSource.File = openFileDialog1.FileName;
                Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = audioSource;
                PlayButton.Enabled = true;
                audioSource.Type = comboBox1.Text;
                audioSource.File = openFileDialog1.FileName;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = false;
            StopButton.Enabled = true;
            audioSource.Play(LoopCheckBox.Checked);
            LoopCheckBox.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopButton.Enabled = false;
            LoopCheckBox.Enabled = true;
            audioSource.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            audioSource.Stop();
            if (FileTextBox.Text != String.Empty)
                audioSource = new Engine.Classes.Components.AudioSource(comboBox1.Text, FileTextBox.Text);
            audioSource.Type = comboBox1.Text;
            audioSource.File = FileTextBox.Text;
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = audioSource;
            PlayButton.Enabled = true;
            StopButton.Enabled = false;
        }

        private void LoopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            audioSource.Loop = LoopCheckBox.Checked;
        }

        private void AudioSound_Shown(object sender, EventArgs e)
        {
            FileTextBox.Text = audioSource.File;
            comboBox1.Text = audioSource.Type;
            LoopCheckBox.Checked = audioSource.Loop;
            if(FileTextBox.Text != string.Empty)
                PlayButton.Enabled = true;
        }
    }
}
