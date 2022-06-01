using System;
//SFML
using SFML.Window;

namespace Mickey_Engine
{
    /// <summary>
    /// Application configuration class
    /// </summary>
    public class Config
    {
        //VideoMode classes variables
        /// <summary>
        /// Application Window Text
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// Width of the application window
        /// </summary>
        public uint width { get; set; }
        /// <summary>
        /// Height of the application window
        /// </summary>
        public uint height { get; set; }
        /// <summary>
        /// Game window style (default/fullscreen mode)
        /// </summary>
        public Styles style { get; set; } = Styles.Default;
        /// <summary>
        /// The path to the icon file from the configuration file
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// Vertical synchronization addition variable
        /// </summary>
        public bool vertical_sync { get; set; }

        //Engine classes variables
        /// <summary>
        /// Console window display variable
        /// </summary>
        public bool console { get; set; }
        /// <summary>
        /// The path to the archive file from the configuration file
        /// </summary>
        public string archive { get; set; }
        /// <summary>
        /// Interface language
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// The path to saving the game files
        /// </summary>
        public string saving_path { get; set; }
        /// <summary>
        /// Variable frame limit per second
        /// </summary>
        public uint fps_limit { get; set; } = 60;
    }
}
