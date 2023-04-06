using Engine.App;

namespace Engine.Classes.ScriptFunc
{
    public class GetObject
    {
        #pragma warning disable
        public static GameObject GetGameObject(string Name)
        {
            return Window.GameObjects.Find(item => item.Name == Name);
        }

        public static Component GetComponent(GameObject Copy)
        {
            return Copy.Components[0];
        }
        #pragma warning restore
    }
}
