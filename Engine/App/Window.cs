using Engine.Classes;
using Engine.Tools;
using SFML.Graphics;
using SFML.System;
using System.Security.Cryptography.X509Certificates;

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

        //Initializing the rendering window
        public static void Init()
        {
            RenderWindow = new RenderWindow(Config.VideoMode, Config.Title, Config.WindowStyle);
            RenderWindow.Closed += (s, e) => { RenderWindow.Close(); }; //Window closing event
            #pragma warning disable
            RenderWindow.MouseButtonPressed += (s, e) => { Dialog.NextLine(); }; //Keyboard tapping event
            #pragma warning restore
            RenderWindow.SetVerticalSyncEnabled(Config.VerticalSync);
            RenderWindow.SetFramerateLimit(Config.FramerateLimit);
            if(Config.WindowIcon != null)
                RenderWindow.SetIcon(Config.WindowIcon.Size.X, Config.WindowIcon.Size.Y, Config.WindowIcon.Pixels);

            //Search for all scripts (temporarily out of service
            //foreach (string file in Directory.EnumerateFiles($@"{Config.GameData}\scripts", "*.lua", SearchOption.AllDirectories))
            //{
            //Scripts.Add(Script.LoadFromFile(file));
            //}
            //foreach (string file in Directory.EnumerateFiles($@"{Config.GameData}\scripts", "*.script", SearchOption.AllDirectories))
            //{
            //Scripts.Add(Script.LoadFromFile(file, true));
            //}

            Map.LoadMap(Config.StartMap, false);

            //GameObject player = new GameObject(TexturePath: "$GAME_DATA/resource/mickey_normal.png");
            //player.Scale = new Vector2f(0.2f, 0.2f); player.Position = new Vector2f(100, 100);
            //player.AddComponent(new Classes.Components.PlayerController());
            //GameObjects.Add(player);

            GameObject test = new GameObject("TEventNode"); test.Position = new Vector2f(10, 10);
            test.AddComponent(new Classes.Components.EventNode(EventNodeType.Trigger, new List<NodeClass>() { new NodeClass(EventType.LoadMap, "$GAME_DATA/maps/NewMap2.mickeymap") }));
            GameObjects.Add(test);

            GameObject testb = new GameObject("BEventNode"); testb.Position = new Vector2f(400, 10);
            testb.AddComponent(new Classes.Components.EventNode(EventNodeType.Branch, new List<NodeClass>() { new NodeClass(EventType.LoadMap, "$GAME_DATA/maps/NewMap2.mickeymap") }));
            GameObjects.Add(testb);

            GameObject test2 = new GameObject("EventNode"); test2.Position = new Vector2f(200, 10);
            List<NodeClass> testNodeClass = new List<NodeClass>();
            testNodeClass.Add(new NodeClass(EventType.SetWindowIcon, "$GAME_DATA/resource/PAh03XDFGfM.jpg")); testNodeClass.Add(new NodeClass(EventType.SetWindowTitle, "Hello"));
            testNodeClass.Add(new NodeClass(EventType.SetVisible, "EventNode", "false")); testNodeClass.Add(new NodeClass(EventType.SetPosition, "Love", "400,5; 555,5")); testNodeClass.Add(new NodeClass(EventType.SetRotation, "Love", "90"));
            testNodeClass.Add(new NodeClass(EventType.SetCollision, "Love", "true"));
            test2.AddComponent(new Classes.Components.EventNode(EventNodeType.Trigger, testNodeClass)); 
            GameObjects.Add(test2);

            Clock DeltaClock = new Clock(); float lastTime = 0;
            while (RenderWindow.IsOpen) //While the window is open, while is called
            {
                Config.DeltaTime = DeltaClock.Restart().AsSeconds(); Config.FramesPerSecond = Convert.ToInt32(1.0f / (Config.DeltaTime - lastTime));
                Scripting.Script.Globals["DeltaTime"] = Config.DeltaTime; Scripting.Script.Globals["FPS"] = Config.FramesPerSecond;

                RenderWindow.DispatchEvents();
                RenderWindow.Clear();

                //foreach (Script script in Scripts)
                //{
                    //#pragma warning disable
                    //if(script.Update != null)
                        //script.Update.Call(script);
                    //if (script.Draw != null)
                        //script.Draw.Call(script);
                    //#pragma warning restore
                //}


                foreach (GameObject @object in GameObjects)
                {
                    @object.Update(Config.DeltaTime);
                    RenderWindow.Draw(@object);
                }

                RenderWindow.Display();
            }
        }
    }
}
