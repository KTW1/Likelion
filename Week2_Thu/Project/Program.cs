using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Project
{
    class Program
    {
        const int MAX = 100;

        static void Status()
        {
            int gold = 500;
            int health = 100;
            int power = 10;
            int input;

            Console.WriteLine($"Status: health:{health} | gold:{gold} | att:{power}");
        }
        static void Title()
        {
            Console.WriteLine("");
            Console.WriteLine("§Adenture§");
            Thread.Sleep(1000);
        }
        struct Inven
        {
            static string[] Item = new string[MAX];
            static int[] Counts = new int[MAX];

            static void Buying(string name, int count)
            {
                for (int i = 0; i < MAX; i++)
                {
                    if (Item[i] == name)  //이미 있는 아이템이면 개수 증가
                    {
                        Counts[i] += count;
                        return;
                    }
                }
                
                for (int i = 0; i < MAX; i++)
                {
                    if (Item[i] == null)
                    {
                        Item[i] = name;
                        Counts[i] = count;
                        return;
                    }
                    Console.WriteLine("inventory is fulled");
                }
            }
            static void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리 : ");
                bool None = true;
                for (int i = 0; i < MAX; i++)
                {
                    if (Item[i] != null)
                    {
                        Console.WriteLine($"{Item[i]} x{Counts[i]}");
                        None = false;
                    }
                }
                if (None)
                {
                    Console.WriteLine("Items are exhausted.");
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = new UTF8Encoding(false);
                Random rand = new Random();

                Title();
             
                bool isAlive = true;
                while (isAlive)
                {
                    Console.Clear();
                    Status();
                    Console.WriteLine("\n1.Find💎");
                    Console.WriteLine("2.Use🎲");
                    Console.WriteLine("3.Trash🏕️");
                    Console.WriteLine("4.Exit ");
                    Console.Write("Want? ");

                    int input = int.Parse(Console.ReadLine());
                    Console.Write("action? ");

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

                        int item1 = rand.Next(1, 3);
                        Console.WriteLine($"Portion! +{item1}");
                        num1 += item1;

                        int item2 = rand.Next(1, 3);
                        Console.WriteLine($"???+{item2}");
                        num2 += item2;

                        int item3 = rand.Next(1, 3);
                        Console.WriteLine($"Bone+{item3}");
                        num3 += item3;
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("What?");
                        string What = Console.ReadLine();
                        if(What == Portion)
                        {
                            Console.WriteLine("How many?");
                            int Many = int.Parse(Console.ReadLine());
                            
                        }
                        else if (What ==???)
                        {
                            
                        }
 
                    }
                    else if (input == 3)
                    {

                    }

                    else if (input == 4)
                    {
                        Console.WriteLine("Goodbye~");
                        Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("Wronginput,Retry");
                        Thread.Sleep(1000);
                        string item = Console.ReadLine();
                        Console.Clear();

                        Console.Write("how many? ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Clear();

                    }
    }
}
