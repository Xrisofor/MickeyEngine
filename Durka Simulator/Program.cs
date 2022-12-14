using System;
using System.Collections.Generic;
//SFML
using SFML.Window;
using SFML.Graphics;
using SFML.System;
//MickeyEngine
using Mickey_Engine.Functions;
using Mickey_Engine.Classes;
using Mickey_Engine.Special;
using Mickey_Engine.Classes.Audio;

namespace Mickey_Engine
{
    internal class Program
    {
        //Window Variables
        public static RenderWindow Window;
        public static VideoMode VideoMode;
        public static bool FirstLaunch = true;

        //Game Variables
        public static Config Config = new Config();
        public static int DialogPosition = 0;
        public static bool[] GameState = { true, false, false, false };
        public static Classes.Draw.Menu Menu;

        //Lists of all program objects
        public static List<Inputs> Inputs = new List<Inputs>();
        public static List<Language> Languages = new List<Language>();
        public static List<Translation> Translations = new List<Translation>();

        public static List<Images> Images = new List<Images>();
        public static List<Fonts> Fonts = new List<Fonts>();
        public static List<Sounds> Sounds = new List<Sounds>();
        public static List<Musics> Musics = new List<Musics>();
        public static List<Character> Characters = new List<Character>();

        [Obsolete]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Special.App.Arguments.ParseArgument(arg);
            }

            try
            {
                Config.ReadConfig();

                //Loading all the main functions
                LanguageManager.LoadLanguage();
                LanguageManager.ChangeLanguage();
                InputsManager.LoadInputs();
                ImageManager.LoadImages();
                FontsManager.LoadFonts();
                MusicManager.LoadMusic();
                SoundManager.LoadSound();
                CharactersManager.LoadAll();

                //Creating and configuring a window
                VideoMode = new VideoMode(Config.Width, Config.Height);
                Window = new RenderWindow(VideoMode, Config.Title, Config.Style);
                Window.SetFramerateLimit(Config.Fps_Limit);
                Window.SetVerticalSyncEnabled(Config.Vertical_Sync);
                Window.KeyPressed += Window_KeyPressed;
                Window.Closed += Window_Closed;

                Special.Script.Manager.Run();

                //Launching functions creating menus

                if(GameState[0])
                    Menu = new Classes.Draw.Menu("Loading.json");
                else
                    Menu = new Classes.Draw.Menu();

                //Creating text to display the frame rate counter
                Debug.FPS_Text = new Text("FPS: 0", Program.Fonts.Find(item => item.Name == "Impact").Font, 14);

                FirstLaunch = false; //Disabling the first run variable

                //Creating a new clock to determine the frame rate
                Clock clock = new Clock();
                float lastTime = 0;

                //Infinite loop while the window is open
                while (Window.IsOpen)
                {
                    //Frame rate detection
                    float currentTime = clock.Restart().AsSeconds();
                    Debug.FPS_Counter = Convert.ToInt32(1.0f / (currentTime - lastTime));
                    Debug.FPS_Text.DisplayedString = $"FPS: {Debug.FPS_Counter}";

                    //Window rendering
                    Window.DispatchEvents();

                    //Update functions
                    //if (GameState[0])
                        //Classes.Draw.Loading.Update();
                    //if (GameState[1])
                        //Menu.Update(); //Classes.Draw.Menu_OLd.Update();

                    Menu.Update();

                    Window.Clear(Color.Blue);

                    //Draw functions
                    //if (GameState[0])
                        //Classes.Draw.Loading.Draw();
                    //if (GameState[1])
                        //Menu.Draw(); //Classes.Draw.Menu_OLd.Draw();

                    Menu.Draw();

                    if (Config.Fps_Show)
                        Window.Draw(Debug.FPS_Text);

                    Window.Display();
                }
            }
            catch(Exception ex)
            {
                //Sending error information
                var st = new System.Diagnostics.StackTrace(ex, true); var frame = st.GetFrame(0); var line = frame.GetFileLineNumber();
                Debug.Error(ex.Message, ex.Data.ToString(), $"{ex.Source} - Line {line}");
            }
        }

        //If some button is pressed on the keyboard, run this function
        private static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Escape && GameState[0] == false && GameState[1] == false)
            {
                Window.Close();
            }
        }

        //If the close window button is pressed, run this function
        private static void Window_Closed(object sender, EventArgs e)
        {
            Console.WriteLine();
            Debug.Log("Engine shutdown...", ConsoleColor.Green);
            Environment.Exit(0);
        }
    }
}
