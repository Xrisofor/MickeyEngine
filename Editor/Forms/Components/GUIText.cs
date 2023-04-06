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
using SFML.Graphics;

namespace Editor.Forms.Components
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
            FontComboBox.Text = string.Empty;
            FontComboBox.SelectedText = guiText.Text.Font.GetInfo().Family;
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
    }
}
