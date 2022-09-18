using System;
using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface Irepositoriotiempocompleto
    {
        IEnumerable<Tiempocompleto> GetAlltiempocompleto();
        Tiempocompleto Addtiempocompleto(Tiempocompleto tiempocompleto);
        // Tiempocompleto Updatetiempocompleto(Tiempocompleto tiempocompleto);
        void Deletetiempocompleto(int idtiempocompleto);
        Tiempocompleto Gettiempocompleto(int idtiempocompleto);
    }
}