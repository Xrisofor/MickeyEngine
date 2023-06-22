using Engine.Classes;
using Engine.Tools;
using SFML.Graphics;
using SFML.System;

namespace Engine.App
{
    //SFML Window Class
    public class Window
    {
        public static RenderWindow? RenderWindow { get; private set; }
        //List of all game objects in the scene
        public static List<GameObject> GameObjects = new List<GameObject>();
        //List of all game scripts (need to be redone)
        public static List<Script> Scripts { get; set; } = new List<Script>();

        //Temporarily out of service
        [Obsolete]
        public static DialogSystem Dialog = new DialogSystem();

        public static bool KeyPress = false;

        //Initializing the rendering window
        public static void Init()
        {
            RenderWindow = new RenderWindow(Config.VideoMode, Config.Title, Config.WindowStyle);
            RenderWindow.Closed += (s, e) => { RenderWindow.Close(); }; //Window closing event
            #pragma warning disable
            RenderWindow.MouseButtonPressed += (s, e) => { Dialog.NextLine(); }; //Keyboard tapping event
            #pragma warning restore
            RenderWindow.KeyPressed += KeyPressed;
            RenderWindow.KeyReleased += KeyReleased;
            RenderWindow.JoystickConnected += JoystickConnected;
            RenderWindow.JoystickDisconnected += JoystickDisconnected;
            RenderWindow.SetVerticalSyncEnabled(Config.VerticalSync);
            RenderWindow.SetFramerateLimit(Config.FramerateLimit);
            if(Config.WindowIcon != null)
                RenderWindow.SetIcon(Config.WindowIcon.Size.X, Config.WindowIcon.Size.Y, Config.WindowIcon.Pixels);

            Map.LoadMap(Config.StartMap, false);

            //Search for all scripts (temporarily out of service
            foreach (string file in Directory.EnumerateFiles($@"{Config.GameData}\scripts", "*.lua", SearchOption.AllDirectories))
            {
                Scripts.Add(Script.LoadFromFile(file));
            }
            foreach (string file in Directory.EnumerateFiles($@"{Config.GameData}\scripts", "*.script", SearchOption.AllDirectories))
            {
                Scripts.Add(Script.LoadFromFile(file, true));
            }

            /*foreach (GameObject @object in GameObjects)
            {
                if (@object.Components[0].ComponentName == "LogicComponent")
                {
                    Classes.Components.LogicComponent logicComponent = (Classes.Components.LogicComponent)@object.Components[0];
                    if (logicComponent.Type == "Auto")
                    {

                    }
                }
            }*/

            Clock DeltaClock = new Clock(); float lastTime = 0;
            while (RenderWindow.IsOpen) //While the window is open, while is called
            {
                Config.DeltaTime = DeltaClock.Restart().AsSeconds(); Config.FramesPerSecond = Convert.ToInt32(1.0f / (Config.DeltaTime - lastTime));
                Scripting.Script.Globals["DeltaTime"] = Config.DeltaTime; Scripting.Script.Globals["FPS"] = Config.FramesPerSecond;

                RenderWindow.DispatchEvents();
                RenderWindow.Clear();


                foreach (Script script in Scripts)
                {
                    #pragma warning disable
                    if(script.Update != null)
                        script.Update.Call(script);
                    if (script.Draw != null)
                        script.Draw.Call(script);
                    #pragma warning restore
                }

                foreach (GameObject @object in GameObjects)
                {
                    @object.Update(Config.DeltaTime);
                    RenderWindow.Draw(@object);
                }

                RenderWindow.Display();
            }
        }

        private static void KeyReleased(object? sender, SFML.Window.KeyEventArgs e)
        {
            KeyPress = false;
        }

        private static void KeyPressed(object? sender, SFML.Window.KeyEventArgs e)
        {
            KeyPress = true;
        }

        private static void JoystickDisconnected(object? sender, SFML.Window.JoystickConnectEventArgs e)
        {
            
        }

        private static void JoystickConnected(object? sender, SFML.Window.JoystickConnectEventArgs e)
        {
            
        }
    }
}
