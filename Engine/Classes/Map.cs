using Engine.App;
using Engine.Classes.Components;
using Newtonsoft.Json;
using SFML.Window;

namespace Engine.Classes
{
    //The main class of work with the map
    public class Map
    {
        //Loading a new map
        public static void LoadMap(string Path, bool Encryp = false)
        {
            App.Window.GameObjects = new List<GameObject>(); string? allData;
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
                            if(IdleAnim != null)
                                playerController.IdleAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(IdleAnim));
                            if(MoveAnim != null)
                            playerController.MoveAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(MoveAnim));
                            gameObject.AddComponent(playerController);
                            break;
                        case "AudioSource":
                            string AudioType = comp.Type, AudioFile = comp.File; bool AudioLoop = comp.Loop;
                            Classes.Components.AudioSource audioSource = new Classes.Components.AudioSource(AudioType, AudioFile); audioSource.Loop = AudioLoop;
                            gameObject.AddComponent(audioSource);
                            break;
                        case "GUIText":
                            string GuiDisplayedString = comp.Text.DisplayedString; uint GuiCharacterSize = comp.Text.CharacterSize;
                            Engine.Classes.Components.GUIText guiText = new Engine.Classes.Components.GUIText(GuiDisplayedString, Config.GameFont, GuiCharacterSize);
                            gameObject.AddComponent(guiText);
                            break;
                        case "Prefab":
                            string PrefabFile = comp.PrefabFile, PrefabName = comp.PrefabC.Name;
                            Prefab prefab = LoadPrefab(PrefabFile, PrefabName);
                            Engine.Classes.Components.PrefabComp prefabComp = new Engine.Classes.Components.PrefabComp(prefab);
                            prefabComp.PrefabFile = PrefabFile;
                            gameObject.AddComponent(prefabComp);
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
                            string LogicType = comp.Type;
                            Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);

                            List<LogicAction> logicAction = new List<LogicAction>();

                            dynamic logicD = comp.LogicAction;
                            foreach (var lD in logicD)
                            {
                                string ObjName = lD.ObjectName, ObjAction = lD.Action, ObjValue = lD.Value;Wait Wait = lD.Wait;
                                GameObject @object = App.Window.GameObjects.Find(item => item.Name == ObjName);
                                Console.WriteLine($"Logic | {ObjName} | {@object.Name} | {ObjAction}, {ObjValue} | {Wait}");
                                LogicAction lA = new LogicAction(ObjName, @object, ObjAction, Wait, ObjValue);
                                logicAction.Add(lA);
                            }
                            logicComponent.LogicAction = logicAction;
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

                Console.WriteLine($"Add Object: {gameObject.Name}");
                App.Window.GameObjects.Add(gameObject);
            }
            #pragma warning restore
        }

        public static Prefab LoadPrefab(string FilePath, string PrefabName = "None")
        {
            string allData = File.ReadAllText(FilePath);
            #pragma warning disable
            dynamic jsonData = JsonConvert.DeserializeObject(allData);
            #pragma warning restore

            List<GameObject> gameObjects = new List<GameObject>();

            #pragma warning disable
            foreach (var data in jsonData)
            {
                string Name = data.Name, Texture = data.Texture;
                float PosX = data.Position.X, PosY = data.Position.Y;
                float ScaleX = data.Scale.X, ScaleY = data.Scale.Y;
                float Rotation = data.Rotation; bool Visible = data.Visible;

                GameObject gameObject;

                if (Texture != null)
                {
                    gameObject = new GameObject(Name, Texture);
                    gameObject.TexturePath = Texture;
                }
                else gameObject = new GameObject(Name);

                gameObject.Position = new SFML.System.Vector2f(PosX, PosY);
                gameObject.Scale = new SFML.System.Vector2f(ScaleX, ScaleX);
                gameObject.Rotation = Rotation;
                gameObject.Visible = Visible;

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
                            if (IdleAnim != null)
                                playerController.IdleAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(IdleAnim));
                            if (MoveAnim != null)
                                playerController.MoveAnim = new SFML.Graphics.Texture(Config.ReplaceFunction(MoveAnim));
                            gameObject.AddComponent(playerController);
                            break;
                        case "AudioSource":
                            string Type = comp.Type, File = comp.File; bool Loop = comp.Loop;
                            Engine.Classes.Components.AudioSource audioSource = new Engine.Classes.Components.AudioSource(Type, File);
                            audioSource.File = File; audioSource.Type = Type; audioSource.Loop = Loop;
                            gameObject.AddComponent(audioSource);
                            break;
                        case "GUIText":
                            string GuiDisplayedString = comp.Text.DisplayedString; uint GuiCharacterSize = comp.Text.CharacterSize;
                            Engine.Classes.Components.GUIText guiText = new Engine.Classes.Components.GUIText(GuiDisplayedString, Config.GameFont, GuiCharacterSize);
                            gameObject.AddComponent(guiText);
                            break;
                        case "Prefab":
                            string PrefabFileC = comp.PrefabFile, PrefabNameC = comp.PrefabC.Name;
                            Prefab prefabC = LoadPrefab(PrefabFileC, PrefabNameC);
                            Engine.Classes.Components.PrefabComp prefabComp = new Engine.Classes.Components.PrefabComp(prefabC);
                            prefabComp.PrefabFile = PrefabFileC;
                            gameObject.AddComponent(prefabComp);
                            break;
                        case "AnimationComponent":
                            //gameObject.AddComponent(new Engine.Classes.Components.AnimationComponent());
                            break;
                        case "ScriptComponent":
                            string ScriptFile = comp.File;
                            gameObject.AddComponent(new Engine.Classes.Components.ScriptComponent(ScriptFile));
                            break;
                        case "LogicComponent":
                            string LogicType = comp.Type;
                            Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);

                            List<LogicAction> logicAction = new List<LogicAction>();

                            dynamic logicD = comp.LogicAction;
                            foreach (var lD in logicD)
                            {
                                string ObjName = lD.ObjectName, ObjAction = lD.Action, ObjValue = lD.Value; Wait Wait = lD.Wait;

                                Console.WriteLine(ObjName);
                                Console.WriteLine(ObjAction);
                                Console.WriteLine(ObjValue);
                                Console.WriteLine(Wait);

                                GameObject @object = App.Window.GameObjects.Find(item => item.Name == ObjName);
                                LogicAction lA = new LogicAction(ObjName, @object, ObjAction, Wait, ObjValue);
                                logicAction.Add(lA);
                            }
                            logicComponent.LogicAction = logicAction;
                            gameObject.AddComponent(logicComponent);
                            break;
                        case "DialogSystem":
                            uint NameSize = comp.NameSize, DialogSize = comp.DialogSize; string NameColor = comp.NameColor, DialogColor = comp.DialogColor, DialogFile = comp.DialogFile;
                            Engine.DialogSystem dialogSystem = new Engine.DialogSystem();
                            dialogSystem.NameSize = NameSize; dialogSystem.DialogSize = DialogSize; dialogSystem.NameColor = NameColor; dialogSystem.DialogColor = DialogColor; dialogSystem.DialogFile = DialogFile;
                            gameObject.AddComponent(dialogSystem);
                            break;
                    }
                }
                gameObjects.Add(gameObject);
            }
            Prefab prefab = new Prefab(PrefabName);
            prefab.GameObjects = gameObjects;
            return prefab;
            #pragma warning restore
        }
    }
}
