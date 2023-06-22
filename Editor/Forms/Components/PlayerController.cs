using Editor.App;

namespace Editor.Components
{
    public partial class PlayerController : Form
    {
        public Engine.Classes.Components.PlayerController playerController;

        public PlayerController()
        {
            InitializeComponent();
        }

        #region KeyPress | Region
        private void IsDigit(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == ',' && text.Length > 0 && !text.Contains(","))
            {
                e.Handled = false;
                return;
            }
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void SpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }
        #endregion

        private void PlayerController_Shown(object sender, EventArgs e)
        {
            SpeedTextBox.Text = playerController.Speed.ToString();
            HorizontalTextBox.Text = playerController.HorizontalController;
            VerticalTextBox.Text = playerController.VerticalController;
        }

        private void SpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            playerController.Speed = Convert.ToSingle(SpeedTextBox.Text);
            MainForm.GameObjects[Program.MainForm.ManagerListBox.SelectedIndex].Components[0] = playerController;
        }

        private void HorizontalTextBox_TextChanged(object sender, EventArgs e)
        {
            playerController.HorizontalController = HorizontalTextBox.Text;
            MainForm.GameObjects[Program.MainForm.ManagerListBox.SelectedIndex].Components[0] = playerController;
        }

        private void VerticalTextBox_TextChanged(object sender, EventArgs e)
        {
            playerController.VerticalController = VerticalTextBox.Text;
            MainForm.GameObjects[Program.MainForm.ManagerListBox.SelectedIndex].Components[0] = playerController;
        }
    }
}
