using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Interface
    {
        public static void drawInterface()
        {
            //Heart Section
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 0);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.SetCursorPosition(0, 1);
            Console.Write("░                               ░                                                                                        ░");
            Console.SetCursorPosition(0, 2);
            Console.Write("░                               ░                                                                                        ░");
            Console.SetCursorPosition(0, 3);
            Console.Write("░                               ░                                                                                        ░");
            Console.SetCursorPosition(0, 4);
            Console.Write("░                               ░                                                                                        ░");
            Console.SetCursorPosition(0, 5);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.ResetColor();

        }
        public static void drawHearths(int count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int poz=1;
            for (int i = 1; i <= count; i++)
            {
                Console.SetCursorPosition(poz, 1);
                Console.WriteLine(" ::: ::: ");
                Console.SetCursorPosition(poz, 2);
                Console.WriteLine(":::::::::");
                Console.SetCursorPosition(poz, 3);
                Console.WriteLine("  :::::  ");
                Console.SetCursorPosition(poz, 4);
                Console.WriteLine("   :::   ");
                poz += 10;

            }
            Console.ResetColor();
        }
    }
}
