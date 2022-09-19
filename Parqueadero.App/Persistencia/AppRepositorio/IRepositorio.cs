using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia.AppRepositorio
{
    public interface IRepositorio
    {
        IEnumerable<Saludar> GetAll();
// metodo abstracto ... le digo que debo hacer 
        Saludar GetSaludoId(int IdSaludo);
        Saludar Update(Saludar saludoActualizado);
    }
}