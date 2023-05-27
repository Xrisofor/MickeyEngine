namespace Editor.App.Forms
{
    public partial class SpriteManager : Form
    {
        public int SelectedIndex { get; private set; }

        public SpriteManager()
        {
            InitializeComponent();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                SelectedIndex = listView1.SelectedIndices[0];
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
