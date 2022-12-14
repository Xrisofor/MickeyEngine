using System;
using System.IO;
//Ionic.Zip
using Ionic.Zip;

namespace Mickey_Engine.Functions
{
    public class Archive
    {
        public static string ZipPath { get; set; }
        public static string ZipPass = "";

        public static MemoryStream GetFile(string FileName)
        {
            MemoryStream FileMS = new MemoryStream();
            using (ZipFile zip = ZipFile.Read(ZipPath))
            {
                zip.Password = ZipPass;
                try
                {
                    zip[FileName].Extract(FileMS);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"[Archive] Extracting the {FileName} file from the archive");
                }
                catch (Exception ex)
                {
                    var st = new System.Diagnostics.StackTrace(ex, true); var frame = st.GetFrame(0); var line = frame.GetFileLineNumber();
                    Debug.Error(ex.Message, ex.Data.ToString(), $"{ex.Source} - Line {line}");
                }
            }
            FileMS.Seek(0, SeekOrigin.Begin);
            return FileMS;
        }
    }
}
