using SFML.Window;

namespace Engine
{
    public class Input
    {
        public static float GetAxis(string axis)
        {
            switch(axis)
            {
                case "Horizontal":
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Right) || Keyboard.IsKeyPressed(Keyboard.Key.D))
                        return 1.0f;
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Left) || Keyboard.IsKeyPressed(Keyboard.Key.A))
                        return -1.0f;
                    else
                        return 0.0f;
                case "Vertical":
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Down) || Keyboard.IsKeyPressed(Keyboard.Key.S))
                        return 1.0f;
                    else if (Keyboard.IsKeyPressed(Keyboard.Key.Up) || Keyboard.IsKeyPressed(Keyboard.Key.W))
                        return -1.0f;
                    else
                        return 0.0f;
                default:
                    return 0.0f;
            }
        }
    }
}
