using Engine.App;
using Newtonsoft.Json;
using SFML.Graphics;

namespace Engine.Classes.Components
{
    public class GUIText : Component
    {
        public Text Text { get; set; }

        public GUIText(string text, Font font, uint characterSize = 26) {
            Text = new Text(text, font, characterSize);
        }

        public static GUIText NewGUIText(string text, Font font, uint characterSize = 26)
        {
            return new GUIText(text, font, characterSize);
        }

        public override void Awake()
        {
            ComponentName = "GUIText";
        }

        public override void Draw(RenderTarget Target, RenderStates States)
        {
            Target.Draw(Text);
        }

        public override void Update(float DeltaTime) {
            Text.Position = GameObject.Position;
            Text.Scale = GameObject.Scale;
            Text.Rotation = GameObject.Rotation;
        }
    }
}
