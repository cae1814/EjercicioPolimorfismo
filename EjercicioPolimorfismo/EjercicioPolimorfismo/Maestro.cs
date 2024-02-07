using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Maestro : Persona
    {
        public Maestro() { }

        public virtual void verDetalles()
        {
            base.verDetalles();
        }
    }
}
