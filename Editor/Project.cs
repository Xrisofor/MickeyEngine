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
        public string AudioManager { get; set; }
        public string FontsManager { get; set; }

        public Structur() { }
        public Structur(string Name, string SpriteManager, string AudioManager, string FontsManager)
        {
            this.Name = Name;
            this.SpriteManager = SpriteManager;
            this.AudioManager = AudioManager;
            this.FontsManager = FontsManager;
        }
    }

    public class ProjInfo
    {
        public static void LoadInfo()
        {
            App.Program.ProjectFolder = App.Program.ProjectFolder.Replace("info.json", string.Empty);
            string allData = File.ReadAllText($"{App.Program.ProjectFolder}/info.json");
            dynamic? jsonData = JsonConvert.DeserializeObject(allData);

            #pragma warning disable
            App.Program.ProjectInfo.Name = jsonData.Name;
            App.Program.ProjectInfo.Icon = jsonData.Icon;
            App.Program.ProjectInfo.Version = jsonData.Version;
            App.Program.ProjectInfo.Description = jsonData.Description;
            App.Program.ProjectInfo.SpriteManager = jsonData.SpriteManager;
            App.Program.ProjectInfo.AudioManager = jsonData.AudioManager;
            App.Program.ProjectInfo.FontsManager = jsonData.FontsManager;
            #pragma warning restore

            if (File.Exists(App.Program.ProjectInfo.SpriteManager))
            {
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

            if (File.Exists(App.Program.ProjectInfo.AudioManager))
            {
                string allAudioData = File.ReadAllText(App.Program.ProjectInfo.AudioManager);
                dynamic? jsonAudioData = JsonConvert.DeserializeObject(allAudioData);

                #pragma warning disable
                foreach (var audioData in jsonAudioData)
                {
                    string Path = audioData.Path;
                    MainForm.Audio.Add(new App.Classes.Sprites(Path));
                }
                #pragma warning restore
            }

            if (File.Exists(App.Program.ProjectInfo.FontsManager))
            {
                string allFontsData = File.ReadAllText(App.Program.ProjectInfo.FontsManager);
                dynamic? jsonFontsData = JsonConvert.DeserializeObject(allFontsData);

                #pragma warning disable
                foreach (var fontsData in jsonFontsData)
                {
                    string Path = fontsData.Path;
                    MainForm.Fonts.Add(new App.Classes.Sprites(Path));
                }
                #pragma warning restore
            }
        }
    }
}
