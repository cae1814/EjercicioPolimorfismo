
using EjercicioPolimorfismo;
using System.Drawing;

List<Persona> lista = new List<Persona>();

Persona per = new Director();
per.Nombres = "Juan Carlos";
per.Apellidos = "Zepeda Galo";
per.Dni = "0801198055441";
per.Sexo = "Masculino";
per.tipoPersona = "Director";
per.FechaNacimiento = "01/01/1980";
per.Edad = 44;

lista.Add(per);

Maestro mae = new Maestro("Rene Francisco", "Ruiz Pineda");
mae.Dni = "0801199405522";
mae.Sexo = "Masculino";
mae.tipoPersona = "Maestro";
mae.FechaNacimiento = "01/02/1994";
mae.Edad = 30;

lista.Add(mae);

Estudiante est = new Estudiante();
est.Nombres = "Jose Roberto";
est.Apellidos = "Perez Muñoz";
est.Dni = "0801200033669";
est.Sexo = "Masculino";
est.tipoPersona = "Alumno";
est.FechaNacimiento = "01/03/2000";
est.Edad = 24;

lista.Add(est);

foreach (Persona persona in lista)
{
    persona.verDetalles();
}

Console.WriteLine();
Console.WriteLine("Resumen rapido....");
Console.WriteLine();

foreach (Persona persona in lista)
{
    persona.resumen();
}