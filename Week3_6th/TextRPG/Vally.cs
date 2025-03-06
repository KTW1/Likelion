using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Vally
    {
        Player m_Player = null;
        Opponent m_Opp = null;
        Random rand = new Random();

        public void SetPlayer(ref Player pPlayer) { m_Player = pPlayer; }
        //public void Match(ref int Rank, ref int Rankp, ref string Tier)
        //{
        //    int R = rand.Next(15, 25);
        //    Rankp += R;

        //    if (Rankp < 100) { Tier = "BSGold"; }
        //    if (Rankp < 200) { Tier = "PDMaster"; }
        //    if (Rankp < 300) { Tier = "Challenger"; }
        //    if (Rankp < 400) { Tier = "LCK"; }
        //}
        public void Progress()
        {
            int Input = 0;
            while (true)
            {
                Console.Clear();

                m_Player.Render();
                Match();
                Input = int.Parse(Console.ReadLine());

                if (Input == 5) break;
                if (Input <= 4)
                {
                    CreateOpp(Input);
                    Fight();
                }
            }
        }
        public void Create(string _strName, int _iHP, int _iAttack, out Opponent pOpp)
        {
            pOpp = new Opponent();
            Info tOpp = new Info();

            tOpp.strName = _strName;
            tOpp.iHP = _iHP;
            tOpp.iAttack = _iAttack;

            pOpp.SetOpponent(tOpp);
        }
        public void CreateOpp(int input)
        {
            switch (input)
            {
                case 1:
                    Create("Bro/Sil/Gol", 30, 3, out m_Opp);
                    break;
                case 2:
                    Create("Pla/Dia/Mas", 60, 6, out m_Opp);
                    break;
                case 3:
                    Create("Challengers", 90, 9, out m_Opp);
                    break;
                case 4:
                    Create("LCK", 150, 15, out m_Opp);
                    break;
            }
        }
        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                m_Player.Render();
                m_Opp.Render();

                Console.WriteLine("\n1. Fight");
                Console.WriteLine("2. Surrender");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    m_Player.SetDamage(m_Opp.GetOpponent().iAttack);
                    m_Opp.SetDamage(m_Player.GetInfo().iAttack);
                    if (m_Player.GetInfo().iHP <= 0)
                    {
                        m_Player.SetHP(100);
                        break;
                    }
                }
                if (input == 2 || m_Opp.GetOpponent().iHP <= 0)
                {
                    m_Opp = null;
                    break;
                }
            }
        }
        public void Match()
        {
            Console.WriteLine("\n1.BSGold");
            Console.WriteLine("2.PDMaster");
            Console.WriteLine("3.Challenger");
            Console.WriteLine("4.LCK");
            Console.Write("\nWhich one? ");
        }
    }
}

