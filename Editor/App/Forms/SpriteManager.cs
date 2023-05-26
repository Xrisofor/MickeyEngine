namespace Editor.App.Forms
{
    public partial class SpriteManager : Form
    {
        public SpriteManager()
        {
            InitializeComponent();
            //var m = imageList1.Images.Cast<SFML.Graphics.Image>().ToArray();
            //Texture texture = new Texture(m[0]);
        }

        private void AddImgButton_Click(object sender, EventArgs e)
        {
            if (SelectImageFile.ShowDialog() == DialogResult.OK)
            {
                imageList1.Images.Add(SelectImageFile.SafeFileName, Image.FromFile(SelectImageFile.FileName));
                listView1.Items.Add(SelectImageFile.SafeFileName, SelectImageFile.SafeFileName);
            }
        }

        private void RemoveImgButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                imageList1.Images.RemoveByKey(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
