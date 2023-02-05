using SFML.Graphics;
using SFML.System;

namespace Editor.App
{
    public class Grid : Drawable
    {
        private VertexArray lines;
        private RenderStates states;

        public uint Size = 20;
        public SFML.Graphics.Color Color = new SFML.Graphics.Color(255, 255, 255, 140);

        public Grid()
        {
            lines = new VertexArray(PrimitiveType.Lines);
            for (uint i = 0; i <= 1280; i += Size)
            {
                lines.Append(new Vertex(new Vector2f(i, 0), Color));
                lines.Append(new Vertex(new Vector2f(i, 720), Color));
                lines.Append(new Vertex(new Vector2f(0, i), Color));
                lines.Append(new Vertex(new Vector2f(1280, i), Color));
            }
            states = new RenderStates(BlendMode.Add);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(lines, this.states);
        }

        public void ReDraw()
        {
            lines = new VertexArray(PrimitiveType.Lines);
            for (uint i = 0; i <= 1280; i += Size)
            {
                lines.Append(new Vertex(new Vector2f(i, 0), Color));
                lines.Append(new Vertex(new Vector2f(i, 720), Color));
                lines.Append(new Vertex(new Vector2f(0, i), Color));
                lines.Append(new Vertex(new Vector2f(1280, i), Color));
            }
            states = new RenderStates(BlendMode.Add);
        }
    }

}
