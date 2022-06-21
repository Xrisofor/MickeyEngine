using System;
//SFML
using SFML.Graphics;
using SFML.System;

namespace Mickey_Engine
{
    /// <summary>
    /// Class for working with the camera
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Camera
        /// </summary>
        public View camera;

        /// <summary>
        /// Creating a new camera
        /// </summary>
        /// <param name="center">Center of the screen</param>
        /// <param name="size">Screen Size</param>
        public Camera(Vector2f center, Vector2f size)
        {
            camera = new View(center, size);
        }

        /// <summary>
        /// Gets the coordinates of the player (object) and centralizes the camera
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns>Camera</returns>
        public View getPlayerCoordinateForView(float x, float y)
        {
            camera.Center = new Vector2f(x + 100, y);
            return camera;
        }

        /// <summary>
        /// Zooming in or out of the camera
        /// </summary>
        /// <param name="factor">How much you need to zoom in/out (by default 1.0f)</param>
        /// <returns>Camera</returns>
        public View Zoom(float factor = 1.0f)
        {
            camera.Zoom(factor);
            return camera;
        }

        /// <summary>
        /// Specifies a new area to draw this camera
        /// </summary>
        /// <param name="left">Left edge position (default 0)</param>
        /// <param name="top">Top edge position (default 0)</param>
        /// <param name="width">Vertical Size</param>
        /// <param name="height">Horizontal Size</param>
        /// <returns>Camera</returns>
        public View Viewport(uint width, uint height, uint left = 0, uint top = 0)
        {
            camera.Viewport = new FloatRect(left, top, width, height);
            return camera;
        }
    }
}
