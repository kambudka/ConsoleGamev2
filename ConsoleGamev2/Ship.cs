using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGamev2
{
    class Ship
    {
        public static void DrawShip(int left, int top,int poz)
        {
            if (poz == 0)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(" /$\\ ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("|   | ");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("\\$$$/");
                Console.SetCursorPosition(left, top + 3);
                Console.Write(" ### ");
            }
            else if (poz == 1){
                Console.SetCursorPosition(left, top);
                Console.Write("/--");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("#$  \\");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("#$  $");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("#$  /");
                Console.SetCursorPosition(left, top + 4);
                Console.Write("\\--");
            }
            else if (poz == 2)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(" --\\");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("/  $#");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("$  $#");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("\\  $#");
                Console.SetCursorPosition(left, top + 4);
                Console.Write(" --/");
            }
            else if (poz == 3)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(" ### ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("/$$$\\");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("|   |");
                Console.SetCursorPosition(left, top + 3);
                Console.Write(" \\$/");

            }
        }

        public static void DrawShipExplode(int left, int top,int poz)
        {
            ClearShip(left, top, poz);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(left + 2, top + 1);
            Console.Write(" ** ");
            Console.SetCursorPosition(left + 2, top + 2);
            Console.Write(" * ");
            Thread.Sleep(200);
            Console.SetCursorPosition(left , top);
            Console.Write(" **   ** ");
            Console.SetCursorPosition(left, top + 3);
            Console.Write(" **   ** ");
            Thread.Sleep(200);
            Console.SetCursorPosition(left-2, top-1);
            Console.Write(" **        ** ");
            Console.SetCursorPosition(left-2, top + 4);
            Console.Write(" **        ** ");
            Thread.Sleep(200);
        }



        public static void ClearShip(int left, int top, int poz)
        {
            if (poz == 0)
            {
                Console.SetCursorPosition(left, top);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("     ");
            }
            else if (poz == 1)
            {
                Console.SetCursorPosition(left, top);
                Console.Write("   ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 4);
                Console.Write("   ");
            }
            else if (poz == 2)
            {
                Console.SetCursorPosition(left, top);
                Console.Write("    ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("      ");
                Console.SetCursorPosition(left, top + 4);
                Console.Write("    ");
            }
            else if (poz == 3)
            {
                Console.SetCursorPosition(left, top);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 1);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 2);
                Console.Write("     ");
                Console.SetCursorPosition(left, top + 3);
                Console.Write("    ");

            }

        }
    }
}
