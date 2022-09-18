using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;

namespace Parqueadero.App.Persistencia
{
    public class repositoriovehiculos : Irepositoriovehiculos
    {
        private readonly AppContext appcox; /// simplificacion de la directiva 
        public repositoriovehiculos(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
// -------------------------llamr todos los vehiculos ------------------------------------
        IEnumerable<Porhoras> Irepositoriovehiculos.GetAllvehiculo()
        {
            return appcox.vehiculo;
        }
// --------------------------- agregar vehiculo----------------------------------------------
        Vehiculo Irepositoriovehiculos.Addvehiculo(Parqueadero.App.Dominio.Vehiculo vehiculo)
        {
            var agregarvehiculo = appcox.vehiculo.Add(vehiculo);
            appcox.SaveChanges();
            return agregarvehiculo.Entity;
        }
//-------------------------- eliminar----------------------------------------
        void Irepositoriovehiculos.Deletevehiculo(int idvehiculo)
        {  //// busca lo primero o por defecto a vehiculo => por el id que sea igual al ide del vehiculo  
            var encontrarvehiculo = appcox.vehiculo.FirstOrDefault(p => p.Id == idvehiculo);
            if (encontrarvehiculo == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.vehiculo.Remove(encontrarvehiculo);
            appcox.SaveChanges();
        }
//  ----------- captura de vehiculo de manera individual ------------------------------
        Vehiculo Irepositoriovehiculos.GetVehiculo(int idvehiculo)
        {
            return appcox.vehiculo.FirstOrDefault(p => p.Id == idvehiculo);
        }
// ----------------------------------------------------------------------------------------


    }
}