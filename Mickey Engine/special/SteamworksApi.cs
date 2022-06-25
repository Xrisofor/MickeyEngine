using System;
using System.Windows.Forms;
//Steamworks
using Steamworks;

namespace Mickey_Engine
{
    /// <summary>
    /// Steam Api Function Class.
    /// </summary>
    public class SW_SteamAPI
    {
        private static Timer RunAutoCallback = new Timer();

        /// <summary>
        /// The ID of your app. It can be installed via SW_SteamAPI.Init() or manually.
        /// </summary>
        public static AppId_t AppID;

        /// <summary>
        /// Initializes the Steamworks library, Steamworks Api and connects to Steam via AppID.
        /// </summary>
        /// <param name="_AppID">An optional variable is needed to connect an application or game to Steam.</param>
        public static void Init(string _AppID)
        {
            try
            {
                if (_AppID != "")
                {
                    Environment.SetEnvironmentVariable("SteamAppID", _AppID);
                    int v = Convert.ToInt32(_AppID);
                    uint value = Convert.ToUInt32(v);
                    AppID = new AppId_t(value);
                }
                SteamAPI.Init();
                SW_SteamUser.steamID = SW_SteamUser.GetSteamID();
            }
            catch
            {
                Debug.Log("The Steam process was not found. SteamApi Disconnections");
            }
        }

        /// <summary>
        /// Completes the connection process with Steam can also occur automatically when the application or game is closed.
        /// </summary>
        public static void Shutdown()
        {
            SteamAPI.Shutdown();
        }

        /// <summary>
        /// Checks whether the Steam client is open or not.
        /// </summary>
        /// <returns>Returns a bool variable, true if the Steam client is open and false if closed.</returns>
        public static bool IsSteamRunning()
        {
            return SteamAPI.IsSteamRunning();
        }

        /// <summary>
        /// Launch callbacks to the client and the Steam Api in general.
        /// </summary>
        /// <param name="EnabledAutoCallbacks">Automatic start of callbacks, the initial value is false.</param>
        /// <param name="Interval">Timer tick interval initial value 500.</param>
        public static void RunCallbacks(bool EnabledAutoCallbacks = false, int Interval = 500)
        {
            if (EnabledAutoCallbacks == true)
            {
                RunAutoCallback.Tick += RunAutoCallback_Tick;
                RunAutoCallback.Interval = Interval;
                RunAutoCallback.Enabled = true;
            }
            SteamAPI.RunCallbacks();
        }
        private static void RunAutoCallback_Tick(object sender, EventArgs e)
        {
            RunCallbacks();
        }

        /// <summary>
        /// Restarts applications if necessary.
        /// </summary>
        /// <param name="YourAppID">ID of your app.</param>
        public static void RestartAppIfNecessary(AppId_t YourAppID)
        {
            SteamAPI.RestartAppIfNecessary(YourAppID);
        }
    }

    /// <summary>
    /// Steam user's Friends class.
    /// </summary>
    public class SW_SteamFriends
    {
        /// <summary>
        /// Requests your nickname from Steam.
        /// </summary>
        /// <returns>Returns a nickname by string type.</returns>
        public static string GetPersonaName()
        {
            return SteamFriends.GetPersonaName();
        }

        /// <summary>
        /// Requests the name of any user via the Steam Api.
        /// </summary>
        /// <param name="_SteamIDPlayer">ID of the user whose name you want to get.</param>
        /// <returns>Returns the user name.</returns>
        public static string GetPlayerNickname(CSteamID _SteamIDPlayer)
        {
            return SteamFriends.GetPlayerNickname(_SteamIDPlayer);
        }
    }

    /// <summary>
    /// Application List class.
    /// </summary>
    public class SW_SteamAppList
    {
        /// <summary>
        /// Returns the name of the application.
        /// </summary>
        /// <param name="_AppID">ID of the application whose name you want to get.</param>
        /// <param name="AppName">Returns the application name via out.</param>
        /// <param name="MaxNameCount">The maximum value of the name, the initial value of 100.</param>
        /// <returns>Returns the number of characters in the application name.</returns>
        public static int GetAppName(AppId_t _AppID, out string AppName, int MaxNameCount = 100)
        {
            return SteamAppList.GetAppName(_AppID, out AppName, MaxNameCount);
        }

