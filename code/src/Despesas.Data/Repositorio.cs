using Despesas.Data.Interface;
using Despesas.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas.Data
{
    public class Repositorio<T> : IRepositorioGenerico<T> where T : BaseEntity
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
