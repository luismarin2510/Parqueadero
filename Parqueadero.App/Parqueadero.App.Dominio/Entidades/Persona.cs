using System;

namespace Parqueadero.App.Dominio
{

    public class Persona
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime horario { get; set; }
        public string estacionamiento { get; set; }
        public string numero_vehiculos { get; set; }
        public string contraseña { get; set;}
    }
}