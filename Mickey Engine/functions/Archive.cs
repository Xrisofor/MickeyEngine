using System;
using System.IO;
//Ionic.Zip
using Ionic.Zip;

namespace Mickey_Engine
{
    /// <summary>
    /// Class of working with the archive of application files
    /// </summary>
    public class Archive
    {
        /// <summary>
        /// The path to the archive with the application files
        /// </summary>
        public static string ZipPath { get; set; }
        /// <summary>
        /// Password for the archive with the application files (if you do not have a password, leave the field empty!)
        /// </summary>
        public static string ZipPass = "";

        /// <summary>
        /// The function of extracting files from the archive and writing them to MemoryStream
        /// </summary>
        /// <param name="FileName">The name of the file to be written to memory</param>
        /// <returns>Memory cell for MemoryStream</returns>
        /// <example>MemoryStream mFile = Archive.GetFile("file.txt");</example>
        public static MemoryStream GetFile(string FileName)
        {
            MemoryStream FileMS = new MemoryStream();
            using (ZipFile zip = ZipFile.Read(ZipPath))
            {
                zip.Password = ZipPass;
                try
                {
                    zip[FileName].Extract(FileMS);
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
