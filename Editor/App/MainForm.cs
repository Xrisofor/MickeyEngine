using Editor.App.Paint;
using Engine;
using SFML.Graphics;
using SFML.Window;
using System.Windows.Forms;

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
        #endregion
    }
}
