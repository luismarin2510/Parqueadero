using System.Collections.Generic;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Parqueadero.App.Persistencia
{
    public interface Irepositoriotransaccion
    {
        IEnumerable<Transaccion> GetAlltransaccion();
        Transaccion Addtransaccion(Transaccion transaccion);
        // Transaccion Updatetransaccion(Transaccion transaccion);
        void Deletetransaccion(int idtransaccion);
        Transaccion Gettransaccion(int idtransaccion);
        
    }
}