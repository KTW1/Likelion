
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shooting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            };

            int pX = 0;
            int pY = 12;
            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;

            //타임루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                Console.Clear();
                long currentSecond = stopwatch.ElapsedMilliseconds;
                if(currentSecond - prevSecond >= 1000)
                {
                    Console.WriteLine("1s loop");
                    prevSecond = currentSecond;
                }

                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (pY > 0) pY--; break;
                    case ConsoleKey.DownArrow: if (pY < Console.WindowHeight - 1) pY++; break;
                    case ConsoleKey.LeftArrow: if (pX > 0) pX--; break;
                    case ConsoleKey.RightArrow: if (pX < Console.WindowWidth - 1) pX++; break;
                    case ConsoleKey.Spacebar: Console.Write("Missile"); break;
                    case ConsoleKey.Escape: return;
                }

                Console.Clear();
                for (int y = 0; y < player.Length; y++)
                {
                    Console.SetCursorPosition(pX, pY + y);
                    Console.WriteLine(player[y]);
                }
                Console.Clear();
            }


            //int x = 10, y = 10;
            //ConsoleKeyInfo KeyInfo;
            //Console.CursorVisible = false;
            //while (true)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, y); //현재위치
            //    Console.Write("●");
            //    KeyInfo = Console.ReadKey(true);

            //    //방향키 입력. 좌표변경
            //    switch (KeyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--;break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth -1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("Missile"); break;
            //        case ConsoleKey.Escape: return;
            //    }
        }

    }
}

