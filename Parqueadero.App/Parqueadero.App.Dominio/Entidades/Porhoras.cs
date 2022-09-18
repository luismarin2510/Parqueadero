using System;

namespace Parqueadero.App.Dominio
{

    public class Porhoras
    {
        
        public int Id {get; set;}
        public string motivo {get; set;}
        public DateTime entrada {get; set;}
        public DateTime salida { get; set; }
    }
}