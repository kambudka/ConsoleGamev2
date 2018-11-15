using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleGamev2;

namespace ConsoleGamev2
{
    class Map
    {
        public List<Asteroid> asteroidList = new List<Asteroid>();
        private int astcount;
        private int shipleft;
        private int shiptop;
        private int shippoz;
        private int hearts;
        public void drawMap()
        {
            hearts = 3;
            shipleft = 50;
            shiptop = 20;
            shippoz = 0;
            astcount = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Ship.drawShip(shipleft, shiptop, shippoz);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key.Equals(ConsoleKey.UpArrow))
                    {
                        Ship.clearShip(shipleft, shiptop, shippoz);
                        shippoz = 0;
                        if(checkTop(shiptop -1))shiptop -= 1;
                        
                        Ship.drawShip(shipleft, shiptop, 0);
                    }
                    if (key.Key.Equals(ConsoleKey.DownArrow))
                    {
                        Ship.clearShip(shipleft, shiptop, shippoz);
                        shippoz = 3;
                        if (checkTop(shiptop + 1)) shiptop += 1;

                        Ship.drawShip(shipleft, shiptop, 3);
                    }
                    if (key.Key.Equals(ConsoleKey.LeftArrow))
                    {
                        Ship.clearShip(shipleft, shiptop, shippoz);
                        shippoz = 2;
                        if (checkLeft(shipleft - 2)) shipleft -= 2;
                        
                        Ship.drawShip(shipleft, shiptop, 2);
                    }
                    if (key.Key.Equals(ConsoleKey.RightArrow))
                    {
                        Ship.clearShip(shipleft, shiptop, shippoz);
                        shippoz = 1;
                        if (checkLeft(shipleft + 2)) shipleft += 2;
                        Ship.drawShip(shipleft, shiptop, 1);
                    }
                    if (key.Key.Equals(ConsoleKey.Escape))
                    {
                        break;
                    }
                }
                if(asteroidUpdate())
                    break;
                Thread.Sleep(100);
                if (astcount <= 3)
                {
                    asteroidGenerate();
                }

            }
            asteroidList.Clear();
        }
        private bool asteroidUpdate()
        {
            foreach (Asteroid asteroid in asteroidList)
            {
                if (!asteroid.moveSmall())
                {
                    asteroidList.Remove(asteroid);
                    astcount--;
                    break;
                }
                if (checkCollision(asteroid))
                    return true;
            }
            return false;
        }
        private bool checkCollision(Asteroid asteroid)
        {
            switch (asteroid.dir)
            {
                case 0:
                  if (asteroid.pozleft+6 >= shipleft && asteroid.pozleft<= shipleft)
                        if (asteroid.poztop >= shiptop && asteroid.poztop <= shiptop + 3)
                            return true;
                        else if(asteroid.poztop+4 >= shiptop && asteroid.poztop+4 <= shiptop + 3)
                            return true;
                break;
                case 1:
                    if (asteroid.pozleft <= shipleft+4 && asteroid.pozleft >= shipleft)
                        if (asteroid.poztop >= shiptop && asteroid.poztop <= shiptop + 3)
                            return true;
                        else if (asteroid.poztop + 4 >= shiptop && asteroid.poztop + 4 <= shiptop + 3)
                            return true;
                    break;
            }
            return false;
        }
        private void asteroidGenerate()
        {
            int value;
            Random rng = new Random();
            Asteroid mala;
            if (rng.Next(0, 10) < 5)
            {
                mala = new Asteroid(1, rng.Next(6, 36), 0);
            }
            else
            {
                mala = new Asteroid(114, rng.Next(6, 36), 1);
            }
            asteroidList.Add( mala);
            astcount++;
        }
        private bool checkLeft(int left)
        {
            if (left <= 1)
                return false;
            else if (left >= 118)
                return false;
            else
                return true;

        }
        private bool checkTop(int top)
        {
            if (top <= 5)
                return false;
            else if (top >= 36)
                return false;
            else
                return true;
        }
    }
}
