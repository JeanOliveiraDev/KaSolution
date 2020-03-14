using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07.Model
{
    public class ServicoAluno
    {
        private EscolaContexto contexto = new EscolaContexto("EscolaContexto");

        public List<Aluno> ConsultarAluno()
        {
            //contexto.Database.Log = Console.WriteLine;
            contexto.Configuration.LazyLoadingEnabled = true;

            return contexto.Alunos.Include("Desempenho").ToList();                            
        }

        public void CriarAluno(string cpf, string nome)
        {
            Aluno aluno = new Aluno()
            {
                CPF = cpf,
                Nome = nome
            };

            contexto.Alunos.Add(aluno);
            contexto.SaveChanges();
        }
    }
}
