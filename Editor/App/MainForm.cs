//Engine
using Engine;
using Engine.Classes.Components;
//SFML
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//Editor
using Editor.App.Paint;
using Editor.Project;
using Editor.App.Forms;
using Editor.App.Classes;

namespace Editor.App
{
    public partial class MainForm : Form
    {
        public static RenderWindow Window { get; private set; }
        public static Grid EditorGrid = new Grid();
        public static Camera Camera;

        public static List<GameObject> GameObjects { get; private set; } = new List<GameObject>();
        public static List<Sprites> Sprites { get; private set; } = new List<Sprites>();
        public static List<Sprites> Audio { get; private set; } = new List<Sprites>();
        public static List<Sprites> Fonts { get; private set; } = new List<Sprites>();


        private string[] args;
        public MainForm(string[] args)
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();

            this.args = args;
            Arguments.Init(args);

            if (Program.ProjectFolder == null)
                if (MessageBox.Show("To work with the editor, open the project by clicking OK or using the launcher!", "Mickey Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "Info|*.json"; openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        Program.ProjectFolder = openFile.FileName;
                    }
                }

            ProjInfo.LoadInfo();
        }

        Text FPSText = new Text("World View | FPS: 0 | 0 ms", Program.EditorFont, 14);

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DebLog("Loading project...");
            Window = new RenderWindow(sfmlPanel.Handle);
            Text = $"{Program.ProjectInfo.Name} - Mickey Editor";
            if (Program.ProjectInfo.Icon != null)
            {
                System.Drawing.Image IconImg = System.Drawing.Image.FromFile(Program.ProjectInfo.Icon);
                Bitmap IconBitmap = (Bitmap)IconImg;
                IntPtr PtrIcon = IconBitmap.GetHicon();
                Icon Icon = Icon.FromHandle(PtrIcon);
                this.Icon = Icon;
                Icon.Dispose();
            }

            Arguments.Init(args);

            Camera = new Camera(new FloatRect(new Vector2f(0, 0), new Vector2f(Window.Size.X, Window.Size.Y)));
            FPSText.Position = new Vector2f(5, 694);

            DebLog("Running the editor");

            Window.MouseWheelScrolled += (s, e) =>
            {
                if (e.Wheel == Mouse.Wheel.VerticalWheel)
                {
                    float zoomFactor = (e.Delta > 0) ? (1f - 0.1f) : (1f + 0.1f);
                    Camera.Zoom(zoomFactor);
                }
            };

