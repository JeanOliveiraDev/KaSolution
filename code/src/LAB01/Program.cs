using System;
using System.Text.RegularExpressions;

namespace LAB01
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");

            #region Concatenação           
            string resultado;
            var data = DateTime.Now;

            resultado = "A" + "B";
            resultado = string.Concat("A","B","C","D");
            resultado = string.Format("Olá: {0}","Jean");
            resultado = $"Hora: {data.ToString("dd/MM/yyyy HH:mm")}";

            Console.WriteLine(resultado);
            #endregion

            #region Operadores   
            /*int num1, num2, num3;            

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num1);            

            Console.WriteLine("Digite outro número");            
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine(RealizarSoma(ref num1, ref num2));*/
            #endregion

            #region Regex
            /*string rResultado = "tresdasda{12316a} tesasdas a{222222}asdasdasd";
            MatchCollection regex = Regex.Matches(rResultado, @"\{(\w)*\}");
            Console.WriteLine($"{regex[0]} - {regex[1]}");*/
            #endregion

            Console.ReadKey();
        }

        #region RealizarSoma
        static void RealizarSomaOut(ref int num1, ref int num2, out int soma)
        {
            soma = num1 + num2;
        }

        static int RealizarSoma(ref int num1, ref int num2)
        {
            var soma = num1 + num2;
            return soma;
        }

        static int RealizarSoma(ref int num1, ref int num2, ref int num3, string msg = null)
        {
            var soma = RealizarSoma(ref num1, ref num2) + num3;
            return soma;
        }
        #endregion        
    }
}
