using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    public static class Extensao
    {
        public static string TomaUmaString(this string recebe)
        {
            Console.WriteLine(recebe);
            return recebe.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
        }
    }
}
