﻿using Engine;
using Engine.Classes.Components;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Editor.App
{
    public class Map
    {
        public static void SaveMap(int t = 0)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "NewMap.mickeymap";
            if (Program.SaveFolderPath != string.Empty && t == 0)
            {
                using (StreamWriter file = File.CreateText(Program.SaveFolderPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    serializer.Serialize(file, MainForm.GameObjects.ToArray());
                }
                Program.MainForm.DebLog($"Saving the {Path.GetFileName(Program.SaveFolderPath)} file");
            }
            else
            {
                saveFileDialog.InitialDirectory = Path.GetFullPath($@"{Program.ProjectFolder}\content\maps\");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Program.SaveFolderPath = saveFileDialog.FileName;
                    using (StreamWriter file = File.CreateText(Program.SaveFolderPath))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, MainForm.GameObjects.ToArray());
                    }
                    Program.MainForm.DebLog($"Saving the {Path.GetFileName(Program.SaveFolderPath)} file");
                }
            }
        }

        public static void LoadInsMap()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mickey Map|*.mickeymap";
            openFileDialog.InitialDirectory = Path.GetFullPath($@"{Program.ProjectFolder}\content\maps\");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMap(openFileDialog.FileName);
                Program.MainForm.DebLog($"Opening the {Path.GetFileName(Program.SaveFolderPath)} file");
            }
        }

        public static void LoadMap(string path) 
        {
            path = path.Replace("\"", "");
            Program.MainForm.ManagerListBox.Items.Clear();
            Program.SaveFolderPath = path;

            string allData = File.ReadAllText(Program.SaveFolderPath);
            #pragma warning disable
            dynamic jsonData = JsonConvert.DeserializeObject(allData);
            #pragma warning restore

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
                            Engine.Classes.Components.PlayerController playerController = new Engine.Classes.Components.PlayerController();
                            float playerSpeed = comp.Speed; playerController.Speed = playerSpeed;
                            string horControll = comp.HorizontalController, verControll = comp.VerticalController; playerController.HorizontalController = horControll; playerController.VerticalController = verControll;
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
                            Engine.Classes.Components.GUIText guiText = new Engine.Classes.Components.GUIText(GuiDisplayedString, Program.EditorFont, GuiCharacterSize);
                            gameObject.AddComponent(guiText);
                            break;
                        case "Prefab":
                            string PrefabFile = comp.PrefabFile, PrefabName = comp.PrefabC.Name;
                            Prefab prefab = LoadPrefab(PrefabFile, PrefabName);
                            Engine.Classes.Components.PrefabComp prefabComp = new Engine.Classes.Components.PrefabComp(prefab);
                            prefabComp.PrefabFile = PrefabFile;
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
                            Engine.Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);

                            List<LogicAction> logicAction = new List<LogicAction>();

                            dynamic logicD = comp.LogicAction;
                            foreach (var lD in logicD)
                            {
                                string ObjName = lD.ObjectName, ObjAction = lD.Action, ObjValue = lD.Value; Wait Wait = lD.Wait;
                                GameObject @object = Program.Form2.GameObjects.Find(item => item.Name == ObjName);
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

                MainForm.GameObjects.Add(gameObject);
                Program.MainForm.ManagerListBox.Items.Add(gameObject.Name);

                Program.MainForm.SaveButton_TSM.Enabled = true;
                Program.MainForm.CloseButton_TSM.Enabled = true;
                Program.MainForm.SaveAsButton_TSM.Enabled = true;
                Program.MainForm.AddGameObjectButton_TSM.Enabled = true;
                Program.MainForm.RemoveGameObjectButton_TSM.Enabled = true;
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
                            Engine.Classes.Components.PlayerController playerController = new Engine.Classes.Components.PlayerController();
                            float playerSpeed = comp.Speed; playerController.Speed = playerSpeed;
                            string horControll = comp.HorizontalController, verControll = comp.VerticalController; playerController.HorizontalController = horControll; playerController.VerticalController = verControll;
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
                            Engine.Classes.Components.GUIText guiText = new Engine.Classes.Components.GUIText(GuiDisplayedString, Program.EditorFont, GuiCharacterSize);
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
                            Engine.Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);

                            List<LogicAction> logicAction = new List<LogicAction>();

                            dynamic logicD = comp.LogicAction;
                            foreach (var lD in logicD)
                            {
                                string ObjName = lD.ObjectName, ObjAction = lD.Action, ObjValue = lD.Value; Wait Wait = lD.Wait;
                                GameObject @object = Program.Form2.GameObjects.Find(item => item.Name == ObjName);
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
