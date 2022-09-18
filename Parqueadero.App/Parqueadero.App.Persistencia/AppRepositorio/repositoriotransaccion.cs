using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;

namespace Parqueadero.App.Persistencia
{
    public class repositoriotransaccion :Irepositoriotransaccion
    {
        private readonly AppContext appcox; /// simplificacion de la directiva 
        public repositoriotransaccion(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
// -------------------------llamar transaccion ------------------------------------
        IEnumerable<Transaccion> Irepositoriotransaccion.GetAlltransaccion()
        {
            return appcox.transacciones;
        }
// --------------------------- agregar transaccion----------------------------------------------
        Transaccion Irepositoriotransaccion.Addtransaccion(Parqueadero.App.Dominio.Transaccion transaccion)
        {
            var agregartransaccion = appcox.transacciones.Add(transaccion);
            appcox.SaveChanges();
            return agregartransaccion.Entity;
        }
//-------------------------- eliminar----------------------------------------
        void Irepositoriotransaccion.Deletetransaccion(int idtransaccion)
        {  //// busca lo primero o por defecto a vehiculo => por el id que sea igual al ide del transaccion  
            var buscartransaccion = appcox.transacciones.FirstOrDefault(p => p.Id == idtransaccion);
            if (buscartransaccion == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.transacciones.Remove(buscartransaccion);
            appcox.SaveChanges();
        }
//  ----------- buscar transaccion de manera individual ------------------------------
        Transaccion Irepositoriotransaccion.Gettransaccion(int idtransaccion)
        {
            return appcox.transacciones.FirstOrDefault(p => p.Id == idtransaccion);
        }
// ----------------------------------------------------------------------------------------
    }
}