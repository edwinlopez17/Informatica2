using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
   public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public QueHaceres Tareas { get; set; }


        ////////////////////////////////////////////////////////////////////////////////////
        public bool EstaDisponible()
        {
            if (Tareas.SiEstaDisponible())
            {
                return true;
            }
            return false;
        }


        // //////////////////////////////////////////////////////////////////////////////////////
        public void AgregarQueHacer(QueHacer QueHacer)
        {
            Tareas.AgregarTarea(QueHacer);
        }
        public void CompletarQueHacer()
        {
            Tareas.CompletarQueHacer();
        }
    }
}
