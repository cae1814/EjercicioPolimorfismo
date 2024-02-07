using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Persona
    {
        public string tipoPersona {  get; set; }
        public string Nombres {  get; set; }
        public string Apellidos { get; set; }
        public int Edad {  get; set; }
        public string Dni {  get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo {  get; set; }

        public virtual void verDetalles() {
            Console.WriteLine("************ Detalles ************");
            Console.WriteLine("Tipo: " + tipoPersona);
            Console.WriteLine("Nombre completo: "+Nombres+" "+Apellidos);
            Console.WriteLine("Fecha nacimiento: " + FechaNacimiento + ", edad: " + Edad);
            Console.WriteLine("DNI: " + Dni + ", Sexo: " + Sexo);
            Console.WriteLine("**********************************");
            Console.WriteLine("");
        }



    }
}
