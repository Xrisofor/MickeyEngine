using System;
using System.Collections.Generic;
//SFML
using SFML.Graphics;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game fonts
    /// </summary>
    public class Fonts
    {
        /// <summary>
        /// Font code name
        /// </summary>
        public string name;
        /// <summary>
        /// Font
        /// </summary>
        public Font font;
        /// <summary>
        /// Font character size
        /// </summary>
        public uint character_size;

        /// <summary>
        /// Creating a new font
        /// </summary>
        /// <param name="_name">Font code name</param>
        /// <param name="_font">Font</param>
        /// <param name="_character_size">Font character size</param>
        public Fonts(string _name, Font _font, uint _character_size)
        {
            name = _name;
            font = _font;
            character_size = _character_size;
        }

        /// <summary>
        /// Font ID return function
        /// </summary>
        /// <returns>Font ID</returns>
        public int GetID()
        {
            return GetHashCode();
        }
    }
}
