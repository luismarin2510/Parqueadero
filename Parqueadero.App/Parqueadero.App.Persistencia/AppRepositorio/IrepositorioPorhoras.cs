using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parqueadero.App.Persistencia.AppRepositorio
{
    public interface IrepositorioPorhoras
    {
         
        IEnumerable<Porhoras> GetAllPorhoras();
        Porhoras AddPorhoras(Porhoras horas);
        Porhoras UpdatePersona(Porhoras horas);
        void DeletePorhoras(int idPorhoras);
        Porhoras GetPorhoras(int idPorhoras);

    }
}