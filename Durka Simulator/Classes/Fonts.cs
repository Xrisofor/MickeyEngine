using System;
using System.IO;
//SFML
using SFML.Graphics;
//Newtonsoft
using Newtonsoft.Json;
//MickeyEngine
using Mickey_Engine.Functions;

namespace Mickey_Engine.Classes
{
    public class FontsManager
    {
        public static void LoadFonts(string file = "Fonts.json")
        {
            Console.WriteLine();
            string allData = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.White);

            foreach (var data in jsonData["Fonts"])
            {
                string fontName = data.Name, fontFile = data.Font;
                Font font = new Font(Environment.CurrentDirectory + $"/../Data/Gui/Fonts/{fontFile}");
                Program.Fonts.Add(new Fonts(fontName, font));
                Debug.Log($"║ Creating a new font: {fontName}", ConsoleColor.White);
            }

            Debug.Log($"╚ Completing the creation of new fonts", ConsoleColor.White);
        }
    }

    public class Fonts
    {
        public string Name { get; set; }
        public Font Font { get; set; }

        public Fonts(string Name, Font Font)
        {
            this.Name = Name;
            this.Font = Font;
        }
    }
}
