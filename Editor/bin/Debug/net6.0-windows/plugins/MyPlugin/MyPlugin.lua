MyPlugin = Plugin("MyPlugin", "$ENGINE_DATA/Plugins/MyPlugin/MyPlugin.dll", "MyPlugin");

function Start()
    --print(MyPlugin.Name);
    param = { }
    MyPlugin.AddMethod("GetVersion");
    --MyPlugin.AddMethod("AddNewCommand");
    --print(MyPlugin.InvokeMethod("AddNewCommand", param));
    print(MyPlugin.InvokeMethod("GetVersion", param));
    print(MyTestCommand);
end