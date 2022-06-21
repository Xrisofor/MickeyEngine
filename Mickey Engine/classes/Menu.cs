using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
//SFML
using SFML.Graphics;
using SFML.System;
//Newtonsoft.Json
using Newtonsoft.Json;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game menus
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Menu code name
        /// </summary>
        public string code_name;
        /// <summary>
        /// Show cursor when menu starts
        /// </summary>
        public bool showCursor = true;
        /// <summary>
        /// Is the main menu
        /// </summary>
        public bool primaryMenu = false;

        /// <summary>
        /// Variable class for storing menu objects
        /// </summary>
        public List<Objects> menuObj = new List<Objects>();

        /// <summary>
        /// Creating a new menu
        /// </summary>
        /// <param name="code_name">Menu code name</param>
        /// <param name="showCursor">Show cursor when menu starts</param>
        /// <param name="primaryMenu">Is the main menu</param>
        public Menu(string code_name, bool showCursor = true, bool primaryMenu = false)
        {
            this.code_name = code_name;
            this.showCursor = showCursor;
            this.primaryMenu = primaryMenu;
        }

        /// <summary>
        /// Function for processing and displaying menus
        /// </summary>
        public void Show(RenderWindow window)
        {
            GetObjects();
            window.SetMouseCursorVisible(showCursor);
        }

        /// <summary>
        /// Parsing an object class from a json file
        /// </summary>
        /// <param name="path">The path to the json file with the menu files</param>
        /// <param name="archive">Variable for working with files from the archive</param>
        public void GetObjects(string path = "data/menu/main.json", bool archive = false)
        {
            string json;
            if (archive)
            {
                MemoryStream mFile = Archive.GetFile(path);
                using (StreamReader sr = new StreamReader(mFile))
                {
                    json = sr.ReadToEnd();
                }
            }
            else
            {
                json = File.ReadAllText(Environment.CurrentDirectory + $"/../{path}");
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData["objects"])
            {
                string code_name = data.code_name, fnt = data.font, color = data.color, position = data.position, visible = data.visible, type = data.type, text = data.text, img = data.image;
                string[] pos = position.Replace(" ", "").Split(',');
                float posX = 0, posY = 0;

                menuObj.Add(new Objects(code_name, type));

                if (pos[0] != "[center]")
                    posX = Convert.ToSingle(pos[0]);
                else
                    posX = Convert.ToSingle(Convert.ToInt32(Program.window.Size.X) / 2.4);
                if (pos[1] != "[center]")
                    posY = Convert.ToSingle(pos[1]);
                else
                    posY = Convert.ToSingle(Convert.ToInt32(Program.window.Size.Y) / 2.4);

                if(text != null)
                {
                    if (text.Contains("[game_name]"))
                        text = text.Replace("[game_name]", Program.config.title);
                    if (text.Contains("[game_version]"))
                        text = text.Replace("[game_version]", Assembly.GetExecutingAssembly().GetName().Version.ToString());
                } 

                for (int i = 0; i < menuObj.Count; i++)
                {
                    if (menuObj.Find(item => item.name == code_name).type == "sprite")
                    {
                        menuObj.Find(item => item.name == code_name).sprite.Position = new Vector2f(posX, posY);
                        if (img != null)
                            menuObj.Find(item => item.name == code_name).sprite.Texture = new Texture(Program.images.Find(item => item.name == img).image);
                        else
                        {
                            string[] cl = { "0", "0", "0", "0" };
                            menuObj.Find(item => item.name == code_name).sprite.Texture = new Texture(new Image(1, 1, Parse.getColor(cl)));
                        }
                    }
                    else if (menuObj.Find(item => item.name == code_name).type == "text")
                    {
                        string[] col = color.Replace(" ", "").Split(',');
                        menuObj.Find(item => item.name == code_name).text.Position = new Vector2f(posX, posY);
                        menuObj.Find(item => item.name == code_name).text.FillColor = Parse.getColor(col);
                        Fonts font = Program.fonts.Find(item => item.name == fnt);
                        menuObj.Find(item => item.name == code_name).text.Font = font.font;
                        menuObj.Find(item => item.name == code_name).text.CharacterSize = font.character_size;
                        menuObj.Find(item => item.name == code_name).text.DisplayedString = text;
                    }

                    menuObj.Find(item => item.name == code_name).visible = Convert.ToBoolean(visible);
                }
            }
        }
    }
}
