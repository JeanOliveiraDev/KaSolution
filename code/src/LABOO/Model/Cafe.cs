using System;
using System.Collections.Generic;
using System.Text;

namespace LABOO.Model
{
    /*
     * Modificadores
        Class - Internal / Public
        Classes abstradas: só podem ser herdadas e nunca instanciadas
    */

    public abstract class Cafe
    {
        //Caracteristicas
        public string Tipo { get; set; }
        public int Intensidade { get; set; }
        public string Origem { get; set; }

        //Comportamentos
        public string Temperatura(int graus)
        {
            return $"{graus}º";
        }

        public virtual string ModoPreparo()
        {
            return "Filtro de Papel";
        }

        public abstract string ModoDeServir();        
    }
}
