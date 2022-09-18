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
        IEnumerable<Vehiculo> Irepositoriovehiculos.GetAllvehiculo()
        {
            return appcox.vehiculoss;
        }
// --------------------------- agregar vehiculo----------------------------------------------
        Vehiculo Irepositoriovehiculos.Addvehculo(Parqueadero.App.Dominio.Vehiculo vehiculo)
        {
            var agregarvehiculo = appcox.vehiculoss.Add(vehiculo);
            appcox.SaveChanges();
            return agregarvehiculo.Entity;
        }
//-------------------------- eliminar----------------------------------------
        void Irepositoriovehiculos.Deletevehiculo(int idvehiculo)
        {  //// busca lo primero o por defecto a vehiculo => por el id que sea igual al ide del vehiculo  
            var encontrarvehiculo = appcox.vehiculoss.FirstOrDefault(p => p.Id == idvehiculo);
            if (encontrarvehiculo == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.vehiculoss.Remove(encontrarvehiculo);
            appcox.SaveChanges();
        }
//  ----------- captura de vehiculo de manera individual ------------------------------
        Vehiculo Irepositoriovehiculos.GetVehiculo(int idvehiculo)
        {
            return appcox.vehiculoss.FirstOrDefault(p => p.Id == idvehiculo);
        }
// ----------------------------------------------------------------------------------------


    }
}