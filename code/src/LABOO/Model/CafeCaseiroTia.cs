using System;
using System.Collections.Generic;
using System.Text;

namespace LABOO.Model
{
    //Sealed classe fechada para herança
    public sealed class CafeCaseiroTia : CafeCaseiro
    {
        public override string ModoDeServir()
        {
            return base.ModoDeServir();
        }
    }
}
