using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas.Dominio.Despesas
{
    public class Despesa : BaseEntity
    {
        public enum Status
        {
            Pendente = 0,
            Paga = 1,
            NaoAprovada = 2,
            Aprovada = 3,
            Cancelada = 4
        }

        public Projeto Projeto { get; set; }
        public Tipo TipoDespesa { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Consultor Consultor{ get; set; }
        public Status StatusDespesa { get; set; }
    }
}
