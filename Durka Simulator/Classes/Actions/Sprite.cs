using SFML.Window;
using System;

namespace Mickey_Engine.Classes.Actions
{
    public class Sprite
    {
        public enum Action
        {
            None,
            Appear,
            Flashing,
            Fade
        }

        public static Action Convert(string Action)
        {
            Action tempAction = Sprite.Action.None;
            switch (Action)
            {
                case "Appear":
                    tempAction = Sprite.Action.Appear;
                    break;
                case "Flashing":
                    tempAction = Sprite.Action.Flashing;
                    break;
                case "Fade":
                    tempAction = Sprite.Action.Fade;
                    break;
            }
            return tempAction;
        }
    }
}

