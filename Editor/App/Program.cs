using SFML.System;
using Newtonsoft.Json;
using Engine;

namespace Editor.App
{
    public class Program
    {
        public static Inspector Form = new Inspector();
        public static Editor Form2 = new Editor();
        public static Window Window;
        public static Grid EditorGrid = new Grid();

        public static bool ShowGrid = true;

        public static SFML.Graphics.Font EditorFont = new SFML.Graphics.Font(ImageList.arial);

        [STAThread]
        static void Main(string[] args)
        {
            Window = new Window();

            Arguments.Init(args);

            Form.StartPosition = FormStartPosition.Manual;
            Form2.StartPosition = FormStartPosition.Manual;
            Form.Location = new Point(Window.Position.X + (int)Window.Size.X, Window.Position.Y);
            Form2.Location = new Point(Window.Position.X - Form2.Width, Window.Position.Y);

            Engine.Program.IsEditor = true;

            Form.Show();
            Form2.Show();

            Clock DeltaClock = new Clock();
            while (Window.IsOpen)
            {
                float DeltaTime = DeltaClock.Restart().AsSeconds();
                Window.DispatchEvents();

                Window.Clear();

                //RectangleShape rectangleShape = new RectangleShape(new Vector2f(800, 800));
                //rectangleShape.OutlineThickness = 2;
                //rectangleShape.OutlineColor = SFML.Graphics.Color.Green;
                //rectangleShape.FillColor = SFML.Graphics.Color.Transparent;

                //Window.Draw(rectangleShape);

                foreach (GameObject GameObjects in Form2.GameObjects)
                {
                    GameObjects.Update(DeltaTime);

                    if (GameObjects.Visible && GameObjects.Sprite.Texture != null)
                        Window.Draw(GameObjects);
                    if(GameObjects.Visible && GameObjects.Components.Length != 0) 
                        if(GameObjects.Components[0].ComponentName == "GUIText" || GameObjects.Visible && GameObjects.Components[0].ComponentName == "Prefab")
                            Window.Draw(GameObjects);
                }

                if (ShowGrid)
                    Window.Draw(EditorGrid);

                Window.Display();
            }
            
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());
        }
    }
}