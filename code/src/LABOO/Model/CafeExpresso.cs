using System;
using System.Collections.Generic;
using System.Text;

namespace LABOO.Model
{
    public class CafeExpresso : Cafe
    {
        public override string ModoPreparo()
        {
            return "Máquina expressa"; 
        }

        public override string ModoDeServir()
        {
            return "Copo de vidro";
        }
    }
}
