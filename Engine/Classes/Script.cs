using MoonSharp.Interpreter;
using Engine.Tools;
using SFML.Graphics;

namespace Engine
{
    public class Script
    {
        public Closure? Start, Update, Draw;
        public Table LocalVars = new Table(Scripting.Script);

        public static Script LoadFromFile(string ScriptFile, bool Encryption = false)
        {
            Script script = new Script();
            Scripting.Load(ScriptFile, Encryption);

            script.Start = Scripting.Script.Globals["Start"] as Closure;
            script.Update = Scripting.Script.Globals["Update"] as Closure;
            script.Draw = Scripting.Script.Globals["Draw"] as Closure;

            #pragma warning disable
            if (script.Start != null)
                script.Start.Call(script);
            #pragma warning restore

            return script;
        }
    }
}
