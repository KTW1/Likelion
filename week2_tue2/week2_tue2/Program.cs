using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace week2_tue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(" 대장장이 키우기 ");

            int input;
            int rnd;
            int gold = 100;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.나무");
                Console.WriteLine("2.뽑기");
                Console.WriteLine("3.나가기");
                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");

                        string str = Console.ReadLine();

                        gold += 100;
                        Console.WriteLine("gold : " + gold);
                        if (str == "x")
                        {
                            Console.WriteLine("");
                            break;
                        }
                    }
                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;

                        for (int a = 1; a < 21; a++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)
                            {
                                Console.WriteLine("SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("B");
                            }
                            else
                            {
                                Console.WriteLine("C");
                            }
                            Thread.Sleep(500);
                        }

                    }
                    else
                    {
                        Console.WriteLine("goldless");
                        Thread.Sleep(1000);
                    }
                    
                }
                else if (input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
