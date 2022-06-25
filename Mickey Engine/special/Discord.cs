using System;
//DiscordRPC
using DiscordRPC;
using DiscordRPC.Logging;

namespace Mickey_Engine
{
    /// <summary>
    /// Class for managing Discord Rich Presence
    /// </summary>
    public class Discord
    {
        /// <summary>
        /// Discord Client
        /// </summary>
        public static DiscordRpcClient client;
        /// <summary>
        /// Initialization status
        /// </summary>
        public static bool Initialized = false;

        /// <summary>
        /// ID of your app from Discord Developer Portal
        /// </summary>
        public static string applicationID { get; set; }

        /// <summary>
        /// Initialize discord
        /// </summary>
        public static void Initialize(string _applicationID)
        {
            try
            {
                Initialized = true;
                client = new DiscordRpcClient(_applicationID);
                applicationID = _applicationID;
                //client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                client.Initialize();
                Debug.Log("Discord has been successfully initialized");
            }
            catch
            {
                Initialized = false;
            }
        }

        /// <summary>
        /// User status update
        /// </summary>
        /// <param name="details">Status Details</param>
        /// <param name="state">Status State</param>
        /// <param name="largeImageKey">Large Image Key for status</param>
        /// <param name="largeImageText">Large Image Text for status</param>
        /// <param name="smallImageKey">Small Image Key for status</param>
        /// <param name="smallImageText">Small Image Text for status</param>
        public static void Update(string details = "Engine", string state = "Loading...", string largeImageKey = "key", string largeImageText = "Engine", string smallImageKey = "", string smallImageText = "Engine")
        {
            if(Initialized)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = details,
                    State = state,
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = largeImageKey,
                        LargeImageText = largeImageText,
                        SmallImageKey = smallImageKey,
                        SmallImageText = smallImageText
                    }
                });
                Debug.Log("Successful update of Rich Presence data");
            }
        }
    }
}
