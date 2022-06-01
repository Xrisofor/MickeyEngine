using System;
//SFML
using SFML.Audio;

namespace Mickey_Engine
{
    /// <summary>
    /// Variable class for storing game sounds
    /// </summary>
    public class Sounds
    {
        /// <summary>
        /// Sound code name
        /// </summary>
        public string name;
        /// <summary>
        /// Sound
        /// </summary>
        public Sound sound;

        /// <summary>
        /// Creating a new sound
        /// </summary>
        /// <param name="_name">Sound code name</param>
        /// <param name="_soundbuffer">Sound buffer</param>
        public Sounds(string _name, SoundBuffer _soundbuffer)
        {
            name = _name;
            sound = new Sound();
            sound.SoundBuffer = _soundbuffer;
        }

        /// <summary>
        /// Sound playback function
        /// </summary>
        /// <param name="name">Sound code name</param>
        /// <param name="loop">Sound looping variable (not optional parameter)</param>
        public void playSound(string name, bool loop = false)
        {
            if(loop)
            {
                Program.sounds.Find(item => item.name == name).sound.Loop = loop;
            }
            Program.sounds.Find(item => item.name == name).sound.Play();
        }

        /// <summary>
        /// Sound pause function
        /// </summary>
        /// <param name="name">Sound code name</param>
        public void pauseSound(string name)
        {
            Program.sounds.Find(item => item.name == name).sound.Pause();
        }

        /// <summary>
        /// Sound stop function
        /// </summary>
        /// <param name="name">Sound code name</param>
        public void stopSound(string name)
        {
            Program.sounds.Find(item => item.name == name).sound.Stop();
        }

        /// <summary>
        /// Sound status function
        /// </summary>
        /// <param name="name">Sound code name</param>
        /// <returns>Sound status</returns>
        public SoundStatus getStatus(string name)
        {
            return Program.sounds.Find(item => item.name == name).sound.Status;
        }

        /// <summary>
        /// Sound set volume function
        /// </summary>
        /// <param name="name">Sound code name</param>
        /// <param name="volume">Sound volume values</param>
        public void setVolume(string name, float volume)
        {
            Program.sounds.Find(item => item.name == name).sound.Volume = volume;
        }
    }
}
