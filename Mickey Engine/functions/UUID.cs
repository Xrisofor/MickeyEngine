using System;
using System.Runtime.InteropServices;

namespace Mickey_Engine
{
    /// <summary>
    /// Class for creating a uuid
    /// </summary>
    public class UUID
    {
        [DllImport("rpcrt4.dll", SetLastError = true)]
        static extern int UuidCreateSequential(out Guid guid);

        /// <summary>
        /// Function that creates a new uuid
        /// </summary>
        /// <returns>Generated uuid key</returns>
        public static Guid NewGuid()
        {
            const int RPC_S_OK = 0;
            Guid g;
            int hr = UuidCreateSequential(out g);
            if (hr != RPC_S_OK)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Debug.Log($"UUID Create Sequential failed: {hr}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return g;
        }
    }
}
