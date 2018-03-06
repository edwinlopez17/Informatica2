using System;
using System.Collections.Generic;
using System.Text;

namespace Genericos
{
   public class Genericos
    {
        public Genericos() { }
        
        public T Head<T>(T[] lista)
        {
            return lista[0];
        }

        
        public T[] Tail<T>(T[] lista)
        {                                                 //Constructor de T
            T[] ListaNueva = new T[lista.Length - 1];   //Se asigna a ListaNueva el contenido de T
            int comodin = 0;

            for (int i = 1; i < lista.Length; i++)
            {
                ListaNueva[comodin] = lista[i];
                comodin += 1;
            }
            return ListaNueva;
        }

       //////////////////////////////////////////////////////////////////////////////////////////
        public Tupla<T1, T2>[] Zip<T1, T2>(T1[] listaA, T2[] listaB)
        {
            Tupla<T1, T2>[] arreglo = new Tupla<T1, T2>[Longitud<T1, T2>(listaA, listaB)];

            
            for (int i = 0; i < arreglo.Length; i++)  //Valores del arreglo
            {
                arreglo[i] = new Tupla<T1, T2>(listaA[i], listaB[i]); 
            }
            return arreglo;     // retorno de tuplas
        }

      ////////////////////////////////////////////////////////////////////////////////
        private int Longitud<T1, T2>(T1[] valorA, T2[] valorB)
        {
            int longitud = 0;
            if (valorA.Length == valorB.Length)   //Longitud del arreglo tuplas
            {
                longitud = valorA.Length;
            }
            else if (valorA.Length > valorB.Length)
            {
                longitud = valorB.Length;
            }
            else if (valorA.Length < valorB.Length)
            {
                longitud = valorA.Length;
            }
            return longitud;     
        }
    }
}
