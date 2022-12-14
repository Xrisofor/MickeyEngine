using System;
using System.IO;
//SFML
using SFML.Graphics;
//Newtonsoft
using Newtonsoft.Json;
//MickeyEngine
using Mickey_Engine.Functions;
using Mickey_Engine.Classes.Draw;

namespace Mickey_Engine.Classes
{
    public class Images
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public Actions.Sprite.Action Action { get; set; }
        public Animations Animations { get; set; }

        public Images(string Name, Image Image, Actions.Sprite.Action Action = Actions.Sprite.Action.None)
        {
            this.Name = Name;
            this.Image = Image;
            this.Action = Action;
            Animations = new Animations(Action);
        }
    }

    public class ImageManager
    {
        public static void LoadImages(string file = "Images.json")
        {
            Console.WriteLine();
            string allData = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Green);

            foreach (var data in jsonData["Images"])
            {
                string imageName = data.Name, img = data.Image;
                Image image = new Image($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Gui/{img}");
                Program.Images.Add(new Images(imageName, image));
                Debug.Log($"║ Creating a new image: {imageName}", ConsoleColor.Green);
            }

            Debug.Log($"╚ Completing the creation of new images", ConsoleColor.Green);
        }
    }
}
