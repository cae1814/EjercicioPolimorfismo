
using EjercicioPolimorfismo;
using System.Drawing;

Director dir = new Director();
dir.Nombres = "Juan Carlos";
dir.Apellidos = "Zepeda Galo";
dir.Dni = "0801198055441";
dir.Sexo = "Masculino";
dir.tipoPersona = "Director";
dir.FechaNacimiento = "01/01/1980";
dir.Edad = 44;

Maestro mae = new Maestro();
mae.Nombres = "Rene Francisco";
mae.Apellidos = "Ruiz Pineda";
mae.Dni = "0801199405522";
mae.Sexo = "Masculino";
mae.tipoPersona = "Maestro";
mae.FechaNacimiento = "01/02/1994";
mae.Edad = 30;

Estudiante est = new Estudiante();
est.Nombres = "Jose Roberto";
est.Apellidos = "Perez Muñoz";
est.Dni = "0801200033669";
est.Sexo = "Masculino";
est.tipoPersona = "Alumno";
est.FechaNacimiento = "01/03/2000";
est.Edad = 24;

var personas = new List<Persona>
{
    dir,mae,est
};

foreach (var persona in personas)
{
    persona.verDetalles();
}