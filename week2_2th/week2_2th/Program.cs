using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_2th
{
    class Program
    {
        static void Main(string[] args)
        {
            ////전위와 후위 a++ ++a;
            //int a = 3;
            //Console.WriteLine("a = " + a++);

            ////관계연산
            //int x = 5, y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);

            ////3-11논리;
            //bool a = true, b = false;
            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(!a);

            //a = !b;
            //Console.WriteLine(a);

            ////13비트연산
            //int x = 5, y = 3; 0101 0011
            //Console.WriteLine(x&y); 0001
            //Console.WriteLine(x|y); 0111
            //Console.WriteLine(x^y); 0110
            //Console.WriteLine(~x); //


            ////14시프트연산
            //int value = 4;
            //Console.WriteLine(value << 1);
            //Console.WriteLine(value >> 1);

            ////15기타연산, 삼항연산
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b; //a>b? 맞으면t a, 틀리면f b.
            //Console.WriteLine(max);

            //Console.Write("??? : ");
            //int key = int.Parse(Console.ReadLine());
            //string res;
            //res = (key = null) ? "open" : "close";

            //Console.WriteLine(res);

            ////우선순위.일반 연산
            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);

            //int score = 69;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score > 70)
            //{
            //    Console.WriteLine("B");
            //}
            //else
            //{
            //    Console.WriteLine("F");

            //string ID = "SW";
            //if(ID == "SW")
            //{
            //    Console.WriteLine("Login");
            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}

            //int score =78;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}

            //소지금을 입력, 0~100는 "무한의대검", 101~200 "카타나", 201~300 "진은검", 301~400 "집판검" 401~500 "엑스칼리버" 501~600 "유령검"

            //Console.Write("소지금 입력: ");
            //int pay = int.Parse(Console.ReadLine());
            //string weapon = default;
            //int att = 0;

            //if (pay >= 0 && pay <= 100)
            //{
            //    weapon = "무한의 대검";
            //    att = 1;
            //}
            //else if (pay >= 101 && pay <= 200)
            //{
            //    weapon = "카타나";
            //    att = 2;
            //}
            //else if (pay >= 201 && pay <= 300)
            //{
            //    weapon = "진은검";
            //    att = 3;
            //}
            //else if (pay >= 301 && pay <= 400)
            //{
            //    weapon = "집판검";
            //    att = 4;
            //}
            //else if (pay >= 401 && pay <= 500)
            //{
            //    weapon = "엑스칼리버";
            //    att = 5;
            //}
            //else if (pay >= 501 && pay <= 600)
            //{
            //    weapon = "유령검";
            //    att = 6;
            //}
            //else
            //{
            //    weapon = "전설의 검";
            //    att = 7;
            //}

            //Console.WriteLine("캐릭터 :멋사검존");
            //Console.WriteLine($"무기 : {weapon}");
            //Console.WriteLine($"공격력 : 100+{att}");

            //            문제 1.세 정수의 최대값 구하기
            //              문제 설명:
            //            사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            //            요구사항:
            //사용자에게 세 개의 정수를 입력받습니다.
            //if문을 사용하여 가장 큰 정수를 결정합니다.
            //결과를 “최대값: X” 형식으로 출력합니다.

            Console.Write("1번째:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2번째:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("3번쨰:");
            int c = int.Parse(Console.ReadLine());

            int max;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (a <= b && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            Console.WriteLine("최대값:" + max);
            Console.WriteLine();

            Console.Write("학생의 점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            string grade;
            if (score >= 90)
            {
                grade = "A 학점";
            }
            else if (score >= 80)
            {
                grade = "B 학점";
            }
            else if (score >= 70)
            {
                grade = "C 학점";
            }
            else if (score >= 60)
            {
                grade = "D 학점";
            }
            else
            {
                grade = "F 학점";
            }

            Console.WriteLine($"학생의 점수: {score} = {grade}");

            //문제 3.간단한 사칙연산 계산기
            //문제 설명:
            //사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            //요구사항:

            //두 개의 숫자와 연산자 기호를 입력받습니다.
            //if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            //나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            //결과는 “결과: X” 형식으로 출력합니다. 

            Console.WriteLine();
            Console.Write("첫 번째 숫자를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());
 
            Console.Write("연산자를 입력하세요 (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine();  

            int result = 0;
            bool validOperation = true;  

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("error: 0으로 나눌 수 없습니다.");
                    validOperation = false;  
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else
            {
                Console.WriteLine("error: 유효하지 않은 연산자입니다.");
                validOperation = false;
            }

            if (validOperation)
            {
                Console.WriteLine($"결과: {result}");
            }
        }
    }
}

