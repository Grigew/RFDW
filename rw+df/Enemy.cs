using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    class Enemy : Creature
    {
        public new string name = "Враг";
        public new string art = "&";
        public new ConsoleColor color = ConsoleColor.Yellow;
        public new int x = 7;
        public new int y = 3;
        public Enemy(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
