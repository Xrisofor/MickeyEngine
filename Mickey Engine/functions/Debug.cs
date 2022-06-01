using System;
using System.IO;
using System.Text;


namespace Mickey_Engine
{
    /// <summary>
    /// Application Debugger class
    /// </summary>
    public class Debug
    {
        /// <summary>
        /// Variable number of frames per second in the game
        /// </summary>
        public static int fps_count;

        /// <summary>
        /// Text output to the console using Console.WriteLine
        /// </summary>
        /// <param name="text">Messages to output to the console</param>
        /// <param name="color">Text color for all messages in the console (optional parameter)</param>
        public static void Log(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"[Engine] {text}");
        }

        /// <summary>
        /// Error text output to the console using Console.WriteLine
        /// </summary>
        /// <param name="message">Error messages to output to the console</param>
        /// <param name="data">Error in function/application data</param>
        /// <param name="source">Error Class/Library</param>
        /// <param name="logFile">Error file creation variable (enabled by default)</param>
        public static void Error(string message, string data = "Null", string source = "Null", bool logFile = true)
        {
            if(logFile)
            {
                if (!File.Exists(Environment.CurrentDirectory + $"/log.txt"))
                {
                    File.Create(Environment.CurrentDirectory + $"/log.txt").Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + $"/log.txt", $"[ERROR] {message}\n[ERROR DATA] {data}\n[ERROR SOURCE] {source}\nThe error was found {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} in {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {message}");
            Console.WriteLine($"[ERROR DATA] {data}");
            Console.WriteLine($"[ERROR SOURCE] {source}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[Console] Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
