using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.App.Paint
{
    public class PaintForm
    {
        public static void Separator_Paint(Object sender, PaintEventArgs e)
        {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(33, 37, 41)), 0, 0, width, height);
            e.Graphics.DrawLine(new Pen(Color.White), 4, height / 2, width - 4, height / 2);
        }
    }
}
