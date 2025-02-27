using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Thu
{
    class Program
    {
        static void PrintMessage(string message)
        {
            Console.Write(message);
        }
        static int Num()
        {
            return 42;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        static void Main(string[] args)
        {
            //Greet();
            //Greet("철수");

            //PrintMessage("출력할 내용");
            //int num = Num();
            //Console.WriteLine(num);
            //유형1 int result = Add(3, 5);
            //Console.WriteLine(result);
            //유형2 Console.WriteLine(Add(3, 5));

            //Console.WriteLine(Multi(4, 3));
            //Console.WriteLine(Multi(2.5, 3.5));
            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"value {q}, rest? {r}");
            //int value = 5;
            //Inc(ref value);
            //Console.WriteLine(value);

            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.Write("num? ");
            int num = int.Parse(Console.ReadLine());
            Console.Write(Facto(num));
        }
        static int Facto(int n)
        {
            if (n <= 1)
                return 1; 
            return n*Facto(n - 1);
        }
        static void Print()
        {
            Console.WriteLine("self");
            Print();
        }
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }
        static void Inc(ref int num)
        {
            num += 10;
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        /// <summary>
        /// Parameter
        /// </summary>
        /// <param name="a">int,double</param>
        /// <param name="b">int,double</param>
        /// <returns></returns>
        static int Multi(int a, int b)
        {
            return a + b;
        }
        static double Multi(double a, double b)
        {
            return a + b;
        }
    }
}
