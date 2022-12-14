using System;
using Mickey_Engine.Functions;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine.Classes.Draw
{
    public class Animations
    {
        public bool IsAnim { get; private set; } = false;
        public Clock AnimClock { get; private set; }

        private Actions.Sprite.Action Action;

        public Animations(Actions.Sprite.Action Action)
        {
            this.Action = Action;
        }

        public void Start(Sprite Sprite)
        {
            if (Action == Actions.Sprite.Action.Flashing || Action == Actions.Sprite.Action.Appear)
                Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, 0);
            if (Action == Actions.Sprite.Action.Fade)
                Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, 244);
        }

        public void Animation(Sprite Sprite)
        {
            //AnimClock.Restart().AsSeconds();

            switch (Action)
            {
                case Actions.Sprite.Action.Flashing:

                    if (Sprite.Color.A != 254 && IsAnim == false)
                        Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, Convert.ToByte(Sprite.Color.A + 2));
                    else
                        IsAnim = true;

                    if (Sprite.Color.A >= 150 && IsAnim == true)
                        Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, Convert.ToByte(Sprite.Color.A - 2));
                    else
                        IsAnim = false;

                    break;

                case Actions.Sprite.Action.Appear:

                    if (Sprite.Color.A != 254 && IsAnim == false)
                        Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, Convert.ToByte(Sprite.Color.A + 2));
                    else
                        IsAnim = true;

                    break;

                case Actions.Sprite.Action.Fade:

                    if (Sprite.Color.A != 0 && IsAnim == false)
                        Sprite.Color = new Color(Sprite.Color.R, Sprite.Color.G, Sprite.Color.B, Convert.ToByte(Sprite.Color.A - 2));
                    else
                        IsAnim = true;

                    break;
            }
        }
    }
}
