using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia.AppRepositorio
{
    public class Repositorio : IRepositorio
    {
        List<Saludar> saludos;

        public Repositorio()
        {
            saludos = new List<Saludar>(){
                new Saludar{Id = 15, Español = "Buenos dias",Ingles = "Good morning", Portugues = "bom"},
                new Saludar{Id = 4, Español = "Buenas tardes", Ingles = "Good afternoon", Portugues = "boa tarde"},
                new Saludar{Id = 5, Español ="Buenas Noches ",Ingles="Good Evening",Portugues ="boa noches"}
            };
        }

        public IEnumerable<Saludar> GetAll()
        {
            return saludos;
        }

        public Saludar GetSaludoId(int IdSaludo)
        {
            return saludos.SingleOrDefault(a => a.Id == IdSaludo);
        }

       public Saludar Update(Saludar saludoActualizado)
        {
           var saludito = saludos.SingleOrDefault(s => s.Id == saludoActualizado.Id);

           if (saludito !=null){
            saludito.Español = saludoActualizado.Español;
            saludito.Ingles = saludoActualizado.Ingles;
            saludito.Portugues = saludoActualizado.Portugues;
           }
           return saludito;
        }
    }
}