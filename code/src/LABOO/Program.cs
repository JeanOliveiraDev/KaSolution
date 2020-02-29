using LABOO.Model;
using System;

namespace LABOO
{
    class Program
    {
        static Cafe cafe;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Herança
            cafe = new CafeExpresso();
            Console.WriteLine(cafe.ModoDeServir());            

            cafe = new CafeCaseiro();
            Console.WriteLine(cafe.ModoDeServir());

            Console.ReadKey();

            //Polimorfismo
            //Encapsulamento
            //Sobrecarga     -- OK                        
        }
    }
}
