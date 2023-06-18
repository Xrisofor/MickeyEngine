using Editor.Project;

namespace Editor.App
{
    public class Program
    {
        public static MainForm MainForm;
        public static Structur ProjectInfo { get; set; } = new Structur();

        public static SFML.Graphics.Font EditorFont = new SFML.Graphics.Font(ImageList.arial);
        public static Grid EditorGrid = new Grid();

        //String
        public static string ProjectFolder { get; set; }
        public static string SaveFolderPath { get; set; } = string.Empty;

        //Bool
        public static bool ShowGrid = true;

        //Удалить
        public static Inspector Form = new Inspector();
        public static Editor Form2 = new Editor();
        public static Window Window;
        //Уже не нужно

        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            MainForm = new MainForm(args);
            Application.Run(MainForm);
        }
    }
}