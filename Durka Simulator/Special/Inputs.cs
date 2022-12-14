using System;
//SFML
using SFML.Window;
//Newtonsoft
using Newtonsoft.Json;
//MickeyEngine
using Mickey_Engine.Functions;

namespace Mickey_Engine.Special
{
    public enum InputActions
    {
        Quit,
        Save,
        Load,
        DialogMove,
    }
    
    public class InputsManager
    {
        public static void LoadInputs(string file = "Inputs.json")
        {
            Console.WriteLine();
            string allData = System.IO.File.ReadAllText($"{Environment.CurrentDirectory}/../Data/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Blue);

            foreach (var data in jsonData["Inputs"])
            {
                string inputUUID = data.UUID, key = data.Key, action = data.Action;
                Program.Inputs.Add(new Inputs(inputUUID, key, action));
                Debug.Log($"║ Creating a new {inputUUID} action by pressing the {key} button", ConsoleColor.Blue);
            }

            Debug.Log($"╚ Completing the creation with the action button", ConsoleColor.Blue);
        }
    }

    
    public class Inputs
    {
        public string UUID;
        public Keyboard.Key Key;
        public string Action;

        public Inputs(string UUID, string Key, string Action)
        {
            this.UUID = UUID;
            this.Key = ConvertKey(Key);
            this.Action = Action;
        }

