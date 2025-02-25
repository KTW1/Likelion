using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2_tue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("???");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("???");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("???");
            //int c = int.Parse(Console.ReadLine());

            //int max = 0;

            ////단문의 경우 {}중괄호는 생략가능하다.
            //if (a >= b && a >= c)
            //    max = a;
            //else if (b >= a && b >= c)
            //    max = b;
            //else
            //    max = c;

            //Console.WriteLine($"최대값: {max}");

            //Console.Write("??");
            //int day = int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tue");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wed");
            //        break;
            //    default:
            //        Console.WriteLine("null");
            //        break;
            //}

            //중간문제, case/break세트;
            //Console.Write("캐릭터 선택 (1.검사, 2.마법사, 3.도적 : ");
            //int charater = int.Parse(Console.ReadLine());
            //switch (charater)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100 ");
            //        Console.WriteLine("방어력 90 ");
            //        break;

            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110 ");
            //        Console.WriteLine("방어력 80 ");
            //        break;

            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115 ");
            //        Console.WriteLine("방어력 70 ");
            //        break;
            //}

            //12무한루프.
            //int count = 0;
            //while (true)
            //{
            //    Console.WriteLine("integral");
            //    count++;
            //    if (count == 3) break;
            //}

            //for(int i=0; i <= 9; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum+i;
            //    Console.WriteLine($"sum={sum} i={i}");
            //}

            //Console.WriteLine();
            //Console.WriteLine(sum);

            //13팩토리얼
            //for (int a = 1; a <= 4; a++)
            //{
            //    int factorial = 1;
            //    for (int b = 1; b <= a; b++)
            //    {
            //        factorial *= b;
            //    }
            //    Console.WriteLine($"{a}! ={factorial}");
            //}

            //14구구단
            //for (int a = 1; a <= 9; a++)
            //{
            //    for(int b = 1; b <= 9; b++)
            //    {
            //        Console.WriteLine($"{a}x{b}={a * b}\t");
            //    }
            //    Console.WriteLine();
            //}

            //16while for분리식
            //int n = 1;
            //Console.WriteLine("\nㅡㅡㅡㅡㅡㅡㅡ");

            //while (n <= 5)
            //{
            //    Console.WriteLine($"\nnum={n}");
            //    n++;

            //    if (n == 3){
            //        Console.WriteLine("exit_3");
            //        break;
            //        }
            //}
            //Random asd = new Random();

            //for (int a=0; a<5; a++)
            //{
            //    int random = asd.Next(1, 11);
            //    Console.WriteLine($"{a}번 : " + random);
            //}

            //랜덤뽑기
            //Console.Write("gotcha?");
            //Console.ReadLine();
            //Console.Clear();

            //for (int t=0; t <= 100; t++)
            //{
            //    int got = asd.Next(1, 101);
            //    if (got >= 1 && got <= 10)
            //    {
            //        Console.Write("SSS 10%");
            //    }
            //    else if (got >= 11 && got <= 40)
            //    {
            //        Console.Write("SS 40%");
            //    }
            //    else
            //    {
            //        Console.Write("S 50%");
            //    }
            //    Console.Read();
            //    Console.Clear();
            //}

            //Random asd = new Random();
            //int x = asd.Next(1,4);
            //do
            //{
            //    Console.WriteLine("least one");
            //    x--;
            //} while (x > 0);

            //자동으로 지우고 실행하려면?

            //for(int a=1; a<=10; a++)
            //{
            //    if (a % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(a);
            //}
            //요구사항을 코드로 변환하는 연습
            //코드 > 요구사항 > 다시 코딩

            //int a = 1;

            //start:
            //if (a <= 3)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //    goto start;
        }


    }
}
}
