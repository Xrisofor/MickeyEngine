using MoonSharp.Interpreter;
using SFML.System;
using SFML.Graphics;
using Engine.App;
using System.Reflection;
using Engine.Classes.Components;
using Engine.Classes.ScriptFunc;

namespace Engine.Tools
{
    public class Scripting
    {
        public static MoonSharp.Interpreter.Script Script { get; set; } = new MoonSharp.Interpreter.Script();
        public static Table GlobalVars = new Table(Script);

        public static void Load(string ScriptFile, bool Encryp = false)
        {
            LoadFunctions();
            string code = File.ReadAllText(ScriptFile);
            if (Encryp)
                code = Encryption.Decrypt(File.ReadAllText(ScriptFile));
            Script.DoString(code);
        }

        #pragma warning disable
        private static void LoadFunctions()
        {
            #region UserData | Region
            UserData.RegisterType<Script>();
            UserData.RegisterType<GameObject>();
            UserData.RegisterType<Plugin>();
            UserData.RegisterType<Prefab>();
            UserData.RegisterType<Assembly>();
            UserData.RegisterType<MethodInfo>();
            UserData.RegisterType<Vector2f>();
            UserData.RegisterType<SFML.Audio.SoundStatus>();
            UserData.RegisterType<Classes.Components.PlayerController>();
            UserData.RegisterType<Classes.Components.AnimationComponent>();
            UserData.RegisterType<Classes.Components.AudioSource>();
            UserData.RegisterType<Classes.Components.LogicComponent>();
            UserData.RegisterType<Classes.Components.PrefabComp>();
            UserData.RegisterType<Classes.Components.GUIText>();
            UserData.RegisterType<Classes.Components.ScriptComponent>();
            UserData.RegisterType<Guid>();
            UserData.RegisterType<GetColor>();
            UserData.RegisterType<Component>();
            #endregion

            #region Variables | Region
            Script.Globals["GameData"] = Config.GameData;
            Script.Globals["EngineData"] = Config.EngineData;
            Script.Globals["GlobalVars"] = GlobalVars;
            Script.Globals["Language"] = Config.Language;
            #endregion

            #region New Objects | Region
            Script.Globals["GameObject"] = (Func<string, bool, GameObject>)GameObject.NewGameObject;
            Script.Globals["Prefab"] = (Func<string, Prefab>)Prefab.NewPrefab;
            Script.Globals["Plugin"] = (Func<string, string, string, Plugin>)Plugin.NewPlugin;
            Script.Globals["Guid"] = (Func<Guid>)Guid.NewGuid;
            Script.Globals["Vector2"] = (Func<float, float, Vector2f>)Functions.NewVector2;
            Script.Globals["Color"] = (Func<byte, byte, byte, byte, Color>)GetColor.CreateColor;
            Script.Globals["ToWhole"] = (Func<float, int>)Convert.ToInt32;
            Script.Globals["RandomNum"] = (Func<int, int, int>)Random.Shared.Next;
            Script.Globals["LoadDialogs"] = (Action<string>)DialogSystem.LoadDialogs;
            #endregion

            #region Main Functions | Region
            Script.Globals["GetGameObject"] = (Func<string, GameObject>)GetObject.GetGameObject;
            Script.Globals["GetComponent"] = (Func<GameObject, Component>)GetObject.GetComponent;
            //GameObject Components
            Script.Globals["PlayerController"] = new Classes.Components.PlayerController();
            Script.Globals["AnimationComponent"] = (Func<int[], float, Classes.Components.AnimationComponent>)Classes.Components.AnimationComponent.NewAnimationComponent;
            Script.Globals["AudioSource"] = (Func<string, string, Classes.Components.AudioSource>)Classes.Components.AudioSource.NewAudioSource;
            #endregion
        }
        #pragma warning restore
    }

    public class Functions
    {
        public static Vector2f NewVector2(float X = 0, float Y = 0)
        {
            return new Vector2f(X, Y);
        }
    }
}
