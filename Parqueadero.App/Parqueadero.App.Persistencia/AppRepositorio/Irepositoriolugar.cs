using System;
using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface Irepositoriolugar
    {
        IEnumerable<Lugar> GetAlllugar();
        Lugar Addlugar(Lugar lugar);
        // Lugar UpdateLugar(Lugar lugar);
        void Deletelugar(int idlugar);
        Lugar Getlugar(int idlugar);
    }
}