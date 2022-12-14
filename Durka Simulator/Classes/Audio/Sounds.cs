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
    public class Sounds
    {
        public string UUID { get; set; }
        public Sound Sound { get; set; }

        public Sounds(string UUID, SoundBuffer SoundBuffer)
        {
            this.UUID = UUID;
            Sound = new Sound();
            Sound.SoundBuffer = SoundBuffer;
        }

        public void PlaySound(bool Loop = false)
        {
            Program.Sounds.Find(item => item.UUID == UUID).Sound.Loop = Loop;
            Program.Sounds.Find(item => item.UUID == UUID).SetVolume(Program.Config.Sound_Volume);
            Program.Sounds.Find(item => item.UUID == UUID).Sound.Play();
        }
        public void PauseSound()
        {
            Program.Sounds.Find(item => item.UUID == UUID).Sound.Pause();
        }

        public void StopSound()
        {
            Program.Sounds.Find(item => item.UUID == UUID).Sound.Stop();
        }

        public SoundStatus GetStatus()
        {
            return Program.Sounds.Find(item => item.UUID == UUID).Sound.Status;
        }

        public void SetVolume(float Volume)
        {
            Program.Sounds.Find(item => item.UUID == UUID).Sound.Volume = Volume;
        }
    }

    public class SoundManager
    {
        public static void LoadSound(string file = "Audio.json")
        {
            Console.WriteLine();
            string allData = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Config/{file}");
            dynamic jsonData = JsonConvert.DeserializeObject(allData);

            Debug.Log($"╔ Reading data from the {file} file", ConsoleColor.Yellow);

            foreach (var data in jsonData["Sound"])
            {
                if (data != null)
                {
                    string soundUUID = data.UUID, soundFile = data.File;
                    SoundBuffer sound = new SoundBuffer(Environment.CurrentDirectory + $"/../Data/Audio/{soundFile}");
                    Program.Sounds.Add(new Sounds(soundUUID, sound));
                    Debug.Log($"║ Creating a new sound: {soundUUID}", ConsoleColor.Yellow);
                }
                else
                    Debug.Log($"║ Sound not found skipping an action", ConsoleColor.Yellow);
            }

            Debug.Log($"╚ Completing the creation of new sounds", ConsoleColor.Yellow);
        }
    }
}
