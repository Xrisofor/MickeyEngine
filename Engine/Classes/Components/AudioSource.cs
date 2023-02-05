using Engine.App;
using Newtonsoft.Json;
using SFML.Audio;
using SFML.Graphics;

namespace Engine.Classes.Components
{
    //Audio component
    public class AudioSource : Component
    {
        //Main variables
        [JsonIgnore] public Music Music { get; set; } [JsonIgnore] public Sound Sound { get; set; }
        public string Type { get; set; } = "Sound"; public string File { get; set; } public bool Loop { get; set; } = false;

        //Creating a new AudioSource component
        public AudioSource(string Type, string File)
        {
            ComponentName = "AudioSource"; this.Type = Type; this.File = File;
            switch (Type)
            {
                case "Music":
                    Music = new Music(Config.ReplaceFunction(File));
                    break;
                case "Sound":
                    SoundBuffer soundBuffer = new SoundBuffer(Config.ReplaceFunction(File));
                    Sound = new Sound(soundBuffer);
                    break;
            }
        }

        public static AudioSource NewAudioSource(string Type, string File)
        {
            return new AudioSource(Type, Config.ReplaceFunction(File));
        }

        public void Play(bool Loop = false)
        {
            if(Music != null)
            {
                Music.Loop = Loop;
                Music.Volume = Config.MusicVolume;
                Music.Play();
            }

            if (Sound != null)
            {
                Sound.Loop = Loop;
                Sound.Volume = Config.SoundVolume;
                Sound.Play();
            }
            this.Loop = Loop;
        }

        public void Pause()
        {
            if (Music != null)
                Music.Pause();

            if (Sound != null)
                Sound.Pause();
        }

        public SoundStatus GetStatus()
        {
            SoundStatus Status = new SoundStatus();
            if (Music != null)
                Status = Music.Status;
            if (Sound != null)
                Status = Sound.Status;
            return Status;
        }

        public void Stop()
        {
            if (Music != null)
                Music.Stop();

            if (Sound != null)
                Sound.Stop();
        }

        public override void Awake() { GameObject.Visible = false; } public override void Draw(RenderTarget Target, RenderStates States) { } public override void Update(float DeltaTime) { }
    }
}
