using SFML.Window;
using System;

namespace Mickey_Engine.Classes.Actions
{
    public class Button
    {
        public enum Action
        {
            None,
            HideMenu,
            OpenMenu,
            Quit
        }

        public static Action Convert(string Action)
        {
            Action tempAction = Button.Action.None;
            switch (Action) {
                case "HideMenu":
                    tempAction = Button.Action.HideMenu;
                    break;
                case "OpenMenu":
                    tempAction = Button.Action.HideMenu;
                    break;
                case "Quit":
                    tempAction = Button.Action.Quit;
                    break;
            }
            return tempAction;
        }

        public static void Function(Action Action)
        {
            switch(Action)
            {
                case Action.Quit:
                    Program.Window.Close();
                    break;
                case Action.OpenMenu:
                    Program.Menu.Texts.Find(action => action.Action == Action.HideMenu).Visible = false;
                    break;
            }
        }
    }
}
