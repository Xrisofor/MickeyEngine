using Editor.App.Classes;
using Newtonsoft.Json;

namespace Editor.App.Forms
{
    public partial class SpriteManager : Form
    {
        public int SelectedIndex { get; private set; }

        private ManagerType ManagerType;

        public SpriteManager(ManagerType Type)
        {
            InitializeComponent();
            ManagerType = Type;

            OtherList.Images.Add("audio", ImageList.audio_100px);
            OtherList.Images.Add("font", ImageList.font);

            switch (Type)
            {
                case ManagerType.Sprite:
                    Text = "Sprite Manager";
                    ObjectsListView.LargeImageList = SpritesList;
                    foreach (Sprites sprite in MainForm.Sprites)
                    {
                        SpritesList.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                        ObjectsListView.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
                    }
                    break;
                case ManagerType.Audio:
                    Text = "Audio Manager";
                    ObjectsListView.LargeImageList = OtherList;
                    foreach (Sprites audio in MainForm.Audio)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(audio.Path), "audio");
                    }
                    break;
                case ManagerType.Font:
                    Text = "Fonts Manager";
                    ObjectsListView.LargeImageList = OtherList;
                    foreach (Sprites fonts in MainForm.Fonts)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(fonts.Path), "font");
                    }
                    break;
            }
        }

        private void AddImgButton_Click(object sender, EventArgs e)
        {
            switch (ManagerType)
            {
                case ManagerType.Sprite:
                    if (SelectImageFile.ShowDialog() == DialogResult.OK)
                    {
                        SpritesList.Images.Add(SelectImageFile.SafeFileName, Image.FromFile(SelectImageFile.FileName));
                        ObjectsListView.Items.Add(SelectImageFile.SafeFileName, SelectImageFile.SafeFileName);
                        File.Copy(SelectImageFile.FileName, $"{Program.ProjectFolder}/content/images/{SelectImageFile.SafeFileName}", true);
                        MainForm.Sprites.Add(new Sprites($"{Program.ProjectFolder}/content/images/{SelectImageFile.SafeFileName}"));
                        Save();
                    }
                    break;
                case ManagerType.Audio:
                    if (SelectAudioFile.ShowDialog() == DialogResult.OK)
                    {
                        ObjectsListView.Items.Add(SelectAudioFile.SafeFileName, "audio");
                        File.Copy(SelectAudioFile.FileName, $"{Program.ProjectFolder}/content/audio/{SelectAudioFile.SafeFileName}", true);
                        MainForm.Audio.Add(new Sprites($"{Program.ProjectFolder}/content/audio/{SelectAudioFile.SafeFileName}"));
                        Save();
                    }
                    break;
                case ManagerType.Font:
                    if (SelectFontFile.ShowDialog() == DialogResult.OK)
                    {
                        ObjectsListView.Items.Add(SelectFontFile.SafeFileName, "font");
                        File.Copy(SelectFontFile.FileName, $"{Program.ProjectFolder}/content/{SelectFontFile.SafeFileName}", true);
                        MainForm.Fonts.Add(new Sprites($"{Program.ProjectFolder}/content/{SelectFontFile.SafeFileName}"));
                        Save();
                    }
                    break;
            }
        }

        private void RemoveImgButton_Click(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count != 0)
            {
                switch (ManagerType)
                {
                    case ManagerType.Sprite:
                        File.Delete($"{Program.ProjectFolder}/content/images/{ObjectsListView.SelectedItems[0].Text}");
                        MainForm.Sprites.RemoveAt(ObjectsListView.SelectedIndices[0]);
                        SpritesList.Images.RemoveByKey(ObjectsListView.SelectedItems[0].Text);
                        ObjectsListView.Items.Remove(ObjectsListView.SelectedItems[0]);
                        Save();
                        break;
                    case ManagerType.Audio:
                        File.Delete($"{Program.ProjectFolder}/content/audio/{ObjectsListView.SelectedItems[0].Text}");
                        MainForm.Audio.RemoveAt(ObjectsListView.SelectedIndices[0]);
                        ObjectsListView.Items.Remove(ObjectsListView.SelectedItems[0]);
                        Save();
                        break;
                    case ManagerType.Font:
                        File.Delete($"{Program.ProjectFolder}/content/{ObjectsListView.SelectedItems[0].Text}");
                        MainForm.Fonts.RemoveAt(ObjectsListView.SelectedIndices[0]);
                        ObjectsListView.Items.Remove(ObjectsListView.SelectedItems[0]);
                        Save();
                        break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count != 0)
                SelectedIndex = ObjectsListView.SelectedIndices[0];
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Save()
        {
            switch (ManagerType)
            {
                case ManagerType.Sprite:
                    File.Create($@"{Program.ProjectFolder}\content\images\sprites.json").Close();
                    using (StreamWriter file = File.CreateText($@"{Program.ProjectFolder}\content\images\sprites.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, MainForm.Sprites);
                    }
                    break;
                case ManagerType.Audio:
                    File.Create($@"{Program.ProjectFolder}\content\audio\audios.json").Close();
                    using (StreamWriter file = File.CreateText($@"{Program.ProjectFolder}\content\audio\audios.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, MainForm.Audio);
                    }
                    break;
                case ManagerType.Font:
                    File.Create($@"{Program.ProjectFolder}\content\fonts.json").Close();
                    using (StreamWriter file = File.CreateText($@"{Program.ProjectFolder}\content\fonts.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, MainForm.Fonts);
                    }
                    break;
            }
        }

        private void ReloadImgButton_Click(object sender, EventArgs e)
        {
            ObjectsListView.Items.Clear();
            SpritesList.Images.Clear();

            switch (ManagerType)
            {
                case ManagerType.Sprite:
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
                        SpritesList.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                        ObjectsListView.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
                    }
                    break;
                case ManagerType.Audio:
                    MainForm.Audio.Clear();
                    string allAudioData = File.ReadAllText(Program.ProjectInfo.AudioManager);
                    dynamic? jsonAudioData = JsonConvert.DeserializeObject(allAudioData);

                    #pragma warning disable
                    foreach (var audioData in jsonAudioData)
                    {
                        string Path = audioData.Path;
                        MainForm.Audio.Add(new App.Classes.Sprites(Path));
                    }
                    #pragma warning restore

                    foreach (Sprites audio in MainForm.Audio)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(audio.Path), "audio");
                    }
                    break;
                case ManagerType.Font:
                    MainForm.Fonts.Clear();
                    string allFontsData = File.ReadAllText(Program.ProjectInfo.FontsManager);
                    dynamic? jsonFontsData = JsonConvert.DeserializeObject(allFontsData);

                    #pragma warning disable
                    foreach (var fontData in jsonFontsData)
                    {
                        string Path = fontData.Path;
                        MainForm.Fonts.Add(new App.Classes.Sprites(Path));
                    }
                    #pragma warning restore

                    foreach (Sprites font in MainForm.Fonts)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(font.Path), "font");
                    }
                    break;
            }
        }
    }

    public enum ManagerType
    {
        Audio,
        Sprite,
        Font
    }
}
