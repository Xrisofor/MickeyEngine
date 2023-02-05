using SFML.Graphics;

namespace Engine.Classes.Components
{
    //Script Component (Rework required)
    [Obsolete]
    public class ScriptComponent : Component
    {
        public string File { get; private set; }

        public ScriptComponent(string ScriptFile)
        {
            ComponentName = "ScriptComponent";
            File = ScriptFile;
        }

        public override void Awake() { } public override void Draw(RenderTarget Target, RenderStates States) { } public override void Update(float DeltaTime) { }
    }
}
