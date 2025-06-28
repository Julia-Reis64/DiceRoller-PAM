using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    class Game{
        public int VitoriaSequencia;
        public int TotalVitorias;
        public int UltimaSomaDosDados;
        public int LimiteVitorias;

        public Game()
        {
            VitoriaSequencia = 0;
            TotalVitorias = 0;
            UltimaSomaDosDados = 0;
            LimiteVitorias = 25;
        }

        public bool CheckResultado(int dado1, int dado2, int escolha)
        {
            UltimaSomaDosDados = dado1 + dado2;

            if (UltimaSomaDosDados == escolha)
            {
                TotalVitorias++;
                VitoriaSequencia++;
                return true;
            }
            else
            {
                VitoriaSequencia = 0;
                return false;
            }
        }
        //Adicionar um limite de vitórias (25 vitórias)
        public bool LimiteCheck()
        {
            return TotalVitorias >= LimiteVitorias;
        }

    }
}
