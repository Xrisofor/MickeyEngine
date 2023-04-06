using Engine.App;
using Newtonsoft.Json;
using SFML.Graphics;
using SFML.System;

namespace Engine
{
    public class Prefab : Drawable
    {
        public string Name { get; set; }
        public Vector2f Position = new Vector2f(0, 0), Scale = new Vector2f(1, 1); public float Rotation = 0;
        public bool Visible = true; public bool Collision = false;

        [JsonIgnore] public List<GameObject> GameObjects = new List<GameObject>();

        public Prefab(string Name)
        {
            this.Name = Name;
        }

        public static Prefab NewPrefab(string Name = "None")
        {
            return new Prefab(Name);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            foreach (GameObject obj in GameObjects)
            {
                obj.Draw(target, states);
            }
        }

        public void Update(float DeltaTime)
        {
            foreach (GameObject obj in GameObjects)
            {
                obj.Position = Position;
                obj.Scale = Scale;
                obj.Rotation = Rotation;
                obj.Visible = Visible;
                obj.Collision = Collision;
                obj.Update(DeltaTime);
            }
        }
    }
}
