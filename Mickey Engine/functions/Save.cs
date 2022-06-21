using System;
using System.IO;

namespace Mickey_Engine
{
    /// <summary>
    /// A class for saving game progress
    /// </summary>
    public class Save
    {
        /// <summary>
        /// Function to save the gameplay
        /// </summary>
        /// <param name="slot">Loading slot</param>
        /// <param name="progress">Dialog Script Progress</param>
        public static void SaveGame(int slot, int progress)
        {
            Debug.Log($"Saving progress to slot {slot.ToString()}");
            if (!File.Exists($"{Program.config.saving_path}/slot{slot.ToString()}.ini"))
                File.Create($"{Program.config.saving_path}/slot{slot.ToString()}.ini").Close();
            string saveData = $"[Save]\nProgress={progress.ToString()}\nName=";
            File.WriteAllText($"{Program.config.saving_path}/slot{slot.ToString()}.ini", saveData);
        }
    }

    /// <summary>
    /// A class for loading game progress
    /// </summary>
    public class Load
    {
        /// <summary>
        /// Function for loading the gameplay
        /// </summary>
        /// <param name="slot">Loading slot</param>
        /// <returns>Dialog Script Progress</returns>
        public static int LoadGame(int slot)
        {
            int progress = 1;
            Debug.Log($"Loading progress from slot {slot.ToString()}");
            if (!File.Exists($"{Program.config.saving_path}/slot{slot.ToString()}.ini"))
                File.Create($"{Program.config.saving_path}/slot{slot.ToString()}.ini").Close();
            else
            {
                string[] loadData = File.ReadAllLines($"{Program.config.saving_path}/slot{slot.ToString()}.ini");
                progress = Convert.ToInt32(loadData[1].Replace("Progress=", ""));
            }
            return progress;
        }
    }
}
