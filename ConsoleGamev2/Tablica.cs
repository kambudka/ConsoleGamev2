using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamev2
{
    class Tablica
    {
        private static int index = 0;
        public static void ShowTable()
        {
            List<string> nameItems = new List<string>() {
                "Kamil",
                "Piotr",
                "Łukasz",
                "Maciek"
            };
            List<string> scoreItems = new List<string>() {
                "100",
                "75",
                "50",
                "25"
            };

            Console.Clear();
            for (int i = 0; i < nameItems.Count; i++)
            {
                    Console.SetCursorPosition(50, 12 + i);

                    Console.WriteLine(nameItems[i]);
            }

            for (int i = 0; i < scoreItems.Count; i++)
            {
                    Console.SetCursorPosition(60, 12 + i);

                    Console.WriteLine(scoreItems[i]);
                Console.ResetColor();
            }
            Console.Read();
            Console.Clear();
        }

    }
}
