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
            AddPerson();

        }
        private static void AddPerson()
        {

            var pers = new Persona
            {

                nombre = "Juan Carlos",
                apellido = "Mora Lizcano",
                cedula = "1x973x8xxx",
                telefono = "31x54x15xx",
                email = "opraedu@gmail.com",
                estacionamiento = "1",
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
