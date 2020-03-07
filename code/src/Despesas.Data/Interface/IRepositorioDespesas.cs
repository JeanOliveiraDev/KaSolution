using Despesas.Dominio.Despesas;
using System;

namespace Despesas.Data
{
    public interface IRepositorioDespesas
    {
        int GravarDespesa(Despesa despesa);
        void ExcluirDespesa(int codigo);
        void AprovarDespesa(int codigo);
        void ReprovarDespesa(int codigo);
    }
}
