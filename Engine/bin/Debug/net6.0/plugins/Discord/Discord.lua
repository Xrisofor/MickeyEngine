DiscordPlugin = Plugin("DiscordRichPresence", "$ENGINE_DATA/Plugins/Discord/Discord.dll", "DiscordRichPresence");

function Start()
    param = { "1072435853697228863" }
    DiscordPlugin.AddMethod("Initialize");
    DiscordPlugin.AddMethod("SetPresence");
    DiscordPlugin.AddMethod("DeInitialize");
    DiscordPlugin.InvokeMethod("Initialize", param);
    presense = { }
    presense[1] = "TEST DISCORD RPC"; -- Detail
    presense[2] = "This is a plugin for Mickey Engine"; -- State
    presense[3] = "large"; -- LargeImageKey
    presense[4] = "large"; -- SmallImageKey
    DiscordPlugin.InvokeMethod("SetPresence", presense);
end