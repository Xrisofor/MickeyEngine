using Editor.App.Paint;
using Engine;
using SFML.Graphics;
using Engine.Classes.Components;
using System.Resources;
using Editor.App.Forms;

namespace Editor.App
{
    public partial class MainForm : Form
    {
        public static RenderWindow Window { get; private set; }
        public static List<GameObject> GameObjects { get; private set; } = new List<GameObject>();
        public static Grid EditorGrid = new Grid(); public static bool ShowGrid = true;

        public MainForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            Window = new RenderWindow(sfmlPanel.Handle);

            DebLog("Running the editor");

            while (Visible)
            {
                Application.DoEvents();
                Window.DispatchEvents();

                Window.Clear();

                if (ShowGrid)
                    Window.Draw(EditorGrid);

                Window.Display();
            }
        }

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
        }

        private void ExitButton_TSM_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SpriteManager_TSM_Click(object sender, EventArgs e)
        {
            SpriteManager spriteManager = new SpriteManager();
            if(spriteManager.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #region TSM Add Button | Region
        private void AddASGameObjectButton_TSM_Click(object sender, EventArgs e)
        {
            AudioSource audioSource = new AudioSource("Sound", $@"{Environment.CurrentDirectory}\components\audiosource.wav");
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

            NameTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Name; RotationTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Rotation.ToString();
            PosXTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Position.X.ToString();
            PosYTextBox.Text = GameObjects[ManagerListBox.SelectedIndex].Position.Y.ToString();

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
    }
}
