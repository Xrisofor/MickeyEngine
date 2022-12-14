using System;

namespace Mickey_Engine.Special.App
{
    public class Arguments
    {
        public static void ParseArgument(string arg)
        {
            switch(arg)
            {
                case "-cmd":
                    Program.Config.Console = true;
                    break;
                case "-dev":
                    Program.Config.DevMode = true;
                    break;
                case "-skip":
                    Program.GameState[0] = false;
                    Program.GameState[1] = true;
                    break;
            }
        }
    }
}
