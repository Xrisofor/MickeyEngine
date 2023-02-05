using SFML.Graphics;
using SFML.Window;

namespace Editor.App
{
    public class Window : RenderWindow
    {
        public static VideoMode VideoMode = new VideoMode(1280, 720);

        public Window() : base(VideoMode, "Viewer - No Map", Styles.Close)
        {
            SFML.Graphics.Image icon = new SFML.Graphics.Image($@"{Environment.CurrentDirectory}\components\editor_icon.png");
            this.SetIcon(icon.Size.X, icon.Size.Y, icon.Pixels);
            #pragma warning disable
            this.Closed += OnClose;
            #pragma warning restore
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                e.Item.ForeColor = System.Drawing.Color.White;
                base.OnRenderMenuItemBackground(e);
            }
            else
            {
                Pen oPen = new Pen(System.Drawing.Color.White);
                SolidBrush oBrsh = new SolidBrush(System.Drawing.Color.FromArgb(61, 61, 61));

                e.Item.ForeColor = System.Drawing.Color.White;
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(oBrsh, rc);
                e.Graphics.DrawRectangle(oPen, 0, 0, rc.Width, rc.Height);

                oPen.Dispose();
                oBrsh.Dispose();
            }
        }
    }
}
