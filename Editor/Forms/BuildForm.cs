using Engine;
using Encryption;
using System.Windows.Forms;
using Engine.Classes.Components;
using SFML.System;
using Editor.App;

namespace Editor.Forms
{
    public partial class BuildForm : Form
    {
        public BuildForm()
        {
            InitializeComponent();
        }

        private void BuildForm_Shown(object sender, EventArgs e)
        {
            label1.Text = "Creating folders";
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build");
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Audio");
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Images");
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Scripts");
            progressBar1.Value = 5;

            string EngineCode = "";

            foreach (GameObject gameObject in Editor.App.Program.Form2.GameObjects)
            {
                string TextureName = String.Empty;

                if (gameObject.Sprite.Texture != null && gameObject.TexturePath != null)
                {
                    if (!File.Exists($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Images\{Path.GetFileName(gameObject.TexturePath)}"))
                        File.Copy(gameObject.TexturePath, $@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Images\{Path.GetFileName(gameObject.TexturePath)}"); label1.Text = $"Copying a file: {gameObject.TexturePath}"; TextureName = Path.GetFileName(gameObject.TexturePath);
                }

                if (gameObject.Sprite.Texture != null && gameObject.TexturePath != null)
                    EngineCode = EngineCode + $"{gameObject.Name} = GameObject(\"$GAME_DATA/Images/{TextureName}\");\n";
                else
                    EngineCode = EngineCode + $"{gameObject.Name} = GameObject();\n";

                EngineCode = EngineCode + $"{gameObject.Name}.Position = {Vector2(gameObject.Position)};\n";
                EngineCode = EngineCode + $"{gameObject.Name}.Scale = {Vector2(gameObject.Scale)};\n";
                EngineCode = EngineCode + $"{gameObject.Name}.Rotation = {gameObject.Rotation};\n";
                EngineCode = EngineCode + $"{gameObject.Name}.Visible = {gameObject.Visible.ToString().ToLower()};\n";

                #pragma warning disable
                for (int i = 0; i < gameObject.Components.Length; i++)
                {
                    switch (gameObject.Components[i])
                    {
                        case Engine.Classes.Components.AudioSource:
                            Engine.Classes.Components.AudioSource audioSource = (Engine.Classes.Components.AudioSource)gameObject.Components[i];
                            if(!File.Exists($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Audio\{Path.GetFileName(audioSource.File)}"))
                                File.Copy(audioSource.File, $@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Audio\{Path.GetFileName(audioSource.File)}"); label1.Text = $"Copying a file: {audioSource.File}";
                            EngineCode = EngineCode + $"{gameObject.Name}.AddComponent(AudioSource({audioSource.Type}, \"$GAME_DATA/Audio/{Path.GetFileName(audioSource.File)}\"));\n";
                            break;
                        case Engine.Classes.Components.ScriptComponent:
                            Engine.Classes.Components.ScriptComponent scriptComponent = (Engine.Classes.Components.ScriptComponent)gameObject.Components[i];
                            string script = File.ReadAllText(scriptComponent.File);
                            script = Core.Encrypt(script);
                            string file = Path.GetFileName(scriptComponent.File); file = Path.ChangeExtension(file, ".script");
                            File.Create($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Scripts\{file}").Close();
                            File.WriteAllText($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Scripts\{file}", script);
                            label1.Text = $"Copying a file: {scriptComponent.File}";
                            EngineCode = EngineCode + $"{gameObject.Name}.AddComponent(ScriptComponent(\"$GAME_DATA/Scripts/{file}\"));\n";
                            break;
                        case Engine.Classes.Components.PlayerController:
                            Engine.Classes.Components.PlayerController playerController = (Engine.Classes.Components.PlayerController)gameObject.Components[i];
                            EngineCode = EngineCode = $"{gameObject.Name}.AddComponent(PlayerController());";
                            break;
                    }
                }
                #pragma warning restore

                File.Create($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Scripts\All.lua").Close();
                File.WriteAllText($@"{Path.GetDirectoryName(Editor.App.Program.Form2.FilePath)}\Build\Scripts\All.lua", EngineCode);
            }
        }

        private string Vector2(Vector2f vector2F)
        {
            string temp = $"Vector2({vector2F.X.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {vector2F.Y.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))})";
            return temp;
        }
    }
}
