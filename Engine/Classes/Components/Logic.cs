using Engine.App;
using Engine.Resources;
using Newtonsoft.Json;
using SFML.Graphics;
using SFML.System;

namespace Engine.Classes.Components
{
    //Logic component (Rework required)
    [Obsolete]
    public class LogicComponent : Component
    {
        public string Type; public string ScriptName; public string FunctionName;

        public LogicComponent(string Type = "Auto")
        {
            ComponentName = "LogicComponent";
            this.Type = Type;
        }

        public override void Awake() { }
        public override void Draw(RenderTarget Target, RenderStates States) { }
        public override void Update(float DeltaTime) { }
    }

    public class EventNode : Component
    {
        public EventNodeType EventNodeType; public List<NodeClass> NodeClasses;
        [JsonIgnore] bool IsTrigger; public int Count = 0;

        public EventNode(EventNodeType eventNodeType, List<NodeClass> nodeClasses)
        {
            EventNodeType = eventNodeType;
            NodeClasses = nodeClasses;
            ComponentName = "EventNode";
        }

        public override void Awake() {

            switch(EventNodeType)
            {
                case EventNodeType.Logic:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.EventNode));
                    break;
                case EventNodeType.Auto:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.EventNode)); Trigger();
                    break;
                case EventNodeType.Script:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.Script));
                    break;
                case EventNodeType.Trigger:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.Trigger));
                    GameObject.CreateRectangleShape(Color.Red, 2); IsTrigger = true; GameObject.Collision = true;
                    break;
                case EventNodeType.Dialog:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.TheatricalMasks));
                    break;
                case EventNodeType.Branch:
                    GameObject.Sprite = new Sprite(new Texture(EngineResource.Branch));
                    break;
            }
        }

        public override void Draw(RenderTarget Target, RenderStates States) { }

        public override void Update(float DeltaTime) {
            foreach(GameObject @object in Window.GameObjects)
            {
                if(GameObject.Collision && @object.Collision && @object.Components.Length != 0)
                {
                    switch (@object.Components[0])
                    {
                        case Components.PlayerController:
                            if (IsTrigger && GameObject.Visible && GameObject.Sprite.GetGlobalBounds().Intersects(@object.Sprite.GetGlobalBounds()))
                                Trigger();
                            break;
                    }
                }
            }
        }

        public void Trigger()
        {
            #pragma warning disable
            foreach(NodeClass Node in NodeClasses)
            {
                switch (Node.EventType)
                {
                    case EventType.SetWindowTitle:
                        Window.RenderWindow.SetTitle(Node.Value);
                        break;
                    case EventType.SetWindowIcon:
                        Config.WindowIcon = new Image(Config.ReplaceFunction(Node.Value));
                        Window.RenderWindow.SetIcon(Config.WindowIcon.Size.X, Config.WindowIcon.Size.Y, Config.WindowIcon.Pixels);
                        break;
                    case EventType.LoadMap:
                        Map.LoadMap(Config.ReplaceFunction(Node.Value));
                        break;
                    case EventType.SetVisible:
                        Window.GameObjects.Find(item => item.Name == Node.Name).Visible = Convert.ToBoolean(Node.Value);
                        break;
                    case EventType.SetPosition:
                        string[] NewPosition = Node.Value.Replace(" ", "").Split(';');
                        Window.GameObjects.Find(item => item.Name == Node.Name).Position = new Vector2f(Convert.ToSingle(NewPosition[0]), Convert.ToSingle(NewPosition[1]));
                        break;
                    case EventType.SetScale:
                        string[] NewScale = Node.Value.Replace(" ", "").Split(';'); Window.GameObjects.Find(item => item.Name == Node.Name).Scale = new Vector2f(Convert.ToSingle(NewScale[0]), Convert.ToSingle(NewScale[1]));
                        break;
                    case EventType.SetRotation:
                        Window.GameObjects.Find(item => item.Name == Node.Name).Rotation = Convert.ToInt32(Node.Value);
                        break;
                    case EventType.SetCollision:
                        Window.GameObjects.Find(item => item.Name == Node.Name).Collision = Convert.ToBoolean(Node.Value);
                        if(Window.GameObjects.Find(item => item.Name == Node.Name).Collision) Window.GameObjects.Find(item => item.Name == Node.Name).CreateRectangleShape(Color.Yellow, Window.GameObjects.Find(item => item.Name == Node.Name).CollisionRectangleShape.OutlineThickness); else Window.GameObjects.Find(item => item.Name == Node.Name).CreateRectangleShape(Color.Blue, Window.GameObjects.Find(item => item.Name == Node.Name).CollisionRectangleShape.OutlineThickness);
                        break;
                    case EventType.EventTrigger:
                        foreach(EventNode eventNode in Window.GameObjects.Find(item => item.Name == Node.Value).Components)
                        {
                            eventNode.Trigger();
                        }
                        break;
                    case EventType.SetVariable:
                        foreach (EventNode eventNode in Window.GameObjects.Find(item => item.Name == Node.Name).Components)
                        {
                            eventNode.Count = Convert.ToInt32(Node.Value);
                        }
                        break;
                }
            }
            #pragma warning restore
        }
    }
}