        /// <summary>
        /// Returns the path where the application is installed.
        /// </summary>
        /// <param name="_AppID">ID of the application whose path you want to get.</param>
        /// <param name="AppInstallDir">Returns the path to the folder of the installed application via out.</param>
        /// <param name="MaxNameCount">The maximum value of the path, the initial value is 300.</param>
        /// <returns>Returns the number of characters in the path to the application.</returns>
        public static int GetAppInstallDir(AppId_t _AppID, out string AppInstallDir, int MaxNameCount = 300)
        {
            return SteamAppList.GetAppInstallDir(_AppID, out AppInstallDir, MaxNameCount);
        }

        /// <summary>
        /// Requests all installed applications and games from Steam.
        /// </summary>
        /// <param name="_AppsID">Application IDs must be specified in the array.</param>
        /// <param name="MaxAppIDs">The maximum value of the ids, the initial value is 100.</param>
        /// <returns></returns>
        public static uint GetInstalledApps(AppId_t[] _AppsID, uint MaxAppIDs = 100)
        {
            return SteamAppList.GetInstalledApps(_AppsID, MaxAppIDs);
        }

        /// <summary>
        /// Requests from the Steam Api the number of all installed games and programs from the user's library.
        /// </summary>
        /// <returns>Returns the number of all installed games and apps.</returns>
        public static uint GetNumInstalledApps()
        {
            return SteamAppList.GetNumInstalledApps();
        }

        /// <summary>
        /// Requests the application build ID from the Steam Api.
        /// </summary>
        /// <param name="_AppID">ID of the application whose build you want to get.</param>
        /// <returns>Returns the ID of the application build.</returns>
        public static int GetAppBuildId(AppId_t _AppID)
        {
            return SteamAppList.GetAppBuildId(_AppID);
        }
    }

    /// <summary>
    /// Class of work with the Steam user.
    /// </summary>
    public class SW_SteamUser
    {
        /// <summary>
        /// The user ID can be set via SW_SteamAPI.Init() or manually.
        /// </summary>
        public static CSteamID steamID;

        /// <summary>
        /// Requests the user profile level via the Steam Api.
        /// </summary>
        /// <returns>Returns the user profile level.</returns>
        public static int GetPlayerSteamLevel()
        {
            return SteamUser.GetPlayerSteamLevel();
        }

        /// <summary>
        /// Requests a user ID via the Steam Api.
        /// </summary>
        /// <returns>Returns the user ID.</returns>
        public static CSteamID GetSteamID()
        {
            return SteamUser.GetSteamID();

        }

        /// <summary>
        /// Ends the authentication session.
        /// </summary>
        /// <param name="_steamID">ID of the user to end authentication session.</param>
        public static void EndAuthSession(CSteamID _steamID)
        {
            SteamUser.EndAuthSession(_steamID);
        }
    }

    /// <summary>
    /// Steam User Statistics class.
    /// </summary>
    public class SW_SteamUserStats
    {
        /// <summary>
        /// Steam Store Status.
        /// </summary>
        /// <returns>Returns the response states of the Steam store.</returns>
        public static bool StoreStats()
        {
            return SteamUserStats.StoreStats();
        }

        /// <summary>
        /// Requests the number of all app achievements from the Steam Api.
        /// </summary>
        /// <returns>Returns the number of all achievements that you can use in SW_SteamUserStats.GetAchievementName().</returns>
        public static uint GetNumAchievements()
        {
            return SteamUserStats.GetNumAchievements();
        }

        /*public static void AddAchievement(uint AchItem)
        {
            string name = SteamUserStats.GetAchievementName(AchItem);
            SteamUserStats.GetAchievement(name, out bool opened);
            if (!opened) SteamUserStats.SetAchievement(name);
            SteamUserStats.StoreStats();
        }*/

        /// <summary>
        /// Requests the Steam Api if the user has this achievement.
        /// </summary>
        /// <param name="AchCode">Code name of the Steam achievement.</param>
        /// <param name="isAch">Are there achievements or not.</param>
        /// <returns>Returns the variable whether the user has this achievement.</returns>
        public static bool GetAchievement(string AchCode, out bool isAch)
        {
            return SteamUserStats.GetAchievement(AchCode, out isAch);
        }

