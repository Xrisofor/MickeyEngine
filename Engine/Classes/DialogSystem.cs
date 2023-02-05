using Engine.App;
using SFML.Graphics;
using SFML.System;
using Newtonsoft.Json;
using System.IO;

namespace Engine
{
    public class DialogLines
    {
        public string Name;
        public string Text;

        public DialogLines(string Text, string Name = "")
        {
            this.Name = Name;
            this.Text = Text;
        }
    }

    public class DialogSystem : Component
    {
        private List<DialogLines> dialogLines;

        private int currentLine;
        private Text dialogText;
        private Text dialogCharacter;

        public uint NameSize = 28, DialogSize = 24;
        public string NameColor = "White", DialogColor = "White";
        public string DialogFile;

        public DialogSystem()
        {
            ComponentName = "DialogSystem";
            dialogLines = new List<DialogLines>();
            dialogLines.Add(new DialogLines(""));
            currentLine = 0;

            dialogText = new Text("", Config.GameFont, DialogSize);
            dialogCharacter = new Text("", Config.GameFont, NameSize);
            dialogText.Position = new Vector2f(50, 550);
            dialogCharacter.Position = new Vector2f(50, 510);
        }

        public void AddLine(string line, string character = "")
        {
            dialogLines.Add(new DialogLines(line, character));
        }

        public void NextLine()
        {
            if (currentLine < dialogLines.Count - 1)
            {
                currentLine++;
                dialogText.DisplayedString = dialogLines[currentLine].Text;
                dialogCharacter.DisplayedString = dialogLines[currentLine].Name;
            }
            else
            {
                dialogText.DisplayedString = "";
                dialogCharacter.DisplayedString = "";
            }
        }

        public static void LoadDialogs(string Path)
        {
            string allData = File.ReadAllText(Config.ReplaceFunction(Path));
            dynamic? jsonData = JsonConvert.DeserializeObject(allData);

            #pragma warning disable
            foreach (var data in jsonData["Dialogs"])
            {
                string Name = data.Name, Text = data.Text;
                Window.Dialog.AddLine(Text, Name);
            }
            #pragma warning restore
        }

        public override void Awake() { }

        public override void Draw(RenderTarget Target, RenderStates States) {
            Target.Draw(dialogText);
            Target.Draw(dialogCharacter);
        }

        public override void Update(float DeltaTime) { }
    }
}
