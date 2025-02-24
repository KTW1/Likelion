using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            //2진수 binary_ 0224Mon
            //Console.WriteLine("2binary input : ");
            //string binaryinput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryinput, 2);
            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 2진수 : {binaryinput}");
            //Console.WriteLine($"10진수 변환 : {decimalValue}");
            //Console.WriteLine($"다시 2진수 변환 : {binaryOutput}");

            //자동변수var string, char. 복잡해지면 곤란할 수 있다.
            //var name = "Alice";
            //var age = 'A';
            //var isStudent = true;

            //Console.WriteLine($"이름:{name},age:{age},student:{isStudent}");

            //기본값default
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리 기본값: {defaultBool}");

            //3.연산자? 전부 외우기보단 읽고 이해하는 중심.
            //int a = 5.b = 3;
            //int sum=a+b; 
            //bool isEqual = (a == b);

            //Console.WriteLine($"sum : {sum}");
            //Console.WriteLine($"a and b same? {isEqual}");

            //단항 연산자
            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            ////변환 연산
            //double pi = 3.14;
            //int integerPi = (int)pi;

            //Console.WriteLine(integerPi);

            //int iKor = 90;
            //int iMath = 75;
            //int iEng = 88;
            //int sum = iKor + iMath + iEng;
            //float average = 0.0f;
            //average = (float)sum / 3;
            //Console.WriteLine("Score:" + sum);
            //Console.WriteLine("Average:" + average);

            //산술연산. %의 나머지연산이 중심;
            //int a = 10, b = 3;
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a % b);

            //산술연산2
            //int number = 7;
            //int sum = 2;
            //sum = number % 2;
            //Console.WriteLine("홀짝판별 : " + sum);

            ////산술3 랜덤가챠 기반
            //bool isEqual = false;
            //int a, b = 5;
            //isEqual = (a == b);

            //Console.WriteLine("a,b가 같은가?" + isEqual);

            //문자열 연결연산
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName+" "+lastName);

            ////할당, 증감연산
            //int a = 10;
            //a += 5;
            //Console.WriteLine(a);

            //int b = 3;
            //b++;
            //Console.WriteLine(b);

            //--b;
            //Console.WriteLine(b);

            //average += 5;
            //average -= 5;
            //average *= 5;
            //average /= 5;
            //average %= 5;
            //Console.WriteLine(average);

            ////오전복습문제1

            //Console.WriteLine($"국어?");
            //int korScore = int.Parse(Console.ReadLine());
            //Console.WriteLine($"영어?");
            //int engScore = int.Parse(Console.ReadLine());
            //Console.WriteLine($"수학?");
            //int mathSrore = int.Parse(Console.ReadLine());

            //int score = korScore + engScore + mathSrore;
            //float average = (float)score / 3;
            //Console.WriteLine($"총점={score}, 평균= {average.ToString("F2")}");

            ////문제2
            ////Console.WriteLine("반전시킬 정수?");

            //Console.WriteLine("");
            //Console.WriteLine("정수?");
            //int bit = int.Parse(Console.ReadLine());
            //int rev = ~bit;
            //Console.WriteLine($"비트반전=" + rev);

            //    int[] scores = new int[3]; // 점수를 저장할 배열  
            //  string[] subjects = { "국어", "영어", "수학" };  

            //// 점수 입력  
            //for (int i = 0; i < subjects.Length; i++)  
            //{  
            //    Console.Write($"{subjects[i]} 점수를 입력하세요: ");  
            //    scores[i] = int.Parse(Console.ReadLine());  
            //}  

            //// 총합 및 평균 계산  
            //int total = 0;  
            //for (int i = 0; i < scores.Length; i++)  
            //{  
            //    total += scores[i];  
            //}  

            //double average = total / 3.0; // 실수로 나누기 위해 3.0 사용  

            //Console.WriteLine($"총합: {total}");  
            //Console.WriteLine($"평균: {average:F2}");

        }
    }
}
