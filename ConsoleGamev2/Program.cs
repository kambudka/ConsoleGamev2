using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleGamev2;

namespace ConsoleApp1
{
    class Ship
    {
        public int posX, posY; public String direction; public bool life;
        public char[,] shipUp = new char[4, 5] {{' ' ,'/' ,'$' ,'\\' ,' ' },
                                              { '|',' ' ,' ' ,' ' , '|'  },
                                              { '\\','@' ,'@' ,'@' , '/'  },
                                              { ' ','#' ,'#' ,'#' , ' '  },
                                             };
        public char[,] shipDown = new char[4, 5] {{' ' ,'#' ,'#' ,'#' ,' ' },
                                              { '/','@' ,'@' ,'@' , '\\'  },
                                              { '|',' ' ,' ' ,' ' , '|'  },
                                              { ' ','\\' ,'$' ,'/' , ' '  },
                                             };
        public char[,] shipRight = new char[5, 4] {{' ' ,'/' ,'-' ,' '  },
                                              { '#','@' ,' ' ,'\\'  },
                                              { '#','@' ,' ' ,'$'   },
                                              { '#','@' ,' ' ,'/'   },
                                              { ' ','\\' ,'-' ,' '  },
                                             };
        public char[,] shipLeft = new char[5, 4] {{' ' ,'-' ,'\\' ,' '  },
                                              { '/',' ' ,'@' ,'#'  },
                                              { '$',' ' ,'@' ,'#'   },
                                              { '\\',' ' ,'@' ,'#'   },
                                              { ' ','-' ,'/' ,' '  },
                                             };

    }
    class Missile
    {
        public char[] missile = new char[1] { '+' };
        public int posX, posY, moveX, moveY;
        public bool onWay;
    }
    class BigAsteroid
    {
        public int moveX, moveY, posX, posY; public bool destroyed;
        public char[,] bigas = new char[6, 6]{{' ' ,' ' ,'_' ,'_' ,' ' ,' '},
                                          {' ' ,'/' ,' ' ,' ' ,'\\' , ' ' },
                                          { '|',' ' ,' ' ,' ' , ' ' ,'|' },
                                          { '|',' ' ,' ' ,' ' , ' ' ,'|' },
                                          { '|',' ' ,' ' ,' ' , ' ' ,'|' },
                                          {'\\' ,'_' ,'_' ,'_' ,'_' ,'/' }};

    }
    class MediumAsteroid
    {
        public int moveX, moveY, posX, posY; public bool destroyed;
        public char[,] bigast = new char[4, 4]{{' ' ,'_' ,'_' ,' '  },
                                          {'/' ,' ' ,' ' ,'\\' },
                                          { '|',' ' ,' ' ,'|' ,  },
                                          { '\\','_' ,'_' ,'/' ,  }
                                          };
    }
    class SmallAsteroid
    {
        public int moveX, moveY, posX, posY;
        public string[,] smallast = new string[2, 2]{{"/" ,"\\"  },

                                          { "\\" ,"/"    }
                                          };
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Map nowa = new Map();
            int menuitem = 0;
            while (true)
            {
                while (menuitem != 1)
                {
                    menuitem = Menu.ShowMenu();
                    if (menuitem == 2)
                        Tablica.ShowTable();
                    else if (menuitem == 3)
                        Autorzy.ShowAutors();

                }
                Interface.drawInterface();
                Interface.drawHearths(3);
                nowa.drawMap();
                menuitem = 0;
                Console.Clear();
                Console.ResetColor();
            }
            int mapHeight = 50, mapWidth = 100;
            Random rng = new Random();
            int countB = 0, countM = 0, countS = 0;
            int i, y, j, n, m;
            Dictionary<int, MediumAsteroid> bigd = new Dictionary<int, MediumAsteroid>();


            List<int> array = new List<int>();

            MediumAsteroid big = new MediumAsteroid();

