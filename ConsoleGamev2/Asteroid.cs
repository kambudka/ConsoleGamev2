using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Asteroid
    {
        public int pozleft,poztop,dir;
        
        public Asteroid(int left, int top, int direction)
        {
            pozleft = left;
            poztop = top;
            dir = direction;
        }

        // direction LECI W 0 - w prawo || 1 - lewo
        public void drawSmall(int pozleft, int top)
        {
            Console.SetCursorPosition(pozleft, top);
            Console.Write(" _____ ");
            Console.SetCursorPosition(pozleft, top + 1);
            Console.Write("/     \\");
            Console.SetCursorPosition(pozleft, top + 2);
            Console.Write("|     |");
            Console.SetCursorPosition(pozleft, top + 3);
            Console.Write(" \\___/ ");
        }
        public void destroySmall(int pozleft, int top)
        {
            Console.SetCursorPosition(pozleft, top);
            Console.Write("        ");
            Console.SetCursorPosition(pozleft, top + 1);
            Console.Write("        ");
            Console.SetCursorPosition(pozleft, top + 2);
            Console.Write("        ");
            Console.SetCursorPosition(pozleft, top + 3);
            Console.Write("        ");
        }

        public bool moveSmall()
        {
            if (dir == 0)
            {
                Console.SetCursorPosition(pozleft - 1, poztop);
                Console.Write("   ");
                Console.SetCursorPosition(pozleft - 1, poztop + 1);
                Console.Write("  ");
                Console.SetCursorPosition(pozleft - 1, poztop + 2);
                Console.Write("  ");
                Console.SetCursorPosition(pozleft - 1, poztop + 3);
                Console.Write("   ");
                if (pozleft + 2 >= 110)
                {
                    destroySmall(pozleft, poztop);
                    return false;
                }
                else
                {
                    drawSmall(pozleft + 2, poztop);
                    pozleft += 2;
                    //return true;
                }
            }
            else if (dir == 1)
            {
                Console.SetCursorPosition(pozleft + 5, poztop);
                Console.Write("   ");
                Console.SetCursorPosition(pozleft + 6, poztop + 1);
                Console.Write("  ");
                Console.SetCursorPosition(pozleft + 6, poztop + 2);
                Console.Write("  ");
                Console.SetCursorPosition(pozleft + 5, poztop + 3);
                Console.Write("   ");
                if (pozleft - 2 <= 0)
                {
                    destroySmall(pozleft, poztop);
                    return false;
                }
                else
                {
                    drawSmall(pozleft - 2, poztop);
                    pozleft -= 2;
                    //return true;
                }

            }
            return true;
        }
    }
}
