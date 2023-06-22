using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Editor.App.Forms
{
    public partial class PluginsManager : Form
    {
        public static List<PluginMBase> pluginMs = new List<PluginMBase>();

        public PluginsManager()
        {
            InitializeComponent();

            string[] files = Directory.GetFiles($@"{Environment.CurrentDirectory}\plugins\", "*.mplg", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                string allData = File.ReadAllText(files[i]);
                dynamic? jsonData = JsonConvert.DeserializeObject(allData);

#pragma warning disable
                string Name = jsonData.Name;
                PluginMBase pluginM = new PluginMBase(Name, files[i]);
                pluginM.Version = jsonData.Version; pluginM.Developer = jsonData.Developer; pluginM.Icon = jsonData.Icon;
                pluginMs.Add(pluginM);
#pragma warning restore
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                label1.Text = $"Name: {pluginMs[listView1.SelectedIndices[0]].Name}\r\nDeveloper: {pluginMs[listView1.SelectedIndices[0]].Developer}\r\nVersion: {pluginMs[listView1.SelectedIndices[0]].Version}\r\n";
            }
        }

        private void AllPluginsButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (PluginMBase pluginM in pluginMs)
            {
                if (pluginM.Icon != null)
                {
                    imageList1.Images.Add(pluginM.Icon, Image.FromFile($@"{pluginM.Folder}\{pluginM.Icon}"));
                    listView1.Items.Add(pluginM.Name, pluginM.Icon);
                }
                else
                    listView1.Items.Add(pluginM.Name, 0);
            }
        }
    }
}
