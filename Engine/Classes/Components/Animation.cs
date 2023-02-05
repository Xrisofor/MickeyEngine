using SFML.Graphics;

namespace Engine.Classes.Components
{
    //Animation Component (Rework required)
    public class AnimationComponent : Component
    {
        public int Distance = 32, Speed = 3, Width = 25, Height = 48;
        private IntRect[] Frames; private float CurrentFrame = 0;
         
        public AnimationComponent()
        {
            ComponentName = "Animation";
        }

        public override void Update(float DeltaTime)
        {
            if(GameObject.Visible)
            {
                if (CurrentFrame <= Frames.Length - 0.2f) CurrentFrame += Speed * DeltaTime; else CurrentFrame = 0;

                for (int i = 0; i < Frames.Length; i++)
                {
                    GameObject.Sprite.TextureRect = new IntRect(Distance * (int)CurrentFrame, GameObject.Sprite.TextureRect.Top, Width, Height);
                }
            }
        }

        public override void Awake() {
            int count = GameObject.Sprite.TextureRect.Width / Distance;
            Frames = new IntRect[count];
        }

        public override void Draw(RenderTarget Target, RenderStates States) { }

        public static AnimationComponent NewAnimationComponent(int[] frames, float timePerFrame)
        {
            return new AnimationComponent();
        }
    }
}
