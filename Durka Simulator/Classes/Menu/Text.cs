using System;
using System.IO;
//Mickey_Engine
using Mickey_Engine.Special;
//Json
using Newtonsoft.Json;
//SFML
using SFML.Graphics;
using SFML.Window;

namespace Mickey_Engine.Classes.Menu
{
    public class Text
    {
        //Text Variables
        public string UUID { get; set; }
        public SFML.Graphics.Text String { get; set; }
        public bool Visible { get; set; }
        public bool isButton { get; set; }

        //Text Event
        public delegate void OnPress(Actions.Button.Action Action);
        public event OnPress ButtonLeftPress; //public event OnPress ButtonRightPress;

        //Text Action
        public Actions.Button.Action Action;

        public Text(string UUID, SFML.Graphics.Text String, bool Visible, bool isButton = false, Actions.Button.Action Action = Actions.Button.Action.None)
        {
            this.UUID = UUID;
            this.String = String;
            this.Visible = Visible;
            this.isButton = isButton;
            this.Action = Action;

            ButtonLeftPress += TextButtonLeftPress;
        }

        private void TextButtonLeftPress(Actions.Button.Action Action)
        {
            Actions.Button.Function(Action);
        }

        public void HoverCheck()
        {
            if (Visible && isButton)
            {
                if (Mouse.GetPosition(Program.Window).X > String.GetGlobalBounds().Left && Mouse.GetPosition(Program.Window).X < String.GetGlobalBounds().Left + String.GetGlobalBounds().Width)
                {
                    if (Mouse.GetPosition(Program.Window).Y > String.GetGlobalBounds().Top && Mouse.GetPosition(Program.Window).Y < String.GetGlobalBounds().Top + String.GetGlobalBounds().Height)
                    {
                        String.FillColor = Color.White;

                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                            ButtonLeftPress(Action);
                        //if (Mouse.IsButtonPressed(Mouse.Button.Right))
                            //ButtonRightPress(Action);
                    }
                    else
                    {
                        String.FillColor = GetColor.GetSFMLColor("Gray");
                    }
                }
                else
                {
                    String.FillColor = GetColor.GetSFMLColor("Gray");
                }
            }
        }

    }
}
