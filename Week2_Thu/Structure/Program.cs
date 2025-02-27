using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        //struct Point
        //{
        //    //public권한 private
        //    public int X;
        //    public int Y;
        //    public void Print()
        //    {
        //        Console.WriteLine($"Index {X}, {Y}");
        //    }
        //}
        struct Student
        {
            public string Name;
            public int Kor;
            public int Eng;
            public int Math;

            //난해.출력함수 {var,좌표}
            public void Print()
            {
                Console.WriteLine($"{Name,-3} {Kor,5} {Eng,7} {Math,8}");
            }
        }
        static void Main(string[] args)
        {
            Student[] input = new Student[3];

            for(int y=0; y<input.Length; y++) //난해.for[y]
            {
                Console.Write("Name? ");
                input[y].Name = Console.ReadLine(); //난해.문자열입력
                Console.Write("kor? ");
                input[y].Kor = int.Parse(Console.ReadLine());
                Console.Write("eng? ");
                input[y].Eng = int.Parse(Console.ReadLine());
                Console.Write("math? ");
                input[y].Math = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("이름    국어    영어    수학");
            foreach (Student kem in input) //난해.foreach
            {
                kem.Print();
            }
            
            //Point p; //구조체선언. 초기화
            //p.X = 10;
            //p.Y = 20;
            //p.Print();
        }
    }
}
