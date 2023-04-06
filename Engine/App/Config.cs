using SFML.Graphics;
using SFML.Window;
using Newtonsoft.Json;
using SFML.Audio;
using Engine.Resources;
using System.Runtime.InteropServices;

namespace Engine.App
{
    public class Config
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //The main variables of the engine
        public static string Title { get; set; } = "Mickey Engine";
        public static VideoMode VideoMode { get; set; } = new VideoMode(1280, 720); //Window size, default 1280 by 720
        public static bool VerticalSync { get; set; } = false;
        public static Styles WindowStyle { get; set; } = Styles.Close; //Rendering window style, by default Close (collapse and close only), also Fullscreen
        public static uint FramerateLimit { get; set; } = 60;
        public static string Language { get; set; } = "En"; //Engine language (taken automatically from the computer if possible)
        public static uint MusicVolume { get; set; } = 100; //Music volume in the engine
        public static uint SoundVolume { get; set; } = 100; //Sound volume in the engine
        public static string GameData { get; private set; } = $@"{Environment.CurrentDirectory}\content"; //The path to the folder with all game files, maps, and so on
        public static Image WindowIcon { get; set; } //The window icon is missing by default

        //Engine Variables
        public static string EngineData { get; private set; } = $@"{Environment.CurrentDirectory}";
        public static float DeltaTime { get; set; } //Time after a new frame
        public static int FramesPerSecond { get; set; } //Number of frames per second
        public static Font GameFont { get; private set; } = new Font(Resources.EngineResource.Font); //Default game font
        public static Sound FileNotFound { get; private set; } = new Sound(new SoundBuffer(EngineResource.FileNotFound)); //Default game sound
        public static string StartMap { get; set; } public static bool ShowRectangleShape { get; set; } = true; //Responsible for displaying all RectangleShape on the object

        //Reading all files related to the engine config
        public static void Init()
        {
            string allData = File.ReadAllText($@"{GameData}\game_info.json");
            dynamic? jsonData = JsonConvert.DeserializeObject(allData);

            #pragma warning disable
            Title = jsonData["GameInfo"].Title;
            #pragma warning restore
            string vModeNoSplit = jsonData["GameInfo"].WindowSize;
            string[] vMode = vModeNoSplit.Replace(" ", "").Split(';');
            VideoMode = new VideoMode(Convert.ToUInt32(vMode[0]), Convert.ToUInt32(vMode[1]));
            VerticalSync = jsonData["GameInfo"].VerticalSync;
            FramerateLimit = jsonData["GameInfo"].FramerateLimit;
            string vIcon = jsonData["GameInfo"].WindowIcon;
            StartMap = jsonData["GameInfo"].StartMap; StartMap = ReplaceFunction(StartMap);
            if (vIcon != null)
                WindowIcon = new Image(vIcon);

            foreach (string file in Directory.EnumerateFiles($@"{EngineData}\plugins", "*.lua", SearchOption.AllDirectories))
            {
                Window.Scripts.Add(Script.LoadFromFile(file));
            }
            foreach (string file in Directory.EnumerateFiles($@"{EngineData}\plugins", "*.plugin", SearchOption.AllDirectories))
            {
                Window.Scripts.Add(Script.LoadFromFile(file, true));
            }
        }

        //Replaces special characters with data from the config
        public static string ReplaceFunction(string String)
        {
            String = String.Replace("$GAME_DATA", GameData);
            String = String.Replace("$ENGINE_DATA", EngineData);
            String = String.Replace("$WINDOW_X_CENTER", (VideoMode.Width / 2).ToString());
            String = String.Replace("$WINDOW_Y_CENTER", (VideoMode.Height / 2).ToString());
            return String;
        }

        public static void ConsoleState(int SW = 0) //0 - Hide, 5 - Show
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW);
        }
    }
}
