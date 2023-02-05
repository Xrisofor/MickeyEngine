DiscordPlugin = Plugin("DiscordRichPresence", "$ENGINE_DATA/Plugins/Discord/Discord.dll", "DiscordRichPresence");

function Start()
    param = { "989807940007518238" }
    DiscordPlugin.AddMethod("Initialize");
    DiscordPlugin.AddMethod("SetPresence");
    DiscordPlugin.AddMethod("DeInitialize");
    DiscordPlugin.InvokeMethod("Initialize", param);
    presense = { }
    presense[1] = "TEST DISCORD RPC"; -- Detail
    presense[2] = "This is a plugin for Mickey Engine"; -- State
    presense[3] = "c-sharp"; -- LargeImageKey
    presense[4] = "vs"; -- SmallImageKey
    DiscordPlugin.InvokeMethod("SetPresence", presense);
end