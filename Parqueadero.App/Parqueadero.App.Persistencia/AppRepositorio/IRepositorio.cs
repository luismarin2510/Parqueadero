using System.Collections.Generic;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface IRepositorio
    {

        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona perso);
        Persona UpdatePersona(Persona perso);
        void DeletePesona(int idPersona);
        Persona GetPersona(int idPersona);



    }
}