            char[][] render = new char[mapHeight][];
            for (y = 0; y < mapHeight; ++y)
                render[y] = new char[mapWidth];
            Ship ship = new Ship();
            ship.direction = "UP";
            ship.life = true;
            Missile miss = new Missile();
            miss.onWay = false;
            ship.posX = 25;
            ship.posY = 25;
            int previous = 0;
            char[,] map = new char[mapHeight, mapWidth];
            Console.CursorVisible = false;

            for (i = 0; i < mapHeight; i++)
            {
                Console.Write("\n");
                for (y = 0; y < mapWidth; y++)
                {
                    map[i, y] = ' ';
                }
            }
            for (i = 0; i < mapHeight; i++)
            {
                Console.Write("\n");
                for (y = 0; y < mapWidth; y++)
                {
                    Console.Write(map[i, y]);
                }
            }

            while (true)
            {
                Interface.drawHearths(1);
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                if (countB < 6)
                {
                    big = new MediumAsteroid();
                    big.destroyed = false;
                    int a = rng.Next(1, 5);
                    if (previous == a)
                        a = rng.Next(1, 5);
                    previous = a;

                    if (a == 1)
                    {
                        big.moveX = 0;
                        big.moveY = -1;
                        big.posX = rng.Next(5, 45);
                        big.posY = 100;
                    }
                    if (a == 2)
                    {
                        big.moveX = -1;
                        big.moveY = 0;
                        big.posX = 50;
                        big.posY = rng.Next(5, 75);
                    }
                    if (a == 3)
                    {
                        big.moveX = 0;
                        big.moveY = 1;
                        big.posX = rng.Next(5, 40);
                        big.posY = 0;
                    }
                    if (a == 4)
                    {
                        big.moveX = -1;
                        big.moveY = 0;
                        big.posX = 0;
                        big.posY = rng.Next(5, 75);
                    }
                    int key = rng.Next(1, 100000);
                    array.Add(key);
                    bigd.Add(key, big);
                    countB++;
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key.Equals(ConsoleKey.UpArrow))
                    {
                        ship.direction = "UP";
                        ship.posX--;
                    }
                    if (key.Key.Equals(ConsoleKey.DownArrow))
                    {
                        ship.direction = "DOWN";
                        ship.posX++;
                    }
                    if (key.Key.Equals(ConsoleKey.LeftArrow))
                    {
                        ship.direction = "LEFT";
                        ship.posY--;
                    }
                    if (key.Key.Equals(ConsoleKey.RightArrow))
                    {
                        ship.direction = "RIGHT";
                        ship.posY++;
                    }
                    if (key.Key.Equals(ConsoleKey.Spacebar))
                    {
                        miss.onWay = true;
                        miss.posX = ship.posX;
                        miss.posY = ship.posY;
                        if (ship.direction == "RIGHT")
                        {
                            miss.moveX = 0;
                            miss.moveY = 1;
                        }
                        if (ship.direction == "LEFT")
                        {
                            miss.moveX = 0;
                            miss.moveY = -1;
                        }
                        if (ship.direction == "UP")
                        {
                            miss.moveX = -1;
                            miss.moveY = 0;
                        }
                        if (ship.direction == "DOWN")
                        {
                            miss.moveX = 1;
                            miss.moveY = 0;
                        }

                    }
                }

                if (miss.onWay == true)
                {
                    if (miss.posX < mapHeight && miss.posY < mapWidth && miss.posX > 0 && miss.posY > 0)
                    {
                        map[miss.posX, miss.posY] = miss.missile[0];
                        miss.posX = miss.posX + miss.moveX;
                        miss.posY = miss.posY + miss.moveY;
                    }
                    else
                        miss.onWay = false;

                }

