using System;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
1. 배열을 만들고, 배열의 오름차/기본 정렬을 한다. Array,Sort();면 된다.
2. 특정 문자가 포함된 문자열을 가져올 수 있다.
3. LINQ/select. 각 요소를 변환해 컬렉션을 생성. 가령 대문자로 변환하고 싶은 경우
4. 평균, 최대최소, 합 등 연산과 절댓값을 통한 타겟에 가장 가까운값 구하기
5. 탐색, 그룹화. GroupBy(조건)의 문자배열만 있어도 묶어줄 수 있다.
6. 상속. 파생 : 뿌리 구조인데, 영문 of를 생각하면 된다.
6-2. 오버라이드. 함수가 종속클래스에 있다면, 사용가능. 기본뼈대/파생. 응용과 확장을 목적.
6-3. 업캐스팅. 안전성 확보/deriv를 root로, 다운캐스팅. 종속화시키면 접근권한이 폐쇄된다.
 */
namespace Week3_5th
{
    class Skill
    {
        public string Name;
        public int ManaCost;
        public int Cooldown;
        public int LastUsedTime;
        public Skill(string name, int manaCost, int cooldown)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000;
            LastUsedTime = 0;
        }
        public bool CanUse(int playerMana)
        {
            int CurrentTime = Environment.TickCount;
            if (playerMana < ManaCost)
            {
                Console.WriteLine($"{ManaCost}");
                return false;
            }
            if (CurrentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (CurrentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"Can't use skill {Name} : {remainingTime}");
                return false;
            }
            return true;
        }
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;
            playerMana -= ManaCost;
            LastUsedTime = Environment.TickCount;
            Console.WriteLine($"{Name}fire : {remainingTime}");
        }
    }

    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}");
        }
        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}");
        }

    }
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }
        public override void Attack()
        {
            Console.WriteLine("attack");
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"{target.Name}");
        }
    }
    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }
        public override void Attack()
        {
            Console.WriteLine("attack");
        }
    }
    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"{target.Name}");
        }
    }
    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }
        public override void Attack()
        {
            Console.WriteLine($"attack");
        }
        public override void Move()
        {
            Console.WriteLine($"move");
        }
    }

    class Parent
    {
        public virtual void ShowMessage() //virtual. 어디에 상속했구나
        {
            Console.WriteLine("2 부모클래스의 메시지"); //마지막 실행
        }
    }
    class Child : Parent
    {
        public override void ShowMessage() //여기에 종속시켰구나
        {
            Console.WriteLine("1 자식 클래스의 메시지"); //출력하는 것
            base.ShowMessage(); //base. 부모함수 실행. 부모클래스로
        }
    }

    class Animal
    {
        public string Name { get; set; }
        //가상(virtual)메서드 : 자식 클래스에서 재정의 가능
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {

        //부모 클래스의 메서드를 오버라이딩(재정의)
        public override void Speak()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
        public void Bark()
        {
            Console.WriteLine($"{Name}가 멍멍 짖습니다.");
        }
    }

    class Player
    {
        protected string Name;   //protected 부모랑 자식 상속관계에서만 사용하고싶을때

        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("부모 생성자입니다.");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
    class Wizard : Player
    {
        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("자식 생성자입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 200;
            Skill[] skills = new Skill[]
            {
                new Skill("fireball",20,3),
                new Skill("icy",15,2),
                new Skill("Heal",30,5)
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Now MP? {playerMana}");
                Console.WriteLine("Usable skill?");
                for (int y = 0; y < skills.Length; y++)
                {
                    Console.WriteLine($"{y + 1}. {skills[y].Name}. Mp{skills[y].ManaCost}+" +
                        $"Cooldown{skills[y].Cooldown / 1000}s");
                }
                Console.WriteLine("0.end");
                Console.Write("skill num?");
                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());
                    if (skillIndex == 0) break;
                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                catch
                {
                    Console.WriteLine("num?");
                }
                Thread.Sleep(500);
            }
            Console.WriteLine("Game EXit");
        }
        //List<Unit> units = new List<Unit>();
        //units.Add(new SCV());
        //units.Add(new Marine());
        //units.Add(new Medic());
        //units.Add(new Tank());
        //foreach (var unit in units)
        //{
        //    unit.Move();
        //    unit.Attack();
        //    Console.WriteLine();
        //}
        //SCV scv = new SCV();
        //scv.Heal(units[3]);

        //Medic medic = new Medic();
        //medic.Heal(units[1]); //마린치료

        //Player p = new Player();
        //p.Show();
        //부모가 먼저 실행되고, 종속이 실행된다.
        //Wizard w = new Wizard(); //wizard부터 확인, 이후 변수/함수를 가지고 상속으로
        //w.Show();

        //Child child = new Child(); //child 클래스의 객체 child를 생성
        //child.ShowMessage();//클래스 내 함수출력. 클래스를 확인

        //Dog myDog = new Dog();  //자식 클래스 객체 생성
        //Animal myAnimal = myDog; //업캐스팅(Dog->animal)

        //myAnimal.Speak(); //사용가능 

        ///myAnimal.Bark()  오류 업캐스팅후 자식 클래스의 메서드는 접근 불가

        //Animal myAnimal = new Animal();
        //myAnimal.Name = "일반동물";
        //myAnimal.Speak(); //부모클래스의 기본메서드 실행

        //Dog myDog = new Dog();
        //myDog.Name = "바둑이";
        //myDog.Speak();  //오버라이딩된 메서드 실행

        //string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

        //var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화

        //foreach (var group in groups) 
        //{
        //    Console.WriteLine($"Key : {group.Key}");

        //    foreach (var item in group)
        //    {
        //        Console.WriteLine($" {item}");
        //    }

        //}
        //Sum(), Min(), Max(), Average(); 이렇게 기본연산은 함수로 구현되어 있다.
        //int[] data = { 10, 25, 33, 47, 59 };
        //int target = 22; int nearest = data[0];
        //foreach(var n in data)
        //{
        //    if (Math.Abs(n - target) < Math.Abs(nearest - target))
        //            nearest = n;
        //}
        //Console.WriteLine($"목표치{target} : 가장 가까운 것은? {nearest}");

        //float avg = data.Average();
        //Console.WriteLine($"avg? {avg:F2}");

        //string[] words = { "Apple", "Banana", "Coconut" };
        //var upperWords = words.Select(w => w.ToUpper());
        //foreach (var word in upperWords)
        //{
        //    Console.WriteLine(word);
        //}
        //메서드, 쿼
        //이런게 있는지 모르는 사람들도 있다. 찾아보는 습관이 중요하다.
        //int[] nums = {11,5,8,4 }; var Method = nums.OrderByDescending(n => n);
        //var Query = from n in nums
        //            orderby n //여기 ;쓰는거 아니다. 오류1
        //            select n;

        //Console.WriteLine("");
        //foreach (var n in Method)
        //    Console.WriteLine(n);

        //Console.WriteLine("");
        //foreach (var n in Query)
        //    Console.WriteLine(n);

        //이 부분이 ABC순으로 정렬되는게 맞다.
        //정렬과 특정문자/조건에 포함되는 문자열을 가져오는 식.
        //string[] names = { "Charlie", "Alice", "Bob" };
        //var sortedNames = names.OrderBy(n => n);

        //foreach (var name in sortedNames)
        //{
        //    Console.WriteLine(name);
        //}

        ////여기는 첫문자를 포함한 문자열을 알려주는 식일 뿐.
        //var firstName = names.First(n => n.StartsWith("A"));
        //Console.WriteLine($"First name starting with A: {firstName}");
    }
}

