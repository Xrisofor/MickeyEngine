using System;
using System.Windows.Forms;

namespace Mickey_Engine.Special.App
{
    public class App
    {
        public static void Restart()
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
