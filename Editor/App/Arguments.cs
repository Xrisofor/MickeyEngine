using Engine.App;

namespace Editor.App
{
    public class Arguments
    {
        public static void Init(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    switch (args[i])
                    {
                        case "-map":
                            Map.LoadMap(Config.ReplaceFunction(args[i + 1]));
                            break;
                        case "-project":
                            Program.ProjectFolder = Config.ReplaceFunction(args[i + 1]);
                            Program.ProjectFolder = Program.ProjectFolder.Replace("info.json", string.Empty);
                            break;
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
