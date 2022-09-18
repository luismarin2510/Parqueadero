using System;
using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface IrepositorioPorhoras
    {
         
        IEnumerable<Porhoras> GetAllporhoras();
        Porhoras Addporhoras(Porhoras horas);
        // Porhoras Updateporhoras(Porhoras horas);
        void Deleteporhoras(int idPorhoras);
        // Porhoras Getporhoras(int idPorhoras);

    }
}