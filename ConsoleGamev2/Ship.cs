using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Ship
    {
        public static void drawShip(int left, int top,int poz)
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

        public static void clearShip(int left, int top, int poz)
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
