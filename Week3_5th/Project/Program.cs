using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study34
{
    class Champion
    {
        public string Name;
        public string SkillName;
        public int Heath;
        public int DPS;
        public float SkillDamage;
        public int Mana;
        public int Max;

        public Champion()
        {
            Name = "None";
            Heath = 0;
            DPS = 0;
            SkillName = "n";
            SkillDamage = 0;
            Mana = 0;
            Max = 0;
        }
        public virtual void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
        public virtual void Nick()
        {
            Console.WriteLine($"======{Name}======");
            Console.WriteLine();
        }
        public virtual void Skill()
        {
            Console.WriteLine($"{SkillName}! {SkillDamage}");
            Mana = 0;
        }
        public virtual void Att()
        {
            Console.WriteLine($"normal Attack {DPS}");
            Mana += 5;
        }
    }
    class Resource
    {
        public int Gold;
        public string Item;
        public string Signiture;
    }
    class Powder1 : Champion
    {
        public Powder1()
        {
            Name = "Powder";
            Heath = 600;
            DPS = 30;
            SkillName = "별난 장난감";
            SkillDamage = (float)(DPS * 4.2);
            Mana = 40;
            Max = 100;
        }
        public override void Nick()
        {
            Console.WriteLine($"============{Name}============");
            Console.WriteLine();
        }
        public override void Skill()
        {
            Console.WriteLine($"\n{SkillName}! damage:{SkillDamage}");
            Mana = 0;
        }
        public override void Att()
        {
            Console.WriteLine($"Normal Attack! damage:{DPS} ({Mana}/{Max})");
            Mana += 5;
        }
        public override void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
    }
    class Jerry2 : Champion
    {
        public Jerry2()
        {
            Name = "Jerry";
            Heath = 600;
            DPS = 38;
            SkillName = "살아있는 배터리";
            SkillDamage = DPS * 2;
            Mana = 0;
            Max = 3;
        }
        public override void Nick()
        {
            Console.WriteLine($"============{Name}============");
            Console.WriteLine();
        }
        public override void Skill()
        {
            Console.WriteLine($"\n{SkillName}! damage:{SkillDamage}");
            Mana = 0;
        }
        public override void Att()
        {
            Console.WriteLine($"Normal Attack! damage:{DPS} ({Mana}/{Max})");
            Mana += 5;
        }
        public override void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
    }
    class Nami3 : Champion
    {
        public Nami3()
        {
            Name = "Nami";
            Heath = 700;
            DPS = 28;
            SkillName = "바다의 썰물";
            SkillDamage = (float)(DPS * 1.2);
            Mana = 0;
            Max = 60;
        }
        public override void Nick()
        {
            Console.WriteLine($"============{Name}============");
            Console.WriteLine();
        }
        public override void Skill()
        {
            Console.WriteLine($"\n{SkillName}! damage:{SkillDamage}");
            Mana = 0;
        }
        public override void Att()
        {
            Console.WriteLine($"Normal Attack! damage:{DPS} ({Mana}/{Max})");
            Mana += 5;
        }
        public override void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
    }
    class Bi4 : Champion
    {
        public Bi4()
        {
            Name = "Bi";
            Heath = 1100;
            DPS = 64;
            SkillName = "일당백";
            SkillDamage = DPS * 6;
            Mana = 40;
            Max = 100;
        }
        public override void Nick()
        {
            Console.WriteLine($"============{Name}============");
            Console.WriteLine();
        }
        public override void Skill()
        {
            Console.WriteLine($"\n{SkillName}! damage:{SkillDamage}");
            Mana = 0;
        }
        public override void Att()
        {
            Console.WriteLine($"Normal Attack! damage:{DPS} ({Mana}/{Max})");
            Mana += 5;
        }
        public override void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
    }
    class Jinx5 : Champion
    {
        public Jinx5()
        {
            Name = "Jinx";
            Heath = 900;
            DPS = 48;
            SkillName = "모든 것의 파멸";
            SkillDamage = (float)(DPS * 9.65);
            Mana = 0;
            Max = 60;
        }
        public override void Nick()
        {
            Console.WriteLine($"============{Name}============");
            Console.WriteLine();
        }
        public override void Skill()
        {
            Console.WriteLine($"\n{SkillName}! damage:{SkillDamage}");
            Mana = 0;
        }
        public override void Att()
        {
            Console.WriteLine($"Normal Attack! damage:{DPS} ({Mana}/{Max})");
            Mana += 5;
        }
        public override void Charge()
        {
            if (Mana < Max)
            {
                for (int y = 0; Mana < Max; y++)
                {
                    Att();
                }
            }
            else if (Mana == Max)
            {
                Skill();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> Action = new List<Champion>();

            Action.Add(new Powder1());
            Action.Add(new Jerry2());
            Action.Add(new Nami3());
            Action.Add(new Bi4());
            Action.Add(new Jinx5());

            foreach (var act in Action)
            {
                act.Nick();
                act.Att();
                act.Charge();
                act.Skill();
                Console.ReadLine();
            }

        }
    }
}
