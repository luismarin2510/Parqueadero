using System;

namespace Parqueadero.App.Dominio
{

    public class Tiempocompleto
    {
        public int Id { get; set; }
        public Boolean aprobacion { get; set; }
        public DateTime fecha_salida { get; set; }
    }
}