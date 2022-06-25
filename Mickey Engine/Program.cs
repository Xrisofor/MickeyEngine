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
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //Console Status Variables
        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
        public const int SW_Min = 2;
        public const int SW_Max = 3;
        public const int SW_Norm = 4;

        //Variables are available for modification
        public static RenderWindow window; //Screen Visualization Window
        public static Config config = new Config(); //Creating a config variable
        public static int scriptPos = 0; //The position of the dialog script
        public static bool isMenu = false; /* Is the player in the menu? */ public static string menuName; //Code name of the main menu

        //Variables that are not recommended to be changed
        public static List<Language> languages = new List<Language>();
        public static List<Input> inputs = new List<Input>();
        
        public static List<Objects> objects = new List<Objects>();
        public static List<Images> images = new List<Images>();
        public static List<Dialog> dialogs = new List<Dialog>();
        public static List<Fonts> fonts = new List<Fonts>();
        public static List<Sounds> sounds = new List<Sounds>();
        public static List<Musics> musics = new List<Musics>();
        public static List<Menu> menus = new List<Menu>();

        //Private variables
        static VideoMode mode;
        static string[] config_fl;
        static Sprite splashScreen, splashScreenProgressBar;

        //Change the values of these variables if you don't want to write everywhere the path to your loading screen in the game
        static string splashScreenFile = "data/splash/loading_pc.png", splashScreenProgressBarFile = "data/splash/loading_pc_progress_bar.png"; static bool splashScreenIsInTheArchive = false;
        static void SplashScreen(string file, string progressFile, bool acrhive = false, int progress = 0)
        {
            if(splashScreen == null)
            {
                Image image_sp;
                if (acrhive)
                {
                    MemoryStream mStream = Archive.GetFile(file);
                    image_sp = new Image(mStream);
                }
                else
                {
                    image_sp = new Image(Environment.CurrentDirectory + $"/../{file}");
                }
                splashScreen = new Sprite(new Texture(image_sp));
            }
            if (splashScreenProgressBar == null)
            {
                Image image_sp_pb;
                if (acrhive)
                {
                    MemoryStream mStream = Archive.GetFile(progressFile);
                    image_sp_pb = new Image(mStream);
                }
                else
                {
                    image_sp_pb = new Image(Environment.CurrentDirectory + $"/../{progressFile}");
                }
                splashScreenProgressBar = new Sprite(new Texture(image_sp_pb));
            }

            splashScreenProgressBar.TextureRect = new IntRect(splashScreenProgressBar.TextureRect.Left, splashScreenProgressBar.TextureRect.Top, progress, splashScreenProgressBar.TextureRect.Height);

            window.Draw(splashScreen);
            window.Draw(splashScreenProgressBar);
            window.Display();
        }

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
                Archive.ZipPath = Environment.CurrentDirectory + $"/../{config.archive}";

                Debug.Log("Creating a video mode function");
                mode = new VideoMode(config.width, config.height);
                Debug.Log("Creating a visualization window");
                window = new RenderWindow(mode, config.title, config.style);
                window.SetVerticalSyncEnabled(config.vertical_sync);
                window.SetFramerateLimit(config.fps_limit);
                //Creating a new camera
                Camera camera = new Camera(new Vector2f(config.width / 2, config.height / 2), new Vector2f(config.width, config.height));
                window.SetView(camera.camera);
                //Creating a function for processing keystrokes
                window.KeyPressed += Window_KeyPressed;
                window.JoystickConnected += Window_JoystickConnected;
                window.JoystickDisconnected += Window_JoystickDisconnected;
                window.JoystickButtonPressed += Window_JoystickButtonPressed;
                window.Closed += Window_Closed;

                //Splash Screen
                SplashScreen(splashScreenFile, splashScreenProgressBarFile, splashScreenIsInTheArchive, 150);

                //480 is the ID of the valve test game created specifically for developers
                SW_SteamAPI.Init("480"); //Steam initialization
                //989807940007518238 is the ID of a test application created by the engine developer
                Discord.Initialize("989807940007518238"); //Discord initialization
                //Rich Presense Data Updates
                Discord.Update("Testing the discord", "Dialog: welcome_en.json", "vs", "Visual Studio", "c-sharp", "C#");

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
                        image = new Image(Environment.CurrentDirectory + "/../config.icon"); //Changes to the application icon via the path to the file
                    }
                    Debug.Log("Changes to the app icon");
                    window.SetIcon(image.Size.X, image.Size.Y, image.Pixels);
                }

                //Debug.Log(UUID.NewGuid().ToString()); //Creating a test UUID

                //Checking the existence of the save folder
                if (!Directory.Exists(config.saving_path))
                {
                    //Creating a save folder in case it is lost or deleted
                    Directory.CreateDirectory(config.saving_path);
                }

                //Parsing of json configuration files
                Parse.languagesFile("data/languages.json"); //Language file
                Parse.inputFile("config/input.json"); //Input File
                Parse.fontsList(); //Font File
                SplashScreen(splashScreenFile, splashScreenProgressBarFile, splashScreenIsInTheArchive, 450);
                Parse.objectList(); //Object File
                Parse.imagesList(); //Image File
                SplashScreen(splashScreenFile, splashScreenProgressBarFile, splashScreenIsInTheArchive, 790);
                Parse.audioList("config/audio.json", "sound"); //Sound File
                Parse.audioList("config/audio.json", "music"); //Music File
                Parse.menuList("menu/main.json", true); //Menu File
                SplashScreen(splashScreenFile, splashScreenProgressBarFile, splashScreenIsInTheArchive, 1000);

                for (int l = 0; l < languages.Count; l++)
                {
                    if (config.language == languages[l].code_name)
                    {
                        Debug.Log($"Changing the language to {languages[l].name}");
                        Parse.dialogsList(languages[l].script, languages[l].array_name);
                        l = languages.Count;
                    }
                }
                
                Parse.dialog();
                SplashScreen(splashScreenFile, splashScreenProgressBarFile, splashScreenIsInTheArchive, 1280);

                for (int i = 0; i < menus.Count; i++)
                {
                    if(menus[i].primaryMenu)
                    {
                        //isMenu = true; //Temprorarily disabled due to development
                        menuName = menus[i].code_name;
                        i = menus.Count;
                    }
                }

                menus.Find(item => item.code_name == menuName).Show(window);

                //Testing of encryption and decryption of text
                Debug.Log(Encryption.Encrypt("[Discord]\nApplicationID = 989807940007518238", "me2z1c4e8b!0akey27plx@m32dev927s0b1"));
                Debug.Log(Encryption.Decrypt("DbBfYfMt9PdX60TagNW0VApwZfUPmkcsytJh3vuJnAJ7vVNOPMu5Zs5JkZ7ONwn/Gr2ut3sRpCeGw7pAdKmgxn4yeo3CYC5KNH8Tng4YJMjRpmajw+vuydJTIk+dpLs0", "me2z1c4e8b!0akey27plx@m32dev927s0b1"));

                Clock clock = new Clock();
                float lastTime = 0;
                while (window.IsOpen)
                {
                    float currentTime = clock.Restart().AsSeconds();
                    Debug.fps_count = Convert.ToInt32(1.0f / (currentTime - lastTime));

                    if(config.fps_show)
                        objects.Find(item => item.name == "fps_text").text.DisplayedString = $"FPS: {Debug.fps_count.ToString()}";

                    window.DispatchEvents();
                    window.Clear(Color.Black);

                    if(isMenu)
                    {
                        //Drawing objects
                        Drawing.MenuDraw("menu_bg");

                        //Drawing texts
                        Drawing.MenuDrawText("game_name");
                        Drawing.MenuDrawText("game_version");
                    }
                    else
                    {
                        //Drawing objects
                        Drawing.Draw("background");
                        Drawing.Draw("left_pos");
                        Drawing.Draw("center_pos");
                        Drawing.Draw("right_pos");
                        Drawing.Draw("textbox");
                        Drawing.Draw("choice");

                        //Drawing texts
                        Drawing.DrawText("textbox_name");
                        Drawing.DrawText("textbox_text");
                    }

                    if (config.fps_show)
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

        //Close
        private static void Window_Closed(object sender, EventArgs e)
        {
            Debug.Log("The application is closing...");
            Environment.Exit(0);
        }

        //Keyboard
        private static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == inputs.Find(item => item.action == "Quit").key)
            {
                window.Close();
            }
            if (e.Code == inputs.Find(item => item.action == "OpenConsole").key && config.console)
            {
                Console.WriteLine("[Console] Enter the command:");
                string com = Console.ReadLine();
                functions.Console.Command(com);
            }
            if (e.Code == inputs.Find(item => item.action == "SaveGame").key && !isMenu)
            {
                Save.SaveGame(0, scriptPos);
            }
            if (e.Code == inputs.Find(item => item.action == "LoadGame").key && !isMenu)
            {
                scriptPos = Load.LoadGame(0) - 1;
                Parse.dialog();
            }
            if (e.Code == inputs.Find(item => item.action == "Dialog.Move").key && !isMenu)
            {
                if(scriptPos < dialogs.Count)
                {
                    Parse.dialog();
                }
            }
        }

        //Joystick
        private static void Window_JoystickConnected(object sender, JoystickConnectEventArgs e)
        {
            Debug.Log($"A new joystick is connected");
        }

        private static void Window_JoystickDisconnected(object sender, JoystickConnectEventArgs e)
        {
            Debug.Log($"The joystick was disabled");
        }

        private static void Window_JoystickButtonPressed(object sender, JoystickButtonEventArgs e)
        {
            switch(e.Button)
            {
                case 0:
                    if (scriptPos < dialogs.Count)
                    {
                        Parse.dialog();
                    }
                    break;
            }
        }


        //Config
        static void ReadConfig()
        {
            Debug.Log("Reading the configuration file");
            config_fl = File.ReadAllLines(Environment.CurrentDirectory + @"/../config.ini");
            string title, width, height, console, archive, icon, language, saving_path, vertical_sync, fullscreen, drawFPS;

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
            drawFPS = config_fl[10].Replace("DrawFPS=", "");
            config.fps_show = Convert.ToBoolean(drawFPS);
            archive = config_fl[11].Replace("Archive=", "").Replace("\"", "");
            config.archive = archive;
            language = config_fl[12].Replace("Language=", "").Replace("\"", "");
            config.language = language;
            saving_path = config_fl[13].Replace("SavingPath=", "").Replace("\"", "");
            if(saving_path.Contains("[appdata]"))
                saving_path = saving_path.Replace("[appdata]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            config.saving_path = saving_path;
        }
    }
}
