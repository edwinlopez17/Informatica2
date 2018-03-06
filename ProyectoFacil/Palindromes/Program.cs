using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {




        static void Main(string[] args)
        {
            string Palabra1;
            string Palabra2;

            Console.WriteLine("Ingrese una palabra"); // Ingreso de las palabras a comparar
            Palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese una segunda palabra");
            Palabra2 = Console.ReadLine();

            char[] charArray = Palabra2.ToCharArray();
            Array.Reverse(charArray);
            string Resultado = new string(charArray);
            if (Palabra1.Equals(Resultado))
            {
                Console.WriteLine("Si, son palabras palindromes");
            }
            else { Console.WriteLine("No son palabras palindromes, SORRY BRU"); }
            Console.ReadLine();

        }
    }
}



