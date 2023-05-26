using Newtonsoft.Json;
using Engine;
using Editor.Forms;
using System.Windows.Forms;
using Encryption;
using System;
using Newtonsoft.Json.Linq;
using Editor.Forms.Components;

namespace Editor.App
{
    public partial class Editor : Form
    {
        public List<GameObject> GameObjects = new List<GameObject>();
        public int ListIndex = 0;

        public string FilePath = String.Empty;

        public Editor()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        #region Enable / Disabled | Region
        public void Enable(int index = 0)
        {
            switch (index)
            {
                case 0:
                    SaveAsButton_TSM.Enabled = true;
                    SaveButton_TSM.Enabled = true;
                    CloseButton_TSM.Enabled = true;
                    BuildButton_TSM.Enabled = true;
                    AddNewObjectButton.Enabled = true;
                    RemoveSelectObjectButton.Enabled = true;
                    break;
            }
        }
        public void Disable(int index = 0)
        {
            switch (index)
            {
                case 0:
                    SaveAsButton_TSM.Enabled = false;
                    SaveButton_TSM.Enabled = false;
                    CloseButton_TSM.Enabled = false;
                    BuildButton_TSM.Enabled = false;
                    break;
            }
        }
        #endregion

        #region ListBox | Region
        public object GetListItem()
        {
            return listBox1.Items[ListIndex];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListIndex = listBox1.SelectedIndex;
            Program.Form.UpdateForm(GameObjects[listBox1.SelectedIndex].Name, GameObjects[listBox1.SelectedIndex].Position, GameObjects[listBox1.SelectedIndex].Rotation, GameObjects[listBox1.SelectedIndex].Scale, GameObjects[listBox1.SelectedIndex].Visible, GameObjects[listBox1.SelectedIndex].Components);
        }

        public void AddListBoxItem(object Obj)
        {
            listBox1.Items.Add(Obj);
        }

        public void ClearListBox()
        {
            listBox1.Items.Clear();
        }
        #endregion

        #region Clicked | Region
        private void AddNewObjectButton_Click(object sender, EventArgs e)
        {
            Objects.NewObject();
        }

        private void ExitButton_TSM_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RemoveSelectObjectButton_Click(object sender, EventArgs e)
        {
            Program.Form.DisabledAll();
            listBox1.Items.RemoveAt(ListIndex);
            GameObjects.RemoveAt(ListIndex);
        }

        private void ShowGrid_TSM_Click(object sender, EventArgs e)
        {
            switch (ShowGrid_TSM.Checked)
            {
                case true:
                    Program.ShowGrid = false;
                    ShowGrid_TSM.Checked = false;
                    break;
                case false:
                    Program.ShowGrid = true;
                    ShowGrid_TSM.Checked = true;
                    break;
            }
        }

        private void NewButton_TSM_Click(object sender, EventArgs e)
        {
            GameObjects = new List<GameObject>();
            listBox1.Items.Clear();
            AddNewObjectButton.Enabled = true;
            RemoveSelectObjectButton.Enabled = true;
            Program.Form.DisabledAll();
            SaveButton_TSM.Enabled = true;
            SaveAsButton_TSM.Enabled = true;
            CloseButton_TSM.Enabled = true;
            FilePath = String.Empty;
            BuildButton_TSM.Enabled = true;
            Program.Window.SetTitle($"Viewer - New Map");
        }

        private void CloseButton_TSM_Click(object sender, EventArgs e)
        {
            GameObjects = new List<GameObject>();
            listBox1.Items.Clear();
            AddNewObjectButton.Enabled = false;
            RemoveSelectObjectButton.Enabled = false;
            Program.Form.DisabledAll();
            SaveButton_TSM.Enabled = false;
            SaveAsButton_TSM.Enabled = false;
            CloseButton_TSM.Enabled = false;
            BuildButton_TSM.Enabled = false;
            Program.Window.SetTitle($"Viewer - No Map");
        }

        private void SaveButton_TSM_Click(object sender, EventArgs e)
        {
            Map.SaveMap(0);
        }

