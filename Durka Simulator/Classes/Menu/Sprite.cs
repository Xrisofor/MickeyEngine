using System;
using Mickey_Engine.Classes.Draw;
//Mickey_Engine
using Mickey_Engine.Functions;
//Json
using Newtonsoft.Json;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine.Classes.Menu
{
    public class Image
    {
        public Sprite Sprite { get; set; }
        public Actions.Sprite.Action Action { get; set; }
        public bool Visible { get; set; }
        public Animations Animations { get; set; }

        private static Clock loadClock = new Clock();
        public Image(string Name, Actions.Sprite.Action Action, bool Visible)
        {
            Sprite = new Sprite(new Texture(Program.Images.Find(image => image.Name == Convert.ToString(Name)).Image));
            this.Action = Action;
            this.Visible = Visible;
            Animations = new Animations(Action);
            Animations.Start(Sprite);

            //if (Action == Actions.Sprite.Action.SmoothAppearance)
                //Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, 0); loadClock.Restart().AsSeconds();
        }

        public void Update()
        {
            Animations.Animation(Sprite);

            //if (Animations.AnimClock.ElapsedTime.AsSeconds() >= 10.0f)
            //{
                //Program.Menu = new Draw.Menu();
            //}
        }
    }
}
