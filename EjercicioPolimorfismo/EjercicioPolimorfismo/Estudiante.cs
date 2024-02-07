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

        public Estudiante(string nombres, string apellidos)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }

        public virtual void verDetalles()
        {
            base.verDetalles();
        }
    }
}
