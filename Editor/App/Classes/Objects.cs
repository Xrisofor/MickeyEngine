using Editor.Forms;
using Engine;
using System.Windows.Forms;

namespace Editor.App
{
    public class Objects
    {
        public static List<string> ComponentList = new List<string>()
        {
          "Audio Source",
          "Animation",
          "Dialog",
          "Logic",
          "Player Controller",
          "Script"
          //"Text"
        };

        public static void NewObject()
        {
            CreateObject CreateForm = new CreateObject();
            if (CreateForm.ShowDialog() == DialogResult.OK)
            {
                GameObject NewGameObject = new GameObject(CreateForm.ObjectName);
                NewGameObject.Name = CreateForm.ObjectName;

                switch (CreateForm.ObjectType)
                {
                    case "Player Controller":
                        NewGameObject.AddComponent(new Engine.Classes.Components.PlayerController());
                        break;
                    case "Audio Source":
                        NewGameObject.AddComponent(new Engine.Classes.Components.AudioSource("Sound", $@"{Environment.CurrentDirectory}\components\AudioSource.wav"));
                        break;
                    case "Animation":
                        //NewGameObject.AddComponent(new Engine.Classes.Components.AnimationComponent());
                        break;
                    case "Script":
                        if (Program.Form2.FilePath != string.Empty)
                            NewGameObject.AddComponent(new Engine.Classes.Components.ScriptComponent($@"{Path.GetDirectoryName(Program.Form2.FilePath)}\{NewGameObject.Name}.lua"));
                        else NewGameObject.AddComponent(new Engine.Classes.Components.ScriptComponent($@"{Environment.CurrentDirectory}\{NewGameObject.Name}.lua"));
                        break;
                    case "Logic":
                        NewGameObject.AddComponent(new Engine.Classes.Components.LogicComponent());
                        break;
                    case "Dialog":
                        NewGameObject.TexturePath = $@"{Environment.CurrentDirectory}\components\textbox.png";
                        NewGameObject.Sprite = new SFML.Graphics.Sprite(new SFML.Graphics.Texture(NewGameObject.TexturePath));
                        DialogSystem dialogSystem = new DialogSystem();
                        if (Program.Form2.FilePath != string.Empty)
                            dialogSystem.DialogFile = $@"{Path.GetDirectoryName(Program.Form2.FilePath)}\{NewGameObject.Name}.json";
                        else dialogSystem.DialogFile = $@"{Environment.CurrentDirectory}\{NewGameObject.Name}.json";
                        NewGameObject.AddComponent(dialogSystem);
                        File.Create(dialogSystem.DialogFile).Close();
                        using (StreamWriter sw = new StreamWriter(dialogSystem.DialogFile))
                        {
                            sw.WriteLine("{");
                            sw.WriteLine("  \"Dialogs\": [");
                            sw.WriteLine("    {");
                            sw.WriteLine("      \"Name\": \"Mickey\",");
                            sw.WriteLine("      \"Text\": \"Hello\"");
                            sw.WriteLine("    },");
                            sw.WriteLine("    {");
                            sw.WriteLine("      \"Name\": \"Mickey\",");
                            sw.WriteLine("      \"Text\": \"This is an example of a dialog written in Mickey Engine\"");
                            sw.WriteLine("    }");
                            sw.WriteLine("  ]");
                            sw.WriteLine("}");
                        }
                        break;
                }

                Program.Form2.GameObjects.Add(NewGameObject);
                Program.Form2.AddListBoxItem(NewGameObject.Name);
            }
        }
    }
}
