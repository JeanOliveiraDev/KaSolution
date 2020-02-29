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
            /*int num, num2; 
            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {num + num2}");*/
            #endregion

            #region Regex
            /*string rResultado = "tresdasda{12316a} tesasdas a{222222}asdasdasd";
            MatchCollection regex = Regex.Matches(rResultado, @"\{(\w)*\}");
            Console.WriteLine($"{regex[0]} - {regex[1]}");*/
            #endregion

            Console.ReadKey();
        }
    }
}
