using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev1
{
    class Mine
    {
        public static void Hi()
        {
            Console.WriteLine("to hell");
        }
    }
}
namespace nameSpace
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("헬로");
        }
        enum WeaponType
        {
            Sword, Bow, Staff
        }
        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }
            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("지팡이를 선택했습니다.");
            }
        }
        static void Main(string[] args)
        {
            //dev1.Mine.Hi();
            //Hi();
            //Console.WriteLine(Arrow(5, 10));
            //Message();

            //Console.WriteLine($"pi {Math.PI}");
            //Console.WriteLine($"Square rootㅁ25 {Math.Sqrt(25)}");
            //Console.WriteLine($"Power 3^5 {Math.Pow(3,5)}");
            //Console.WriteLine($"Round 3.75 {Math.Round(3.75)}");

            //DayOfWeek today = DayOfWeek.Thu;
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);
            //Console.Write("Choose?1.Sword, 2.Bow, 3.Staff ");

            //Weapontype.Sword   검을 선택했습니다.
            //Weapontype.Bow    활을 선택했습니다.
            //Weapontype.Staff  지팡이를 선택했습니다.
            ChooseWeapon(WeaponType.Staff);

        }
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }
        enum DayOfWeek
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }
        static void Message() => Console.WriteLine("hello");
        static int Arrow(int a, int b) => a + b; //simple
    }
}
