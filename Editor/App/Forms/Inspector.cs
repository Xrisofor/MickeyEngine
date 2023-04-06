using Editor.App;
using Newtonsoft.Json;
using SFML.Graphics;
using SFML.System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Editor
{
    public partial class Inspector : Form
    {
        public Inspector()
        {
            InitializeComponent();
        }

        public void UpdateForm(string Name, Vector2f Position, float Rotation, Vector2f Scale, bool Visible, Engine.Component[] Components)
        {
            ObjectPictureBox.BackgroundImage = ImageList._object;

            NameTextBox.Enabled = true;
            PosXTextBox.Enabled = true;
            PosYTextBox.Enabled = true;
            ScaleXTextBox.Enabled = true;
            ScaleYTextBox.Enabled = true;
            VisibleCheckBox.Enabled = true;
            SelectTextureButton.Enabled = true;
            RotationTextBox.Enabled = true;

            for (int index = 0; index < ComponentPanel.Controls.Count; index++)
            {
                if (ComponentPanel.Controls[index].Name != "ComponentLabel")
                    ComponentPanel.Controls.RemoveAt(index);
            }
            ComponentNameLabel.Text = "Component";
            ComponentLabel.Visible = true;

            NameTextBox.Text = Name;
            PosXTextBox.Text = Position.X.ToString();
            PosYTextBox.Text = Position.Y.ToString();
            ScaleXTextBox.Text = Scale.X.ToString();
            ScaleYTextBox.Text = Scale.Y.ToString();
            VisibleCheckBox.Checked = Visible;
            RotationTextBox.Text = Rotation.ToString();
            TextureTextBox.Text = Program.Form2.GameObjects[Program.Form2.ListIndex].TexturePath;

            #pragma warning disable
            for (int i = 0; i < Components.Length; i++)
            {
                switch (Components[i])
                {
                    case Engine.Classes.Components.AudioSource:
                        ComponentLabel.Visible = false;
                        Forms.Components.AudioSound AudioSoundForm = new Forms.Components.AudioSound();
                        AudioSoundForm.TopLevel = false;
                        AudioSoundForm.AutoScroll = true;
                        AudioSoundForm.audioSource = (Engine.Classes.Components.AudioSource)Components[i];
                        ComponentPanel.Controls.Add(AudioSoundForm);
                        AudioSoundForm.Dock = DockStyle.Fill;
                        AudioSoundForm.Show();
                        ComponentNameLabel.Text = "Audio Source";
                        ObjectPictureBox.BackgroundImage = ImageList.audio;
                        DisabledAll(1);
                        break;
                    case Engine.Classes.Components.GUIText:
                        ComponentLabel.Visible = false;
                        Forms.Components.GUIText GUITextForm = new Forms.Components.GUIText();
                        GUITextForm.TopLevel = false;
                        GUITextForm.AutoScroll = true;
                        GUITextForm.guiText = (Engine.Classes.Components.GUIText)Components[i];
                        ComponentPanel.Controls.Add(GUITextForm);
                        GUITextForm.Dock = DockStyle.Fill;
                        GUITextForm.Show();
                        ComponentNameLabel.Text = "Text";
                        ObjectPictureBox.BackgroundImage = ImageList.text;
                        DisabledAll(2);
                        break;
                    case Engine.Classes.Components.PrefabComp:
                        ComponentLabel.Visible = false;
                        Forms.Components.PrefabComp PrefabCompForm = new Forms.Components.PrefabComp();
                        PrefabCompForm.TopLevel = false;
                        PrefabCompForm.AutoScroll = true;
                        PrefabCompForm.prefabComp = (Engine.Classes.Components.PrefabComp)Components[i];
                        ComponentPanel.Controls.Add(PrefabCompForm);
                        PrefabCompForm.Dock = DockStyle.Fill;
                        PrefabCompForm.Show();
                        ComponentNameLabel.Text = "Prefab";
                        ObjectPictureBox.BackgroundImage = ImageList.prefabhouse;
                        DisabledAll(2);
                        break;
                    case Engine.Classes.Components.PlayerController:
                        ComponentLabel.Visible = false;
                        Forms.Components.PlayerController PlayerControllerForm = new Forms.Components.PlayerController();
                        PlayerControllerForm.TopLevel = false;
                        PlayerControllerForm.AutoScroll = true;
                        PlayerControllerForm.playerController = (Engine.Classes.Components.PlayerController)Components[i];
                        ComponentPanel.Controls.Add(PlayerControllerForm);
                        PlayerControllerForm.Dock = DockStyle.Fill;
                        PlayerControllerForm.Show();
                        ComponentNameLabel.Text = "Player Controller";
                        //ObjectPictureBox.BackgroundImage = ImageList.audio;
                        break;
                    case Engine.Classes.Components.ScriptComponent:
                        ComponentLabel.Visible = false;
                        Forms.Components.ScriptComponent ScriptComponentForm = new Forms.Components.ScriptComponent();
                        ScriptComponentForm.TopLevel = false;
                        ScriptComponentForm.AutoScroll = true;
                        ScriptComponentForm.scriptComponent = (Engine.Classes.Components.ScriptComponent)Components[i];
                        ComponentPanel.Controls.Add(ScriptComponentForm);
                        ScriptComponentForm.Dock = DockStyle.Fill;
                        ScriptComponentForm.Show();
                        ComponentNameLabel.Text = "Script Component";
                        ObjectPictureBox.BackgroundImage = ImageList.script;
                        DisabledAll(1);
                        break;
                    case Engine.Classes.Components.LogicComponent:
                        ComponentLabel.Visible = false;
                        Forms.Components.LogicComponent LogicComponentForm = new Forms.Components.LogicComponent();
                        LogicComponentForm.TopLevel = false;
                        LogicComponentForm.AutoScroll = true;
                        LogicComponentForm.logicComponent = (Engine.Classes.Components.LogicComponent)Components[i];
                        ComponentPanel.Controls.Add(LogicComponentForm);
                        LogicComponentForm.Dock = DockStyle.Fill;
                        LogicComponentForm.Show();
                        ComponentNameLabel.Text = "Logic Component";
                        ObjectPictureBox.BackgroundImage = ImageList.cube_ryb;
                        DisabledAll(1);
                        break;
                    case Engine.DialogSystem:
                        ComponentLabel.Visible = false;
                        Forms.Components.DialogSystem DialogSystemForm = new Forms.Components.DialogSystem();
                        DialogSystemForm.TopLevel = false;
                        DialogSystemForm.AutoScroll = true;
                        DialogSystemForm.dialogSystem = (Engine.DialogSystem)Components[i];
                        ComponentPanel.Controls.Add(DialogSystemForm);
                        DialogSystemForm.Dock = DockStyle.Fill;
                        DialogSystemForm.Show();
                        ComponentNameLabel.Text = "Dialog Component";
                        ObjectPictureBox.BackgroundImage = ImageList.theatrical_masks;
                        break;
                }
            }
            #pragma warning restore
        }

        public void DisabledAll(int index = 0)
        {
            switch (index)
            {
                case 0:
                    NameTextBox.Enabled = false;
                    PosXTextBox.Enabled = false;
                    PosYTextBox.Enabled = false;
                    ScaleXTextBox.Enabled = false;
                    ScaleYTextBox.Enabled = false;
                    VisibleCheckBox.Enabled = false;
                    RotationTextBox.Enabled = false;
                    SelectTextureButton.Enabled = false;
                    break;
                case 1:
                    PosXTextBox.Enabled = false;
                    PosYTextBox.Enabled = false;
                    ScaleXTextBox.Enabled = false;
                    ScaleYTextBox.Enabled = false;
                    VisibleCheckBox.Enabled = false;
                    SelectTextureButton.Enabled = false;
                    RotationTextBox.Enabled = false;
                    break;
                case 2:
                    SelectTextureButton.Enabled = false;
                    break;
            }
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

        private void PosXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void PosYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void ScaleXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void ScaleYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }

        private void RotationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsDigit(sender, e);
        }
        #endregion

        #region Change | Region
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.Form2.GameObjects[Program.Form2.ListIndex].Name = NameTextBox.Text;
        }

        private void PosXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PosXTextBox.Text == String.Empty) PosXTextBox.Text = "0";
            Program.Form2.GameObjects[Program.Form2.ListIndex].Position = new Vector2f(Convert.ToSingle(PosXTextBox.Text), Program.Form2.GameObjects[Program.Form2.ListIndex].Position.Y);
        }

        private void PosYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PosYTextBox.Text == String.Empty) PosYTextBox.Text = "0";
            Program.Form2.GameObjects[Program.Form2.ListIndex].Position = new Vector2f(Program.Form2.GameObjects[Program.Form2.ListIndex].Position.X, Convert.ToSingle(PosYTextBox.Text));
        }

        private void SelectTextureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextureTextBox.Text = openFileDialog1.FileName;
                TextureTextBox.Text = Program.Form2.GameObjects[Program.Form2.ListIndex].TexturePath = openFileDialog1.FileName;
                Program.Form2.GameObjects[Program.Form2.ListIndex].Sprite.Texture = new SFML.Graphics.Texture(openFileDialog1.FileName);
                Program.Form2.GameObjects[Program.Form2.ListIndex].Sprite.Scale = new Vector2f(1, 1);
            }
        }

        private void VisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.Form2.GameObjects[Program.Form2.ListIndex].Visible = VisibleCheckBox.Checked;
        }

        private void ScaleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ScaleXTextBox.Text == String.Empty) ScaleXTextBox.Text = "0";
            Program.Form2.GameObjects[Program.Form2.ListIndex].Scale = new Vector2f(Convert.ToSingle(ScaleXTextBox.Text), Program.Form2.GameObjects[Program.Form2.ListIndex].Scale.Y);
        }

        private void ScaleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ScaleYTextBox.Text == String.Empty) ScaleYTextBox.Text = "0";
            Program.Form2.GameObjects[Program.Form2.ListIndex].Scale = new Vector2f(Program.Form2.GameObjects[Program.Form2.ListIndex].Scale.X, Convert.ToSingle(ScaleYTextBox.Text));
        }

        private void RotationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RotationTextBox.Text == String.Empty) RotationTextBox.Text = "0";
            Program.Form2.GameObjects[Program.Form2.ListIndex].Rotation = Convert.ToSingle(RotationTextBox.Text);
        }
        #endregion
    }
}