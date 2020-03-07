using System;

namespace Despesas.Dominio
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public long Cnpj { get; set; }

    }
}