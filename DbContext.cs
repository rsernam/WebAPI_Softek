using WebAPI_Softek.Models;
using Microsoft.EntityFrameworkCore;
namespace WebAPI_Softek
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "VentasDb");
        }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
    }
}