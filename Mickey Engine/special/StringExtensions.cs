using System;
using System.Text;

namespace Mickey_Engine
{
    /// <summary>
    /// String Extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Text encoding changes
        /// </summary>
        /// <param name="text">The text to be changed</param>
        /// <returns>Text with a new encoding</returns>
        public static string ToUTF8(this string text)
        {
            return Encoding.UTF8.GetString(Encoding.Default.GetBytes(text));
        }
    }
}
