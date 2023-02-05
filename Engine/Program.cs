using Engine.App;
using System.Diagnostics;

namespace Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = Encryption.Encrypt(File.ReadAllText($@"{Config.GameData}\maps\NewMap.mickeymap"), "M@I!C@K@E#Y%M&A*P@F^I!L9E!@");
                File.Create($@"{Config.GameData}\maps\NewMap_Enc.mickeymap").Close();
                File.WriteAllText($@"{Config.GameData}\maps\NewMap_Enc.mickeymap", a);

                Config.ConsoleState(0);
                Arguments.Init(args);
                Config.Init();
                Window.Init();
            }
            catch(Exception ex) //Handling global engine errors
            {
                #pragma warning disable
                var st = new StackTrace(ex, true); var frame = st.GetFrame(0); var line = frame.GetFileLineNumber();
                Console.WriteLine($"{ex.Message}\n{ex.Data}\n{ex.Source}\nLine: {line}");
                Console.ReadKey();
                #pragma warning restore
            }
        }
    }
}