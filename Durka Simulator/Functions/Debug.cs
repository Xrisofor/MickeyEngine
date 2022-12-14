using System;
using System.IO;
using System.Runtime.InteropServices;
//SFML
using SFML.Graphics;

namespace Mickey_Engine.Functions
{
    public class Debug
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static int FPS_Counter { get; set; }
        public static Text FPS_Text { get; set; }

        public static void Log(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"[Mickey Engine] {text}");
        }

        public static void LogWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] {text}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(string message, string data = "Null", string source = "Null", bool logFile = true)
        {
            if (logFile)
            {
                if (!File.Exists(Environment.CurrentDirectory + $"/log.txt"))
                {
                    File.Create(Environment.CurrentDirectory + $"/log.txt").Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + $"/log.txt", $"[ERROR] {message}\n[ERROR DARA] {data}\n[ERROR SOURCE] {source}\nThe error was detected {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} in {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {message}");
            Console.WriteLine($"[ERROR DARA] {data}");
            Console.WriteLine($"[ERROR SOURCE] {source}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[Console] Press any key to exit the program");
            Console.ReadKey();
        }

        public static void ConsoleState()
        {
            var handle = GetConsoleWindow();
            if (!Program.Config.Console)
                ShowWindow(handle, 0);
        }
    }
}
