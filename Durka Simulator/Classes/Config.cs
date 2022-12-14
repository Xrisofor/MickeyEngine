using System;
using System.IO;
//SFML
using SFML.Window;
//MickeyEngine
using Mickey_Engine.Functions;
using System.Collections.Generic;

namespace Mickey_Engine.Classes
{
    public class Config
    {
        //Window settings (do not participate in the config)
        public string Title { get; set; } = "Durka Simulator: A New Era";
        public uint Width { get; set; } = 1280;
        public uint Height { get; set; } = 720;

        //Window settings (participate in the config)
        public Styles Style { get; set; } = Styles.Close;
        public string Icon { get; set; }
        public bool Vertical_Sync { get; set; } = false;

        //Engine settings (do not participate in the config)
        public string Main_Folder { get; set; } = "Data";
        public bool Console { get; set; } = false;
        public string Saving_Path_Temp { get; set; }
        public bool DevMode { get; set; } = false;

        //Archive settings (do not participate in the config)
        public string Archive { get; set; } = $"main.zip";
        public string Archive_Password { get; set; } = "";
        private bool ArchiveEnabled { get; set; } = false;

        //Engine settings (participate in the config)
        public string Language { get; set; }
        public string Saving_Path { get; set; }
        public bool Fps_Show { get; set; } = false;
        public uint Fps_Limit { get; set; } = 60;

        //Audio settings
        public float Music_Volume { get; set; } = 100;
        public float Sound_Volume { get; set; } = 100;

        //List of texts to be deleted from the archive reading
        private List<string> Replaces = new List<string>()
        {
            "Fullscreen=",
            "VerticalSync=",
            "DrawFPS=",
            "Language=",
            "SavingPath=",
            "FPSLimit=",
            "MusicVolume=",
            "SoundVolume="
        };

        //Config reading function
        public void ReadConfig(string file = "Config.ini")
        {
            Debug.Log("╔ Reading the game configuration...", ConsoleColor.Cyan);

            string[] config = File.ReadAllLines($"{Environment.CurrentDirectory}/../{file}");
            for (int i = 0; i < config.Length; i++)
            {
                if (config[i].Length != 0)
                {
                    for (int z = 0; z < Replaces.Count; z++)
                    {
                        config[i] = config[i].Replace(Replaces[z], string.Empty);
                    }
                }
            }

            //FullScreen
            bool FullScreen = System.Convert.ToBoolean(config[1]);
            Debug.Log($"║ Changing the fullscreen variable to {FullScreen}", ConsoleColor.Cyan);
            if (FullScreen)
                this.Style = Styles.Fullscreen;

            //Vertical Synchronization
            this.Vertical_Sync = System.Convert.ToBoolean(config[2]);
            Debug.Log($"║ Changing the vertical synchronization variable to {Vertical_Sync}", ConsoleColor.Cyan);

            this.Fps_Show = System.Convert.ToBoolean(config[3]);
            Debug.Log($"║ Changing the fps show variable to {Fps_Show}", ConsoleColor.Cyan);

            //Archive
            if(ArchiveEnabled)
            {
                Functions.Archive.ZipPath = $"{Environment.CurrentDirectory}/{this.Main_Folder}/{this.Archive}";
                Debug.Log($"║ Changing the archive path variable to {Functions.Archive.ZipPath}", ConsoleColor.Cyan);
                Functions.Archive.ZipPass = this.Archive_Password;
            }

            //Language
            this.Language = config[7].Replace("\"", "");
            Debug.Log($"║ Changing the language variable to {Language.ToUpper()}", ConsoleColor.Cyan);

            //Saving Path
            this.Saving_Path = config[8].Replace("\"", "").Replace("[AppData]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            this.Saving_Path_Temp = config[8];
            Debug.Log($"║ Changing the saving path variable to {Saving_Path}", ConsoleColor.Cyan);
            
            //FPS Limit
            this.Fps_Limit = System.Convert.ToUInt32(config[4]);
            Debug.Log($"║ Changing the fps limit variable to {Fps_Limit}", ConsoleColor.Cyan);

            //Music Volume
            this.Music_Volume = System.Convert.ToSingle(config[11]);
            Debug.Log($"║ Changing the music volume variable to {Music_Volume}", ConsoleColor.Cyan);

            //Sound Volume
            this.Sound_Volume = System.Convert.ToSingle(config[12]);
            Debug.Log($"╚ Changing the sound volume variable to {Sound_Volume}", ConsoleColor.Cyan);

            //Creating a save folder, if one does not exist
            if (!Directory.Exists(this.Saving_Path))
            {
                Directory.CreateDirectory(this.Saving_Path);
            }

            Debug.ConsoleState();
        }

        public static void WriteConfig(string file = "Config.ini")
        {
            string[] config = { "", "", "", "", "", "", "" };
            config[0] = "[MickeyEngine.VideoMode]";
            if(Program.Config.Style == Styles.Fullscreen)
                config[1] = "Fullscreen=True";
            else
                config[1] = "Fullscreen=False";
            config[2] = $"VerticalSync={Program.Config.Vertical_Sync}";
            config[3] = $"DrawFPS={Program.Config.Fps_Show}";
            config[4] = $"FPSLimit={Program.Config.Fps_Limit}";
            config[6] = $"[MickeyEngine.GameSettings]";
            config[7] = $"Language=\"{Program.Config.Language}\"";
            config[8] = $"SavingPath={Program.Config.Saving_Path_Temp}";
            config[10] = "[MickeyEngine.AudioSettings]";
            config[11] = $"MusicVolume={Program.Config.Music_Volume}";
            config[12] = $"SoundVolume={Program.Config.Sound_Volume}";
            File.WriteAllLines($"{Environment.CurrentDirectory}/../{file}", config);
        }
    }
}
