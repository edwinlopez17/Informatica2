using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Program
    {
        public static int Heap;

        static void Main(string[] args)
        {
        }

        
        public static void Heapify(int[] A)
        {
            Heap = A.Length - 1;

            for (int i = floop(A.Length); i >= 0; i--)
            {
                ShiftDown(A, i);
            }

        }

        public static void ShiftDown(int[] A, int i)
        {

            int izq = Izquierdo(i);
            int der = Derecho(i);

            int index = 0;

            // Check to see which node in the tree subset has the largest value
            if (izq <= Heap && A[izq] > A[i])
            {
                index = izq;
            }
            else
            {
                index = i;
            }
            if (der <= Heap && A[der] > A[index])
            {
                index = der;
            }

            // Do not make any switches if the largest node is the parent
            if (index != i)
            {
                int temp = A[index];
                A[index] = A[i];
                A[i] = temp;
                ShiftDown(A, index);
            }

        }

        private static int floop(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        private static int Izquierdo(int currentIndex)
        {
            return currentIndex * 2 + 2;
        }

        private static int Derecho(int currentIndex)
        {
            return currentIndex * 2 + 1;
        }

    }
}