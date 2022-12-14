using System;
using System.Collections.Generic;
using System.IO;
//SFML
using SFML.Graphics;
//Newtonsoft
using Newtonsoft.Json;
//MickeyEngine
using Mickey_Engine.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using Mickey_Engine.Classes.Draw;

namespace Mickey_Engine.Classes
{
    public class CharacterSprite
    {
        public string Name { get; set; }
        public Sprite Sprite { get; set; }
        public Animations Animations { get; set; }

        public CharacterSprite(string Name, Sprite Sprite)
        {
            this.Name = Name;
            this.Sprite = Sprite;
            //Animations.Start(Sprite);
        }
    }

    public class Character
    {
        public string UUID { get; set; }
        public string Name { get; set; }
        public Actions.Sprite.Action Action { get; set; }

        public List<CharacterSprite> Sprites = new List<CharacterSprite>();

        public Character(string UUID, string Name, Actions.Sprite.Action Action = Actions.Sprite.Action.None)
        {
            this.UUID = UUID;
            this.Name = Name;
            this.Action = Action;
        }
    }

    public class CharactersManager
    {
        public static void LoadAll()
        {
            Console.WriteLine();
            var result = Directory.EnumerateFiles($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Characters/", "*.json");
            foreach (var m in result)
            {
                string allData = File.ReadAllText(m);
                dynamic jsonData = JsonConvert.DeserializeObject(allData);

                Debug.Log($"Creating a new character, please wait...", ConsoleColor.Cyan);

                string characterUUID = jsonData["Character"].UUID, characterName = jsonData["Character"].Name, characterFolder = jsonData["Character"].Folder;
                Program.Characters.Add(new Character(characterUUID, characterName));

                foreach (var data in jsonData["Sprite"])
                {
                    string spriteName = data.Name, spriteFile = data.File; Sprite characterSprite = new Sprite(new Texture($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Characters/{characterFolder}/{spriteFile}"));
                    Program.Characters.Find(character => character.UUID == characterUUID).Sprites.Add(new CharacterSprite(spriteName, characterSprite));
                }
            }
        }
    }
}
