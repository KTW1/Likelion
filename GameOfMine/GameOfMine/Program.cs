using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfMine
{
    /*
    처음부터 지금까지 배운 내용을 종합. 
    최대한 유기적으로 로직을 연결해 만든다.
    화려하게 만드는 것보다 정석과 기본에 중점.
    게임의 완성. 
    1. UIUX. 1~n번호를 입력하는 창. 별 거 아니다.
    de프로그래밍
    2. 스토리. 별 거 아니다. 짧게 몇 줄 적어내면 그만인 것.
    3. 클리어+엔딩. 이 것도 별 거 아니다.
    그럼 중요한건 뭐냐? 내부 플레잉 로직이 가장 중요하다.
     */
    class Program
    {
        static void Story()
        {
            Console.WriteLine("\n때는 바야흐로 2025년...");
            Console.WriteLine("\n3일 내내 롤에 빠져있던 나는, 피곤함에 쓰러졌다.");
            Console.WriteLine("눈을 떠보니 이게 웬걸? 날짜를 보니 2011년이 아닌가!");
            Console.WriteLine("영문은 모르겠지만 기왕 이렇게 됐으니, 프로에 도전해보자!");
            Console.WriteLine("\nSSS급 불사대마왕을 향한 여정이 지금 시작된다.");
            Console.ReadLine();
        }
        static void Title()
        {
            Console.Clear();
            Console.WriteLine("\nLOL Team Fight");
            Console.WriteLine("\nPress Enter to Start");
            Console.ReadLine();
        }
        static void DownLoad()
        {
            Console.Clear();
            Console.WriteLine("\nLOL Clent Download");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("□□□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■□□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■■□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■■■");
            Console.WriteLine("\nDownload Compelete");
            Console.Clear();

            Console.WriteLine("\nRiot Vangaurd Download");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("□□□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■□□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■□□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■□□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■■□");
            Console.WriteLine("Wait Please...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("■■■■■");
            Console.WriteLine("\nDownload Compelete");
            Console.Clear();
        }
        class Position
        {
            public int rank = 0;
            public string Tier = "UnRank";

        }
        static void MyRank()
        {


            //Console.WriteLine($"Top | {Tier}");
            //Console.WriteLine("Jungle | {Tier}");
            //Console.WriteLine("Mid | {Tier}");
            //Console.WriteLine("Support | {Tier}");
            //Console.WriteLine("DPS | {Tier}");
        }
        static void Tutorial() //뭐하려했지?
        {
            Console.Clear();
            Console.WriteLine("튜토리얼을 진행합니다.");
            Thread.Sleep(1000);
            
            Console.Clear();
            Console.WriteLine("ㅡㅡㅡㅡ미구현 항목ㅡㅡㅡㅡ");
            Console.WriteLine("매칭 시스템");
            Console.WriteLine("로그인. 아이디/패스워드");
            Console.WriteLine("아이템 구매/스테이터스");
            Console.WriteLine("스테이터스");
            Console.WriteLine("랭킹 시스템");
            Console.WriteLine("티어표기");

            Console.Clear();
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Random rand = new Random(); //랜덤값

            Console.Clear();
            Story();
            Title();
            DownLoad();
            Tutorial();
            //3아이디/패스워드 가입
            //매칭. 팀원/적팀뽑기. continue/자기포지션 생략

            int sum = 0 ; int game = 0; int rank = 0;
            //float mmr = sum / i; //실수형. for평균값 :F2
            //삼항연산.
            bool isAlive = true;

            Thread.Sleep(500);
            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine("1.RankGame");
                Console.WriteLine("2.MyRank");
                Console.WriteLine("3.Exit");
                Console.Write("Which one?");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Which Position? ");
                    Console.WriteLine("1.Top");
                    Console.WriteLine("2.Jungle");
                    Console.WriteLine("3.Mid");
                    Console.WriteLine("4.Support");
                    Console.WriteLine("5.DPS");
                    int p = int.Parse(Console.ReadLine());

                    int Match = rand.Next(1, 500);
                    
                    Console.Clear();
                    if (rank <= Match)
                    {
                        int lose = rand.Next(15, 25);
                        Console.WriteLine($"⚔️ Lose! Rank-{lose}");
                        rank -= lose;
                    }
                    else if (rank > Match)
                    {
                        int win = rand.Next(15, 25);
                        Console.WriteLine($"⚔️ Win! Rank+{win}");
                        rank += win;
                    }
                    
                    if (rank <= 0)
                    {
                        Console.WriteLine("☠️ Not enuogh talent");
                        Console.WriteLine("☠️ 다음 생에는 꼭...");
                        isAlive = false;
                    }
                    if (rank >= 500)
                    {
                        Console.WriteLine("해냈다! 프로팀에서 스카웃 제의가 왔다");
                        Console.WriteLine("\n과연, 이게 끝일까?");
                        isAlive = false;
                    }
                    Thread.Sleep(1000);
                }
                if (input == 2)
                {
                    MyRank();
                }
                if (input == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Program Exit");
                    Environment.Exit(0);
                }
            }
        }
    }
}