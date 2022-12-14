using System;
using System.Collections.Generic;
using System.IO;
//MickeyEngine
using Mickey_Engine.Functions;
//Newtonsoft
using Newtonsoft.Json;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine.Classes.Draw
{
    public class Menu
    {
        private Sprite Background; public List<Classes.Menu.Image> Sprites = new List<Classes.Menu.Image>(); public List<Classes.Menu.Text> Texts = new List<Classes.Menu.Text>();
        private string CharacterUUID, CharacterSprite; private bool CharacterVisible = false;

        public Menu(string file = "MainMenu.json")
        {
            Console.WriteLine();
            string allData = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Menu/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData, Special.JSON.Settings.JsonSettings);

            Debug.Log($"Loading a new menu, please wait...", ConsoleColor.Magenta);

            //Menu Settings
            string backgroundName = jsonData["Settings"].Background, musicUUID = jsonData["Settings"].Music;
            if (backgroundName != "[None]" || backgroundName != "[none]")
                Background = new Sprite(new Texture(Program.Images.Find(image => image.Name == backgroundName).Image));
            else
                Background = new Sprite(new Texture(1, 1));

            foreach (var data in jsonData["Settings"].Images)
            {
                Sprites.Add(new Classes.Menu.Image(Convert.ToString(data.Name), Actions.Sprite.Convert(Convert.ToString(data.Action)), Convert.ToBoolean(data.Visible)));
            }

            if (musicUUID != null)
                Program.Musics.Find(music => music.UUID == musicUUID).PlayMusic();

            //Menu Text
            foreach (var data in jsonData["Text"])
            {
                string textUUID = data.UUID, textTempString = data.Text, textTempPosition = data.Position, textTempFont = data.Font, TextColor = data.Color, textAction = data.Action; bool textVisible = data.Visible;
                string[] textFont = textTempFont.Replace(" ", null).Split(','), textPosition = textTempPosition.Replace(" ", null).Split(',');
                Text textString = new Text(textTempString, Program.Fonts.Find(font => font.Name == textFont[0]).Font, Convert.ToUInt32(textFont[1]));
                if (TextColor != null) textString.FillColor = Special.GetColor.GetSFMLColor(TextColor);
                textString.Position = new Vector2f(Convert.ToSingle(textPosition[0]), Convert.ToSingle(textPosition[1]));
                Texts.Add(new Classes.Menu.Text(textUUID, textString, textVisible, Action: Actions.Button.Convert(textAction)));
            }

            //Menu Button
            foreach (var data in jsonData["Button"])
            {
                string buttonUUID = data.UUID, buttonTempString = data.Text, buttonTempPosition = data.Position, buttonTempFont = data.Font, buttonAction = data.Action; bool buttonVisible = data.Visible;
                string[] buttonFont = buttonTempFont.Replace(" ", null).Split(','), buttonPosition = buttonTempPosition.Replace(" ", null).Split(',');
                Text buttonString = new Text(buttonTempString, Program.Fonts.Find(font => font.Name == buttonFont[0]).Font, Convert.ToUInt32(buttonFont[1]));
                buttonString.Position = new Vector2f(Convert.ToSingle(buttonPosition[0]), Convert.ToSingle(buttonPosition[1]));
                Texts.Add(new Classes.Menu.Text(buttonUUID, buttonString, buttonVisible, true, Actions.Button.Convert(buttonAction)));
            }

            //Menu Character
            string characterUUID = jsonData["Character"].UUID, characterSprite = jsonData["Character"].Sprite, characterTempPosition = jsonData["Character"].Position, characterTempScale = jsonData["Character"].Scale, characterAction = jsonData["Character"].Action; bool characterVisible = jsonData["Character"].Visible;
            string[] characterPosition = characterTempPosition.Replace(" ", null).Split(','), characterScale = characterTempScale.Replace(" ", null).Split(';');
            Program.Characters.Find(character => character.UUID == characterUUID).Action = Actions.Sprite.Convert(characterAction);
            Program.Characters.Find(character => character.UUID == characterUUID).Sprites.Find(sprite => sprite.Name == characterSprite).Sprite.Position = new Vector2f(Convert.ToSingle(characterPosition[0]), Convert.ToSingle(characterPosition[1]));
            Program.Characters.Find(character => character.UUID == characterUUID).Sprites.Find(sprite => sprite.Name == characterSprite).Sprite.Scale = new Vector2f(Convert.ToSingle(characterScale[0]), Convert.ToSingle(characterScale[1]));
            CharacterUUID = characterUUID; CharacterSprite = characterSprite; CharacterVisible = characterVisible;
        }

        public void Update()
        {
            for (int i = 0; i < Texts.Count; i++)
            {
                Texts[i].HoverCheck();
            }

            for (int i = 0; i < Sprites.Count; i++)
            {
                Sprites[i].Update();
            }

            if(CharacterUUID != null && CharacterVisible)
            {

            }
        }

        public void Draw()
        {
            Program.Window.Draw(Background);
            for (int i = 0; i < Sprites.Count; i++)
            {
                Program.Window.Draw(Sprites[i].Sprite);
            }

            if (CharacterUUID != null && CharacterVisible)
            {
                Program.Window.Draw(Program.Characters.Find(character => character.UUID == CharacterUUID).Sprites.Find(sprite => sprite.Name == CharacterSprite).Sprite);
            }

            for (int i = 0; i < Texts.Count; i++)
            {
                if (Texts[i].Visible)
                    Program.Window.Draw(Texts[i].String);
            }
        }
    }
}
