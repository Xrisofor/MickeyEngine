using SFML.Graphics;
using SFML.System;

namespace Editor.App
{
    public class Camera : SFML.Graphics.View
    {
        public bool IsCameraMoving = false;
        public Vector2i LastMousePosition;

        public RectangleShape GameBounds;
        Vector2f GameBoundsSize;

        public Camera(FloatRect viewRect) : base(viewRect) {
            GameBoundsSize = new Vector2f(MainForm.Window.Size.X, MainForm.Window.Size.Y);
            GameBounds = new RectangleShape(GameBoundsSize);
            GameBounds.Position = (new Vector2f(MainForm.Window.Size.X, MainForm.Window.Size.Y) - GameBoundsSize) / 2f;
            GameBounds.FillColor = SFML.Graphics.Color.Transparent;
            GameBounds.OutlineThickness = 2f;
            GameBounds.OutlineColor = SFML.Graphics.Color.Yellow;
        }
    }
}
