using System;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game images
    /// </summary>
    public class Images
    {
        /// <summary>
        /// Image code name
        /// </summary>
        public string name;
        /// <summary>
        /// Image
        /// </summary>
        public Image image;

        /// <summary>
        /// Creating a new image
        /// </summary>
        /// <param name="_name">Image code name</param>
        /// <param name="_image">Image</param>
        public Images(string _name, Image _image)
        {
            name = _name;
            image = _image;
        }
    }
}
