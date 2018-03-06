using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFacil2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igrese un número para Factorizar:");  //INGRESO DE NUMERO A FACTORIZAR
            
            string input = Console.ReadLine();

            while (!String.IsNullOrEmpty(input))


            {
                int value;
                List<int> NumeroFactorizado; ;

                if (int.TryParse(input, out value) && value > 0)
                {
                    NumeroFactorizado = FactoresPrimos(int.Parse(input));
                    Console.WriteLine(String.Join(",", NumeroFactorizado));
                }
                else    /////////////////////////////CUANDO ES 0 EL NUMERO
                    Console.WriteLine("Ingrese un número de tipo entero y mayor que 0.");

                input = Console.ReadLine();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////
        private static List<int> FactoresPrimos(int p)
        {
            List<int> Factores = new List<int>();   //OPERACIÒN DE FACTORIZACIÓN
            if (p == 1)
                Factores.Add(p);
            else
            {
                while (p > 1)
                {
                    int div = 2;

                    while (p % div != 0)
                        div++;

                    p = p / div;
                    Factores.Add(div);
                }
            }

            return Factores;

        }
    }
}
