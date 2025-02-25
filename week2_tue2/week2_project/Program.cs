using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace week2_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;
            
            Console.WriteLine("");
            Console.WriteLine("§Adenture§");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"Status.health{health} | gold{gold} | att {power}");
                Console.WriteLine("\n1.Venture⚔️");
                Console.WriteLine("\n2.Gotcha🎲 1000$");
                Console.WriteLine("\n3.Rest🏕️ +20hp");
                Console.WriteLine("\n4.Exit ");
                Console.Write("Want? ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Roaming.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Roaming..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Roaming...");
                    Thread.Sleep(500);
                    Console.Clear();

                    int eventChange = rand.Next(1, 101);

                    if (eventChange <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"⚔️Monster! hp-{damage}");
                        health -= damage;
                    }
                    else if (eventChange <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        Console.WriteLine($"💰Treasure! +gold{reward}");
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($"💕Medicine +hp{heal}");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n ☠️You Died");
                        isAlive = false;
                    }
                    Thread.Sleep(1000);
                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("");
                        Thread.Sleep(500);

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS, att=50");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS, att=30");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S, att=10");
                            power += 10;
                        }
                        else
                        {
                            Console.WriteLine("N,att=5");
                            power += 5;
                        }
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.WriteLine("goldless, $1000");
                        Thread.Sleep(1000);

                    }
                }
                else if (input == 3)
                {
                    Console.Write("Healing +20hp");
                    health += 20;
                    Thread.Sleep(1000);

                }
                else if (input == 4)
                {
                    Console.WriteLine("Needrest +20hp");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Wronginput,RE");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
