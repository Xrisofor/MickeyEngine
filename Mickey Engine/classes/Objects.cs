using System;
using System.Collections.Generic;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game objects
    /// </summary>
    public class Objects
    {
        /// <summary>
        /// The code name of the object with which it can be drawn or changed (English letters only!)
        /// </summary>
        public string name;
        /// <summary>
        /// The type of object with which can understand how to draw it correctly (there are currently sprites and text)
        /// </summary>
        public string type;
        /// <summary>
        /// The variable responsible for the visibility of the object
        /// </summary>
        public bool visible;
        /// <summary>
        /// Object Sprite
        /// </summary>
        public Sprite sprite;
        /// <summary>
        /// Object Text
        /// </summary>
        public Text text;
        /// <summary>
        /// Transparency of the object for animation effects (Initial value 255 - opaque, 0 - transparent)
        /// </summary>
        public int transparency = 255;

        /// <summary>
        /// Creating a new object
        /// </summary>
        /// <param name="_name">The code name of the object with which it can be drawn or changed (English letters only!)</param>
        /// <param name="_type">The type of object with which can understand how to draw it correctly (there are currently sprites and text)</param>
        /// <param name="_visible">The variable responsible for the visibility of the object</param>
        public Objects(string _name, string _type = "sprite", bool _visible = true)
        {
            Debug.Log($"Creating the {_name} object");
            name = _name;
            type = _type;
            visible = _visible;
            if (_type == "sprite")
            {
                sprite = new Sprite();
            }
            else if (_type == "text")
            {
                text = new Text();
            }
        }

        /// <summary>
        /// Object ID return function
        /// </summary>
        /// <returns>Object ID</returns>
        public int GetID()
        {
            return GetHashCode();
        }
    }
}
