using System;
using System.Collections.Generic;
//SFML
using SFML.Graphics;

namespace Mickey_Engine
{
    /// <summary>
    /// Temporary variable class for storing game positions of characters
    /// </summary>
    public class temp_position
    {
        /// <summary>
        /// Character code name
        /// </summary>
        public string code_name;
        /// <summary>
        /// Position (left, center, right)
        /// </summary>
        public string pos;

        /// <summary>
        /// Creating a new temporary position
        /// </summary>
        /// <param name="_code_name">Character code name</param>
        /// <param name="_pos">Position (left, center, right)</param>
        public temp_position(string _code_name, string _pos)
        {
            code_name = _code_name;
            pos = _pos;
        }
    }
}
