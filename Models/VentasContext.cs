
using Microsoft.EntityFrameworkCore;
namespace WebAPI_Softek.Models;

public class VentasContext : DbContext
{
    public VentasContext(DbContextOptions<VentasContext> options)
        : base(options)
    {
    }

    public DbSet<Venta> Ventas { get; set; } = null!;
    public DbSet<Detalle> Detalles { get; set; } = null!;
}