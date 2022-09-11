using System;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;
namespace Parqueadero.App.Consola
{
    class program
    {
        private static IRepositorio _repoPersona =  new Repositorio(new Parqueadero.App.Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // AddPerson();
            buscarPersona(3);

        }
        private static void AddPerson()
        {

            var pers = new Persona
            {

                nombre = "Pedro ",
                apellido = "Gomez Hernandez",
                cedula = "109x3x8x5x",
                telefono = "31x86x67xx",
                email = "pedro@xmail.com",
                estacionamiento = "3",
                numero_vehiculos = "1",
                horario = DateTime.Now

            };
            _repoPersona.AddPersona(pers);
            ////////////////////////////////////////////////////////////

        }
        private static void buscarPersona(int idp)
        {
            var person = _repoPersona.GetPersona(idp);

            if (person != null)
            {
                Console.WriteLine("nombre: " + person.nombre + " " + person.apellido + "\nTelefono: " + person.telefono + "\nEstacionamiento: " + person.estacionamiento
                +" "+"\nhorario de ingreso: "+person.horario);
            }
        }

    }

}
