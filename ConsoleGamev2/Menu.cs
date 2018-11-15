using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Menu
    {
        private static int index = 0;

        public static int ShowMenu()
        {
            List<string> menuItems = new List<string>() {
                "Nowa Gra",
                "Wyniki",
                "Twórcy",
                "Exit"
            };
            
            Console.CursorVisible = false;
            Console.SetWindowSize(122,40 );
            while (true)
            {
                string selectedMenuItem = drawMenu(menuItems);
                Console.Clear();
                if (selectedMenuItem == "Nowa Gra")
                {
                    Console.Clear();
                    return 1;
                }
                else if (selectedMenuItem == "Wyniki")
                {
                    Console.Clear();
                    return 2;
                }
                else if (selectedMenuItem == "Twórcy")
                {
                    Console.Clear();
                    return 3;
                }
                else if (selectedMenuItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }

        public static void drawTitle()
        {
            Console.SetCursorPosition(20,3);
            Console.WriteLine(" _______  _______ _________ _______  _______  _______ _________ ______   _______");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("(  ___  )(  ____  \\__   __/(  ____ \\(  ____ )(  ___  )\\__   __/(  __  \\ (  ____ \\ ");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("| (   ) || (    \\/   ) (   | (    \\/| (    )|| (   ) |   ) (   | (  \\  )| (    \\/ ");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("| (___) || (_____    | |   | (__    | (____)|| |   | |   | |   | |   ) || (_____ ");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("|  ___  |(_____  )   | |   |  __)   |     __)| |   | |   | |   | |   | |(_____  ) ");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("| (   ) |      ) |   | |   | (      | (\\ (   | |   | |   | |   | |   ) |      ) |");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("| )   ( |/\\____) |   | |   | (____/\\| ) \\ \\__| (___) |___) (___| (__/  )/\\____) |");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("|/     \\|\\_______)   )_(   (_______/|/   \\__/(_______)\\_______/(______/ \\_______)");

        }

        public static void drawNowaGra(int left,int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("     __                       ___           ");
            Console.SetCursorPosition(left, top+1);
            Console.Write("  /\\ \\ \\_____      ____ _    / _ \\_ __ __ _ ");
            Console.SetCursorPosition(left, top+2);
            Console.Write(" /  \\/ / _ \\ \\ /\\ / / _` |  / /_\\/ '__/ _` |");
            Console.SetCursorPosition(left, top+3);
            Console.Write("/ /\\  / (_) \\ V  V / (_| | / /_\\\\| | | (_| |");
            Console.SetCursorPosition(left, top+4);
            Console.Write("\\_\\ \\/ \\___/ \\_/\\_/ \\__,_| \\____/|_|  \\__,_|");
        }

        public static void drawWyniki(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(" __    __             _ _    _ ");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("/ / /\\ \\ \\_   _ _ __ (_) | _(_)");
            Console.SetCursorPosition(left, top + 2);
            Console.Write("\\ \\/  \\/ / | | | '_ \\| | |/ / |");
            Console.SetCursorPosition(left, top + 3);
            Console.Write(" \\  /\\  /| |_| | | | | |   <| |");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("  \\/  \\/  \\__, |_| |_|_|_|\\_\\_|");
            Console.SetCursorPosition(left, top + 5);
            Console.Write("          |___/                ");
        }

        public static void drawAutorzy(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("   _         _                       ");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("  /_\\  _   _| |_ ___  _ __ _____   _ ");
            Console.SetCursorPosition(left, top + 2);
            Console.Write(" //_\\\\| | | | __/ _ \\| '__|_  / | | |");
            Console.SetCursorPosition(left, top + 3);
            Console.Write("/  _  \\ |_| | || (_) | |   / /| |_| |");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("\\_/ \\_/\\__,_|\\__\\___/|_|  /___|\\__, |");
            Console.SetCursorPosition(left, top + 5);
            Console.Write("                               |___/ ");
        }

        public static void drawExit(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("   __      _ _   ");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("  /__\\_  _(_) |_ ");
            Console.SetCursorPosition(left, top + 2);
            Console.Write(" /_\\ \\ \\/ / | __|");
            Console.SetCursorPosition(left, top + 3);
            Console.Write("//__  >  <| | |_ ");
            Console.SetCursorPosition(left, top + 4);
            Console.Write("\\__/ /_/\\_\\_|\\__|");
        }

        public static string drawMenu(List<string> items)
        {
            int top = 12;
            drawTitle();
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.SetCursorPosition(50, top);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    if(i == 0)
                        drawNowaGra(35, top);
                    else if (i == 1)
                        drawWyniki(42, top);
                    else if (i == 2)
                        drawAutorzy(40, top);
                    else if (i == 3)
                        drawExit(50, top);
                    //Console.WriteLine(items[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (i == 0)
                        drawNowaGra(35, top);
                    else if (i == 1)
                        drawWyniki(42, top);
                    else if (i == 2)
                        drawAutorzy(40, top);
                    else if (i == 3)
                        drawExit(50, top);
                    //Console.SetCursorPosition(50, 12+i);
                    //Console.WriteLine(items[i]);
                }
                Console.ResetColor();
                top += 6;
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}