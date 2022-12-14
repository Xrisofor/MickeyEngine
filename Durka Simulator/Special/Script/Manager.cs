using System;
using System.Collections.Generic;
using System.IO;
//Westwind
using Westwind.Scripting;

namespace Mickey_Engine.Special.Script
{
    public class Manager
    {
        [Obsolete]
        public static void Run()
        {
            string ScriptCode = File.ReadAllText($"{Environment.CurrentDirectory}/../{Program.Config.Main_Folder}/Scripts/Test.cs");
        }
    }
}
