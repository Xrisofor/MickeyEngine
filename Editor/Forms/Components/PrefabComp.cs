﻿using Editor.App;
using Engine;
using Engine.Classes.Components;

namespace Editor.Forms.Components
{
    public partial class PrefabComp : Form
    {
        public Engine.Classes.Components.PrefabComp prefabComp;

        public PrefabComp()
        {
            InitializeComponent();
        }

        private void PrefabComp_Shown(object sender, EventArgs e)
        {
            FileTextBox.Text = prefabComp.PrefabFile;
            NameTextBox.Text = prefabComp.PrefabC.Name;
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                prefabComp.PrefabFile = openFileDialog1.FileName;
                FileTextBox.Text = prefabComp.PrefabFile;
                prefabComp.PrefabC = Map.LoadPrefab(openFileDialog1.FileName, prefabComp.PrefabC.Name);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            prefabComp.PrefabC.Name = NameTextBox.Text;
        }
    }
}
