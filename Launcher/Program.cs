using System;
using System.Diagnostics;

namespace Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arg = String.Join("", args);

            ProcessStartInfo processStart = new ProcessStartInfo($"{Environment.CurrentDirectory}/Release/Mickey Engine.exe");
            processStart.WorkingDirectory = $"{Environment.CurrentDirectory}/Release/";
            processStart.Arguments = arg;
            Process.Start(processStart);
        }
    }
}
