using System;
//SFML
using SFML.Graphics;

namespace Mickey_Engine.classes
{
    public class Menu
    {
        public string code_name;
        public string type;
        public Sprite sprite;
        public Text text;
        public bool visible = true;

        public Menu(string _code_name, string _type)
        {
            code_name = _code_name;
            type = _type;
        }
    }
}
