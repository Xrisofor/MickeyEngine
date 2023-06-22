namespace Editor.App.Forms
{
    public class PluginMBase
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Version { get; set; }
        public string Icon { get; set; }
        public string? Folder { get; set; }

        public PluginMBase(string Name, string? Folder)
        {
            this.Name = Name;
            this.Folder = Path.GetDirectoryName(Folder);
        }
    }
}
