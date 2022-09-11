using System;

namespace Parqueadero.App.Dominio
{

    public class Vehiculo
    {
         public int Id { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string tipo_vehiculo { get; set; }
    }
}