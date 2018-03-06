using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramas
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1;
            string p2;

            Console.WriteLine("ingrese una palabra");
            p1 = Console.ReadLine();
            Console.WriteLine("ingrese una segunda palabra");
            p2 = Console.ReadLine();

            char[] charArray = p2.ToCharArray();
            Array.Reverse(charArray);
            string p3 = new string(charArray);
            if (p1.Equals(p3))
            {
                Console.WriteLine("son palindromes");
            }
            else { Console.WriteLine("no son palindromes"); }
            Console.ReadLine();


        }
    }
}
