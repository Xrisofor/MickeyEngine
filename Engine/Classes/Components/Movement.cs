using Engine.App;
using SFML.Graphics;
using SFML.System;

namespace Engine.Classes.Components
{
    //PlayerController Component (Removal is being considered)
    public class PlayerController : Component
    {
        public float Speed = 100.0f;
        public string HorizontalController = "Horizontal", VerticalController = "Vertical";
        public Texture? IdleAnim, MoveAnim;

        public PlayerController()
        {
            ComponentName = "PlayerController";
        }

        public override void Update(float DeltaTime)
        {
            //foreach(GameObject @object in Window.GameObjects) {
                //if (GameObject.Collision && @object.Collision && !GameObject.Sprite.GetGlobalBounds().Intersects(@object.Sprite.GetGlobalBounds()))
                //{
                    var movement = new Vector2f(Input.GetAxis(HorizontalController), Input.GetAxis(VerticalController)) * Speed * DeltaTime;
                    GameObject.Position += movement;
                //}
            //}

            switch (Input.GetAxis(HorizontalController))
            {
                case 1.0f:
                    GameObject.Sprite.Texture = MoveAnim;
                    if (GameObject.Scale.X < 0)
                        GameObject.Scale = new Vector2f(-GameObject.Scale.X, GameObject.Scale.Y);
                    break;
                case -1.0f:
                    GameObject.Sprite.Texture = MoveAnim;
                    if(GameObject.Scale.X > 0)
                        GameObject.Scale = new Vector2f(-GameObject.Scale.X, GameObject.Scale.Y);
                    break;
                case 0.0f:
                    GameObject.Sprite.Texture = IdleAnim;
                    break;
            }
        }

        public override void Awake() { }
        public override void Draw(RenderTarget Target, RenderStates States) { }
    }
}
