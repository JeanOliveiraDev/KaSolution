using LAB07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LAB08
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlunoService" in both code and config file together.
    [ServiceContract]
    public interface IAlunoService
    {
        [OperationContract(IsOneWay = true)]
        void AddStudent(Aluno student);

        [OperationContract]
        List<Aluno> GetAlunos(bool showPerformance);
    }
}
