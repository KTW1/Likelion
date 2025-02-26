using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wed2
{
    class Program
    {
        //static int Add(int n1, int n2)
        //{
        //    return n1 + n2;
        //}

        //static int hi(string Hello)
        //{
        //    return Hello.Length;
        //}

        static int Max(int a, int b, int c)
        {
            int maxi = 0;
            for (int n = 0; n < 3; n++) {
                if (a > b && b > c) maxi = a;
                else if (a < b && b > c) maxi = b;
                else maxi = c;
            }
            return maxi;
        }
        static void Main(string[] args)
        {

            //3-3
            Console.Write("num1? ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2? ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3? ");
            int num3 = int.Parse(Console.ReadLine());

            int Result = Max(num1,num2,num3);

            Console.WriteLine("Max? " + Result);

            //3-2
            //Console.Write("Hello? ");
            //string Hello = Console.ReadLine();

            //Console.WriteLine(hi(Hello));
            
            ////3-1
            //int sum = 0;
            
            //Console.Write("num1? ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("num2? ");
            //int n2 = int.Parse(Console.ReadLine());

            //sum = Add(n1,n2);

            //Console.WriteLine("sum? " +sum);

            ////2-3

            //int[] array4 = new int[5] { 1, 2, 3, 4, 5 };
            //foreach(int num in array4)
            //{
            //    Console.Write(num + " ");
            //}

            ////2-2
            //while (true)
            //{
            //    for(int n=1; n<=10; n++)
            //    {
            //        int num = n % 2;
            //        if (num == 1) continue;
            //        Console.Write(n+" ");
            //    }
            //    break;
            //}

            //2-1
            
            //for (int n = 0; n < 10; n++)
            //{
            //    int num = n;
            //    Console.Write($"{n} ");
            //}

            //    //1-3
            //    int max = 0;
            //int[] array3 = new int[5] { 3,8,15,6,2 };

            //for(int n=0;n<5;n++)
            //{
            //    if (max < array3[n])
            //    {
            //        max = array3[n];
            //    }
            //}
            //Console.Write("Max? " + max);

            ////1-2
            //int sum = 0;
            //int[] array2 = new int[5];

            //for (int n=0; n<5; n++)
            //{
            //    Console.Write($"{n+1}번? ");
            //    int Num = int.Parse(Console.ReadLine());
            //    array2[n] = Num;

            //        sum +=array2[n];
            //}
            //Console.Write("sum? "+sum);

            ////1-1
            //int[] array1 = new int[5] {10,20,30,40,50} ;
            //for(int n=0; n<5; n++)
            //{
            //    int output = array1[n];
            //    Console.Write($"{output} ");
            //}

            //string[] fruits = { "하나", "둘", "셋" };
            //foreach(string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Random randome = new Random();

            //int[] numbers = new int[25];
            //for (int i = 0; i < 25; i++)
            //    numbers[i] = i + 1;

            //for (int i = 0; i < 100; i++)
            //{
            //    int a = randome.Next(25);
            //    int b = randome.Next(25);
            //}

            //int[,] board = new int[5, 5]; //5x5 빙고판
            //bool[,] marked = new bool[5, 5]; //선택된 숫자 체크
            //int bingoCount = 0;
            //Random random = new Random();

            //int[] numbers = new int[25];
            //for (int i = 0; i < 25; i++)
            //    numbers[i] = i + 1;

            ////랜덤 섞기(Fisher-Yates Shuffle)
            //for (int i = 0; i < 100; i++)
            //{
            //    int a = random.Next(25);
            //    int b = random.Next(25);
            //    // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
            //    (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            //}


            ////2차원 배열로 변환
            //int index = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        board[i, j] = numbers[index++];
            //    }
            //}

            ////게임시작
            //while (bingoCount < 5)
            //{
            //    Console.Clear();

            //    //빙고판 출력
            //    Console.WriteLine("현재 빙고판");


            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (marked[i, j])
            //                Console.Write(" X ");
            //            else
            //                Console.Write($"{board[i, j],2} ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
            //    Console.Write("숫자를 입력하세요 (1~25) : ");
            //    int number = int.Parse(Console.ReadLine());

            //    bool found = false;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (board[i, j] == number)
            //            {
            //                marked[i, j] = true; //숫자를 X로 변경
            //                found = true;
            //                break;
            //            }
            //        }
            //        if (found)
            //            break;
            //    }

            //    //빙고 개수 체크
            //    bingoCount = 0;

            //    //가로체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        bool rowBingo = true;
            //        for (int j = 0; j < 5; j++)
            //            if (!marked[i, j]) rowBingo = false;

            //        if (rowBingo) bingoCount++;
            //    }


            //    //세로체크
            //    for (int j = 0; j < 5; j++)
            //    {
            //        bool colBingo = true;

            //        for (int i = 0; i < 5; i++)
            //            if (!marked[i, j]) colBingo = false;

            //        if (colBingo) bingoCount++;
            //    }


            //    //대각선 체크 (왼쪽위 ->오른쪽 아래)

            //    bool diag1Bingo = true;

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (!marked[i, i])
            //            diag1Bingo = false;
            //    }
            //    if (diag1Bingo)
            //        bingoCount++;

            //    //대각선 오른쪽위 ->왼쪽아래
            //    bool diag2Bingo = true;
            //    for (int i = 0; i < 5; i++)
            //        if (!marked[i, 4 - i]) diag2Bingo = false;
            //    if (diag2Bingo) bingoCount++;
            //}
            //Console.WriteLine("빙고 5개 완성! 게임종료");
        }

    }
}

