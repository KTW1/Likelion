
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
        public void Index()
        {
            int pX = 0;
            int pY = 12;
        }
        public void player()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            };
            Index();
            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;
        }
        public void Main(string[] args)
        {

            player();
            

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


