using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Forms
{
    public partial class Engine : Form
    {
        public Engine()
        {
            InitializeComponent();
        }

        private void AddVersionButton_Click(object sender, EventArgs e)
        {
            AddEngine addEngine = new AddEngine();
            if(addEngine.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
