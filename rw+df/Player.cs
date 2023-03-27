using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    class Player : Creature
    {
        public new string name = "Игрок";
        public new string art = "☺";
        public new ConsoleColor color = ConsoleColor.Green;
        public new int x = 5;
        public new int y = 5;
        public int stamina = 10/10;
        public new int speed = 5;

        public void Move()
        {
            Game.key_input = Console.ReadKey(true);
            if (Game.step % speed == 0)
            {

                // Right
                if (Game.key_input.Key == ConsoleKey.D) ++x;

                // Down
                if (Game.key_input.Key == ConsoleKey.S) ++y;

                // Left
                if (Game.key_input.Key == ConsoleKey.A) --x;

                //Up
                if (Game.key_input.Key == ConsoleKey.W) --y;
                if (stamina < speed) stamina++;
            }
        }
        public Player(int x, int y) :base(x,y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
