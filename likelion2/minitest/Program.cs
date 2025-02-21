using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minitest
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;  //hp : 100
            double att = 56.7;  //att : 56.7
            string character = "??"; //캐릭터이름 : ??
            char grade = 'S'; //등급 : S

            Console.WriteLine("캐릭터");
            Console.WriteLine("hp :" +hp);
            Console.WriteLine("att :" +att);
            Console.WriteLine("chracter :" +character);
            Console.WriteLine("grade :" +grade);
        }
    }
}
