using Engine.App;
using System.Diagnostics;

namespace Engine
{
    public class Program
    {
        public static bool IsEditor { get; set; } = false;

        static void Main(string[] args)
        {
            try
            {
                string a = Encryption.Encrypt(File.ReadAllText($@"{Config.GameData}\maps\NewMap.mickeymap"), "M@I!C@K@E#Y%M&A*P@F^I!L9E!@");
                File.Create($@"{Config.GameData}\maps\NewMap_Enc.mickeymap").Close();
                File.WriteAllText($@"{Config.GameData}\maps\NewMap_Enc.mickeymap", a);

                Config.Init();
                Config.ConsoleState(0);
                Arguments.Init(args);
                Window.Init();
            }
            catch(Exception ex) //Handling global engine errors
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The engine was stopped due to a critical error");
                Console.WriteLine($"Reason: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}