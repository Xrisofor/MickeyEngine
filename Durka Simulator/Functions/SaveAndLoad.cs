using System;
using System.IO;

namespace Mickey_Engine.Functions
{
    public class Save
    {
        public static void SaveGame(int slot, int progress)
        {
            Debug.Log($"Saving progress to slot {slot.ToString()}");
            if (!File.Exists($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini"))
                File.Create($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini").Close();
            string saveData = $"[Save]\nProgress={progress.ToString()}\nName=";
            File.WriteAllText($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini", saveData);
        }
    }

    public class Load
    {
        public static int LoadGame(int slot)
        {
            int progress = 1;
            Debug.Log($"Loading progress from slot {slot.ToString()}");
            if (!File.Exists($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini"))
                File.Create($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini").Close();
            else
            {
                string[] loadData = File.ReadAllLines($"{Program.Config.Saving_Path}/slot{slot.ToString()}.ini");
                progress = Convert.ToInt32(loadData[1].Replace("Progress=", ""));
            }
            return progress;
        }
    }
}

