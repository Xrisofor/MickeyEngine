using Editor.App;

namespace Editor.Forms
{
    public partial class AddLogicItem : Form
    {
        public string ObjectName = "GameObject", ComponentName = "GameObject", Action = "None", ActionValue = "None"; public Engine.Wait Wait = Engine.Wait.None;

        public AddLogicItem()
        {
            InitializeComponent();
        }

        #region RG
        private void AddLogicItem_Load(object sender, EventArgs e)
        {
            foreach (string item in Objects.ComponentList)
            {
                comboBox1.Items.Add(item);
            }

            foreach (string item in ObjectAction.GameObject)
            {
                ActionComboBox.Items.Add(item);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (WaitComboBox.Text)
            {
                case "None":
                    Wait = Engine.Wait.None;
                    break;
                case "KeyPress":
                    Wait = Engine.Wait.KeyPress;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionComboBox.Items.Clear();
            switch (comboBox1.Text)
            {
                case "Audio Source":
                    foreach (string item in ObjectAction.AudioSource)
                    {
                        ActionComboBox.Items.Add(item);
                    }
                    break;
                case "GameObject":
                    foreach (string item in ObjectAction.GameObject)
                    {
                        ActionComboBox.Items.Add(item);
                    }
                    break;
                case "Logic":
                    foreach (string item in ObjectAction.Logic)
                    {
                        ActionComboBox.Items.Add(item);
                    }
                    break;
                case "Player Controller":
                    foreach (string item in ObjectAction.PlayerController)
                    {
                        ActionComboBox.Items.Add(item);
                    }
                    break;
            }
            ActionComboBox.Text = "None";
            ActionValueTextBox.Enabled = false;
            ComponentName = comboBox1.Text;
        }

        private void ObjectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ObjectName = ObjectNameTextBox.Text;
        }

        private void ActionValueTextBox_TextChanged(object sender, EventArgs e)
        {
            ActionValue = ActionValueTextBox.Text;
        }
        #endregion

        private void ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionValueTextBox.Enabled = true;
            Action = ActionComboBox.Text;

            switch (ActionComboBox.Text) {
                case "Play":
                    ActionValueTextBox.Enabled = false;
                    break;
                case "Pause":
                    ActionValueTextBox.Enabled = false;
                    break;
                case "Stop":
                    ActionValueTextBox.Enabled = false;
                    break;
                case "GetStatus":
                    ActionValueTextBox.Enabled = false;
                    break;
                case "Trigger":
                    ActionValueTextBox.Enabled = false;
                    break;
                case "Speed":
                    ActionValueTextBox.Text = "0";
                    break;
            }
        }
    }
}
