using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likelion6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요 :");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, [userName]님!");

            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine(); //입력받기
            //int age = int.Parse(input); //문자열 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살입니다!");
            //Console.WriteLine("내년에는 " + age + "살입니다!");
            //Console.WriteLine("내년에는 {0} 살입니다!", age);

            Console.Write("루인 스킬 피해 : "); //4.5%
            float Ruin = float.Parse(Console.ReadLine());
            
            Console.Write("카드 게이지 획득량 : "); //3.2%
            float Card = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해 : "); // 6.5%
            float SkillDamage = float.Parse(Console.ReadLine());

            Console.Write("최대 마나 : "); //2827   
            float Mana = float.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량 : "); //101
            float War_mana = float.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량 : "); //101
            float Nwar_mana = float.Parse(Console.ReadLine());

            Console.Write("이동 속도 : "); //102.6%
            float spd = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도 : "); //100.0%
            float Veh_spd = float.Parse(Console.ReadLine());

            Console.Write("운반 속도 : "); //100.0%
            float Carry_spd = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소 : "); //3.3%
            float Cool = float.Parse(Console.ReadLine());
            
            Console.WriteLine("     ");
            Console.WriteLine($"루인 스킬 피해 : {Ruin}%");
            Console.WriteLine($"카드 게이지 획득량 : {Card}%");
            Console.WriteLine($"각성기 피해 : {SkillDamage}%");
            Console.WriteLine($"최대 마나 : {Mana}");
            Console.WriteLine($"전투 중 마나 회복량 : {War_mana}");
            Console.WriteLine($"비전투 중 마나 회복량 : {Nwar_mana}");
            Console.WriteLine($"이동 속도 : {spd}%");
            Console.WriteLine($"탈 것 속도 : {Veh_spd:F1}%");
            Console.WriteLine($"운반 속도 : {Carry_spd:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {Cool}%");

        }
    }
}
