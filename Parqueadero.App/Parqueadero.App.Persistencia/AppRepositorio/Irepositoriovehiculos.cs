using System;
using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface Irepositoriovehiculos
    {
        IEnumerable<Vehiculo> GetAllvehiculo();
        Vehiculo Addporhoras(Vehiculo vehiculo);
        // Vehiculo Updateporhoras(Vehiculo horas);
        void Deleteporhoras(int idvehiculo);
        Vehiculo Getporhoras(int idvehiculo);
    }
}