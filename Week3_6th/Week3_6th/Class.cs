using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week3_6th
{
    public abstract class Class
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        protected Class(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }
        public abstract void Att(Class target);
        public abstract void Skill(Class target);
        public void Damage(int damage)
        {
            int Damage = Math.Max(1, damage - Defense);
            Health = Math.Max(0, Health - Damage);
            Console.WriteLine($"{Name} is {Damage} reamain {Health}");
        }
    }
}


