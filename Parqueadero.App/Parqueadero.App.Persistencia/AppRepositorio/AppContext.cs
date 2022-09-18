using Microsoft.EntityFrameworkCore;
using Parqueadero.App.Dominio;  


namespace Parqueadero.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> personas { get; set; }
        public DbSet<Lugar> lugares { get; set; }
        public DbSet<Porhoras> porhorass { get; set; }
        public DbSet<Tiempocompleto> tiempocompleto { get; set; }
        public DbSet<Transaccion> transacciones { get; set; }
        public DbSet<Vehiculo> vehiculoss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = BaseDatosParqueadero");
            }
        }
    }

}