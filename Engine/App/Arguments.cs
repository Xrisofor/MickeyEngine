namespace Engine.App
{
    public class Arguments
    {
        public static void Init(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                //Console.WriteLine($"{i} | {args[i]}");
                switch(args[i])
                {
                    case "-dev":
                        Config.ShowRectangleShape = true;
                        break;
                    case "-cmd":
                        Config.ConsoleState(5);
                        break;
                    case "-map":
                        Config.StartMap = Config.ReplaceFunction(args[i + 1]);
                        break;
                }
            }
        }
    }
}
