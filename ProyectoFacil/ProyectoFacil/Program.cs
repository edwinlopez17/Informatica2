using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFacil
{
    class Program
    {
        static void Main(string[] args)
        {

            String Invertir="";    
            Console.WriteLine("Ingrese lo que desea Invertir");

             String Palabra = Console.ReadLine();

            int Largo = Palabra.Length;
            for(int i=Largo-1;i>=0;i--)

            {
            Invertir=Invertir+Palabra.Substring(i, 1);
             }

            Console.WriteLine(Invertir);               
            Console.ReadLine();




        }
    }
}