                for (j = 0; j < array.Count; j++)
                {
                    if (bigd.Keys.Contains(array[j]))
                    {
                        big = bigd[array[j]];
                        if (big.destroyed == false)
                        {
                            for (i = 0; i < 4; i++)
                            {

                                for (y = 0; y < 4; y++)
                                {
                                    if (big.posX - i < mapHeight - 4 && big.posX - i > 4 && big.posY - y < mapWidth - 4 && big.posY > 4)
                                    {

                                        if (map[big.posX - i, big.posY - y].Equals('+'))
                                        {
                                            miss.onWay = false;
                                            big.destroyed = true;
                                        }
                                        else
                                            map[big.posX - i, big.posY - y] = big.bigast[i, y];
                                    }

                                    if (big.posX > 55 || big.posX < -5 || big.posY > 105 || big.posY < -5)
                                        big.destroyed = true;

                                }


                            }

                            big.posX = big.posX + big.moveX;
                            big.posY = big.posY + big.moveY;
                            bigd.Remove(array[j]);
                            bigd.Add(array[j], big);
                        }
                        else
                        {

                            for (n = 0; n < 4; n++)
                            {
                                for (m = 0; m < 4; m++)
                                {
                                    if (big.posX - n < mapHeight - 4 && big.posX - n > 4 && big.posY - m < mapWidth - 4 && big.posY > 4)
                                    {
                                        map[big.posX - n, big.posY - m] = ' ';

                                    }


                                }
                            }
                            bigd.Remove(array[j]);


                            countB--;
                        }
                    }
                }

                if (ship.direction == "RIGHT")
                {
                    for (i = 0; i < 5; i++)
                    {

                        for (y = 0; y < 4; y++)
                        {
                            if (map[ship.posX - i, ship.posY - y] != ' ')
                                if (map[ship.posX - i, ship.posY - y] != '+')
                                    ship.life = false;
                            if (ship.posX - i < mapHeight - 6 && ship.posX - i > 6 && ship.posY - y < mapWidth - 6 && ship.posY > 6)
                                map[ship.posX - i, ship.posY - y] = ship.shipLeft[i, y];

                        }
                    }
                }
                if (ship.direction == "LEFT")
                {
                    for (i = 0; i < 5; i++)
                    {

                        for (y = 0; y < 4; y++)
                        {
                            if (map[ship.posX - i, ship.posY - y] != ' ')
                                if (map[ship.posX - i, ship.posY - y] != '+')
                                    ship.life = false;
                            if (ship.posX - i < mapHeight - 6 && ship.posX - i > 6 && ship.posY - y < mapWidth - 6 && ship.posY > 6)
                                map[ship.posX - i, ship.posY - y] = ship.shipRight[i, y];

                        }
                    }
                }
                if (ship.direction == "DOWN")
                {
                    for (i = 0; i < 4; i++)
                    {

                        for (y = 0; y < 5; y++)
                        {
                            if (map[ship.posX - i, ship.posY - y] != ' ')
                                if (map[ship.posX - i, ship.posY - y] != '+')
                                    ship.life = false;
                            if (ship.posX - i < mapHeight - 6 && ship.posX - i > 6 && ship.posY - y < mapWidth - 6 && ship.posY > 6)
                                map[ship.posX - i, ship.posY - y] = ship.shipUp[i, y];

                        }
                    }
                }
                if (ship.direction == "UP")
                {
                    for (i = 0; i < 4; i++)
                    {

                        for (y = 0; y < 5; y++)
                        {
                            if (map[ship.posX - i, ship.posY - y] != ' ')
                                if (map[ship.posX - i, ship.posY - y] != '+')
                                    ship.life = false;
                            if (ship.posX - i < mapHeight - 6 && ship.posX - i > 6 && ship.posY - y < mapWidth - 6 && ship.posY > 6)
                                map[ship.posX - i, ship.posY - y] = ship.shipDown[i, y];


                        }
                    }
                }

                for (i = 0; i < mapHeight; i++)
                {

                    for (y = 0; y < mapWidth; y++)
                    {
                        render[i][y] = map[i, y];
                    }

                }
                if (ship.life == false)
                    break;
                Console.SetCursorPosition(0, 0);
                for (i = 0; i < mapHeight; i++)
                {
                    Console.WriteLine(render[i]);
                }
                Interface.drawInterface();
                Interface.drawHearths(2);
                for (i = 0; i < mapHeight; i++)
                    for (y = 0; y < mapWidth; y++)
                        map[i, y] = ' ';
                Thread.Sleep(250);

            }
            Console.Clear();
            Console.ReadKey();

        }
    }
}
