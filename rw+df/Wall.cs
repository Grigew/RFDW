using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    class Wall : GameObject
    {
        public new string art = "■";
        public new ConsoleColor color = ConsoleColor.Blue;

        public Wall(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
