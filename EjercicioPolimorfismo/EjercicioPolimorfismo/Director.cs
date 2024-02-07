using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Director : Persona
    {
        public Director() { }

        public virtual void verDetalles()
        {
            base.verDetalles();
        }
    }
}
