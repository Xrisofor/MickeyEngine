using Editor.App.Forms;
using Editor.App;
using Engine.Classes.Components;

namespace Editor.Components
{
    public partial class GUIText : Form
    {
        public Engine.Classes.Components.GUIText guiText;

        public GUIText()
        {
            InitializeComponent();
        }

        private void GUIText_Shown(object sender, EventArgs e)
        {
            NameTextBox.Text = guiText.Text.DisplayedString;
            CharacterSizeBox.Value = guiText.Text.CharacterSize;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            guiText.Text.DisplayedString = NameTextBox.Text;
        }

        private void CharacterSizeBox_ValueChanged(object sender, EventArgs e)
        {
            guiText.Text.CharacterSize = (uint)CharacterSizeBox.Value;
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (Program.MainForm.ManagerListBox.SelectedItem != null)
            {
                SpriteManager fontManager = new SpriteManager(ManagerType.Font);
                if (fontManager.ShowDialog() == DialogResult.OK)
                {
                    guiText.Text = new SFML.Graphics.Text(NameTextBox.Text, new SFML.Graphics.Font(MainForm.Fonts[fontManager.SelectedIndex].Path), (uint)CharacterSizeBox.Value);
                    guiText.FontName = Path.GetFileName(MainForm.Fonts[fontManager.SelectedIndex].Path);
                    MainForm.GameObjects[Program.MainForm.ManagerListBox.SelectedIndex].Components[0] = guiText;
                }
            }
        }
    }
}