        private void SaveAsButton_TSM_Click(object sender, EventArgs e)
        {
            Map.SaveMap(1);
        }

        private void OpenButton_TSM_Click(object sender, EventArgs e)
        {
            Map.LoadInsMap();
        }

        private void BuildButton_TSM_Click(object sender, EventArgs e)
        {
            Map.SaveMap();
            BuildForm buildForm = new BuildForm();
            buildForm.ShowDialog();
        }

        private void GameInfoButton_TSM_Click(object sender, EventArgs e)
        {
            if (FilePath != String.Empty)
            {
                if (!File.Exists($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json"))
                {
                    File.Create($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json").Close();
                    using (StreamWriter sw = new StreamWriter($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine("  \"GameInfo\": {");
                        sw.WriteLine($"    \"Title\": \"{Path.ChangeExtension(Path.GetFileName(FilePath), "")}\",");
                        sw.WriteLine("    \"WindowSize\": \"1280; 720\",");
                        sw.WriteLine("    \"VerticalSync\": true,");
                        sw.WriteLine("    \"FramerateLimit\": 60,");
                        sw.WriteLine("    \"WindowIcon\": null");
                        sw.WriteLine("  }");
                        sw.WriteLine("}");
                    }
                }
            }
            else
            {
                MessageBox.Show("First save your map to change the GameInfo file", "Mickey Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Map.SaveMap();
                if (!File.Exists($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json"))
                {
                    File.Create($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json").Close();
                    using (StreamWriter sw = new StreamWriter($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json"))
                    {
                        sw.WriteLine("{");
                        sw.WriteLine("  \"GameInfo\": {");
                        sw.WriteLine($"    \"Title\": \"{Path.ChangeExtension(Path.GetFileName(FilePath), String.Empty).Replace(".", String.Empty)}\",");
                        sw.WriteLine("    \"WindowSize\": \"1280; 720\",");
                        sw.WriteLine("    \"VerticalSync\": true,");
                        sw.WriteLine("    \"FramerateLimit\": 60,");
                        sw.WriteLine("    \"WindowIcon\": null");
                        sw.WriteLine("  }");
                        sw.WriteLine("}");
                    }
                }
            }

            EditScript editGameInfo = new EditScript();
            editGameInfo.Show();
            editGameInfo.UpdateForm($@"{Path.GetDirectoryName(FilePath)}\GameInfo.json", FastColoredTextBoxNS.Language.JSON);
        }

        #region Grid Size | Region
        private void GridSize20_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 20;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize25_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 25;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize30_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 30;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize35_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 35;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize40_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 40;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize45_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 45;
            Program.EditorGrid.ReDraw();
        }
        private void GridSize50_TSM_Click(object sender, EventArgs e)
        {
            Program.EditorGrid.Size = 50;
            Program.EditorGrid.ReDraw();
        }
        #endregion

        private void GridColorButton_TSM_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.EditorGrid.Color = new SFML.Graphics.Color(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B, Program.EditorGrid.Color.A);
                Program.EditorGrid.ReDraw();
            }
        }

        private void AboutButton_TSM_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        #endregion

        /*public void SaveMap(int t = 0)
        {
            if(FilePath != String.Empty && t == 0)
            {
                using (StreamWriter file = File.CreateText(FilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    serializer.Serialize(file, GameObjects.ToArray());
                }
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFileDialog1.FileName;
                    Program.Window.SetTitle($"Viewer - {FilePath}");
                    using (StreamWriter file = File.CreateText(FilePath))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, GameObjects.ToArray());
                    }
                }
            }
        }

        public void LoadMap()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                GameObjects = new List<GameObject>();
                FilePath = openFileDialog1.FileName;
                Program.Window.SetTitle($"Viewer - {FilePath}");
                SaveAsButton_TSM.Enabled = true;
                SaveButton_TSM.Enabled = true;
                CloseButton_TSM.Enabled = true;
                BuildButton_TSM.Enabled = true;

                string allData = File.ReadAllText(FilePath);
                #pragma warning disable 
                dynamic jsonData = JsonConvert.DeserializeObject(allData);
                #pragma warning restore

                #pragma warning disable
                foreach (var data in jsonData)
                {
                    string Name = data.Name, Texture = data.Texture;
                    float PosX = data.Position.X, PosY = data.Position.Y;
                    float ScaleX = data.Scale.X, ScaleY = data.Scale.Y;
                    float Rotation = data.Rotation; bool Visible = data.Visible;

                    GameObject gameObject;

                    if (Texture != null)
                    {
                        gameObject = new GameObject(Name, Texture);
                        gameObject.TexturePath = Texture;
                    }
                    else gameObject = new GameObject(Name);

                    gameObject.Position = new SFML.System.Vector2f(PosX, PosY);
                    gameObject.Scale = new SFML.System.Vector2f(ScaleX, ScaleX);
                    gameObject.Rotation = Rotation;
                    gameObject.Visible = Visible;

                    dynamic component = data.Components;
                    foreach(var comp in component)
                    {
                        string ComponentName = comp.ComponentName;

                        switch (ComponentName)
                        {
                            case "PlayerController":
                                Engine.Classes.Components.PlayerController playerController = new Engine.Classes.Components.PlayerController();
                                float playerSpeed = comp.Speed; playerController.Speed = playerSpeed;
                                string horControll = comp.HorizontalController, verControll = comp.VerticalController; playerController.HorizontalController = horControll; playerController.VerticalController = verControll;
                                gameObject.AddComponent(playerController);
                                break;
                            case "AudioSource":
                                string Type = comp.Type, File = comp.File; bool Loop = comp.Loop;
                                Engine.Classes.Components.AudioSource audioSource = new Engine.Classes.Components.AudioSource(Type, File);
                                audioSource.File = File; audioSource.Type = Type; audioSource.Loop = Loop;
                                gameObject.AddComponent(audioSource);
                                break;
                            case "AnimationComponent":
                                //gameObject.AddComponent(new Engine.Classes.Components.AnimationComponent());
                                break;
                            case "ScriptComponent":
                                string ScriptFile = comp.File;
                                gameObject.AddComponent(new Engine.Classes.Components.ScriptComponent(ScriptFile));
                                break;
                            case "LogicComponent":
                                string LogicType = comp.Type, ScriptName = comp.ScriptName, FunctionName = comp.FunctionName;
                                Engine.Classes.Components.LogicComponent logicComponent = new Engine.Classes.Components.LogicComponent(LogicType);
                                logicComponent.ScriptName = ScriptName;
                                logicComponent.FunctionName = FunctionName;
                                gameObject.AddComponent(logicComponent);
                                break;
                            case "DialogSystem":
                                uint NameSize = comp.NameSize, DialogSize = comp.DialogSize; string NameColor = comp.NameColor, DialogColor = comp.DialogColor, DialogFile = comp.DialogFile;
                                Engine.DialogSystem dialogSystem = new Engine.DialogSystem();
                                dialogSystem.NameSize = NameSize; dialogSystem.DialogSize = DialogSize; dialogSystem.NameColor = NameColor; dialogSystem.DialogColor = DialogColor; dialogSystem.DialogFile = DialogFile;
                                gameObject.AddComponent(dialogSystem);
                                break;
                        }
                    }

                    GameObjects.Add(gameObject);
                    listBox1.Items.Add(gameObject.Name);
                    AddNewObjectButton.Enabled = true;
                    RemoveSelectObjectButton.Enabled = true;
                }
                #pragma warning restore
            }
        }*/

        #region Paint | Region
        private void Separator_Paint(Object sender, PaintEventArgs e)
        {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(33, 37, 41)), 0, 0, width, height);
            e.Graphics.DrawLine(new Pen(Color.White), 4, height / 2, width - 4, height / 2);
        }

        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }

        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }

        private void toolStripSeparator4_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }

        private void toolStripSeparator3_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }
        private void toolStripSeparator6_Paint(object sender, PaintEventArgs e)
        {
            Separator_Paint(sender, e);
        }
        #endregion
    }
}
