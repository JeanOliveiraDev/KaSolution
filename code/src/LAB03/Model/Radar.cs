﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03.Model
{
    public class Radar
    {
        public delegate void VelocidadeExcedide(string placa, int velocidade, string via);
        public event VelocidadeExcedide EventoGerarMulta;

        public bool IsMovel { get; set; }
        public string Via { get; set; }
        public int LimiteVelocidadePermitida { get; set; }    

        public virtual void Multar(string placa, int km, string via)
        {
            EventoGerarMulta(placa, km, via);
        }

        public bool ValidarVelocidade(int km, string placa, string via)
        {
            if (km > LimiteVelocidadePermitida)
            {
                Multar(placa, km, via);
                return true;
            }

            return false;
        }
    }
}