        private Keyboard.Key ConvertKey(string key)
        {
            Keyboard.Key k = Keyboard.Key.Unknown;
            switch (key)
            {
                case "A":
                    k = Keyboard.Key.A;
                    break;
                case "Add":
                    k = Keyboard.Key.Add;
                    break;
                case "B":
                    k = Keyboard.Key.B;
                    break;
                case "BackSlash":
                    k = Keyboard.Key.Backslash;
                    break;
                case "Backslash":
                    k = Keyboard.Key.Backslash;
                    break;
                case "BackSpace":
                    k = Keyboard.Key.Backspace;
                    break;
                case "Backspace":
                    k = Keyboard.Key.Backspace;
                    break;
                case "C":
                    k = Keyboard.Key.C;
                    break;
                case "Comma":
                    k = Keyboard.Key.Comma;
                    break;
                case "D":
                    k = Keyboard.Key.D;
                    break;
                case "Dash":
                    k = Keyboard.Key.Hyphen;
                    break;
                case "Delete":
                    k = Keyboard.Key.Delete;
                    break;
                case "Divide":
                    k = Keyboard.Key.Divide;
                    break;
                case "Down":
                    k = Keyboard.Key.Down;
                    break;
                case "E":
                    k = Keyboard.Key.E;
                    break;
                case "End":
                    k = Keyboard.Key.End;
                    break;
                case "Enter":
                    k = Keyboard.Key.Enter;
                    break;
                case "Equal":
                    k = Keyboard.Key.Equal;
                    break;
                case "Escape":
                    k = Keyboard.Key.Escape;
                    break;
                case "F":
                    k = Keyboard.Key.F;
                    break;
                case "F1":
                    k = Keyboard.Key.F1;
                    break;
                case "F10":
                    k = Keyboard.Key.F10;
                    break;
                case "F11":
                    k = Keyboard.Key.F11;
                    break;
                case "F12":
                    k = Keyboard.Key.F12;
                    break;
                case "F13":
                    k = Keyboard.Key.F13;
                    break;
                case "F14":
                    k = Keyboard.Key.F14;
                    break;
                case "F15":
                    k = Keyboard.Key.F15;
                    break;
                case "F2":
                    k = Keyboard.Key.F2;
                    break;
                case "F3":
                    k = Keyboard.Key.F3;
                    break;
                case "F4":
                    k = Keyboard.Key.F4;
                    break;
                case "F5":
                    k = Keyboard.Key.F5;
                    break;
                case "F6":
                    k = Keyboard.Key.F6;
                    break;
                case "F7":
                    k = Keyboard.Key.F7;
                    break;
                case "F8":
                    k = Keyboard.Key.F8;
                    break;
                case "F9":
                    k = Keyboard.Key.F9;
                    break;
                case "G":
                    k = Keyboard.Key.G;
                    break;
                case "H":
                    k = Keyboard.Key.H;
                    break;
                case "Home":
                    k = Keyboard.Key.Home;
                    break;
                case "Hyphen":
                    k = Keyboard.Key.Hyphen;
                    break;
                case "I":
                    k = Keyboard.Key.I;
                    break;
                case "Insert":
                    k = Keyboard.Key.Insert;
                    break;
                case "J":
                    k = Keyboard.Key.J;
                    break;
                case "K":
                    k = Keyboard.Key.K;
                    break;
                case "KeyCount":
                    k = Keyboard.Key.KeyCount;
                    break;
                case "L":
                    k = Keyboard.Key.L;
                    break;
                case "LAlt":
                    k = Keyboard.Key.LAlt;
                    break;
                case "LBracket":
                    k = Keyboard.Key.LBracket;
                    break;
                case "LControl":
                    k = Keyboard.Key.LControl;
                    break;
                case "Left":
                    k = Keyboard.Key.Left;
                    break;
                case "LShift":
                    k = Keyboard.Key.LShift;
                    break;
                case "LSystem":
                    k = Keyboard.Key.LSystem;
                    break;
                case "M":
                    k = Keyboard.Key.M;
                    break;
                case "Menu":
                    k = Keyboard.Key.Menu;
                    break;
                case "Multiply":
                    k = Keyboard.Key.Multiply;
                    break;
                case "N":
                    k = Keyboard.Key.N;
                    break;
                case "Num0":
                    k = Keyboard.Key.Num0;
                    break;
                case "Num1":
                    k = Keyboard.Key.Num1;
                    break;
                case "Num2":
                    k = Keyboard.Key.Num2;
                    break;
                case "Num3":
                    k = Keyboard.Key.Num3;
                    break;
                case "Num4":
                    k = Keyboard.Key.Num4;
                    break;
                case "Num5":
                    k = Keyboard.Key.Num5;
                    break;
                case "Num6":
                    k = Keyboard.Key.Num6;
                    break;
                case "Num7":
                    k = Keyboard.Key.Num7;
                    break;
                case "Num8":
                    k = Keyboard.Key.Num8;
                    break;
                case "Num9":
                    k = Keyboard.Key.Num9;
                    break;
                case "Numpad0":
                    k = Keyboard.Key.Numpad0;
                    break;
                case "Numpad1":
                    k = Keyboard.Key.Numpad1;
                    break;
                case "Numpad2":
                    k = Keyboard.Key.Numpad2;
                    break;
                case "Numpad3":
                    k = Keyboard.Key.Numpad3;
                    break;
                case "Numpad4":
                    k = Keyboard.Key.Numpad4;
                    break;
                case "Numpad5":
                    k = Keyboard.Key.Numpad5;
                    break;
                case "Numpad6":
                    k = Keyboard.Key.Numpad6;
                    break;
                case "Numpad7":
                    k = Keyboard.Key.Numpad7;
                    break;
                case "Numpad8":
                    k = Keyboard.Key.Numpad8;
                    break;
                case "Numpad9":
                    k = Keyboard.Key.Numpad9;
                    break;
                case "O":
                    k = Keyboard.Key.O;
                    break;
                case "P":
                    k = Keyboard.Key.P;
                    break;
                case "PageDown":
                    k = Keyboard.Key.PageDown;
                    break;
                case "PageUp":
                    k = Keyboard.Key.PageUp;
                    break;
                case "Pause":
                    k = Keyboard.Key.Pause;
                    break;
                case "Period":
                    k = Keyboard.Key.Period;
                    break;
                case "Q":
                    k = Keyboard.Key.Q;
                    break;
                case "Quote":
                    k = Keyboard.Key.Quote;
                    break;
                case "R":
                    k = Keyboard.Key.R;
                    break;
                case "RAlt":
                    k = Keyboard.Key.RAlt;
                    break;
                case "RBracket":
                    k = Keyboard.Key.RBracket;
                    break;
                case "RControl":
                    k = Keyboard.Key.RControl;
                    break;
                case "Return":
                    k = Keyboard.Key.Enter;
                    break;
                case "Right":
                    k = Keyboard.Key.Right;
                    break;
                case "RShift":
                    k = Keyboard.Key.RShift;
                    break;
                case "RSystem":
                    k = Keyboard.Key.RSystem;
                    break;
                case "S":
                    k = Keyboard.Key.S;
                    break;
                case "Semicolon":
                    k = Keyboard.Key.Semicolon;
                    break;
                case "SemiColon":
                    k = Keyboard.Key.Semicolon;
                    break;
                case "Slash":
                    k = Keyboard.Key.Slash;
                    break;
                case "Space":
                    k = Keyboard.Key.Space;
                    break;
                case "Subtract":
                    k = Keyboard.Key.Subtract;
                    break;
                case "T":
                    k = Keyboard.Key.T;
                    break;
                case "Tab":
                    k = Keyboard.Key.Tab;
                    break;
                case "Tilde":
                    k = Keyboard.Key.Tilde;
                    break;
                case "U":
                    k = Keyboard.Key.U;
                    break;
                case "Unknown":
                    k = Keyboard.Key.Unknown;
                    break;
                case "Up":
                    k = Keyboard.Key.Up;
                    break;
                case "V":
                    k = Keyboard.Key.V;
                    break;
                case "W":
                    k = Keyboard.Key.W;
                    break;
                case "X":
                    k = Keyboard.Key.X;
                    break;
                case "Y":
                    k = Keyboard.Key.Y;
                    break;
                case "Z":
                    k = Keyboard.Key.Z;
                    break;
                default:
                    k = Keyboard.Key.Unknown;
                    break;
            }
            return k;
        }
    }
}
