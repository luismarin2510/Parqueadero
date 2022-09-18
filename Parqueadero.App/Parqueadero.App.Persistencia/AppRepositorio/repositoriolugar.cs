using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;

namespace Parqueadero.App.Persistencia
{
    public class repositoriolugar : Irepositoriolugar
    {
        private readonly AppContext appcox; /// simplificacion de la directiva 
        public repositoriolugar(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
// -------------------------llama todos los lugares ------------------------------------
        IEnumerable<Lugar> Irepositoriolugar.GetAlllugar()
        {
            return appcox.lugares;
        }
// --------------------------- agregar un nuevo lugar----------------------------------------------
        Lugar Irepositoriolugar.Addlugar(Parqueadero.App.Dominio.Lugar lugar)
        {
            var agregarlugar = appcox.lugares.Add(lugar);
            appcox.SaveChanges();
            return agregarlugar.Entity;
        }
//-------------------------- eliminar----------------------------------------
        void Irepositoriolugar.Deletelugar(int idlugar)
        {  //// busca lo primero o por defecto a vehiculo => por el id que sea igual al ide del lugar  
            var encontrarlugar = appcox.lugares.FirstOrDefault(p => p.Id == idlugar);
            if (encontrarlugar == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.lugares.Remove(encontrarlugar);
            appcox.SaveChanges();
        }
//  ----------- llama lugar manera individual ------------------------------
        Lugar Irepositoriolugar.Getlugar(int idlugar)
        {
            return appcox.lugares.FirstOrDefault(p => p.Id == idlugar);
        }
// ----------------------------------------------------------------------------------------
        
    }
}