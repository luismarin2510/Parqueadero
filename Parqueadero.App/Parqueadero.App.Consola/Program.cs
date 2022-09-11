using System;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;
namespace Parqueadero.App.Consola
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
        private static void AddPerson()
        {

            var pers = new Persona
            {

                nombre = "Luis Eduardo",
                apellido = "Marin Velasco",
                cedula = "109x3x81xx",
                telefono = "31x75x25xx",
                email = "opraedu@gmail.com",
                estacionamiento = "2",
                numero_vehiculos = "1"

            };
            _repoPersona.AddPersona(pers);
            ////////////////////////////////////////////////////////////

        }
        private static void buscarPersona(int idp)
        {
            var person = _repoPersona.GetPersona(idp);

            if (person != null)
            {
                Console.WriteLine("nombre: " + person.nombre + " " + person.apellido + "\n telefono: " + person.telefono + "\n Estacionamiento: " + person.estacionamiento);
            }
        }

    }

}
