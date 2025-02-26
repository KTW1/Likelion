using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuction
{
    class Program
    {
        static void Loading()
        {
            Console.WriteLine("Loading.");
            Console.WriteLine("Loading..");
            Console.WriteLine("Loading...");
        }
        static void AttackF(int Att)
        {
            Console.WriteLine("att = " +Att);
        }

        static int Damage()
        {
            int att = 10;
            return att;
        }
        static void Main(string[] args)
        {
            //로딩화면 함수
            int tDamage = 0;
            Console.Write("att?");
            int att = int.Parse(Console.ReadLine());

            tDamage = Damage();

            AttackF(tDamage+att);

        }
    }
}
