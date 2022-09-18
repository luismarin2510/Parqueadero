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
        Vehiculo Addvehculo(Vehiculo vehiculo);
        // Vehiculo Updatevehiculo(Vehiculo vehiculo);
        void Deletevehiculo(int idvehiculo);
        Vehiculo GetVehiculo(int idvehiculo);
    }
}