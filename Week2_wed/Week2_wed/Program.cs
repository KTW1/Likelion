using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_wed
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //int[] array = new int[25];

            //for(int a=0; a<25; a++)
            //{
            //    array[a] = a + 1;
            //}
            
            //Random rand = new Random();
            
            //for(int n = 0; n < 100; n++)
            //{
            //    int A = 0;
            //    int B = 0;
            //    int T = 0;

            //    T = array[A];
            //    array[A] = array[B];
            //    array[B] = T;
            //}

            //for (int a = 0; a < 5; a++)
            //{
            //    for (int b = 0; b < 5; b++)
            //    {
            //        Console.Write(array[a * 5 + b].ToString("D2") + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("숫자를 입력하세요: ");
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 25; i++)
            //{
            //    if (array[i] == input)
            //    {
            //        array[i] = 0;
            //        break;
            //    }
            //}
            ////2차원 가변배열. 가변, 추후에 길이를 수정가능한 배열이다.
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //// 가변 배열 순회
            //for (int i =0; i < jaggedArray.Length; i++)
            //{
            //    for (int j =0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //var 변수선언 다시 복기
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");

            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for(int i =0; i<2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //double Value = 12.3456;

            //Console.WriteLine(Value.ToString("G3"));
            //Console.WriteLine($"{Value:F2}");
            //Console.WriteLine(String.Format("{0:F2}", Value));
            //Value = Math.Round(Value, 3);
            //Console.WriteLine(Value);

            //
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;



            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            //}

            //[0]~[2]배열을 생성하고, 각각 10, 20, 30 출력.
            //int[] num = new int[3];

            //num[0] = 10;
            //num[1] = 20 ;
            //num[2] = 30;

            //for 사용
            //for(int a=0; a<3; a++)
            //{
            //    Console.WriteLine(num[a]);
            //}

            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[] { 1, 2, 3 };

            //string[] fruits = {"하나", "둘", "셋"};

            //for (int a=0; a<3; a++)
            //{
            //    Console.WriteLine(numbers[a]);
            //    Console.WriteLine(fruits[a]);
            //}

            //int[] kor = new int[3];
            //int[] eng = new int[3];
            //int[] math = new int[3];

            //int[] sum = new int[3];
            //float[] ave = new float[3];

            //for (int f = 0; f < 3; f++)
            //{
            //    Console.WriteLine((f+1)+"번째");
            //    Console.Write("국 입력:");
            //    kor[f] = int.Parse(Console.ReadLine());

            //    Console.Write("영 입력:");
            //    eng[f] = int.Parse(Console.ReadLine());

            //    Console.Write("수 입력:");
            //    math[f] = int.Parse(Console.ReadLine());

            //    sum[f] = kor[f] + eng[f] + math[f];
            //    ave[f] = (float)sum[f] / 3;
            //    Console.WriteLine();
            //}

            //for (int f = 0; f < 3; f++)
            //{

            //    Console.Write("Which One?");
            //    int Choice = int.Parse(Console.ReadLine());

            //    if (Choice == 1)
            //    {
            //        Console.WriteLine((f + 1) + "번");
            //        Console.WriteLine($"kor : {kor[f]} eng: {eng[f]}, math: {math[f]}");
            //        Console.WriteLine("sum? " + sum[f]);
            //        Console.WriteLine("ave? " + ave[f]);
            //    }
            //    else if (Choice == 2)
            //    {
            //        Console.WriteLine((f + 1) + "번");
            //        Console.WriteLine($"kor : {kor[f]} eng: {eng[f]}, math: {math[f]}");
            //        Console.WriteLine("sum? " + sum[f]);
            //        Console.WriteLine("ave? " + ave[f]);
            //    }
            //    else if (Choice == 3)
            //    {
            //        Console.WriteLine((f + 1) + "번");
            //        Console.WriteLine($"kor : {kor[f]} eng: {eng[f]}, math: {math[f]}");
            //        Console.WriteLine("sum? " + sum[f]);
            //        Console.WriteLine("ave? " + ave[f]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("NoneData");
            //    }
        }
    }
}


