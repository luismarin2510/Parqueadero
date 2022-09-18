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
            // buscarPersona(3);
            // eliminar(4);
            

        }
        private static void AddPerson()
        {

            var pers = new Persona
            {

                nombre = "Jose Jose ",
                apellido = "Torres Hernandez",
                cedula = "119x3x8x5x",
                telefono = "30x80x37xx",
                email = "Jose@xmail.com",
                estacionamiento = "33",
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

        private static void eliminar(int idl)
        {
            _repoPersona.DeletePesona(idl);
            Console.WriteLine(" el susuaio" + idl +" ha sido eliminado exitosamente " );
            
        }

    }

}
