using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {
        public Info m_tInfo;
        public void SetDamage(int iAttack) { m_tInfo.iHP -= iAttack; }
        public Info GetInfo() { return m_tInfo; }
        public void SetHP(int iHP) { m_tInfo.iHP = iHP; }
        public void Position()
        {
            m_tInfo = new Info();
            Console.WriteLine("\nPosition Select");
            Console.WriteLine("\n1.Top");
            Console.WriteLine("2.Jungle");
            Console.WriteLine("3.Mid");
            Console.WriteLine("4.Support");
            Console.WriteLine("5.DPS");
            Console.Write("\nWhich one? ");
            int Input = int.Parse(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    m_tInfo.strName = "Top";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.Tier = "Iron";
                    m_tInfo.Rankp = 0;
                    break;
                case 2:
                    m_tInfo.strName = "Jungle";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.Tier = "Iron";
                    m_tInfo.Rankp = 0;
                    break;
                case 3:
                    m_tInfo.strName = "Mid";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.Tier = "Iron";
                    m_tInfo.Rankp = 0;
                    break;
                case 4:
                    m_tInfo.strName = "Support";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.Tier = "Iron";
                    m_tInfo.Rankp = 0;
                    break;
                case 5:
                    m_tInfo.strName = "DPS";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.Tier = "Iron";
                    m_tInfo.Rankp = 0;
                    break;
            }
        }
        public void Render()
        {
            Console.WriteLine("==================");
            Console.WriteLine("Position: " + m_tInfo.strName);
            Console.WriteLine("Hp: " + m_tInfo.iHP + "\nAtt: " + m_tInfo.iAttack);
            Console.WriteLine("Rank: " + m_tInfo.Rankp + "\nTier: " + m_tInfo.Tier);
            Console.WriteLine("==================");
        }
    }
}

