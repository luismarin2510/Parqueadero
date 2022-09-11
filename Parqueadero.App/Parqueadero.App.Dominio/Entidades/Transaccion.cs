using System;

namespace Parqueadero.App.Dominio
{

    public class Transaccion
    {
        public DateTime acceso {get; set;}
        public DateTime salida {get; set;}
        public int tarifa {get; set;}
        public string pago {get; set;}
    }
}