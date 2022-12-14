using System;
using System.IO;
//MickeyEngine
using Mickey_Engine.Functions;
//Newtonsoft
using Newtonsoft.Json;
//SFML
using SFML.Audio;

namespace Mickey_Engine.Classes.Audio
{
    public class Musics
    {
        public string UUID { get; set; }
        public Music Music { get; set; }

        public Musics(string UUID, Music Music)
        {
            this.UUID = UUID;
            this.Music = Music;
        }

        public void PlayMusic(bool Loop = false)
        {
            Program.Musics.Find(item => item.UUID == UUID).Music.Loop = Loop;
            Program.Musics.Find(item => item.UUID == UUID).SetVolume(Program.Config.Music_Volume);
            Program.Musics.Find(item => item.UUID == UUID).Music.Play();
        }

        public void PauseMusic()
        {
            Program.Musics.Find(item => item.UUID == UUID).Music.Pause();
        }

        public void StopMusic()
        {
            Program.Musics.Find(item => item.UUID == UUID).Music.Stop();
        }

        public SoundStatus GetStatus()
        {
            return Program.Musics.Find(item => item.UUID == UUID).Music.Status;
        }

        public void SetVolume(float Volume)
        {
            Program.Musics.Find(item => item.UUID == UUID).Music.Volume = Volume;
        }
    }

    public class MusicManager
    {
        public static void LoadMusic(string file = "Audio.json")
        {
            Console.WriteLine();
            string allData = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Yellow);

            foreach (var data in jsonData["Music"])
            {
                string musicUUID = data.UUID, musicFile = data.File;
                Music music = new Music(Environment.CurrentDirectory + $"/../Data/Audio/{musicFile}");
                Program.Musics.Add(new Musics(musicUUID, music));
                Debug.Log($"║ Creating a new music: {musicUUID}", ConsoleColor.Yellow);
            }

            Debug.Log($"╚ Completing the creation of new musics", ConsoleColor.Yellow);
        }
    }
}
