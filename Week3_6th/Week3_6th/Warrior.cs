using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week3_6th
{
    public class Warrior : Class
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        {
        }
        public override void Att(Class target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 기본 공격을 시도합니다.!");
            target.Damage(Attack);
        }
        public override void Skill(Class target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 휠윈드 시전합니다.");
            target.Damage(Attack * 2);
        }
    }
}
