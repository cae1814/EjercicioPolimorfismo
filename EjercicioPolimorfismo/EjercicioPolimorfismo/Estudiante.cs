using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Estudiante : Persona
    {
        public Estudiante() { }

        public virtual void verDetalles()
        {
            base.verDetalles();
        }
    }
}
