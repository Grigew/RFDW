using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rw_df
{
    static class Map
    {
        public static int x = 0;
        public static int y = 0;

        public static string[] map1 = """
             ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■'  
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ . . . . . . . . . . ■' 
             ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
             """.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        public static string[,] map2 = new string[4000, 4000];

        public static void Build()
        {
            //  1d map to 2d map
            for (int i = 0; i < map1.Length; ++i)
            {
                map2[x, y] = map1[i];
                if (map2[x, y] == "■'")
                {
                    y++;
                    x = 0;
                }             
                ++x;
                if (map2[x, y] == "■")
                {
                    
                }
            }
        }
        public static void Render()
        {
            for (int l = 0; l <= Map.y; ++l)
            {
                for (int i = 0; i <= Map.x; ++i)
                {
                    Console.Write(Map.map2[i, l] + " ");   
                    
                }        
            }
        }
    }
}
