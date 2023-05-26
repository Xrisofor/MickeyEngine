using System.Net;
using System.IO;
using Ionic.Zip;
using System.Diagnostics;

namespace Launcher.Forms
{
    public partial class Engine : Form
    {
        public Engine()
        {
            InitializeComponent();
        }

        AddEngine addEngine = new AddEngine();

        private void AddVersionButton_Click(object sender, EventArgs e)
        {
            if (addEngine.ShowDialog() == DialogResult.Continue)
            {
                Installlabel.Visible = true; InstallProgressBar.Visible = true;
                Directory.CreateDirectory(addEngine.Folder);
                Next(0);
            }
        }

        public static int id = 0;
        public void Next(int _id)
        {
            id = _id;
            InstallProgressBar.Value = 0;

            int OS = addEngine.InstallLinuxPlatform == true ? 1 : 0;
            string OSPlatform = OS == 0 ? "windows" : "linux";

            if (OS == 1)
            {
                MessageBox.Show("It is not possible to install the Linux version of the engine, wait for the official release of the platform for the engine!", "Mickey Engine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _id = 2;
            } 

            switch (_id)
            {
                case 0:
                    #pragma warning disable CS8602
                    Installlabel.Text = "Downloading Engine...";
                    string EngineLink = Program.Versions.Find(version => version.Number == addEngine.Version && version.Type == "engine" && version.OS == OSPlatform).Link;
                    #pragma warning restore CS8602

                    #pragma warning disable SYSLIB0014
                    using (WebClient EngineWC = new WebClient())
                    {
                        EngineWC.DownloadFileAsync(new Uri(EngineLink), @$"{addEngine.Folder}\engine.zip");
                        EngineWC.DownloadProgressChanged += (sender, e) =>
                        {
                            InstallProgressBar.Value = e.ProgressPercentage;
                        };
                        EngineWC.DownloadFileCompleted += (sender, e) => { Installlabel.Text = "Unpacking Engine..."; ExtractZip(@$"{addEngine.Folder}\engine.zip", $@"{addEngine.Folder}\Engine\"); };
                    }
                    #pragma warning restore SYSLIB0014
                    break;
                case 1:
                    if(addEngine.InstallEditor)
                    {
                        #pragma warning disable CS8602
                        Installlabel.Text = "Downloading Editor...";
                        string EditorLink = Program.Versions.Find(version => version.Number == addEngine.Version && version.Type == "editor" && version.OS == OSPlatform).Link;
                        #pragma warning restore CS8602

                        #pragma warning disable SYSLIB0014
                        using (WebClient EngineWC = new WebClient())
                        {
                            EngineWC.DownloadFileAsync(new Uri(EditorLink), @$"{addEngine.Folder}\editor.zip");
                            EngineWC.DownloadProgressChanged += (sender, e) =>
                            {
                                InstallProgressBar.Value = e.ProgressPercentage;
                            };
                            EngineWC.DownloadFileCompleted += (sender, e) => { Installlabel.Text = "Unpacking Editor..."; ExtractZip(@$"{addEngine.Folder}\editor.zip", $@"{addEngine.Folder}\Editor\"); };
                        }
                        #pragma warning restore SYSLIB0014
                    }
                    else
                    {
                        id = id + 1;
                        Next(id);
                    }
                    break;
                case 2:
                    InstallProgressBar.Visible = false; Installlabel.Visible = false;
                    break;
            }
        }

        static bool enabled = false;
        public async void ExtractZip(string file, string folder)
        {
            enabled = true;
            try
            {
                await Task.Run(() =>
                {
                    int oldProgress = -1;
                    using (ZipFile zip = new ZipFile(file))
                    {
                        int currentEntry = -1;
                        int totalEntries = zip.Entries.Count;
                        zip.ExtractProgress += (s, e) =>
                        {
                            if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
                                currentEntry++;
                            else if (e.TotalBytesToTransfer > 0)
                            {
                                int newProgress = currentEntry * 100 / totalEntries + (int)(e.BytesTransferred * 100 / e.TotalBytesToTransfer / totalEntries);
                                if (newProgress != oldProgress)
                                {
                                    InstallProgressBar.Value = newProgress;
                                    oldProgress = newProgress;
                                }

                                if (newProgress >= 99 && enabled == true) {
                                    enabled = false;
                                    id = id + 1;
                                    Next(id);
                                }
                            }
                        };

                        zip.ExtractAll(folder, ExtractExistingFileAction.OverwriteSilently);
                    }
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
