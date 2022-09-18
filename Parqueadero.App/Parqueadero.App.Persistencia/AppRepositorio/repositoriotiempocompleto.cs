using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;


namespace Parqueadero.App.Persistencia
{
    public class repositoriotiempocompleto : Irepositoriotiempocompleto
    {
         private readonly AppContext appcox; /// simplificacion de la directiva 
        public repositoriotiempocompleto(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
// -------------------------llama todos los tiempocompletoss ------------------------------------
        IEnumerable<Tiempocompleto> Irepositoriotiempocompleto.GetAlltiempocompleto()
        {
            return appcox.tiempocompletoss;
        }
// --------------------------- agregar un nuevo Tiempocompleto----------------------------------------------
        Tiempocompleto Irepositoriotiempocompleto.Addtiempocompleto(Parqueadero.App.Dominio.Tiempocompleto tiempocompleto)
        {
            var agregartiempocompleto = appcox.tiempocompletoss.Add(tiempocompleto);
            appcox.SaveChanges();
            return agregartiempocompleto.Entity;
        }
//-------------------------- eliminar----------------------------------------
        void Irepositoriotiempocompleto.Deletetiempocompleto(int idtiempocompleto)
        {  //// busca lo primero o por defecto a vehiculo => por el id que sea igual al ide del Tiempocompleto  
            var encontrartiempocompleto = appcox.tiempocompletoss.FirstOrDefault(p => p.Id == idtiempocompleto);
            if (encontrartiempocompleto == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.tiempocompletoss.Remove(encontrartiempocompleto);
            appcox.SaveChanges();
        }
//  ----------- llama Tiempocompleto manera individual ------------------------------
        Tiempocompleto Irepositoriotiempocompleto.Gettiempocompleto(int idtiempocompleto)
        {
            return appcox.tiempocompletoss.FirstOrDefault(p => p.Id == idtiempocompleto);
        }
// ----------------------------------------------------------------------------------------
        
    }
}