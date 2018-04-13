using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    public abstract class LineaAbstracta<T> : ILinea<T>
    {
        public abstract T[] Puntos { get; }

        public double Longitud()
        {
            if (Puntos.Length == 0)
                return 0;

            double longitud = 0;
            for (int i = 0; i < Puntos.Length - 1; i++)
            {
                longitud += Distancia(Puntos[i], Puntos[i + 1]);
            }
            return longitud;
        }

        public T PuntoMasCercano(T punto)
        {
            T cercano = Puntos[0];

            for (int i = 0; i < Puntos.Length; i++)
            {
                if (Distancia(punto, Puntos[i]) < Distancia(punto, cercano))
                    cercano = Puntos[i];
            }
            return cercano;
        }

        public abstract double Distancia(T punto1, T punto2);
    }
}
