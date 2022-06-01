using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
//SFML
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine
{
    internal class Program
    {
        //Importing a DLL
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //Console Status Variables
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        const int SW_Min = 2;
        const int SW_Max = 3;
        const int SW_Norm = 4;

        //Variables are available for modification
        public static RenderWindow window; //Screen Visualization Window
        public static Config config = new Config(); //Creating a config variable
        public static int scriptPos = 0;

        //Variables that are not recommended to be changed
        public static List<Language> languages = new List<Language>();

        public static List<Objects> objects = new List<Objects>();
        public static List<Images> images = new List<Images>();
        public static List<Dialog> dialogs = new List<Dialog>();
        public static List<Fonts> fonts = new List<Fonts>();
        public static List<Sounds> sounds = new List<Sounds>();
        public static List<Musics> musics = new List<Musics>();

        //Private variables
        static VideoMode mode;
        static string[] config_fl;

        [Obsolete]
        static void Main(string[] args)
        {
            //Reading the configuration file
            ReadConfig();

            try
            {
                //Getting the Console window
                var handle = GetConsoleWindow();
                if (!config.console) ShowWindow(handle, SW_HIDE); //Hiding the console

                //Setting the path to the archive with files
                Archive.ZipPath = Environment.CurrentDirectory + $"/{config.archive}";

                Debug.Log("Creating a video mode function");
                mode = new VideoMode(config.width, config.height);
                Debug.Log("Creating a visualization window");
                window = new RenderWindow(mode, config.title, config.style);
                window.SetVerticalSyncEnabled(config.vertical_sync);
                //window.SetMouseCursor
                window.SetFramerateLimit(config.fps_limit);
                //Creating a function for processing keystrokes
                window.KeyPressed += Window_KeyPressed;

                //Checking for empty icons in the configuration file
                if (config.icon != "")
                {
                    Image image; //Creating an empty image
                    //Checking for the type of image upload
                    if (config.icon.Contains("[Archive]")) //The postscript [Archive] means taking a file by example from the archive
                    {
                        MemoryStream mIcon = Archive.GetFile(config.icon.Replace("[Archive]", "")); //Recording in memory of an image taken from the archive
                        image = new Image(mIcon); //Changes to the app icon
                    }
                    else
                    {
                        image = new Image(config.icon); //Changes to the application icon via the path to the file
                    }
                    Debug.Log("Changes to the app icon");
                    window.SetIcon(image.Size.X, image.Size.Y, image.Pixels);
                }

                //Create new objects
                objects.Add(new Objects("background"));
                objects.Add(new Objects("left"));
                objects.Add(new Objects("center"));
                objects.Add(new Objects("right"));
                objects.Add(new Objects("choice"));
                objects.Add(new Objects("textbox"));
                objects.Add(new Objects("textbox_name", "text"));
                objects.Add(new Objects("textbox_text", "text"));
                objects.Add(new Objects("fps_text", "text"));

                //Parsing of json configuration files
                Parse.languagesFile("data/languages.json");
                Parse.imagesList();
                Parse.fontsList();
                Parse.objectList();

                for(int l = 0; l < languages.Count; l++)
                {
                    if (config.language == languages[l].code_name)
                    {
                        Debug.Log($"Changing the language to {languages[l].name}");
                        Parse.dialogsList(languages[l].script, languages[l].array_name);
                        l = languages.Count;
                    }
                }
                
                Parse.dialog();

                Clock clock = new Clock();
                float lastTime = 0;
                while (window.IsOpen)
                {
                    float currentTime = clock.Restart().AsSeconds();
                    Debug.fps_count = Convert.ToInt32(1.0f / (currentTime - lastTime));

                    objects.Find(item => item.name == "fps_text").text.DisplayedString = $"FPS: {Debug.fps_count.ToString()}";

                    window.DispatchEvents();
                    window.Clear(Color.Black);

                    //Drawing objects
                    Drawing.Draw("background");
                    Drawing.Draw("left");
                    Drawing.Draw("center");
                    Drawing.Draw("right");
                    Drawing.Draw("textbox");
                    Drawing.Draw("choice");

                    //Drawing texts
                    Drawing.DrawText("textbox_name");
                    Drawing.DrawText("textbox_text");
                    Drawing.DrawText("fps_text");

                    window.Display();
                }
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true); var frame = st.GetFrame(0); var line = frame.GetFileLineNumber();
                Debug.Error(ex.Message, ex.Data.ToString(), $"{ex.Source} - Line {line}");
            }
        }

        private static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Escape)
            {
                window.Close();
            }
            else if(e.Code == Keyboard.Key.Space)
            {
                if(scriptPos < dialogs.Count)
                {
                    Parse.dialog();
                }
            }
        }

        static void ReadConfig()
        {
            Debug.Log("Reading the configuration file");
            config_fl = File.ReadAllLines(Environment.CurrentDirectory + @"/config.ini");
            string title, width, height, console, archive, icon, language, saving_path, vertical_sync, fullscreen;

            title = config_fl[1].Replace("Title=", "").Replace("\"", "");
            if (title == "")
            {
                config.title = "Mickey Engine";
            }
            else
            {
                config.title = title;
            }
            width = config_fl[2].Replace("Width=", "");
            config.width = Convert.ToUInt32(width);
            height = config_fl[3].Replace("Height=", "");
            config.height = Convert.ToUInt32(height);
            fullscreen = config_fl[4].Replace("Fullscreen=", "").Replace("\"", "");
            if(Convert.ToBoolean(fullscreen))
            {
                config.style = Styles.Fullscreen;
            }
            icon = config_fl[5].Replace("Icon=", "").Replace("\"", "");
            config.icon = icon;
            vertical_sync = config_fl[6].Replace("VerticalSync=", "").Replace("\"", "");
            config.vertical_sync = Convert.ToBoolean(vertical_sync);
            console = config_fl[9].Replace("Console=", "");
            config.console = Convert.ToBoolean(console);
            archive = config_fl[10].Replace("Archive=", "").Replace("\"", "");
            config.archive = archive;
            language = config_fl[11].Replace("Language=", "").Replace("\"", "");
            config.language = language;
            saving_path = config_fl[12].Replace("SavingPath=", "").Replace("\"", "");
            config.saving_path = saving_path;
        }
    }
}
