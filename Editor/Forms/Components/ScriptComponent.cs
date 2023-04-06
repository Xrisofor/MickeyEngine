using Engine.Classes.Components;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Editor.Forms.Components
{
    public partial class ScriptComponent : Form
    {
        #pragma warning disable
        public Engine.Classes.Components.ScriptComponent scriptComponent;
        #pragma warning restore

        public ScriptComponent()
        {
            InitializeComponent();
        }

        private void ScriptComponent_Shown(object sender, EventArgs e)
        {
            FileTextBox.Text = scriptComponent.File;
            ScriptTextBox.Text = File.ReadAllText(scriptComponent.File);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditScript editScript = new EditScript();
            editScript.Show();
            editScript.UpdateForm(scriptComponent.File);
        }

        private void ScriptTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
