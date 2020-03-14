using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LAB07;
using LAB07.Model;

namespace LAB08
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlunoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlunoService.svc or AlunoService.svc.cs at the Solution Explorer and start debugging.
    public class AlunoService : IAlunoService
    {
        public void AddStudent(Aluno student)
        {
            var servicoAluno = new ServicoAluno();

            servicoAluno.CriarAluno(student.CPF, student.Nome);
        }

        public List<Aluno> GetAlunos(bool showPerformance)
        {
            var servicoAluno = new ServicoAluno();

            return servicoAluno.ConsultarAluno();
        }
    }
}
