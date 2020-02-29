using System;
using System.Text;

namespace LAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MetodoErro();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        private static void MetodoErro()
        {
            int num1 = 10, num2 = 0;
            StringBuilder builder;

            try
            {
                builder = new StringBuilder();
                int result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                builder = null;
            }
        }
    }
}