            Clock DeltaClock = new Clock();
            float lastTime = 0;
            while (Visible)
            {
                float DeltaTime = DeltaClock.Restart().AsSeconds();
                Application.DoEvents();
                Window.DispatchEvents();

                FPSText.DisplayedString = $"World View | FPS: {System.Convert.ToInt32(1.0f / (DeltaTime - lastTime))} | {DeltaTime} ms";

                if (Mouse.IsButtonPressed(Mouse.Button.Right))
                {
                    if (!Camera.IsCameraMoving)
                    {
                        Camera.IsCameraMoving = true;
                        Camera.LastMousePosition = Mouse.GetPosition(Window);
                    }
                    else
                    {
                        Vector2i mousePosition = Mouse.GetPosition(Window);
                        Vector2i delta = mousePosition - Camera.LastMousePosition;
                        Camera.Move(new Vector2f(-delta.X, -delta.Y));
                        Camera.LastMousePosition = mousePosition;
                    }
                }
                else
                {
                    Camera.IsCameraMoving = false;
                }

                Window.Clear();

                Window.SetView(Camera);

                foreach (GameObject GameObjects in GameObjects)
                {
                    GameObjects.Update(DeltaTime);

                    if (GameObjects.Visible && GameObjects.Sprite.Texture != null)
                        Window.Draw(GameObjects);
                    if (GameObjects.Visible && GameObjects.Components.Length != 0)
                        if (GameObjects.Components[0].ComponentName == "GUIText" || GameObjects.Visible && GameObjects.Components[0].ComponentName == "Prefab")
                            Window.Draw(GameObjects);
                }

                if (Program.ShowGrid)
                    Window.Draw(EditorGrid);

                Window.Draw(Camera.GameBounds);

                //Рендер без камеры
                Window.SetView(Window.DefaultView);

                if (Program.ShowFPS)
                    Window.Draw(FPSText);

                Window.Display();
            }
        }

        #region AddObject | Region
        public void AddObject(Component? component = null)
        {
            GameObject gameObject = new GameObject();

            if (component != null)
            {
                gameObject.AddComponent(component);

                switch (component)
                {
                    case AudioSource:
                        gameObject.Name = $"AudioSource-{Guid.NewGuid()}";
                        DebLog("Creating a new Audio Source");
                        break;
                    case PlayerController:
                        gameObject.Name = $"PlayerController-{Guid.NewGuid()}";
                        DebLog("Creating a new PlayerController");
                        break;
                    case PrefabComp:
                        PrefabComp prefab = (PrefabComp)component;
                        gameObject.Name = prefab.PrefabC.Name;
                        DebLog("Creating a new Prefab");
                        break;
                    case GUIText:
                        gameObject.Name = $"Text-{Guid.NewGuid()}";
                        DebLog("Creating a new Text");
                        break;
#pragma warning disable CS0612
                    case LogicComponent:
                        gameObject.Name = $"Logic-{Guid.NewGuid()}";
                        DebLog("Creating a new Logic");
                        break;
#pragma warning restore CS0612
                    case DialogSystem:
                        gameObject.Name = $"Dialog-{Guid.NewGuid()}";
                        DebLog("Creating a new Dialog");
                        break;
                    #pragma warning disable CS0612
                    case ScriptComponent:
                        gameObject.Name = $"Script-{Guid.NewGuid()}";
                        DebLog("Creating a new Script");
                        break;
                    #pragma warning restore CS0612
                }

            }
            else { gameObject.Name = $"Sprite-{Guid.NewGuid()}"; DebLog("Creating a new Sprite"); }

            GameObjects.Add(gameObject);
            ManagerListBox.Items.Add(gameObject.Name);
        }
        #endregion

        #region Form.Control.Buttons | Region
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MunimazeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Paint | Region
        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator7_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator6_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator5_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator4_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator3_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        #endregion

        #region Form.TSM | Region
        private void ShowGrid_TSM_Click(object sender, EventArgs e)
        {
            if (ShowGrid_TSM.Checked)
            {
                ShowGrid_TSM.Checked = false;
                Program.ShowGrid = false;
            }
            else
            {
                ShowGrid_TSM.Checked = true;
                Program.ShowGrid = true;
            }
        }

        private void GridColorButton_TSM_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                EditorGrid.Color = new SFML.Graphics.Color(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B, Program.EditorGrid.Color.A);
                EditorGrid.ReDraw();
            }
        }

        #region Grid Size | Region
        private void GridSize20_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 20;
            EditorGrid.ReDraw();
        }

        private void GridSize25_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 25;
            EditorGrid.ReDraw();
        }

        private void GridSize30_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 30;
            EditorGrid.ReDraw();
        }

        private void GridSize35_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 35;
            EditorGrid.ReDraw();
        }

        private void GridSize40_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 40;
            EditorGrid.ReDraw();
        }

        private void GridSize45_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 45;
            EditorGrid.ReDraw();
        }

        private void GridSize50_TSM_Click(object sender, EventArgs e)
        {
            EditorGrid.Size = 50;
            EditorGrid.ReDraw();
        }
        #endregion

        private void AboutButton_TSM_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void NewButton_TSM_Click(object sender, EventArgs e)
        {
            DebLog("Creating a new map");
            CloseButton_TSM.Enabled = true;
            SaveAsButton_TSM.Enabled = true;
            SaveButton_TSM.Enabled = true;
            AddGameObjectButton_TSM.Enabled = true;
            RemoveGameObjectButton_TSM.Enabled = true;

            Program.SaveFolderPath = string.Empty;

            ManagerListBox.Items.Clear();
            GameObjects.Clear();
            NameTextBox.Enabled = false; VisibleCheckBox.Enabled = false; RotationTextBox.Enabled = false;
            PosXTextBox.Enabled = false; PosYTextBox.Enabled = false; ScaleXTextBox.Enabled = false;
            ScaleYTextBox.Enabled = false; SelectTextureButton.Enabled = false;
            ComponentLabel.Visible = true; ComponentNameLabel.Visible = false;
        }

        private void CloseButton_TSM_Click(object sender, EventArgs e)
        {
            CloseButton_TSM.Enabled = false;
            SaveAsButton_TSM.Enabled = false;
            SaveButton_TSM.Enabled = false;
            AddGameObjectButton_TSM.Enabled = false;
            RemoveGameObjectButton_TSM.Enabled = false;

            ManagerListBox.Items.Clear();
            GameObjects.Clear();
            NameTextBox.Enabled = false; VisibleCheckBox.Enabled = false; RotationTextBox.Enabled = false;
            PosXTextBox.Enabled = false; PosYTextBox.Enabled = false; ScaleXTextBox.Enabled = false;
            ScaleYTextBox.Enabled = false; SelectTextureButton.Enabled = false;
            ComponentLabel.Visible = true; ComponentNameLabel.Visible = false;

            ConsoleListBox.Items.Clear();
            DebLog("Closing map editing");
        }

        private void ExitButton_TSM_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SpriteManager_TSM_Click(object sender, EventArgs e)
        {
            SpriteManager spriteManager = new SpriteManager(ManagerType.Sprite);
            spriteManager.ShowDialog();
        }

        private void AudioManager_TSM_Click(object sender, EventArgs e)
        {
            SpriteManager audioManager = new SpriteManager(ManagerType.Audio);
            audioManager.ShowDialog();
        }

        private void PluginsManager_TSM_Click(object sender, EventArgs e)
        {
            PluginsManager pluginsManager = new PluginsManager();
            pluginsManager.ShowDialog();
        }

        private void FontsManager_TSM_Click(object sender, EventArgs e)
        {
            SpriteManager fontsManager = new SpriteManager(ManagerType.Font);
            fontsManager.ShowDialog();
        }

        private void RemoveGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedItem != null)
            {
                GameObjects.RemoveAt(ManagerListBox.SelectedIndex);
                ManagerListBox.Items.Clear();
                foreach (GameObject gameObject in GameObjects)
                    ManagerListBox.Items.Add(gameObject.Name);
            }
        }

        #region TSM Add Button | Region
        private void AddASGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            var memoryStream = new MemoryStream(); Engine.Resources.EngineResource.FileNotFound.CopyToAsync(memoryStream);
            AudioSource audioSource = new AudioSource("Sound", memoryStream.ToArray());
            AddObject(audioSource);
        }

        private void AddSpriteGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            AddObject();
        }

        private void AddPCGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            PlayerController playerController = new PlayerController();
            AddObject(playerController);
        }

        private void AddPrefabGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            Prefab prefab = new Prefab($"Prefab-{Guid.NewGuid()}");
            AddObject(new PrefabComp(prefab));
        }

        private void AddTextGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            GUIText guiText = new GUIText("Text", Program.EditorFont);
            AddObject(guiText);
        }

        private void AddLGGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            #pragma warning disable CS0612
            LogicComponent logicComponent = new LogicComponent();
            #pragma warning restore CS0612
            AddObject(logicComponent);
        }

        private void AddDLGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            string FilePath = $@"{Program.ProjectFolder}/content/scripts/{Guid.NewGuid()}.lua";
            NewScript(FilePath);
            DialogSystem dialogSystem = new DialogSystem();
            dialogSystem.DialogFile = FilePath;
            AddObject(dialogSystem);
        }

        private void AddSGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            string FilePath = $@"{Program.ProjectFolder}/content/scripts/{Guid.NewGuid()}.lua";
            NewScript(FilePath);
            #pragma warning disable CS0612
            ScriptComponent scriptComponent = new ScriptComponent(FilePath);
            #pragma warning restore CS0612
            AddObject(scriptComponent);
        }

        private void AddTargetGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            AddObject();
        }

        private void ShowFPS_TSM_Click(object sender, EventArgs e)
        {
            if (ShowFPS_TSM.Checked)
            {
                ShowFPS_TSM.Checked = false;
                Program.ShowFPS = false;
            }
            else
            {
                ShowFPS_TSM.Checked = true;
                Program.ShowFPS = true;
            }
        }

        private void ShowConsole_TSM_Click(object sender, EventArgs e)
        {
            if (ShowConsole_TSM.Checked)
            {
                ShowConsole_TSM.Checked = false;
                ConsoleLabel.Visible = false;
                ConsoleListBox.Visible = false;
                ManagerListBox.Size = new Size(270, 662);
            }
            else
            {
                ShowConsole_TSM.Checked = true;
                ConsoleLabel.Visible = true;
                ConsoleListBox.Visible = true;
                ManagerListBox.Size = new Size(270, 502);
            }
        }

        private void ResetCSize_TSM_Click(object sender, EventArgs e)
        {
            Camera.Reset(new FloatRect(new Vector2f(0, 0), new Vector2f(Window.Size.X, Window.Size.Y)));
        }
        #endregion

        #endregion

        #region Form.Console | Region
        public void DebLog(string Message)
        {
            ConsoleListBox.Items.Add($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}] {Message}");
        }

        private void ManagerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBox.Enabled = true; RotationTextBox.Enabled = true;
            PosXTextBox.Enabled = true; ScaleXTextBox.Enabled = true;
            PosYTextBox.Enabled = true; ScaleYTextBox.Enabled = true;
            SelectTextureButton.Enabled = true; VisibleCheckBox.Enabled = true;

            NameTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Name; RotationTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Rotation.ToString(); ScaleYTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Scale.Y.ToString();
            PosXTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Position.X.ToString(); VisibleCheckBox.Checked = GameObjects[ManagerListBox.SelectedIndex].Visible;
            PosYTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Position.Y.ToString(); ScaleXTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Scale.X.ToString();
            TextureTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].TexturePath;

            ObjectPictureBox.BackgroundImage = ImageList._object;

            UpdateInspector(ManagerListBox.SelectedIndex);
        }

        public void NewScript(string Path)
        {
            if(!File.Exists(Path))
            {
                File.Create(Path).Close();
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine("function Start(this)");
                    sw.WriteLine();
                    sw.WriteLine("end");
                    sw.WriteLine();
                    sw.WriteLine("function Update(this)");
                    sw.WriteLine();
                    sw.WriteLine("end");
                }
            }
        }

        private void UpdateInspector(int index)
        {
            ComponentLabel.Visible = true;
            ComponentNameLabel.Visible = false;

            ComponentPanel.Controls.Clear();
            ComponentLabel = new Label();
            ComponentLabel.Text = "This object does not have any components";
            ComponentLabel.Dock = DockStyle.Fill; ComponentLabel.TextAlign = ContentAlignment.MiddleCenter;
            ComponentPanel.Controls.Add(ComponentLabel);

            SelectTextureButton.Enabled = true;

            if (GameObjects[index].Components.Length != 0)
                #pragma warning disable CS0612 // Тип или член устарел
                switch (GameObjects[index].Components[0])
                {
                    case AudioSource:
                        ObjectPictureBox.BackgroundImage = ImageList.audio;
                        GameObjects[index].Sprite.Texture = new Texture(Classes.Convert.ToSFMLImage(ImageList.audio));
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Audio Source";
                        Components.AudioSound AudioSoundForm = new Components.AudioSound();
                        AudioSoundForm.TopLevel = false;
                        AudioSoundForm.AutoScroll = true;
                        AudioSoundForm.audioSource = (AudioSource)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(AudioSoundForm);
                        AudioSoundForm.Dock = DockStyle.Fill;
                        AudioSoundForm.Show();
                        break;
                    case PrefabComp:
                        ObjectPictureBox.BackgroundImage = ImageList.prefabhouse;
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Prefab";
                        Components.PrefabComp PrefabCompForm = new Components.PrefabComp();
                        PrefabCompForm.TopLevel = false;
                        PrefabCompForm.AutoScroll = true;
                        PrefabCompForm.prefabComp = (PrefabComp)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(PrefabCompForm);
                        PrefabCompForm.Dock = DockStyle.Fill;
                        PrefabCompForm.Show();
                        SelectTextureButton.Enabled = false;
                        break;
                    case PlayerController:
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Player Controller";
                        Components.PlayerController PlayerControllerForm = new Components.PlayerController();
                        PlayerControllerForm.TopLevel = false;
                        PlayerControllerForm.AutoScroll = true;
                        PlayerControllerForm.playerController = (PlayerController)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(PlayerControllerForm);
                        PlayerControllerForm.Dock = DockStyle.Fill;
                        PlayerControllerForm.Show();
                        break;
                    case GUIText:
                        ObjectPictureBox.BackgroundImage = ImageList.text;
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Text";
                        Components.GUIText GUITextForm = new Components.GUIText();
                        GUITextForm.TopLevel = false;
                        GUITextForm.AutoScroll = true;
                        GUITextForm.guiText = (GUIText)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(GUITextForm);
                        GUITextForm.Dock = DockStyle.Fill;
                        GUITextForm.Show();
                        SelectTextureButton.Enabled = false;
                        break;
                    #pragma warning disable CS0612
                    case LogicComponent:
                        ObjectPictureBox.BackgroundImage = ImageList.cube_ryb;
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Logic";
                        Components.LogicComponent LogicComponentForm = new Components.LogicComponent();
                        LogicComponentForm.TopLevel = false;
                        LogicComponentForm.AutoScroll = true;
                        LogicComponentForm.logicComponent = (LogicComponent)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(LogicComponentForm);
                        LogicComponentForm.Dock = DockStyle.Fill;
                        LogicComponentForm.Show();
                        SelectTextureButton.Enabled = false;
                        break;
                    #pragma warning restore CS0612
                    case DialogSystem:
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Dialog";
                        ObjectPictureBox.BackgroundImage = ImageList.theatrical_masks;
                        Components.DialogSystem DialogSystemForm = new Components.DialogSystem();
                        DialogSystemForm.TopLevel = false;
                        DialogSystemForm.AutoScroll = true;
                        DialogSystemForm.dialogSystem = (DialogSystem)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(DialogSystemForm);
                        DialogSystemForm.Dock = DockStyle.Fill;
                        DialogSystemForm.Show();
                        SelectTextureButton.Enabled = false;
                        break;
                    #pragma warning disable CS0612
                    case ScriptComponent:
                        ComponentLabel.Visible = false;
                        ComponentNameLabel.Visible = true;
                        ComponentNameLabel.Text = "Script";
                        ObjectPictureBox.BackgroundImage = ImageList.script;
                        Components.ScriptComponent ScriptComponentForm = new Components.ScriptComponent();
                        ScriptComponentForm.TopLevel = false;
                        ScriptComponentForm.AutoScroll = true;
                        ScriptComponentForm.scriptComponent = (ScriptComponent)GameObjects[index].Components[0];
                        ComponentPanel.Controls.Add(ScriptComponentForm);
                        ScriptComponentForm.Dock = DockStyle.Fill;
                        ScriptComponentForm.Show();
                        SelectTextureButton.Enabled = false;
                        break;
                    #pragma warning restore CS0612
                }

        }
        #endregion

        #region Inspector | Region
        private void VisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedItem != null)
                GameObjects[ManagerListBox.SelectedIndex].Visible = VisibleCheckBox.Checked;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedItem != null)
                GameObjects[ManagerListBox.SelectedIndex].Name = NameTextBox.Text;
        }

        private void PosXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedItem != null)
            {
                try
                {
                    if (PosXTextBox.Text == string.Empty) PosXTextBox.Text = "0";
                    GameObjects[ManagerListBox.SelectedIndex].Position = new Vector2f(System.Convert.ToSingle(PosXTextBox.Text), GameObjects[ManagerListBox.SelectedIndex].Position.Y);
                }
                catch
                {
                    DebLog("Incorrect number format!");
                    PosXTextBox.Text = "0";
                }
            }
        }

        private void PosYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ManagerListBox.SelectedItem != null)
                {
                    if (PosYTextBox.Text == string.Empty) PosYTextBox.Text = "0";
                    GameObjects[ManagerListBox.SelectedIndex].Position = new Vector2f(GameObjects[ManagerListBox.SelectedIndex].Position.X, System.Convert.ToSingle(PosYTextBox.Text));
                }
            }
            catch
            {
                DebLog("Incorrect number format!");
                PosYTextBox.Text = "0";
            }
        }

        private void RotationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ManagerListBox.SelectedItem != null)
                {
                    if (RotationTextBox.Text == String.Empty) RotationTextBox.Text = "0";
                    GameObjects[ManagerListBox.SelectedIndex].Rotation = System.Convert.ToSingle(RotationTextBox.Text);
                }
            }
            catch
            {
                DebLog("Incorrect number format!");
                RotationTextBox.Text = "0";
            }
        }

        private void ScaleXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ManagerListBox.SelectedItem != null)
                {
                    if (ScaleXTextBox.Text == String.Empty) ScaleXTextBox.Text = "0";
                    GameObjects[ManagerListBox.SelectedIndex].Scale = new Vector2f(System.Convert.ToSingle(ScaleXTextBox.Text), GameObjects[ManagerListBox.SelectedIndex].Scale.Y);
                }
            }
            catch
            {
                DebLog("Incorrect number format!");
                ScaleXTextBox.Text = "0";
            }
        }

        private void ScaleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ManagerListBox.SelectedItem != null)
                {
                    if (ScaleYTextBox.Text == String.Empty) ScaleYTextBox.Text = "0";
                    GameObjects[ManagerListBox.SelectedIndex].Scale = new Vector2f(GameObjects[ManagerListBox.SelectedIndex].Scale.Y, System.Convert.ToSingle(ScaleYTextBox.Text));
                }
            }
            catch
            {
                DebLog("Incorrect number format!");
                ScaleYTextBox.Text = "0";
            }
        }

        private void SelectTextureButton_Click(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedItem != null)
            {
                SpriteManager spriteManager = new SpriteManager(ManagerType.Sprite);
                if (spriteManager.ShowDialog() == DialogResult.OK)
                {
                    TextureTextBox.Text = Sprites[spriteManager.SelectedIndex].Path;
                    GameObjects[ManagerListBox.SelectedIndex].TexturePath = Sprites[spriteManager.SelectedIndex].Path;
                    GameObjects[ManagerListBox.SelectedIndex].Sprite.Texture = new Texture(Sprites[spriteManager.SelectedIndex].Path);
                }
            }
        }
        #endregion

        #region Save | Load Map
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

        #endregion
    }
}
