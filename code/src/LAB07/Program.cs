using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    class Program
    {
        static EscolaContexto contexto = new EscolaContexto("EscolaContexto");

        static void Main(string[] args)
        {
            //CriarAluno("","");
            CriarDesempenho();
            ConsultarAluno();

            Console.ReadKey();
        }

        private static void CriarDesempenho()
        {
            //contexto.Database.Log = Console.WriteLine;
            List<Desempenho> desempenhos = new List<Desempenho>();

            Aluno alunos = contexto.Alunos.Where(x => x.CPF == "123.123.123-10").FirstOrDefault();

            desempenhos.Add(new Desempenho() {
                Ano = 2020,
                Bimestre = "1",
                Aluno = alunos,
                Materia = "Portugues",
                Nota = 10
            });
            desempenhos.Add(new Desempenho()
            {
                Ano = 2020,
                Bimestre = "1",
                Aluno = alunos,
                Materia = "Matematica",
                Nota = 7
            });
            desempenhos.Add(new Desempenho()
            {
                Ano = 2020,
                Bimestre = "2",
                Aluno = alunos,
                Materia = "Portugues",
                Nota = 2
            });
            desempenhos.Add(new Desempenho()
            {
                Ano = 2020,
                Bimestre = "2",
                Aluno = alunos,
                Materia = "Matematica",
                Nota = 4
            });

            contexto.Desempenho.AddRange(desempenhos);
            contexto.SaveChanges();
        }

        private static void ConsultarAluno()
        {
            //contexto.Database.Log = Console.WriteLine;
            contexto.Configuration.LazyLoadingEnabled = true;

            foreach (var aluno in contexto.Alunos.Include("Desempenho"))
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.CPF}");
                var anoLetivo = aluno.Desempenho.GroupBy(x => x.Ano)
                    .Select(grupo => grupo.First())
                    .OrderByDescending(x => x.Ano);

                foreach (var item in anoLetivo)
                {
                    Console.WriteLine(item.Ano);
                    Console.WriteLine("1º BIM \t\t 2º BIM");
                    var notas1 = aluno.Desempenho.Where(anoConsulta => anoConsulta.Ano == item.Ano)
                        .GroupBy(g => g.Materia).Select(x => new
                    {
                        Materia = x.Key,
                        PrimeiroB = x.Where(b => b.Bimestre == "1").FirstOrDefault(),
                        SegundoB = x.Where(b => b.Bimestre == "2").FirstOrDefault(),
                    });

                    foreach (var x in notas1)
                    {
                        var n1 = (x.PrimeiroB != null) ? x.PrimeiroB.Nota : 0;
                        var n2 = (x.PrimeiroB != null) ? x.PrimeiroB.Nota : 0;

                        Console.WriteLine($"{x.Materia} \t\t {x.PrimeiroB.Nota} \t {x.SegundoB.Nota}");
                    }
                }
            }
        }

        private static void CriarAluno(string cpf, string nome)
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
