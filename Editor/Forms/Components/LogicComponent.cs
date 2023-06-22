using Engine.Classes.Components;
using Editor.Forms;
using Editor.App;

namespace Editor.Components
{
    public partial class LogicComponent : Form
    {
#pragma warning disable
        public Engine.Classes.Components.LogicComponent logicComponent;
#pragma warning restore

        public LogicComponent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicComponent.Type = comboBox1.SelectedText;
            MainForm.GameObjects[Program.MainForm.ManagerListBox.SelectedIndex].Components[0] = logicComponent;
        }

        private void LogicComponent_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedText = logicComponent.Type;

            foreach (LogicAction logicAction in logicComponent.LogicAction)
            {
                listBox1.Items.Add($"{logicAction.ObjectName} | {logicAction.GameObject.Components[0].ComponentName} | {logicAction.Action}, {logicAction.Value} | {logicAction.Wait}");
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            AddLogicItem addLogicItem = new AddLogicItem();
            if (addLogicItem.ShowDialog() == DialogResult.OK)
            {
#pragma warning disable
                Engine.GameObject gameObject = Editor.App.Program.Form2.GameObjects.Find(item => item.Name == addLogicItem.ObjectName);
                logicComponent.LogicAction.Add(new LogicAction(addLogicItem.ObjectName, gameObject, addLogicItem.Action, addLogicItem.Wait, addLogicItem.ActionValue));
                listBox1.Items.Add($"{gameObject.Name} | {addLogicItem.ComponentName} | {addLogicItem.Action}, {addLogicItem.ActionValue} | {addLogicItem.Wait}");
#pragma warning restore
            }
        }
    }
}
