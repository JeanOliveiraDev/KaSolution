using System;

namespace Despesas.Dominio
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        internal long Cnpj { get; set; }        
    }
}