using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
   public class QueHaceres
    {
        public List<QueHacer> ListadoTareas { get; set; }

        public QueHaceres()
        {
            ListadoTareas = new List<QueHacer>();
        }
        public void AgregarTarea(QueHacer QueHacer)
        {
            ListadoTareas.Add(QueHacer);
        }
        public void CompletarQueHacer()
        {
            for (int i = 0; i < ListadoTareas.Count; i++)
            {
                if (ListadoTareas[i].Estado == Estado.EnProgreso)
                {
                    ListadoTareas[i].Completar();
                    break;
                }
            }
        }
        public bool SiEstaDisponible()
        {
            for (int i = 0; i < ListadoTareas.Count; i++)
            {
                if (ListadoTareas[i].Estado == Estado.EnProgreso)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
