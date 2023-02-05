using Engine.App;
using System.Reflection;

namespace Engine
{
    //The main class for plugins
    public class Plugin
    {
        public string Name { get; private set; }
        public List<MethodInfo> MethodInfos { get; private set; } = new List<MethodInfo>();
        public Assembly Assembly { get; private set; } public Object Instance { get; private set; } = new object(); public Type Type { get; private set; }

        //Creating a new plugin
        public Plugin(string Name, string Path, string Namespace)
        {
            this.Name = Name;
            Assembly = Assembly.LoadFrom(Config.ReplaceFunction(Path));
            #pragma warning disable
            Instance = Assembly.CreateInstance(Namespace);
            Type = Assembly.GetType(Namespace);
            #pragma warning restore
        }

        //Adding a new method
        public void AddMethod(string Name)
        {
            #pragma warning disable
            MethodInfos.Add(Type.GetMethod(Name));
            #pragma warning restore
        }

        //Function call
        public object InvokeMethod(string Name, Object[] Objects)
        {
            #pragma warning disable
            MethodInfo mi = MethodInfos.Find(item => item.Name == Name);
            return mi.Invoke(Instance, Objects);
            #pragma warning restore
        }

        public static Plugin NewPlugin(string Name, string Path, string Namespace)
        {
            return new Plugin(Name, Path, Namespace);
        }
    }
}
