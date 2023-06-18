using Editor.App;
using Engine;
using Newtonsoft.Json;

namespace Editor.Project
{
    public class Structur
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public List<Plugin> Plugins { get; set; }

        public string SpriteManager { get; set; }

        public Structur() { }
        public Structur(string Name, string SpriteManager)
        {
            this.Name = Name;
            this.SpriteManager = SpriteManager;
        }
    }

    public class ProjInfo
    {
        public static void LoadInfo()
        {
            string allData = File.ReadAllText($"{App.Program.ProjectFolder}/info.json");
            dynamic? jsonData = JsonConvert.DeserializeObject(allData);

            #pragma warning disable
            App.Program.ProjectInfo.Name = jsonData.Name;
            App.Program.ProjectInfo.Icon = jsonData.Icon;
            App.Program.ProjectInfo.Version = jsonData.Version;
            App.Program.ProjectInfo.Description = jsonData.Description;
            App.Program.ProjectInfo.SpriteManager = jsonData.SpriteManager;
            #pragma warning restore

            string allSpritesData = File.ReadAllText(App.Program.ProjectInfo.SpriteManager);
            dynamic? jsonSpritesData = JsonConvert.DeserializeObject(allSpritesData);

            #pragma warning disable
            foreach (var spritesData in jsonSpritesData)
            {
                string Path = spritesData.Path;
                MainForm.Sprites.Add(new App.Classes.Sprites(Path));
            }
            #pragma warning restore
        }
    }
}
