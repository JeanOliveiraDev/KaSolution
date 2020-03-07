using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Filas();  
            Console.ReadKey();
        }

        private static void Filas()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Jean");
            fila.Enqueue("Bruno");
            fila.Enqueue("Joao");

            Queue<string> processo = new Queue<string>(fila.ToArray());

            foreach (var item in processo)
            {
                Console.WriteLine(item);
                if (item == "Bruno")
                {
                    fila.Peek(); // Passa para o próximo                    
                }
                else
                    fila.Dequeue();
            }
        }

        public static void Dicionario()
        {
            Dictionary<int, string> pessoas = new Dictionary<int, string>();

            pessoas.Add(26, "Jean");
            pessoas.Add(32, "Bruno");

            //Console.WriteLine(pessoas[32]);

            foreach (var item in pessoas)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void Listas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa nova = new Pessoa();
            nova.Nome = "Jean Oliveira";
            nova.Idade = 26;
            pessoas.Add(nova);

            nova = new Pessoa();
            nova.Nome = "Bruno Viado";
            nova.Idade = 32;
            pessoas.Add(nova);

            Console.WriteLine(pessoas.Sum(x => x.Idade));

            foreach (Pessoa item in pessoas)
            {
                Console.WriteLine(item.Nome);
            }            

            //Filtro do primeiro com a menor idade
            Pessoa pessoaMaisNova = (from A in pessoas
                                     orderby A.Idade descending
                                     select A).First();            

            //Filtro para trazer pessoas com a letra A
            List<Pessoa> comLetraA = (from A in pessoas
                                      where A.Nome.ToUpper().Contains("A")
                                      select A).ToList();

            List<Pessoa> comLamda = pessoas.Where(x => x.Nome.ToUpper().Contains("A")).ToList();

            pessoas.Remove(pessoaMaisNova);
        }
    }
}
