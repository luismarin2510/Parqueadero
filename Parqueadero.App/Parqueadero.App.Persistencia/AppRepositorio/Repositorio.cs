using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;

namespace Parqueadero.App.Persistencia
{
    public class Repositorio : IRepositorio
    {
        private readonly AppContext appcox; /// simplificacion de la directiva 
        public Repositorio(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
// -------------------- adicionar perona ---------------------------------------
        Persona IRepositorio.AddPersona(Parqueadero.App.Dominio.Persona perso)
        {
            var agregarpersona = appcox.personas.Add(perso);
            appcox.SaveChanges();
            return agregarpersona.Entity;
        }

        //----------------- eliminar----------------------------------------
        void IRepositorio.DeletePesona(int idPersona)
        {  //// busca lo primero o por defecto a persona => por persona id que sea igual al ide de la persona 
            var encontrarPersona = appcox.personas.FirstOrDefault(p => p.Id == idPersona);
            if (encontrarPersona == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.personas.Remove(encontrarPersona);
            appcox.SaveChanges();
        }

        // ---------------Llamar todos los datos de l tabla ------------------------------

        IEnumerable<Persona> IRepositorio.GetAllPersona()
        {
            return appcox.personas;
        }
        // ---------------Llamar a una sola persona en especifico-------------------------

        Persona IRepositorio.GetPersona(int idPersona)
        {
            return appcox.personas.FirstOrDefault(p => p.Id == idPersona);
        }
        //--------------------- nuevo cliente -------------------------------------------
        Persona IRepositorio.UpdatePersona(Parqueadero.App.Dominio.Persona perso)
        {
            var PersonaEncontrada = appcox.personas.FirstOrDefault(p => p.Id == perso.Id);

            if (PersonaEncontrada != null)
            {   /// se agregan todas las variables de  la clase persona en dominio/entidades 
                PersonaEncontrada.nombre = perso.nombre;
                PersonaEncontrada.apellido = perso.apellido;
                PersonaEncontrada.cedula = perso.cedula;
                PersonaEncontrada.telefono = perso.telefono;
                PersonaEncontrada.email = perso.email;
                PersonaEncontrada.horario = perso.horario;
                PersonaEncontrada.estacionamiento = perso.estacionamiento;
                PersonaEncontrada.numero_vehiculos = perso.numero_vehiculos;

                appcox.SaveChanges();
            }
            return PersonaEncontrada; // retorna por fuera del if para que null se pueda ejecutar 
        }

    }

}