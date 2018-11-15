using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Autorzy
    {
        public static void drawTitle()
        {
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("   _____          __                              ");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("  /  _  \\  __ ___/  |_  ______________________.__.");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine(" /  /_\\  \\|  |  \\   __\\/  _ \\_  __ \\___   <   |  |");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("/    |    \\  |  /|  | (  <_> )  | \\//    / \\___  |");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("\\____|__  /____/ |__|  \\____/|__|  /_____ \\/ ____|");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("        \\/                               \\/\\/     ");

        }

        public static void ShowAutors()
        {
            drawTitle();
            Console.ReadKey();
        }
    }
}
