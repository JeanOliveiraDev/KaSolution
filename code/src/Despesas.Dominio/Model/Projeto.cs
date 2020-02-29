﻿using System;
using System.Collections.Generic;

namespace Despesas.Dominio
{
    public class Projeto : BaseEntity
    {
        public Cliente Cliente { get; set; }
        public List<Politica> Politicas { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Consultor Responsavel { get; set; }
        public string Descricao { get; set; }
    }
}