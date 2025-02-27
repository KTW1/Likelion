using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace inven
{
    class Program
    {
        const int MAX_ITEMS = 100;
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];
        static void AddItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    itemCounts[i] += count;
                    return;
                }
            }
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("inventory is full!");
        }
        static void Remove(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    if (itemCounts[i] >= count)
                    {
                        itemCounts[i] -= count;
                        if (itemCounts[i] == 0)
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("item is exhasted");
                        return;
                    }
                }
            }
            Console.WriteLine("Cannot find the item");
        }
        static void Inventory()
        {
            Console.WriteLine("=====Inventory=====");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("inventory is enptied");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Inventory();
                Console.WriteLine("\n1.Buy💎");
                Console.WriteLine("2.Remove🎲");
                Console.Write("Want?");
                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();
                    Console.Write("Name? ");
                    string Name = Console.ReadLine();
                    Console.Write("Many? ");
                    int Many = int.Parse(Console.ReadLine());
                    AddItem(Name, Many);
                    Inventory();
                    Thread.Sleep(3000);
                }
                else if (num == 2)
                {
                    Console.Clear();
                    Console.Write("Name? ");
                    string Name = Console.ReadLine();
                    Console.Write("Many? ");
                    int Many = int.Parse(Console.ReadLine());
                    Remove(Name, Many);
                    Inventory();
                    Thread.Sleep(3000);
                }
                else
                {
                    Inventory();
                    Thread.Sleep(3000);
                }
            }
        }
    }
}

//namespace Inventory
//{
//    class Program
//    {
//        //최대 아이템 개수
//        const int MAX_ITEMS = 10;

//        //아이템 배열
//        static string[] itemNames = new string[MAX_ITEMS];
//        static int[] itemCounts = new int[MAX_ITEMS];
//        //아이템 추가
//        static void AddItem(string name, int count)
//        {
//            for(int y=0; y<MAX_ITEMS; y++)
//            {
//                if (itemNames[y] == name)
//                {
//                    itemCounts[y] += count;
//                    return;
//                }
//            }
//            for (int y = 0; y < MAX_ITEMS; y++)
//            {
//                if (itemNames[y] == null)
//                {
//                    itemNames[y] = name;
//                    itemCounts[y] = count;
//                    return;
//                }
//            }
//            Console.WriteLine("inventory is fulled");
//        }
//        //아이템 삭제
//        static void Remove(string name, int count)
//        {
//            for(int y=0; y<MAX_ITEMS; y++)
//            {
//                if (itemNames[y] == name)
//                {
//                    if (itemCounts[y] >= 1)
//                    {
//                        itemCounts[y] -= count;
//                        if (itemCounts[y] == 0)
//                        {
//                            itemNames[y] = null;
//                        }
//                        return;
//                    }
//                    else
//                    {
//                        Console.WriteLine("item is exhasted");
//                        return;
//                    }
//                }
//                Console.WriteLine("Cannot find the item");
//            }
//        }
//        static void ShowInventory()
//        {
//            Console.WriteLine("Inventory: ");
//            bool Empty = true;
//            for (int y = 0; y < MAX_ITEMS; y++)
//            {
//                if (itemNames[y] != null)
//                {
//                    Console.WriteLine($"{itemNames[y]} (x{itemCounts[y]})");
//                    Empty = false;
//                }
//            }
//        }
//        static void Main(string[] args)
//        {
//            //아이템 추가
//            AddItem("Portion", 5);
//            AddItem("Knife", 1);
//            AddItem("Portion", 3);
//            ShowInventory();
//            //아이템사용
//            Console.WriteLine("two Portions");
//            Remove("Portion", 2);
//            ShowInventory();
//            //아이템제거
//            Console.WriteLine("Shield 1 remove");
//            Remove("Sheild", 1);
//            ShowInventory();
//            //모든아이템제거
//            Console.WriteLine("6 Portions Use");
//            Remove("Portion", 6);
//            ShowInventory();
//        }
//    }
//}
