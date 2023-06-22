using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace Launcher
{
    public static class Program
    {
        public static string ServerLauncherVersion;

        public static List<Versions> Versions = new List<Versions>();
        public static List<EngineVersions> EngineVersions = new List<EngineVersions>(); 
        public static List<Project> Projects = new List<Project>();

        [STAThread]
        static void Main()
        {
            #pragma warning disable SYSLIB0014
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://www.dropbox.com/s/qkop33r01jcspte/lanversions.txt?dl=1", @$"{Environment.CurrentDirectory}\launcher_versions.txt");
                ServerLauncherVersion = File.ReadAllText(@$"{Environment.CurrentDirectory}\launcher_versions.txt");
                File.Delete(@$"{Environment.CurrentDirectory}\launcher_versions.txt");
            }
            #pragma warning restore SYSLIB0014

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

            LoadJSON();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        #pragma warning disable
        public static void LoadJSON()
        {
            if(File.Exists($@"{Environment.CurrentDirectory}\engines.json"))
            {
                string allData = File.ReadAllText($@"{Environment.CurrentDirectory}\engines.json");
                dynamic jsonData = JsonConvert.DeserializeObject(allData);

                foreach (var data in jsonData)
                {
                    string Number = data.Number, OS = data.OS, Path = data.Path;
                    EngineVersions.Add(new EngineVersions(Number, OS, Path));
                }
                
            }

            if (File.Exists($@"{Environment.CurrentDirectory}\projects.json"))
            {
                string allData = File.ReadAllText($@"{Environment.CurrentDirectory}\projects.json");
                dynamic jsonData = JsonConvert.DeserializeObject(allData);

                foreach (var data in jsonData)
                {
                    string Name = data.Name, EngineV = data.EngineV, Path = data.Path;
                    Projects.Add(new Project(Name, EngineV, Path));
                }
            }
        }
        #pragma warning restore

        #pragma warning disable
        public static void SaveJSON()
        {
            using (StreamWriter file = File.CreateText($@"{Environment.CurrentDirectory}\engines.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                serializer.Serialize(file, EngineVersions);
            }

            using (StreamWriter file = File.CreateText($@"{Environment.CurrentDirectory}\projects.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                serializer.Serialize(file, Projects);
            }
        }
        #pragma warning restore
    }
}