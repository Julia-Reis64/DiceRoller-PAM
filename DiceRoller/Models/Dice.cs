﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Dice{
        private static Random random = new Random();

        public int FaceParaCima;
        public int FaceParaBaixo;

        public Dice(){
            FaceParaCima = 1; // Inicializará com um valor padrão (1)
            FaceParaBaixo = 7 - FaceParaCima; // A face oposta de um dado de 6 lados
        }

        public int Roll(){
            FaceParaCima = random.Next(1, 7); // Gera um número entre 1 e 6
            FaceParaBaixo = 7 - FaceParaCima;
            return FaceParaCima;
        }
    }

}
