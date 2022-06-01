using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//SFML
using SFML.Graphics;
using SFML.System;
//Newtonsoft.Json
using Newtonsoft.Json;
using  Newtonsoft.Json.Linq;

namespace Mickey_Engine
{
    /// <summary>
    /// File processing class
    /// </summary>
    public class Parse
    {
        /// <summary>
        /// Parsing an object class from a json file
        /// </summary>
        /// <param name="array_name">Name of the array of objects (non-optional parameter)</param>
        /// <param name="path">The path to the json file with the objects files</param>
        /// <param name="archive">Variable for working with files from the archive</param>
        [Obsolete]
        public static void objectList(string path = "data/json/objects.json", string array_name = "objects", bool archive = false)
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
                json = File.ReadAllText(Environment.CurrentDirectory + $"/{path}");
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData[array_name])
            {
                string name = data.name, fnt = data.font, color = data.color, position = data.position, visible = data.visible;
                string[] pos = position.Replace(" ", "").Split(','); //The position of the object in the form of a text format
                float posX = 0, posY = 0; //The position of the object in the form of non-integers

                //Processing keywords in object positions
                if (pos[0] != "[center]")
                {
                    posX = Convert.ToSingle(pos[0]);
                }
                else
                {
                    posX = Convert.ToSingle(Convert.ToInt32(Program.window.Size.X) / 2.4);
                }
                if (pos[1] != "[center]")
                {
                    posY = Convert.ToSingle(pos[1]);
                }
                else
                {
                    posY = Convert.ToSingle(Convert.ToInt32(Program.window.Size.Y) / 2.4);
                }

                for(int i = 0; i < Program.objects.Count; i++)
                {
                    if(Program.objects.Find(item => item.name == name).type == "sprite")
                    {
                        Program.objects.Find(item => item.name == name).sprite.Position = new Vector2f(posX, posY);
                    }
                    else if (Program.objects.Find(item => item.name == name).type == "text")
                    {
                        string[] col = color.Replace(" ", "").Split(',');
                        Program.objects.Find(item => item.name == name).text.Position = new Vector2f(posX, posY);
                        Program.objects.Find(item => item.name == name).text.Color = getColor(col);
                        Fonts font = Program.fonts.Find(item => item.name == fnt);
                        Program.objects.Find(item => item.name == name).text.Font = font.font;
                        Program.objects.Find(item => item.name == name).text.CharacterSize = font.character_size;
                    }

                    Program.objects.Find(item => item.name == name).visible = Convert.ToBoolean(visible);
                }
            }
        }

        /// <summary>
        /// Parsing a class of images from a json file
        /// </summary>
        /// <param name="array_name">Name of the array of images (non-optional parameter)</param>
        /// <param name="path">The path to the json file with the images files</param>
        /// <param name="archive">Variable for working with files from the archive</param>
        public static void imagesList(string path = "data/json/images.json", string array_name = "images", bool archive = false)
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
                json = File.ReadAllText(Environment.CurrentDirectory + $"/{path}");
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData[array_name])
            {
                string name = data.name, img = data.image;
                bool archive_bl = Convert.ToBoolean(data.archive);
                Image image;

                if (archive_bl)
                {
                    MemoryStream mStream = Archive.GetFile(img);
                    image = new Image(mStream);
                }
                else
                {
                    image = new Image(Environment.CurrentDirectory + $"/{img}");
                }

                Program.images.Add(new Images(name, image));

                if (name == "textbox")
                {
                    Program.objects.Find(item => item.name == "textbox").sprite.Texture = new Texture(Program.images.Find(item => item.name == "textbox").image);
                }
            }
        }

        /// <summary>
        /// Parsing a class of fonts from a json file
        /// </summary>
        /// <param name="array_name">Name of the array of fonts (non-optional parameter)</param>
        /// <param name="path">The path to the json file with the fonts files</param>
        /// <param name="archive">Variable for working with files from the archive</param>
        public static void fontsList(string path = "data/json/fonts.json", string array_name = "fonts", bool archive = false)
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
                json = File.ReadAllText(Environment.CurrentDirectory + $"/{path}");
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData[array_name])
            {
                string name = data.name;
                bool archive_bl = Convert.ToBoolean(data.archive);
                string src = data.src;
                uint carSize = Convert.ToUInt32(data.character_size);

                if (archive_bl)
                {
                    MemoryStream mStream = Archive.GetFile(src);
                    Font font = new Font(mStream);
                    Program.fonts.Add(new Fonts(name, font, carSize));
                }
                else
                {
                    Font font = new Font(src);
                    Program.fonts.Add(new Fonts(name, font, carSize));
                }
            }
        }

        private static Image oldBackground;

        /// <summary>
        /// Parsing a class of dialogs from a json file
        /// </summary>
        /// <param name="path">The path to the dialog file</param>
        /// <param name="array_name">Name of the array of dialogs (non-optional parameter)</param>
        /// <param name="archive">Variable for working with files from the archive</param>
        public static void dialogsList(string path, string array_name = "dialog", bool archive = false)
        {
            string json;
            if (archive)
            {
                MemoryStream mFile = Archive.GetFile(path);
                using (StreamReader sr = new StreamReader(mFile, Encoding.Default))
                {
                    json = sr.ReadToEnd();
                }
            }
            else
            {
                json = File.ReadAllText(Environment.CurrentDirectory + $"/{path}", Encoding.Default);
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData[array_name])
            {
                string code_name = data.code_name, name = data.name, text = data.text, img = data.image, pos = data.position, backgr = data.background;
                bool imgClass = false, backClass = false;
                Image image = new Image(1, 1), background = new Image(1, 1);
                JArray ch = data.choice;

                for (int i = 0; i < Program.images.Count; i++)
                {
                    if(img == $"{Program.images[i].name}")
                    {
                        image = Program.images.Find(item => item.name == img).image;
                        imgClass = true;
                        i = Program.images.Count;
                    }
                    else
                    {
                        imgClass = false;
                    }
                }
                if(!imgClass)
                {
                    MemoryStream mStream = Archive.GetFile(img);
                    image = new Image(mStream);
                }

                if(backgr != "[oldvalue]")
                {
                    for (int i = 0; i < Program.images.Count; i++)
                    {
                        if (backgr == $"{Program.images[i].name}")
                        {
                            background = Program.images.Find(item => item.name == backgr).image;
                            backClass = true;
                            i = Program.images.Count;
                        }
                        else
                        {
                            backClass = false;
                        }
                    }
                    if (!backClass)
                    {
                        MemoryStream mStream = Archive.GetFile(backgr);
                        background = new Image(mStream);
                    }

                    oldBackground = background;
                }
                else
                {
                    background = oldBackground;
                }

                List<Choice> choices = new List<Choice>();

                if (ch != null)
                {
                    choices = ((JArray)ch).Select(x => new Choice
                    {
                        text = (string)x["text"],
                        script = (string)x["script"]
                    }).ToList();
                }

                Program.dialogs.Add(new Dialog(code_name, name, text, image, pos, background, choices));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="archive"></param>
        public static void languagesFile(string path, bool archive = false)
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
                json = File.ReadAllText(Environment.CurrentDirectory + $"/{path}");
            }

            dynamic jsonData = JsonConvert.DeserializeObject(json);
            foreach (var data in jsonData["language"])
            {
                string code_name = data.code_name, name = data.name, file = data.script, developer = data.developer;
                string[] fl = file.Replace(" ", "").Split(',');

                Program.languages.Add(new Language(code_name, name, fl[0], fl[1], developer));
            }
        }
        

        private static string dialogCharacterLastPos;
        private static List<temp_position> temp_Positions = new List<temp_position>();

        /// <summary>
        /// Maximum text length
        /// </summary>
        public static int max_line_length = 61;

        /// <summary>
        /// Dialog/character processing function
        /// </summary>
        public static void dialog()
        {
            string code_name = Program.dialogs[Program.scriptPos].code_name;
            string name = Program.dialogs[Program.scriptPos].name;
            string text = Program.dialogs[Program.scriptPos].text;
            string pos = Program.dialogs[Program.scriptPos].pos;
            Image img = Program.dialogs[Program.scriptPos].img;
            Image background = Program.dialogs[Program.scriptPos].background;
            List<Choice> choices = Program.dialogs[Program.scriptPos].choices;

            Program.objects.Find(item => item.name == "background").sprite.Texture = new Texture(background);

            if(choices.Count > 0)
            {
                Program.objects.Find(item => item.name == "choice").sprite.Texture = new Texture(Program.images.Find(item => item.name == "choice_idle").image);
            }

            for(int i = 0; i < choices.Count; i++)
            {
                Debug.Log($"Choice: {choices[i].text}");
            }

            if (temp_Positions.Count != 0)
            {
                for (int i = 0; i < temp_Positions.Count; i++)
                {
                    if(temp_Positions[i].code_name == code_name)
                    {
                        dialogCharacterLastPos = temp_Positions.Find(item => item.code_name == code_name).pos;
                    }

                    if (temp_Positions[i].code_name == code_name)
                    {
                        temp_Positions.RemoveAt(i);
                    }
                }

                if (dialogCharacterLastPos != null)
                {
                    if (dialogCharacterLastPos != pos)
                    {
                        string[] cl = { "0", "0", "0", "0" };
                        if (dialogCharacterLastPos == "left")
                        {
                            Program.objects.Find(item => item.name == "left").sprite.Texture = new Texture(new Image(1, 1, getColor(cl)));
                        }
                        else if (dialogCharacterLastPos == "center")
                        {
                            Program.objects.Find(item => item.name == "center").sprite.Texture = new Texture(new Image(1, 1, getColor(cl)));
                        }
                        else if (dialogCharacterLastPos == "right")
                        {
                            Program.objects.Find(item => item.name == "right").sprite.Texture = new Texture(new Image(1, 1, getColor(cl)));
                        }
                    }
                }
            }

            if (pos == "left")
            {
                Program.objects.Find(item => item.name == "left").sprite.Texture = new Texture(img);
            }
            else if (pos == "center")
            {
                Program.objects.Find(item => item.name == "center").sprite.Texture = new Texture(img);
            }
            else if (pos == "right")
            {
                Program.objects.Find(item => item.name == "right").sprite.Texture = new Texture(img);
            }

            Program.objects.Find(item => item.name == "textbox_name").text.DisplayedString = name;
            Program.objects.Find(item => item.name == "textbox_text").text.DisplayedString = "";

            Program.objects.Find(item => item.name == "textbox_text").text.DisplayedString = WrapText(text);

            temp_Positions.Add(new temp_position(code_name, pos));

            Program.scriptPos++;
        }

        /// <summary>
        /// The function of creating a color scheme for SFML by RGBA
        /// </summary>
        /// <param name="cl">RGBA color scheme variable</param>
        /// <returns>Color scheme for SFML</returns>
        /// <example>string[] color = { "255", "255", "255", "255" }
        /// Program.textBoxName.Color = getColor(color);</example>
        public static Color getColor(string[] cl)
        {
            Color color = new Color();

            color.R = Convert.ToByte(cl[0]);
            color.G = Convert.ToByte(cl[1]);
            color.B = Convert.ToByte(cl[2]);
            color.A = Convert.ToByte(cl[3]);

            return color;
        }

        /// <summary>
        /// Text Length Processing
        /// </summary>
        /// <param name="text">The text to be processed</param>
        /// <returns>Text with adding new line separations</returns>
        public static string WrapText(string text)
        {
            string form_string = "";
            int av_len = max_line_length;

            string[] word_arr = text.Trim().Split(' ');

            foreach (string w in word_arr)
            {
                string word = w;
                if (word == "")
                {
                    continue;
                }

                int word_length = word.Length;

                if (word_length >= max_line_length)
                {
                    if (av_len > 0)
                    {
                        form_string += word.Substring(0, av_len) + "\n";
                        word = word.Substring(av_len);
                    }
                    else
                    {
                        form_string += "\n";
                    }
                    word = word + " ";
                    av_len = max_line_length;
                    for (var count = 0; count < word.Length; count++)
                    {
                        char ch = word.ElementAt(count);

                        if (av_len == 0)
                        {
                            form_string += "\n";
                            av_len = max_line_length;
                        }

                        form_string += ch;
                        av_len--;
                    }
                    continue;
                }

                if ((word_length + 1) <= av_len)
                {
                    form_string += word + " ";
                    av_len -= (word_length + 1);
                    continue;
                }
                else
                {
                    av_len = max_line_length;
                    form_string += "\n" + word + " ";
                    av_len -= (word_length + 1);
                    continue;
                }

            }

            return form_string;
        }
    }
}
