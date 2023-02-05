using Editor.App;

namespace Editor.Forms
{
    public partial class CreateObject : Form
    {
        public string ObjectName = "GameObject";
        public string ObjectType = "GameObject";

        public CreateObject()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ObjectName = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectType = comboBox1.Text;
        }

        private void CreateObject_Load(object sender, EventArgs e)
        {
            foreach(string item in Objects.ComponentList)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
