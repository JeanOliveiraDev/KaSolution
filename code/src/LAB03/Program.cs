using LAB03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LAB03
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Listas();
            //Filas();
            //Dicionario();
            Eventos();

            Console.ReadKey();
        }

        private static void Eventos()
        {
            Radar radarSP = new Radar(false, "Av. dos Bandeirantes, 655", 50);

            radarSP.EventoGerarMulta += RadarSP_EventoGerarMulta;

            while (true)
            {
                Random placa = new Random();
                Random velocidade = new Random();
                string placaCarro = $"AAA-{placa.Next(0, 9999).ToString().PadLeft(4,'0')}"; 

                int velocidadeCarro = velocidade.Next(30, 60);

                if (!radarSP.ValidarVelocidade(velocidadeCarro, placaCarro, radarSP.Via))
                {
                    Console.WriteLine($"{placaCarro} - {velocidadeCarro}");
                }                               

                Thread.Sleep(2000);
            }
        }

        private static void RadarSP_EventoGerarMulta(string placa, int velocidade, string via)
        {
            Console.WriteLine($"$Multa SP {velocidade} + {placa} + {via}");
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
            nova.Nome = "Bruno Gomes";
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
