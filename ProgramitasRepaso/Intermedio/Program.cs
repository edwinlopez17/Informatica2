using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo1 = new int[] { 1, 3, 6, 7, 8 }; // PROGRAMA INTERMEDIO 
            int[] arreglo2 = new int[] { 0, 5 };

            int[] arregloFinal = new int[arreglo1.Length + arreglo2.Length]; // ARREGLO DE DOS ARREGLOS

            bool next = true;
            int arreglo1Index = 0;
            int arreglo2Index = 0;
            int arregloFinalIndex = 0;



            while (next)
            {
                if (arreglo1.Length == 0 || arreglo2.Length == 0)
                {
                    AddArreglo(arreglo1, arregloFinal, arregloFinalIndex);
                    AddArreglo(arreglo2, arregloFinal, arregloFinalIndex);
                    break;
                }
                if (arreglo1[arreglo1Index] < arreglo2[arreglo2Index])
                {
                    arregloFinal[arregloFinalIndex] = arreglo1[arreglo1Index];
                    arreglo1 = arreglo1.Where(val => val != arreglo1[arreglo1Index]).ToArray();
                    arregloFinalIndex++;
                }
                else
                {
                    arregloFinal[arregloFinalIndex] = arreglo2[arreglo2Index];
                    arreglo2 = arreglo2.Where(val => val != arreglo2[arreglo2Index]).ToArray();
                    arregloFinalIndex++;
                }
            }
            Console.WriteLine("Su arreglo es: ");

            for (int i = 0; i < arregloFinal.Length; i++)
            {
                
                Console.Write( arregloFinal[i]);
                
            }
            Console.ReadLine();
        }
        
            
            

               
            

    



        public static void AddArreglo(int[] arreglo, int[] arregloFinal, int start)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                arregloFinal[start] = arreglo[i];
                start++;




            }
        }
    }
}
