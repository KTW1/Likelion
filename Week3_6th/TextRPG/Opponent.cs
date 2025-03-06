using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Opponent
    {
        public Info m_Opp;
        public void SetDamage(int iAttack) { m_Opp.iHP -= iAttack; }
        public void SetOpponent(Info tOpp) { m_Opp = tOpp; }
        public Info GetOpponent() { return m_Opp; }
        public void Render()
        {
            Console.WriteLine("\nOpponent: " + m_Opp.strName);
            Console.WriteLine("Hp: " + m_Opp.iHP + " Att: " + m_Opp.iAttack);
        }
    }
}
