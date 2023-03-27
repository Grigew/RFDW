using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace rw_df
{
    static class Menu
    {
        // Fields
        public static bool running = true;
        public static ConsoleColor select_color = ConsoleColor.Cyan;
        static int choice = 0;

        // Methods
        public static void Choice(string text, int choice_input, int choice_number, bool check_mark = false)
        {
            if (check_mark) text += " +";
            if (choice_input == choice_number) Game.WriteLineColor($"{text}", select_color);
            else Console.WriteLine(text);
        }
        public static int Choose(int max_choice, int current_choice, ConsoleKeyInfo key_input)
        {
            if (key_input.Key == ConsoleKey.UpArrow) current_choice--;
            if (key_input.Key == ConsoleKey.DownArrow) current_choice++;

            if (current_choice > max_choice) current_choice = 0;
            if (current_choice < 0) current_choice = max_choice;

            return current_choice;
        }
        public static void Build()
        {
            choice = 0;
            while (Menu.running)
            {
                Console.Clear();

                Game.WriteLineColor("\n\tДобро пожаловать!\n", ConsoleColor.Yellow);
                Menu.Choice("\tНачать игру", choice, 0);
                Menu.Choice("\tНастройки", choice, 1);
                Menu.Choice("\tВыход", choice, 2);
                Game.WriteLineColor("\n*Для перехода между пунктами используйте стрелки на клавиатуре, чтобы подтвердить выбор нажмите Enter*", ConsoleColor.DarkGray);

                Game.key_input = Console.ReadKey();
                choice = Menu.Choose(2, choice, Game.key_input);

                if (Game.key_input.Key == ConsoleKey.Enter)
                {
                    if (choice == 0) // Start game button
                    {
                        Game.running = true;
                        Menu.running = false;
                    }
                    if (choice == 1) // Settings button
                    {
                        BuildSettings();
                    }  
                    if (choice == 2) // Quit button
                    {
                        Menu.BuildQuit();
                    }
                }
            }
        }
        public static void BuildQuit()
        {
            choice = 0;

            while (true)
            
            {
                Console.Clear();
                Game.WriteLineColor("Вы точно хотите выйти?", ConsoleColor.Red);

                Choice("Нет", choice, 0);
                Choice("Да", choice, 1);

                Game.key_input = Console.ReadKey();

                choice = Choose(1, choice, Game.key_input);

                if (Game.key_input.Key == ConsoleKey.Enter)
                {
                    if (choice == 0) break;
                    if (choice == 1)
                    {
                        Console.Clear();
                        running = false;
                        break;
                    }
                }
            }
        }
        public static void BuildSettings()
        {
            choice = 0;

            bool[] check_mark = new bool[3];

            while (true)
            {
                check_mark[2] = Game.debug_info;

                Console.Clear();
                Game.WriteLineColor("\n\tНастройки\n", ConsoleColor.Yellow);
                Choice($"\tЗвук (coming soon)", choice, 0, check_mark[0]);
                Choice($"\tМузыка (coming soon)", choice, 1, check_mark[1]);
                Choice($"\tИнфо для разработчиков", choice, 2, check_mark[2]);
                Choice("\n\tНазад в главное меню", choice, 3);

                Game.key_input = Console.ReadKey();

                choice = Choose(3, choice, Game.key_input);

                if (Game.key_input.Key == ConsoleKey.Enter)
                {
                    if (choice == 0)
                    {
                        check_mark[0] = !check_mark[0];
                    }

                    if (choice == 1)
                    {
                        check_mark[1] = !check_mark[1];
                    }

                    if (choice == 2)
                    {
                        Game.debug_info = !Game.debug_info;
                        
                    }

                    if (choice == 3)
                    {
                        break;
                    }
                }
            }
        }

    }
}
