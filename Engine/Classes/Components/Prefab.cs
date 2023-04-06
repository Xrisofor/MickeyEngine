using SFML.Graphics;

namespace Engine.Classes.Components
{
    public class PrefabComp : Component
    {
        public string PrefabFile { get; set; }
        public Prefab PrefabC { get; set; }

        public PrefabComp(Prefab Copy)
        {
            PrefabC = Copy;
        }

        public override void Awake()
        {
            ComponentName = "Prefab";
        }

        public override void Draw(RenderTarget Target, RenderStates States)
        {
            PrefabC.Draw(Target, States);
        }

        public override void Update(float DeltaTime)
        {
            PrefabC.Position = GameObject.Position;
            PrefabC.Scale = GameObject.Scale;
            PrefabC.Rotation = GameObject.Rotation;
            PrefabC.Visible = GameObject.Visible;
            PrefabC.Collision = GameObject.Collision;
            PrefabC.Update(DeltaTime);
        }
    }
}
