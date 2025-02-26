using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_test
{
    class Program
    {
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("1?");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("2?");
            int n2 = int.Parse(Console.ReadLine());

            result = Add(n1,n2);

            Console.WriteLine($"sum? {result}");
        }
    }
}
