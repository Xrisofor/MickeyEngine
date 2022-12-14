using System;
//Newtonsoft
using Newtonsoft.Json;
//MickeyEngine
using Mickey_Engine.Functions;

namespace Mickey_Engine.Special
{
    public class Language
    {
        public string CodeName;
        public string Name;
        public string File;
        public string ArrayName;

        public Language(string CodeName, string Name, string File)
        {
            this.CodeName = CodeName;
            this.Name = Name;
            this.File = File;
        }
    }

    public class LanguageManager
    {
        public delegate void OnChangeLanguage();

        public static event OnChangeLanguage Translation;

        public static void LoadLanguage(string file = "Language.json")
        {
            Console.WriteLine();
            string allData = System.IO.File.ReadAllText($"{Environment.CurrentDirectory}/../Data/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Magenta);

            foreach (var data in jsonData["Language"])
            {
                string codeName = data.CodeName, name = data.Name, langFile = data.File;

                if (langFile != String.Empty)
                {
                    Program.Languages.Add(new Language(codeName, name, langFile));
                    Debug.Log($"║ Creating a new translation ({name})", ConsoleColor.Magenta);
                }
            }

            Debug.Log($"╚ Completing the creation of translations", ConsoleColor.Magenta);
        }

        public static void ChangeLanguage()
        {
            Program.Translations.Clear();
            TranslationManager.LoadTranslations(Program.Languages.Find(item => item.CodeName == Program.Config.Language).File);
            if(!Program.FirstLaunch)
                Translation();
        }
    }
}
