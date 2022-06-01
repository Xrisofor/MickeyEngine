using System;
//SFML
using SFML.System;
using SFML.Graphics;

namespace Mickey_Engine
{
    /// <summary>
    /// Drawing class for elements and animations
    /// </summary>
    public class Drawing
    {
        /// <summary>
        /// Function of drawing objects by name
        /// </summary>
        /// <param name="name">Name of the object from list objects</param>
        public static void Draw(string name)
        {
            if (Program.objects.Find(item => item.name == name).visible)
            {
                if (Program.objects.Find(item => item.name == name).sprite.Texture != null)
                {
                    Program.window.Draw(Program.objects.Find(item => item.name == name).sprite);
                }
            }
        }

        /// <summary>
        /// Function of drawing texts by name
        /// </summary>
        /// <param name="name">Name of the text from the list objects</param>
        public static void DrawText(string name)
        {
            if (Program.objects.Find(item => item.name == name).visible)
            {
                Program.window.Draw(Program.objects.Find(item => item.name == name).text);
            }
        }
    }
}
