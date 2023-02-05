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
    public partial class DialogSystem : Form
    {
        public Engine.DialogSystem dialogSystem;

        public DialogSystem()
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

        private void NameSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void DialogSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }
        #endregion

        private void DialogSystem_Shown(object sender, EventArgs e)
        {
            NameSizeTextBox.Text = dialogSystem.NameSize.ToString();
            DialogSizeTextBox.Text = dialogSystem.DialogSize.ToString();
            ScriptTextBox.Text = File.ReadAllText(dialogSystem.DialogFile);
        }

        private void NameSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            dialogSystem.NameSize = Convert.ToUInt32(NameSizeTextBox.Text);
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = dialogSystem;
        }

        private void DialogSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            dialogSystem.DialogSize = Convert.ToUInt32(DialogSizeTextBox.Text);
            Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = dialogSystem;
        }

        private void SelectNameColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.FromName(dialogSystem.NameColor);
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogSystem.NameColor = colorDialog1.Color.Name;
                Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = dialogSystem;
            }
        }

        private void DialogSelectColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.FromName(dialogSystem.DialogColor);
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogSystem.DialogColor = colorDialog1.Color.Name;
                Program.Form2.GameObjects[Program.Form2.ListIndex].Components[0] = dialogSystem;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditScript editScript = new EditScript();
            editScript.Show();
            editScript.UpdateForm(dialogSystem.DialogFile, FastColoredTextBoxNS.Language.JSON);
        }
    }
}
