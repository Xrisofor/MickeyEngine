using System;
//Newtonsoft.Json
using Newtonsoft.Json;
//Mickey_Engine
using Mickey_Engine.Functions;

namespace Mickey_Engine.Special
{
    public class Translation
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Translation(string Name, string Text)
        {
            this.Name = Name;
            this.Text = Text;
        }
    }

    public class TranslationManager
    {
        public static void LoadTranslations(string file)
        {
            Console.WriteLine();
            string allData = System.IO.File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Localization/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Magenta);

            foreach (var data in jsonData["Localization"])
            {
                string textName = data.Name, textString = data.Text;

                Program.Translations.Add(new Translation(textName, textString));
            }

            Debug.Log($"╚ Completion reading the text from the translation file", ConsoleColor.Magenta);
        }
    }
}
