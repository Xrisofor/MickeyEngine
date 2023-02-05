using Editor.App.Paint;
using Engine;
using SFML.Graphics;
using SFML.Window;

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

            while(Visible)
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
        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        private void toolStripSeparator3_Paint(object sender, PaintEventArgs e)
        {
            PaintForm.Separator_Paint(sender, e);
        }
        #endregion
    }
}