        /// <summary>
        /// Requests the Steam Api whether the user has this achievement and at what time it was received.
        /// </summary>
        /// <param name="AchCode">Code name of the Steam achievement.</param>
        /// <param name="isAch">Are there achievements or not.</param>
        /// <param name="UnlockTime">Time of achievement receipt.</param>
        /// <returns>Returns the variable whether the user has this achievement and at what time it was opened.</returns>
        public static bool GetAchievementAndUnlockTime(string AchCode, out bool isAch, out uint UnlockTime)
        {
            return SteamUserStats.GetAchievementAndUnlockTime(AchCode, out isAch, out UnlockTime);
        }

        /// <summary>
        /// Requests an achievement icon from the Steam Api.
        /// </summary>
        /// <param name="AchCode">Code name of the Steam achievement.</param>
        /// <returns>Returns the icon as a number.</returns>
        public static int GetAchievementIcon(string AchCode)
        {
            return SteamUserStats.GetAchievementIcon(AchCode);
        }

        /// <summary>
        /// Requests from the Steam Api the codename of the achievement via an ordinal number.
        /// </summary>
        /// <param name="iAch">The sequential number of the achievement.</param>
        /// <returns>Returns the codename of the achievement.</returns>
        public static string GetAchievementName(uint iAch)
        {
            return SteamUserStats.GetAchievementName(iAch);
        }

        /// <summary>
        /// Deleting an achievement from a user.
        /// </summary>
        /// <param name="AchCode">Code name of the Steam achievement.</param>
        public static void ClearAchievement(string AchCode)
        {
            SteamUserStats.ClearAchievement(AchCode);
        }

        /// <summary>
        /// Changes the app achievement values for the user.
        /// </summary>
        /// <param name="AchCode">Code name of the Steam achievement.</param>
        /// <returns>Returns the status of the change processing.</returns>
        public static bool SetAchievement(string AchCode)
        {
            return SteamUserStats.SetAchievement(AchCode);
        }
    }

    /// <summary>
    /// A class of utilities for working with Steam.
    /// </summary>
    public class SW_SteamUtils
    {
        /// <summary>
        /// Requests the application ID from the file "steam_appid.txt" or from an already running program using SW_SteamAPI.Init().
        /// </summary>
        /// <returns>Returns the application ID.</returns>
        public static AppId_t GetAppID()
        {
            return SteamUtils.GetAppID();
        }

        /// <summary>
        /// Asks the Steam client about the interface language.
        /// </summary>
        /// <returns>Returns the interface language in English, for example "english".</returns>
        public static string GetSteamUILanguage()
        {
            return SteamUtils.GetSteamUILanguage();
        }

        /// <summary>
        /// Receives the server in real time.
        /// </summary>
        /// <returns>Returns server values in real time.</returns>
        public static uint GetServerRealTime()
        {
            return SteamUtils.GetServerRealTime();
        }

        /// <summary>
        /// Checks whether the Steam overlay process is running in this application or game.
        /// </summary>
        /// <returns>Returns true if the overlay process is added and false if not.</returns>
        public static bool IsOverlayEnabled()
        {
            return SteamUtils.IsOverlayEnabled();
        }

        /// <summary>
        /// Checks if the game or applications are running via Steam VR.
        /// </summary>
        /// <returns>Returns true if the app or game is open via Steam VR, and false if not.</returns>
        public static bool IsSteamRunningInVR()
        {
            return SteamUtils.IsSteamRunningInVR();
        }

        /// <summary>
        /// Gets seconds from the moment the app is activated.
        /// </summary>
        /// <returns>Returns seconds after app activation.</returns>
        public static uint GetSecondsSinceAppActive()
        {
            return SteamUtils.GetSecondsSinceAppActive();
        }

        /// <summary>
        /// Gets the region of the country via IP.
        /// </summary>
        /// <returns>Returns the region in English, for example "US".</returns>
        public static string GetIPCountry()
        {
            return SteamUtils.GetIPCountry();
        }
    }
}
