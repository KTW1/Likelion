using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_6th
{
    public class Mage : Class
    {
        public Mage(string name) : base(name, 70, 15, 5)
        {
        }
        public override void Att(Class target)
        {
            Console.WriteLine($"{Name} {target.Name} 마법");
            target.Damage(Attack);
        }
        public override void Skill(Class target)
        {
            Console.WriteLine($"{Name} {target.Name} 화염");
            target.Damage(Attack * 2);
        }
    }
}
