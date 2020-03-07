using Despesas.Dominio.Despesas;

namespace Despesas.Dominio
{
    public class Politica : BaseEntity
    {
        public string Descricao { get; set; }
        public string Regra { get; set; }
        public Tipo TipoDespesa { get; set; }
    }
}