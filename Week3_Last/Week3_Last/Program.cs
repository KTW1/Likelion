using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            sbyte Byte1 = -50; //byte
            short Byte2 = -32000; //ushort
            int Byte4 = 25; long Byte8 = 1234567890L; //8Byte

            const float Byte_4 = 3.14f; //m
            double Byte_8 = 3.141592;
            decimal Byte_16 = 3.1415926535m; //m

            Console.Write("1:");
            int input = int.Parse(Console.ReadLine()); //ReadLine, string a = int.ToString
            string Output = input.ToString();
            Console.WriteLine($"{Output}");

            int a = rand.Next(1, 5);
            int[] arr = new int[a]; //array[] a = new array[2]. 문법창조
            for (int b = 0; b < arr.Length; b++)
            {
                Console.Write("\n2:");
                arr[b] = int.Parse(Console.ReadLine());
                Console.WriteLine($"{arr[b]}");
            }
            int L = arr.Length;

            Console.WriteLine();

            if (L > 3)
            {
                Console.WriteLine("many");
            }
            else if (L <= 2)
            {
                Console.WriteLine("little");
            }

            switch (L) //switch for() case 1
            {
                case 1:
                    for (int i = 0; i < L; i++)
                    {
                        Console.WriteLine($"{L}*{L}");
                    }
                    break;
                case 2:
                    for (int i = 0; i < L; i++)
                    {
                        Console.WriteLine($"{L}*{L}");
                    }
                    break;
                case 3:
                    for (int i = 0; i < L; i++)
                    {
                        Console.WriteLine($"{L}*{L}");
                    }
                    break;
                case 4:
                    for (int i = 0; i < L; i++)
                    {
                        Console.WriteLine($"{L}*{L}");
                    }
                    break;
                case 5:
                    for (int i = 0; i < L; i++)
                    {
                        Console.WriteLine($"{L}*{L}");
                    }
                    break;
            }

            int y = 1;
            do
            {
                if (y <= L)
                {
                    Console.WriteLine(y);
                }
                y++;
            } while (y == L);

            int[,] Static_2D = new int[3,2]; //new int [3][2]
            int[][] Vary_2D = new int[3][];
        }
    }
}
