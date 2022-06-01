using System;
using System.Collections.Generic;
//SFML
using SFML.Graphics;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game dialogs
    /// </summary>
    public class Dialog
    {
        /// <summary>
        /// Character code name
        /// </summary>
        public string code_name;
        /// <summary>
        /// Character Name
        /// </summary>
        public string name;
        /// <summary>
        /// The text that the character says
        /// </summary>
        public string text;
        /// <summary>
        /// Character Sprite
        /// </summary>
        public Image img;
        /// <summary>
        /// Background
        /// </summary>
        public Image background;
        /// <summary>
        /// The position of the character from existing
        /// </summary>
        public string pos;
        /// <summary>
        /// List of all the choices of this dialog
        /// </summary>
        public List<Choice> choices = new List<Choice>();

        /// <summary>
        /// Creating a new dialog/character
        /// </summary>
        /// <param name="_code_name">Character code name</param>
        /// <param name="_name">Character Name</param>
        /// <param name="_text">The text that the character says</param>
        /// <param name="_img">Character Sprite</param>
        /// <param name="_pos">The position of the character from existing</param>
        /// <param name="_background">Background</param>
        /// <param name="_choices">List of all the choices of this dialog</param>
        public Dialog(string _code_name, string _name, string _text, Image _img, string _pos, Image _background, List<Choice> _choices)
        {
            code_name = _code_name;
            name = _name;
            text = _text;
            img = _img;
            pos = _pos;
            background = _background;
            choices = _choices;
        }

        /// <summary>
        /// Dialog ID return function
        /// </summary>
        /// <returns>Dialog ID</returns>
        public int GetID()
        {
            return GetHashCode();
        }
    }
}
