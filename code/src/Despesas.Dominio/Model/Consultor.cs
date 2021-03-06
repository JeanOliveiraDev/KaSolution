﻿using System.Collections.Generic;

namespace Despesas.Dominio
{
    public class Consultor : BaseEntity
    {
        public string Nome { get; set; }
        public List<Projeto> Projetos { get; set; }
        public string Email { get; set; }
        public int Registro { get; set; }
    }
}