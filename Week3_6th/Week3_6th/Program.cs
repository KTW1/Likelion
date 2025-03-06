using Another;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. NameSpace를 추가해서 public으로 Main에 가져올 수 있다.
/// 2. 클래스. 필드란, 멤버/클래스data를 저장. instance객체의 속성값을 저장하는 것이 필드에 저장하는 것.
/// 3. 생성자. Defualt값 베이스를 초기화하는 경우.
/// 3-2. 소멸자. ~물결표를 붙여주면 선언. GC가비지 컬렉터로 참조되지 않는 객체를 정리한다. 메모리
/// 4. 포인터/ref. 함수를 Main으로 호출해 반영. 주소라 부르는 메모리 스페이스를 개념적 동일시한다.
/// 4-2. out. 반환이 여러개일 경우 out int x
/// 5. 추상Abstract. 기본적 객체생성은 불가. 상속용. 설계 차원의 선언과 종속부에서 구체화하는 것.
/// 6. 상위 클래스 초기화를 하위에서 하는 방식. 변수값 입력으로 인스턴스 기본값 설정하는 데 쓰이겠다.
/// 7. Interface인터페이스. 추상클래스의 다중상속 기능 포함. 다형성 및 재사용성/유지보수에 용이
/// </summary>

namespace Another
{
    //네임스페이스, 클래스는 일개 분류에 불과하다. 변수를 받고 선언하는 역할은 생성자/함수에 맡긴다.
    class Rescource
    {
        ~Rescource()
        {
            Console.WriteLine("Erase Call");
        }
    }
    class Person
    {
        public string Name;

        public Person()
        {
            Name = "none";
        }
        public Person(string name)
        {
            Name = name;
        }
        public void SetName(string a)
        {
            Name = a;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class One
    {
        public void Sub()
        {
            Console.WriteLine("Neo!");
        }
    }

    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다.");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹!");
        }
    }

    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("Parent Maker" + message);
        }
    }
    class Child : Parent
    {
        public Child() : base("Success")
        {
            Console.WriteLine("Child Call");
        }
    }
}
namespace Week3_6th
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("간단한 RPG 게임을 시작합니다.");

            //캐릭터 생성
            Class warrior = new Warrior("전사");
            Class mage = new Mage("마법사");

            //전투 시뮬
            Console.WriteLine("=====전투 시작! ======");

            //전사의 공격
            warrior.Att(mage);
            warrior.Skill(mage);

            //마법사의 반격

            mage.Att(warrior);
            mage.Skill(warrior);

            Console.WriteLine("=========전투종료========");
            Console.WriteLine($"전사 남은 체력: {warrior.Health}");
            Console.WriteLine($"마법사 남은 체력: {mage.Health}");

            //Animal myDog = new Dog();
            //myDog.MakeSound();
            //myDog.Sleep();

            //Animal myCat = new Cat();
            //myCat.MakeSound();
            //myCat.Sleep();

            //static void Point(int a, int b, out int x, out int y)
            //{
            //    x = a;
            //    y = b;
            //}
            //static void Main(string[] args)
            //{
            //    int a = 10;
            //    int b = 20;
            //    int x, y;

            //    Point(a, b, out x, out y);
            //    Console.WriteLine("X" + x + ", " + "y" + y);

            //Rescource E = new Rescource();

            //Person p = new Person("Alice");
            //Console.WriteLine(p.Name);

            //Person N = new Person();
            //N.SetName("You");
            //Console.WriteLine(N.GetName());

            //N.Name = "And you";
            //Console.WriteLine("who are? " + N.Name);

            //One n = new One();
            //n.Sub();
        }
    }
}

