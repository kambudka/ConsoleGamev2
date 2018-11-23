using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGamev2
{
    class Interface
    {
        public static void DrawInterface()
        {
            //Heart Section
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 0);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.SetCursorPosition(0, 1);
            Console.Write("░                               ░                                                              ░                         ░");
            Console.SetCursorPosition(0, 2);
            Console.Write("░                               ░                                                              ░                         ░");
            Console.SetCursorPosition(0, 3);
            Console.Write("░                               ░                                                              ░                         ░");
            Console.SetCursorPosition(0, 4);
            Console.Write("░                               ░                                                              ░                         ░");
            Console.SetCursorPosition(0, 5);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.ResetColor();

        }
        public static void DrawHearths(int count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int poz=1;
            for (int i = 1; i <= 3; i++)
            {
                if(i>count)
                    Console.ForegroundColor = ConsoleColor.Black;
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

        public static void DrawPoints(int points)
        {
            string myString = points.ToString();
            char[] arr;
            arr = myString.ToCharArray(0, myString.Length);

            if (myString.Length == 1)
            {
                DrawBlank(113, 1);
                PickNumber(arr[0], 113, 1);
            }
            else if(myString.Length == 2)
            {
                DrawBlank(113, 1);
                DrawBlank(106, 1);
                PickNumber(arr[0], 106, 1);
                PickNumber(arr[1], 113, 1);
            }
            else if(myString.Length == 3)
            {
                DrawBlank(113, 1);
                DrawBlank(106, 1);
                DrawBlank(99, 1);
                PickNumber(arr[0], 99, 1);
                PickNumber(arr[1], 106, 1);
                PickNumber(arr[2], 113, 1);
            }


        }
        public static void DrawEndGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("_________          _______ _________                     _       _________ _       ");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("\\__   __/|\\     /|(  ___  )\\__    _/  |\\     /||\\     /|( (    /|\\__   __/| \\    /\\");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("   ) (   | )   ( || (   ) |   )  (    | )   ( |( \\   / )|  \\  ( |   ) (   |  \\  / /");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("   | |   | | _ | || |   | |   |  |    | | _ | | \\ (_) / |   \\ | |   | |   |  (_/ / ");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("   | |   | |( )| || |   | |   |  |    | |( )| |  \\   /  | (\\ \\) |   | |   |   _ (  ");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("   | |   | || || || |   | |   |  |    | || || |   ) (   | |\\   |   | |   |  ( \\ \\ ");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("   | |   | () () || (___) ||\\_)  )    | () () |   | |   | )  \\  |___) (___|  /  \\ \\");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("   )_(   (_______)(_______)(____/     (_______)   \\_/   |/    )_)\\_______/|_/    \\/");


        }

        public static void AnimateEndEnter()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Thread.Sleep(100);

                Console.SetCursorPosition(40, 17);
                Console.WriteLine("Aby przejsc do MENU nacisnij ENTER");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo ckey = Console.ReadKey();
                    if (ckey.Key == ConsoleKey.Enter)
                    {
                        break;
                    };
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(100);
                Console.SetCursorPosition(40, 17);
                Console.WriteLine("Aby przejsc do MENU nacisnij ENTER");
            }
        }

        public static void DrawEndPoints(int points)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string myString = points.ToString();
            char[] arr;
            arr = myString.ToCharArray(0, myString.Length);

            if (myString.Length == 1)
            {
                PickNumber(arr[0], 54, 12);
            }
            else if (myString.Length == 2)
            {
                PickNumber(arr[0], 47, 12);
                PickNumber(arr[1], 54, 12);
            }
            else if (myString.Length == 3)
            {

                PickNumber(arr[0], 40, 12);
                PickNumber(arr[1], 47, 12);
                PickNumber(arr[2], 54, 12);
            }


        }
        private static void PickNumber(char liczba,int left, int top)
        {
            switch (liczba)
            {
                case '0':
                    DrawZero(left, top);
                    break;
                case '1':
                    DrawOne(left, top);
                    break;
                case '2':
                    DrawTwo(left, top);
                    break;
                case '3':
                    DrawThree(left, top);
                    break;
                case '4':
                    DrawFour(left, top);
                    break;
                case '5':
                    DrawFive(left, top);
                    break;
                case '6':
                    DrawSix(left, top);
                    break;
                case '7':
                    DrawSeven(left, top);
                    break;
                case '8':
                    DrawEight(left, top);
                    break;
                case '9':
                    DrawNine(left, top);
                    break;
                default:
                    DrawOne(left, top);
                    break;
            }

        }
        public static void DrawStartPoints()
        {
            int poz = 99;
            for (int i = 1; i <= 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                DrawZero(poz, 1);
                poz += 7;
            }
        }
        private static void DrawBlank(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("      ");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("      ");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("      ");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("      ");
        }
        private static void DrawZero(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  __  ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /  \\ ");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("( () )");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine(" \\__/ ");
        }
        private static void DrawOne(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" __ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("/  )");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine(" )( ");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("(__)");
        }
        private static void DrawTwo(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("(__ \\");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine(" / _/");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("(___)");
        }
        private static void DrawThree(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("(__ )");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine(" (_ \\");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("(___/");
        }
        private static void DrawFour(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  __ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /. |");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("(___)");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("  (_)");
        }
        private static void DrawFive(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("| __)");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|__ \\");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("(___/");
        }
        private static void DrawSix(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  _  ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" / ) ");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("/ _ \\");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("\\___/");
        }
        private static void DrawSeven(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("(__ )");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine(" / / ");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("(_/  ");
        }
        private static void DrawEight(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("( _ )");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("/ _ \\");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("\\___/");
        }
        private static void DrawNine(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("/ _ \\");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("\\_  /");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine(" (_/ ");
        }
    }
}
