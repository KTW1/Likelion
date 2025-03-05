using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
     class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ////1
            //Warrior Knight = new Warrior();
            //Knight.Name = "Alpha";
            //Knight.Score = 10;
            //Knight.Strength = 30;

            //Console.WriteLine($"이름? {Knight.Name},점수? {Knight.Score},힘? {Knight.Strength} ");

            ////2
            //try
            //{
            //    Console.WriteLine("input?");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}
            //Console.WriteLine();

            ////3
            //List<string> fruits = new List<string>();
            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //Queue<string> Tasks = new Queue<string>();
            //Tasks.Enqueue("첫 번째 작업");
            //Tasks.Enqueue("두 번째 작업");
            //Tasks.Enqueue("세 번째 작업");

            //Stack<int> nums = new Stack<int>();
            //nums.Push(10);
            //nums.Push(20);
            //nums.Push(30);
            //while(nums.Count > 0)
            //{
            //    Console.WriteLine(nums.Pop());
            //}

            //Console.WriteLine();

            ////4
            //Console.WriteLine("input?");
            //string Sent = Console.ReadLine();
            //Console.WriteLine(Sent.ToUpper());
            //Console.WriteLine($"\nSent.Replace{"C#, CSharp"}");
            //Console.WriteLine(Sent.Length);
            //Console.WriteLine();
            ////5
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = nums.Where(n => n % 2 == 0);
            foreach (var num in even)
            {
                Console.WriteLine(num);
            }
        }
    }
}
