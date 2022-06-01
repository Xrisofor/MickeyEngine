using System;

namespace Mickey_Engine
{
    /// <summary>
    /// The main class for storing/processing languages
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Language code name
        /// </summary>
        public string code_name;
        /// <summary>
        /// Language name
        /// </summary>
        public string name;
        /// <summary>
        /// Path to the script file
        /// </summary>
        public string script;
        /// <summary>
        /// Name of the dialog array
        /// </summary>
        public string array_name;
        /// <summary>
        /// Language Developer
        /// </summary>
        public string developer;

        /// <summary>
        /// Creating a new language
        /// </summary>
        /// <param name="_code_name">Language code name</param>
        /// <param name="_name">Language name</param>
        /// <param name="_script">Path to the script file</param>
        /// <param name="_array_name">Name of the dialog array</param>
        /// <param name="_developer">Language Developer</param>
        public Language(string _code_name, string _name, string _script, string _array_name, string _developer)
        {
            code_name = _code_name;
            name = _name;
            script = _script;
            array_name = _array_name;
            developer = _developer;
        }
    }
}
