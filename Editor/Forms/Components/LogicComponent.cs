using Editor.App;
using Engine.Classes.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Forms.Components
{
    public partial class LogicComponent : Form
    {
        public Engine.Classes.Components.LogicComponent logicComponent;

        public LogicComponent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicComponent.Type = comboBox1.SelectedText;
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = logicComponent;
        }

        private void LogicComponent_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedText = logicComponent.Type;
            ScriptTextBox.Text = logicComponent.ScriptName;
            FunctionTextBox.Text = logicComponent.FunctionName;
        }

        private void ScriptTextBox_TextChanged(object sender, EventArgs e)
        {
            logicComponent.ScriptName = ScriptTextBox.Text;
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = logicComponent; 
        }

        private void FunctionTextBox_TextChanged(object sender, EventArgs e)
        {
            logicComponent.FunctionName = FunctionTextBox.Text;
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = logicComponent;
        }
    }
}
