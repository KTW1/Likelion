using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2_2nd_Game
{
    class Program
    {
        static void Main(string[] args)
        {

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
                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("┎───────────────────────────────────────────┐");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("┃                    패치노트               ┃");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("┃    1.신규이벤트 몬티홀이 추가됐습니다.    ┃");
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("┃    2.다음 업데이트는 없습니다.            ┃");
                Console.SetCursorPosition(0, 4);
                Console.WriteLine("┃                                           ┃");
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("└───────────────────────────────────────────┘");
                Thread.Sleep(3000);
                Console.Clear();

                while (isAlive)
                {
                    Console.Clear();
                    Console.WriteLine($"Status: health:{health} | gold:{gold} | att:{power}");
                    Console.WriteLine("\n1.Venture⚔️");
                    Console.WriteLine("2.Gotcha🎲 1000$");
                    Console.WriteLine("3.Rest🏕️ +20hp");
                    Console.WriteLine("4.(New!) 💎MontiHole");
                    Console.WriteLine("5.Exit ");
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
                        int totalDoors = 3;
                        int winningDoor = rand.Next(1, totalDoors + 1);

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("몬티홀 게임에 오신 것을 환영합니다!");
                        Console.Write("1, 2, 3 중에서 문 한 개를 선택하세요: ");

                        int playerChoice = 0;
                        bool validChoice = false;

                        while (!validChoice)
                        {
                            string input2 = Console.ReadLine();
                            if (int.TryParse(input2, out int choice) && choice >= 1 && choice <= totalDoors)
                            {
                                playerChoice = choice;
                                validChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("유효한 숫자를 입력하세요 (1, 2, 3):");
                            }
                        }

                        Console.Clear();

                        int doorToOpen;
                        do
                        {
                            doorToOpen = rand.Next(1, totalDoors + 1);
                        } while (doorToOpen == playerChoice || doorToOpen == winningDoor);

                        Console.WriteLine();
                        Console.WriteLine($"진행자가 {doorToOpen}번 문을 열었습니다. 염소가 나왔습니다!");

                        Console.WriteLine("선택을 유지하시겠습니까? 아니면 변경하시겠습니까? (유지 / 변경):");
                        string playerDecision = Console.ReadLine().ToLower();
                        Console.Clear();

                        if (playerDecision == "변경")
                        {
                            playerChoice = 6 - playerChoice - doorToOpen; ;
                        }
                        Console.WriteLine();

                        Console.WriteLine("과연 결과는?");
                        Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine("두구");
                        Thread.Sleep(750);
                        Console.Clear();
                        Console.WriteLine("두구두구");
                        Thread.Sleep(750);
                        Console.Clear();
                        Console.WriteLine("두구두구두구");
                        Thread.Sleep(750);
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine($"정답은 {winningDoor}번!");

                        if (playerChoice == winningDoor)
                        {
                            Console.WriteLine();
                            Console.WriteLine("축하합니다! 당신이 승리했습니다!");
                            gold += 3000;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("꽝~ 참가비만 받아갈게요.");
                            gold = 0;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();

                    }

                    else if (input == 5)
                    {
                        Console.WriteLine("Goodbye~");
                        Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("Wronginput,Retry");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
