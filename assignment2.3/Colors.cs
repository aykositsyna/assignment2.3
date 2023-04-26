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
        public static class Foreground
        {
            public static string RESET = Console.IsOutputRedirected ? "" : "\x1b[39m";
            public static string BLACK = Console.IsOutputRedirected ? "" : "\x1b[30m";
            public static string RED = Console.IsOutputRedirected ? "" : "\x1b[31m";
            public static string GREEN = Console.IsOutputRedirected ? "" : "\x1b[32m";
            public static string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[33m";
            public static string BLUE = Console.IsOutputRedirected ? "" : "\x1b[34m";
            public static string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[35m";
            public static string CYAN = Console.IsOutputRedirected ? "" : "\x1b[36m";
            public static string WHITE = Console.IsOutputRedirected ? "" : "\x1b[37m";
            public static string LIGHTGRAY = Console.IsOutputRedirected ? "" : "\x1b[90m";
            public static string LIGHTRED = Console.IsOutputRedirected ? "" : "\x1b[91m";
            public static string LIGHTGREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            public static string LIGHTYELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            public static string LIGHTBLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";
            public static string LIGHTMAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
            public static string LIGHTCYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
            public static string LIGHTWHITE = Console.IsOutputRedirected ? "" : "\x1b[97m";
            public static string VIOLET = Console.IsOutputRedirected ? "" : "\x1b[38;5;91m";
        }
    }
}
