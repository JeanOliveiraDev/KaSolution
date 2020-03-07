using System;
using System.IO;

namespace LAB06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Uso do Path
                Criar pastas
                Criar Arquivo
                Escrever Arquivo
                Ler Arquivo
            */
            string arquivo = CriarArquivo();
            EscreverArquivo(arquivo);
            LerArquivo(arquivo);
            Console.ReadKey();
        }

        private static void LerArquivo(string arquivo)
        {
            using (StreamReader reader = new StreamReader(arquivo))
            {
                //string texto = reader.ReadToEnd();

                while (reader.Peek() >= 0)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }

        private static void EscreverArquivo(string arquivo)
        {
            using (StreamWriter streamWriter = new StreamWriter(arquivo, true))
            {
                streamWriter.WriteLine($"{DateTime.Now} - Olá Mundo!");
                streamWriter.WriteLine($"{DateTime.Now} - Hello Word!");
            }
        }

        private static string CriarArquivo()
        {
            string caminho = Path.GetTempPath();
            string dir = $@"{caminho}\\NotaFiscal";
            string arquivo = $@"{dir}\\{DateTime.Now.ToString("ddMMyyyy")}.txt";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                if (!File.Exists(arquivo))
                {
                    File.Create(arquivo);
                }
            }

            return arquivo;
        }
    }
}
