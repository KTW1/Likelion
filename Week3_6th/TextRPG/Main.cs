using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Main
    {
        public Player User;
        public Vally m_Vally;

        public void Default() //초기화함수
        {
            User = new Player(); //생성
            User.Position(); //포지션
        }
        public void Progress()
        {
            while (true)
            {
                Console.Clear();

                User.Render();
                Console.WriteLine("\n1.Rank_Match");
                Console.WriteLine("2.EXIt");
                Console.Write("\nWhich one? ");
                int iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    if(m_Vally == null)
                    {
                        m_Vally = new Vally();
                        m_Vally.SetPlayer(ref User);
                    }
                }
                m_Vally.Progress();
                if (iInput == 2) { Environment.Exit(0); }
            }
        }
    }
}
