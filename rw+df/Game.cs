using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    static class Game
    {
        public static bool running = false;
        public static bool debug_info = true;
        public static bool music = true;
        public static bool sounds = true;
        public static int step = 0;
        public static int FPMS = 14; // frames per millisecond
        public static GameObject[] objects = new GameObject[Map.map1.Length];
        public static ConsoleKeyInfo key_input;

        public static void WriteColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteLineColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
