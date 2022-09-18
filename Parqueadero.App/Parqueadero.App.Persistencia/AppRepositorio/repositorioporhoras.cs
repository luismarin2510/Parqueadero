using System.Collections.Generic;
using System.Linq;
using Parqueadero.App.Dominio;

namespace Parqueadero.App.Persistencia
{
    public class repositorioporhoras : IrepositorioPorhoras
    {
        private readonly AppContext appcox; /// simplificacion de la directiva 
        public repositorioporhoras(AppContext appContext)
        {
            appcox = appContext;  /// asignacion de la directiva 
        }
        // --------capturar todas las horas
        IEnumerable<Porhoras> IrepositorioPorhoras.GetAllporhoras()
        {
            return appcox.porhorass;
        }
// --------------- agregar horas---------------------------
        Porhoras IrepositorioPorhoras.Addporhoras(Parqueadero.App.Dominio.Porhoras horas)
        {
            var agregarhora = appcox.porhorass.Add(horas);
            appcox.SaveChanges();
            return agregarhora.Entity;
        }
        //----------------- eliminar----------------------------------------
        void IrepositorioPorhoras.Deleteporhoras(int idPorhoras)
        {  //// busca lo primero o por defecto a persona => por persona id que sea igual al ide de la persona 
            var encontrarhora = appcox.porhorass.FirstOrDefault(p => p.Id == idPorhoras);
            if (encontrarhora == null)
            {  //// -------   si lo que encontro es nulo que lo retorne
                return;
            }
            appcox.porhorass.Remove(encontrarhora);
            appcox.SaveChanges();
        }

        
    }

}