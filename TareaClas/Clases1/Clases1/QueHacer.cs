using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
    public enum Estado
    {
        EnProgreso,
        Terminado
    }

    public class QueHacer
    {
        public DateTime Hora { get; set; }
        public String Lugar { get; set; }
        public string Descripcion { get; set; }
        public Estado Estado { get; private set; }

        public QueHacer(DateTime hora, string lugar, string descripcion)
        {
            this.Hora = hora;
            this.Lugar = lugar;
            this.Descripcion = descripcion;
            this.Estado = new Estado();
            this.Estado = Estado.EnProgreso;
        }

        public void Completar()
        {
            this.Estado = Estado.Terminado;
        }

    }
}
