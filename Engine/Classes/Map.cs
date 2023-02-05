using Engine.App;
using Newtonsoft.Json;

namespace Engine.Classes
{
    //The main class of work with the map
    public class Map
    {
        //Loading a new map
        public static void LoadMap(string Path, bool Encryp = false)
        {
            Window.GameObjects = new List<GameObject>(); string? allData;
            if (Encryp) allData = Encryption.Decrypt(File.ReadAllText(Path), "M@I!C@K@E#Y%M&A*P@F^I!L9E!@");
            else allData = File.ReadAllText(Path);
            #pragma warning disable
            dynamic jsonData = JsonConvert.DeserializeObject(allData);
            #pragma warning restore

            #pragma warning disable
            foreach (var data in jsonData)
            {
                string Name = data.Name, Texture = data.Texture;
                float PosX = data.Position.X, PosY = data.Position.Y; float ScaleX = data.Scale.X, ScaleY = data.Scale.Y;
                float Rotation = data.Rotation; bool Visible = data.Visible; bool Collision = data.Collision;
                GameObject gameObject;

                if (Texture != null) {
                    gameObject = new GameObject(Name, Config.ReplaceFunction(Texture), Collision: Collision);
                    gameObject.TexturePath = Config.ReplaceFunction(Texture);
                }
                else gameObject = new GameObject(Name, Collision: Collision);

                gameObject.Position = new SFML.System.Vector2f(PosX, PosY); gameObject.Scale = new SFML.System.Vector2f(ScaleX, ScaleX);
                gameObject.Rotation = Rotation; gameObject.Visible = Visible;

                dynamic component = data.Components;
                foreach (var comp in component)
                {
                    string ComponentName = comp.ComponentName;

                    switch (ComponentName)
                    {
                        case "PlayerController":
                            Classes.Components.PlayerController playerController = new Classes.Components.PlayerController();
                            float playerSpeed = comp.Speed; playerController.Speed = playerSpeed;
                            string horControll = comp.HorizontalController, verControll = comp.VerticalController, IdleAnim = comp.IdleAnim, MoveAnim = comp.MoveAnim; playerController.HorizontalController = horControll; playerController.VerticalController = verControll;
                            playerController.IdleAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(IdleAnim)); playerController.MoveAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(MoveAnim)); gameObject.AddComponent(playerController);
                            break;
                        case "AudioSource":
                            string AudioType = comp.Type, AudioFile = comp.File; bool AudioLoop = comp.Loop;
                            Classes.Components.AudioSource audioSource = new Classes.Components.AudioSource(AudioType, AudioFile); audioSource.Loop = AudioLoop;
                            gameObject.AddComponent(audioSource);
                            break;
                        case "Animation":
                            int AnimDistance = comp.Distance, AnimSpeed = comp.Speed, AnimWidth = comp.Width, AnimHeight = comp.Height;
                            Classes.Components.AnimationComponent animationComponent = new Classes.Components.AnimationComponent(); animationComponent.Distance = AnimDistance; animationComponent.Speed = AnimSpeed; animationComponent.Width = AnimWidth; animationComponent.Height = AnimHeight;
                            gameObject.AddComponent(animationComponent);
                            break;
                        case "ScriptComponent":
                            string ScriptFile = comp.File;
                            gameObject.AddComponent(new Engine.Classes.Components.ScriptComponent(ScriptFile));
                            break;
                        case "LogicComponent":
                            string LogicType = comp.Type, ScriptName = comp.ScriptName, FunctionName = comp.FunctionName;
                            Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);
                            logicComponent.ScriptName = ScriptName;
                            logicComponent.FunctionName = FunctionName;
                            gameObject.AddComponent(logicComponent);
                            break;
                        case "DialogSystem":
                            uint NameSize = comp.NameSize, DialogSize = comp.DialogSize; string NameColor = comp.NameColor, DialogColor = comp.DialogColor, DialogFile = comp.DialogFile;
                            DialogSystem dialogSystem = new DialogSystem();
                            dialogSystem.NameSize = NameSize; dialogSystem.DialogSize = DialogSize; dialogSystem.NameColor = NameColor; dialogSystem.DialogColor = DialogColor; dialogSystem.DialogFile = DialogFile;
                            gameObject.AddComponent(dialogSystem);
                            break;
                    }
                }

                Window.GameObjects.Add(gameObject);
            }
            #pragma warning restore
        }
    }
}
