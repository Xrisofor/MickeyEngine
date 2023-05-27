namespace Launcher
{
    public class Project
    {
        public string Name { get; set; }
        public string EngineV { get; set; }
        public string Path { get; set; }

        public Project(string Name, string EngineV, string Path)
        {
            this.Name = Name; this.EngineV = EngineV; this.Path = Path;
        }
    }

    public class Versions
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string OS { get; set; }
        public string Link { get; set; }

        public Versions(string Number, string Type, string OS, string Link)
        {
            this.Number = Number; this.Type = Type; this.Link = Link; this.OS = OS;
        }
    }

    public class EngineVersions
    {
        public string Number { get; set; }
        public string OS { get; set; }
        public string Path { get; set; }

        public EngineVersions(string Number, string OS, string Path)
        {
            this.Number = Number; this.OS = OS; this.Path = Path;
        }
    }
}
