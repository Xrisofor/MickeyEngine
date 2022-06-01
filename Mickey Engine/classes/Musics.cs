using System;
//SFML
using SFML.Audio;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game musics
    /// </summary>
    public class Musics
    {
        /// <summary>
        /// Music code name
        /// </summary>
        public string name;
        /// <summary>
        /// Music
        /// </summary>
        public Music music;

        /// <summary>
        /// Creating a new music
        /// </summary>
        /// <param name="_name">Music code name</param>
        /// <param name="_music">Music</param>
        public Musics(string _name, Music _music)
        {
            name = _name;
            music = _music;
        }

        /// <summary>
        /// Music playback function
        /// </summary>
        /// <param name="name">Music code name</param>
        /// <param name="loop">Music looping variable (not optional parameter)</param>
        public void playMusic(string name, bool loop = false)
        {
            if (loop)
            {
                Program.musics.Find(item => item.name == name).music.Loop = loop;
            }
            Program.musics.Find(item => item.name == name).music.Play();
        }

        /// <summary>
        /// Music pause function
        /// </summary>
        /// <param name="name">Music code name</param>
        public void pauseMusic(string name)
        {
            Program.musics.Find(item => item.name == name).music.Pause();
        }

        /// <summary>
        /// Music stop function
        /// </summary>
        /// <param name="name">Music code name</param>
        public void stopMusic(string name)
        {
            Program.musics.Find(item => item.name == name).music.Stop();
        }

        /// <summary>
        /// Music status function
        /// </summary>
        /// <param name="name">Music code name</param>
        /// <returns>Sound status</returns>
        public SoundStatus getStatus(string name)
        {
            return Program.musics.Find(item => item.name == name).music.Status;
        }

        /// <summary>
        /// Music set volume function
        /// </summary>
        /// <param name="name">Music code name</param>
        /// <param name="volume">Music volume values</param>
        public void setVolume(string name, float volume)
        {
            Program.musics.Find(item => item.name == name).music.Volume = volume;
        }
    }
}
