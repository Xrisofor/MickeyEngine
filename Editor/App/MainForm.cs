//Engine
using Engine;
using Engine.Classes.Components;
//SFML
using SFML.Graphics;
using SFML.System;
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
        public static Grid EditorGrid = new Grid(); public static bool ShowGrid = true;

        public static List<GameObject> GameObjects { get; private set; } = new List<GameObject>();
        public static List<Sprites> Sprites { get; private set; } = new List<Sprites>();

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

            DebLog("Running the editor");

            Clock DeltaClock = new Clock();
            while (Visible)
            {
                float DeltaTime = DeltaClock.Restart().AsSeconds();
                Application.DoEvents();
                Window.DispatchEvents();

                Window.Clear();

                foreach (GameObject GameObjects in GameObjects)
                {
                    GameObjects.Update(DeltaTime);

                    if (GameObjects.Visible && GameObjects.Sprite.Texture != null)
                        Window.Draw(GameObjects);
                    if (GameObjects.Visible && GameObjects.Components.Length != 0)
                        if (GameObjects.Components[0].ComponentName == "GUIText" || GameObjects.Visible && GameObjects.Components[0].ComponentName == "Prefab")
                            Window.Draw(GameObjects);
                }

                if (ShowGrid)
                    Window.Draw(EditorGrid);

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
                ShowGrid = false;
            }
            else
            {
                ShowGrid_TSM.Checked = true;
                ShowGrid = true;
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

            ConsoleListBox.Items.Clear();
            DebLog("Closing map editing");
        }

        private void ExitButton_TSM_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SpriteManager_TSM_Click(object sender, EventArgs e)
        {
            SpriteManager spriteManager = new SpriteManager();
            spriteManager.ShowDialog();
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
            DialogSystem dialogSystem = new DialogSystem();
            AddObject(dialogSystem);
        }

        private void AddTargetGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            AddObject();
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

            ObjectPictureBox.BackgroundImage = ImageList._object;

            UpdateInspector(ManagerListBox.SelectedIndex);
        }

        private void UpdateInspector(int index)
        {
            if (GameObjects[index].Components.Length != 0)
                switch (GameObjects[index].Components[0])
                {
                    case AudioSource:
                        ObjectPictureBox.BackgroundImage = ImageList.audio;
                        break;
                    case PrefabComp:
                        ObjectPictureBox.BackgroundImage = ImageList.prefabhouse;
                        break;
                    case GUIText:
                        ObjectPictureBox.BackgroundImage = ImageList.text;
                        break;
#pragma warning disable CS0612
                    case LogicComponent:
                        ObjectPictureBox.BackgroundImage = ImageList.cube_ryb;
                        break;
#pragma warning restore CS0612
                    case DialogSystem:
                        ObjectPictureBox.BackgroundImage = ImageList.theatrical_masks;
                        break;
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
                    if (PosXTextBox.Text == String.Empty) PosXTextBox.Text = "0";
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
                    if (PosYTextBox.Text == String.Empty) PosYTextBox.Text = "0";
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
                SpriteManager spriteManager = new SpriteManager();
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
