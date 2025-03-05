using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Fri
{
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "marin";
            Mineral = 50;
        }
        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name? {Name}, mine? {Mineral}");

        }
    }
    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "scv";
            Mineral = 50;
        }
        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name? {Name}, mine? {Mineral}");

        }
    }
    class Barrack
    {
        public string Name;
        public int Mineral;
        public Barrack()
        {
            Name = "Barrack";
            Mineral = 150;
        }
        public Barrack(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name? {Name}, mine? {Mineral}");
        }
    }
    class Mineral
    {
        public int Resource;
        public string Name;
        public Mineral()
        {
            Name = "Mineral";
            Resource = 1500;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"mineral? {Resource}");
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;
        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

            Marin marin = new Marin();
            SCV scv = new SCV();
            Barrack barrack = new Barrack();
            
            Mineral[] minerals = new Mineral[7];
            for(int y=0; y<minerals.Length; y++)
            {
                minerals[y] = new Mineral();
                minerals[y].ShowInfo();
            }

            marin.ShowInfo();//변수값 입력하면, 매개변수 동적
            scv.ShowInfo();
            barrack.ShowInfo();

            //생성자. Instance생성 시 자동실행. 초기화 설정에 주로 사용

            //DateTime Now = DateTime.Now;
            //Console.WriteLine($"Current? {Now}");
            //TimeSpan Duration = new TimeSpan(1, 30, 0); //1h 30m
            //Console.WriteLine($"Term? {Duration}");

            //Class는 Instance를 만든다. 함수와 같으나 객체지향 중심.

        }
    }
}
