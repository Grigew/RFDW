using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    class GameObject
    {
        public string? name;
        public string art = "○";
        public int x = 0;
        public int y = 0;
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor color = ConsoleColor.White;
        public GameObject(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
