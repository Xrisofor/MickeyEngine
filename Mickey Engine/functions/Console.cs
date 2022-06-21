using System;
using System.IO;
//SFML
using SFML.Graphics;

namespace Mickey_Engine.functions
{
    /// <summary>
    /// Working class with the engine console
    /// </summary>
    public class Console
    {
        /// <summary>
        /// The command function handles commands coming from the console
        /// </summary>
        /// <param name="code">String type variable that denotes a command</param>
        public static void Command(string code)
        {
            if(code.EndsWith(";"))
            {
                int a = code.IndexOf('(');
                int b = code.IndexOf(')');
                string func = code.Substring(0, a);
                string args = code.Substring(a + 1, b - a - 1);
                string[] arg = code.Split(',');
                func = func.Replace(" ", "");
                switch(func.ToLower())
                {
                    case "title":
                        ConsoleFunctions.title(args.Replace("\"", ""));
                        break;
                    case "icon":
                        ConsoleFunctions.icon(args.Replace("\"", ""));
                        break;
                    case "console.show":
                        ConsoleFunctions.console_show(args.Replace("\"", ""), func);
                        break;
                    case "console.size":
                        ConsoleFunctions.console_size(arg);
                        break;
                    case "fps.show":
                        ConsoleFunctions.fps_show(args.Replace("\"", ""), func);
                        break;
                    case "fps.limit":
                        ConsoleFunctions.fps_limit(args.Replace("\"", ""));
                        break;
                    case "fps.color":
                        ConsoleFunctions.fps_color(args.Replace("\"", ""));
                        break;
                    case "sound.play":
                        ConsoleFunctions.sound_play(args.Replace("\"", ""));
                        break;
                    case "sound.stop":
                        ConsoleFunctions.sound_stop(args.Replace("\"", ""));
                        break;
                    case "sound.pause":
                        ConsoleFunctions.sound_pause(args.Replace("\"", ""));
                        break;
                    case "music.play":
                        ConsoleFunctions.sound_play(args.Replace("\"", ""), 1);
                        break;
                    case "music.stop":
                        ConsoleFunctions.sound_stop(args.Replace("\"", ""), 1);
                        break;
                    case "music.pause":
                        ConsoleFunctions.sound_pause(args.Replace("\"", ""), 1);
                        break;
                    case "language":
                        ConsoleFunctions.language(args);
                        break;
                    case "clear":
                        System.Console.Clear();
                        break;
                    case "restart":
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        Environment.Exit(0);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"[Console] The {func} function does not exist. Check the spelling of the command!");
                        System.Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"[Console] The {code} function does not exist. Check the spelling of the command!");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    /// <summary>
    /// Class for storing engine console functions
    /// </summary>
    public class ConsoleFunctions
    {
        /// <summary>
        /// The function changes the window title
        /// </summary>
        /// <param name="args">Argument that stores the new name of the window</param>
        public static void title(string args)
        {
            Debug.Log($"Changing the window name to {args}");
            Program.window.SetTitle(args);
        }

        /// <summary>
        /// The function changes the window icon
        /// </summary>
        /// <param name="args">Argument that stores the new icon of the window</param>
        public static void icon(string args)
        {
            Image image;
            Program.config.icon = args;
            if (Program.config.icon.Contains("[Archive]")) //The postscript [Archive] means taking a file by example from the archive
            {
                MemoryStream mIcon = Archive.GetFile(Program.config.icon.Replace("[Archive]", "")); //Recording in memory of an image taken from the archive
                image = new Image(mIcon); //Changes to the app icon
            }
            else
            {
                image = new Image(Program.config.icon); //Changes to the application icon via the path to the file
            }
            Debug.Log("Changes to the app icon");
            Program.window.SetIcon(image.Size.X, image.Size.Y, image.Pixels);
        }

        /// <summary>
        /// Console display function
        /// </summary>
        public static void console_show(string args, string func)
        {
            if (args == "false" || args == "true")
            {
                Debug.Log($"Changing the console_show variable to {args}");
                Program.config.console = Convert.ToBoolean(args);
                var handle = Program.GetConsoleWindow();
                if (Program.config.console) Program.ShowWindow(handle, Program.SW_SHOW);
                else Program.ShowWindow(handle, Program.SW_HIDE);
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"[Console] The {func} function accepts only true or false values!");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Console size function
        /// </summary>
        public static void console_size(string[] arg)
        {
            Debug.Log($"Changing the console size to {Convert.ToInt32(arg[0])}, {Convert.ToInt32(arg[1])}");
            System.Console.SetWindowSize(Convert.ToInt32(arg[0]), Convert.ToInt32(arg[1]));
        }

        /// <summary>
        /// FPS counter display function
        /// </summary>
        public static void fps_show(string args, string func)
        {
            if (args == "false" || args == "true")
            {
                Debug.Log($"Changing the fps_show variable to {args}");
                Program.config.fps_show = Convert.ToBoolean(args);
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"[Console] The {func} function accepts only true or false values!");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// FPS limit change function
        /// </summary>
        public static void fps_limit(string args)
        {
            Debug.Log($"Changing the fps_limit variable to {Convert.ToUInt32(args)}");
            Program.config.fps_limit = Convert.ToUInt32(args);
            Program.window.SetFramerateLimit(Program.config.fps_limit);
        }

        /// <summary>
        /// The function of changing the color of the fps counter
        /// </summary>
        /// <param name="args"></param>
        public static void fps_color(string args)
        {
            Debug.Log($"Changing the fps_text variable color to {getColor(args).ToString()}");
            if (Program.config.fps_show)
                Program.objects.Find(item => item.name == "fps_text").text.FillColor = getColor(args);
        }

        /// <summary>
        /// Plays a file
        /// </summary>
        public static void sound_play(string args, int t = 0)
        {
            try
            {
                Debug.Log($"Playing the {args} file");
                if(t == 0)
                    Program.sounds.Find(item => item.name == args).sound.Play();
                else
                    Program.musics.Find(item => item.name == args).music.Play();
            }
            catch
            {
                Debug.Log($"This audio file was not found, try again");
            }
        }

        /// <summary>
        /// Stopping a file
        /// </summary>
        public static void sound_stop(string args, int t = 0)
        {
            try
            {
                Debug.Log($"Stopping the {args} file");
                if (t == 0)
                    Program.sounds.Find(item => item.name == args).sound.Stop();
                else
                    Program.musics.Find(item => item.name == args).music.Stop();
            }
            catch
            {
                Debug.Log($"This audio file was not found, try again");
            }
        }

        /// <summary>
        /// Pausing a file
        /// </summary>
        public static void sound_pause(string args, int t = 0)
        {
            try
            {
                Debug.Log($"Pausing the {args} file");
                if (t == 0)
                    Program.sounds.Find(item => item.name == args).sound.Pause();
                else
                    Program.musics.Find(item => item.name == args).music.Pause();
            }
            catch
            {
                Debug.Log($"This audio file was not found, try again");
            }
        }

        /// <summary>
        /// Language change function
        /// </summary>
        /// <param name="args">Argument that stores the code name of the language</param>
        public static void language(string args)
        {
            Program.config.language = args.Replace("\"", "");
            for (int l = 0; l < Program.languages.Count; l++)
            {
                if (Program.config.language == Program.languages[l].code_name)
                {
                    Program.dialogs.Clear();
                    Debug.Log($"Changing the language to {Program.languages[l].name}");
                    Parse.dialogsList(Program.languages[l].script, Program.languages[l].array_name);
                    l = Program.languages.Count;
                    Parse.dialog();
                }
            }
        }

        /// <summary>
        /// Color exchanger function from string to SFML.Graphics.Color
        /// </summary>
        /// <param name="color">The name of the color in the SFML system</param>
        /// <returns>SFML color encoding</returns>
        public static Color getColor(string color)
        {
            Color col = Color.Black;
            switch(color)
            {
                case "Black":
                    col = Color.Black;
                    break;
                case "black":
                    col = Color.Black;
                    break;
                case "Blue":
                    col = Color.Blue;
                    break;
                case "blue":
                    col = Color.Blue;
                    break;
                case "Cyan":
                    col = Color.Cyan;
                    break;
                case "cyan":
                    col = Color.Cyan;
                    break;
                case "Green":
                    col = Color.Green;
                    break;
                case "green":
                    col = Color.Green;
                    break;
                case "Magenta":
                    col = Color.Magenta;
                    break;
                case "magenta":
                    col = Color.Magenta;
                    break;
                case "Red":
                    col = Color.Red;
                    break;
                case "red":
                    col = Color.Red;
                    break;
                case "Transparent":
                    col = Color.Transparent;
                    break;
                case "transparent":
                    col = Color.Transparent;
                    break;
                case "White":
                    col = Color.White;
                    break;
                case "white":
                    col = Color.White;
                    break;
                case "Yellow":
                    col = Color.Yellow;
                    break;
                case "yellow":
                    col = Color.Yellow;
                    break;
                default:
                    col = Color.White;
                    break;
            }
            return col;
        }
    }
}
