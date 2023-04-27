using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    static class Colors
    {
        public static string RESET = Console.IsOutputRedirected ? "" : "\x1b[0m";
       
        public static Dictionary<string, string> Foreground = new Dictionary<string, string>()
        {
            ["RESET"] = Console.IsOutputRedirected ? "" : "\x1b[39m",
            ["BLACK"] = Console.IsOutputRedirected ? "" : "\x1b[30m",
            ["RED"] = Console.IsOutputRedirected ? "" : "\x1b[31m",
            ["GREEN"] = Console.IsOutputRedirected ? "" : "\x1b[32m",
            ["YELLOW"] = Console.IsOutputRedirected ? "" : "\x1b[33m",
            ["BLUE"] = Console.IsOutputRedirected ? "" : "\x1b[34m",
            ["MAGENTA"] = Console.IsOutputRedirected ? "" : "\x1b[35m",
            ["CYAN"] = Console.IsOutputRedirected ? "" : "\x1b[36m",
            ["WHITE"] = Console.IsOutputRedirected ? "" : "\x1b[37m",
            ["LIGHTGRAY"] = Console.IsOutputRedirected ? "" : "\x1b[90m",
            ["LIGHTRED"] = Console.IsOutputRedirected ? "" : "\x1b[91m",
            ["LIGHTGREEN"] = Console.IsOutputRedirected ? "" : "\x1b[92m",
            ["LIGHTYELLOW"] = Console.IsOutputRedirected ? "" : "\x1b[93m",
            ["LIGHTBLUE"] = Console.IsOutputRedirected ? "" : "\x1b[94m",
            ["LIGHTMAGENTA"] = Console.IsOutputRedirected ? "" : "\x1b[95m",
            ["LIGHTCYAN"] = Console.IsOutputRedirected ? "" : "\x1b[96m",
            ["LIGHTWHITE"] = Console.IsOutputRedirected ? "" : "\x1b[97m"
        };
    }
}
