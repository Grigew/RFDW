using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    class Creature : GameObject
    {
        public int hp = 100/100;
        public int speed = 10;
        public bool alive = true;

        public void Collision(int wallX, int wallY)
        {
            if (x++ == wallX)
            {
                --x;
            }
            if (x-- == wallX)
            {
                ++x;
            }
            if (y++ == wallY)
            {
                --y;
            }
            if (y-- == wallY)
            {
                ++y;
            }
        }
        public void MoveTo(int toX, int toY)
        {
            if (toX < x)
            {
                --x;
            }
            if (toX > x)
            {
                ++x;
            }
            if (toY < y)
            {
                --y;
            }
            if (toY > y)
            {
                ++y;
            }
        }
        public void Speak(string text)
        {
            Console.WriteLine($"{name} говорит: \"{text}\"");
        }
        public void Attack(Creature opponent)
        {
            Console.WriteLine(opponent.name + "был атакован" + name);
            opponent.hp -= 10/100;
        }
        public void Live() // Creature's live while
        { 
            if (hp == 0) { alive = false; } 
            
        } 
        public Creature(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }
    }
}