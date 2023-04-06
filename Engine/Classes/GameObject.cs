using SFML.System;
using SFML.Graphics;
using Engine.App;
using Newtonsoft.Json;
using Engine.Classes.Components;

namespace Engine
{
    public enum Wait
    {
        None,
        KeyPress
    }

    //Sample class for creating components
    public abstract class Component
    {
        [JsonIgnore] public GameObject GameObject; //Reference to the main object
        public string ComponentName = "GameObject"; //Name of the component that is being worked on
        public abstract void Update(float DeltaTime);
        public abstract void Draw(RenderTarget Target, RenderStates States);
        public abstract void Awake();
    }

    //The main class of game objects
    public class GameObject : Drawable
    {
        public string Name; [JsonIgnore] public Sprite Sprite; public Component[] Components = new Component[0]; [JsonIgnore] public RectangleShape CollisionRectangleShape;
        public Vector2f Position = new Vector2f(0, 0), Scale = new Vector2f(1, 1); public float Rotation = 0;
        public bool Visible = true; public bool Collision = false; [JsonProperty("Texture")] public string TexturePath = "";

        //Creating a new object
        public GameObject(string Name = "GameObject", string TexturePath = "", bool AutoScale = false, bool Collision = false)
        {
            //If there is a path to the texture, we set it, if not, we create a simple sprite
            if (TexturePath != String.Empty) Sprite = new Sprite(new Texture(Config.ReplaceFunction(TexturePath)));
            else Sprite = new Sprite();

            if (AutoScale) //Automatic object size using window size
                Scale = new Vector2f(Config.VideoMode.Width / Sprite.GetGlobalBounds().Width, Config.VideoMode.Height / Sprite.GetGlobalBounds().Height);

            this.Name = Name; this.Collision = Collision; Sprite.Position = Position; Sprite.Scale = Scale; Sprite.Rotation = Rotation; this.TexturePath = TexturePath;
        }

        public void CreateRectangleShape(Color Color, float OutlineThickness = 1)
        {
            if (Config.ShowRectangleShape)
            {
                CollisionRectangleShape = new RectangleShape(new Vector2f(Sprite.TextureRect.Width, Sprite.TextureRect.Height));
                CollisionRectangleShape.FillColor = Color.Transparent;
                CollisionRectangleShape.OutlineThickness = OutlineThickness;
                CollisionRectangleShape.OutlineColor = Color;
            }
        }

        public static GameObject NewGameObject(string TexturePath = "", bool AutoScale = false)
        {
            GameObject NewGameObject = new GameObject(TexturePath: Config.ReplaceFunction(TexturePath), AutoScale: AutoScale);
            App.Window.GameObjects.Add(NewGameObject);
            return NewGameObject;
        }

        //Adding a new component
        public void AddComponent(Component Component)
        {
            Component.GameObject = this; var NewComponents = new Component[Components.Length + 1];
            Components.CopyTo(NewComponents, 0); NewComponents[Components.Length] = Component;
            Components = NewComponents; Component.Awake();
        }

        public Component GetComponent(int ID = 0)
        {
            #pragma warning disable
            Component component = null;
            switch (Components[ID].ComponentName)
            {
                case "AudioSource":
                    component = (AudioSource)Components[ID];
                    break;
            }
            return component;
            #pragma warning restore
        }

        //Game object update function
        public void Update(float DeltaTime)
        {
            for (int i = 0; i < Components.Length; i++)
            {
                Components[i].Update(DeltaTime);
            }

            Sprite.Position = Position; Sprite.Scale = Scale; Sprite.Rotation = Rotation;
            
            if(CollisionRectangleShape != null)
            {
                CreateRectangleShape(CollisionRectangleShape.OutlineColor, CollisionRectangleShape.OutlineThickness); CollisionRectangleShape.Scale = Scale; CollisionRectangleShape.Position = Position; CollisionRectangleShape.Rotation = Rotation;
            }
            else if(Collision) CreateRectangleShape(Color.Yellow);
            else CreateRectangleShape(Color.Blue);
        }

        //The function of drawing a game object
        public void Draw(RenderTarget Target, RenderStates States)
        {
            if (Visible)
            {
                for (int i = 0; i < Components.Length; i++)
                {
                    Components[i].Draw(Target, States);
                }

                if (Sprite.Texture != null)
                {
                    Target.Draw(Sprite, States);
                    if (Config.ShowRectangleShape && CollisionRectangleShape != null) Target.Draw(CollisionRectangleShape, States);
                }
            }
        }
    }
}
