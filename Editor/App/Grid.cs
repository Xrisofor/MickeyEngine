using SFML.Graphics;
using SFML.System;
using System.Runtime.CompilerServices;

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
            states = new RenderStates(BlendMode.Add);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            ReDraw();
            target.Draw(lines, this.states);
        }

        public void ReDraw()
        {
            lines = new VertexArray(PrimitiveType.Lines);

            for (uint x = 0; x <= MainForm.Window.Size.X; x += Size)
            {
                lines.Append(new Vertex(new Vector2f(x, 0), Color));
                lines.Append(new Vertex(new Vector2f(x, MainForm.Window.Size.Y), Color));
            }

            for (uint y = 0; y <= MainForm.Window.Size.Y; y += Size)
            {
                lines.Append(new Vertex(new Vector2f(0, y), Color));
                lines.Append(new Vertex(new Vector2f(MainForm.Window.Size.X, y), Color));
            }

            states = new RenderStates(BlendMode.Add);
        }
    }

}
