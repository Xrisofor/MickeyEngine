using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Launcher
{
    public static class Program
    {
        public static List<Versions> Versions = new List<Versions>();

        [STAThread]
        static void Main()
        {
            #pragma warning disable SYSLIB0014
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://www.dropbox.com/s/agjtrs8g1t2pe6a/versions.txt?dl=1", @$"{Environment.CurrentDirectory}\versions.txt");
                string[] allLines = File.ReadAllLines(@$"{Environment.CurrentDirectory}\versions.txt");
                for(int i = 0; i < allLines.Length; i++)
                {
                    string[] lineSplit = allLines[i].Replace("\n", "").Split(';');
                    Versions.Add(new Versions(lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3]));
                }
                File.Delete(@$"{Environment.CurrentDirectory}\versions.txt");
            }
            #pragma warning restore SYSLIB0014

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }

    public class Versions
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string OS { get; set; }
        public string Link { get; set; }

        public Versions(string _Number, string _Type, string _OS, string _Link) {
            Number = _Number; Type = _Type; Link = _Link; OS = _OS;
        }
    }
}