using Editor.App.Classes;
using Newtonsoft.Json;

namespace Editor.App.Forms
{
    public partial class SpriteManager : Form
    {
        public int SelectedIndex { get; private set; }

        public SpriteManager()
        {
            InitializeComponent();

            foreach (Sprites sprite in MainForm.Sprites)
            {
                imageList1.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                listView1.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
            }
        }

        private void AddImgButton_Click(object sender, EventArgs e)
        {
            if (SelectImageFile.ShowDialog() == DialogResult.OK)
            {
                imageList1.Images.Add(SelectImageFile.SafeFileName, Image.FromFile(SelectImageFile.FileName));
                listView1.Items.Add(SelectImageFile.SafeFileName, SelectImageFile.SafeFileName);
                File.Copy(SelectImageFile.FileName, $"{Program.ProjectFolder}/content/images/{SelectImageFile.SafeFileName}", true);
                MainForm.Sprites.Add(new Classes.Sprites(SelectImageFile.FileName));
                SaveImages();
            }
        }

        private void RemoveImgButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                File.Delete($"{Program.ProjectFolder}/content/images/{listView1.SelectedItems[0].Text}");
                MainForm.Sprites.RemoveAt(listView1.SelectedIndices[0]);
                imageList1.Images.RemoveByKey(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                SaveImages();
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

        private void SaveImages()
        {
            File.Create($@"{Program.ProjectFolder}\content\images\sprites.json").Close();
            using (StreamWriter file = File.CreateText($@"{Program.ProjectFolder}\content\images\sprites.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                serializer.Serialize(file, MainForm.Sprites);
            }
        }

        private void ReloadImgButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            imageList1.Images.Clear();
            MainForm.Sprites.Clear();

            string allSpritesData = File.ReadAllText(Program.ProjectInfo.SpriteManager);
            dynamic? jsonSpritesData = JsonConvert.DeserializeObject(allSpritesData);

            #pragma warning disable
            foreach (var spritesData in jsonSpritesData)
            {
                string Path = spritesData.Path;
                MainForm.Sprites.Add(new App.Classes.Sprites(Path));
            }
            #pragma warning restore
            
            foreach (Sprites sprite in MainForm.Sprites)
            {
                imageList1.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                listView1.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
            }
        }
    }
}
