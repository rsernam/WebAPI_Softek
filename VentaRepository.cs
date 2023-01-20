using WebAPI_Softek.Models;
using Microsoft.EntityFrameworkCore;
namespace WebAPI_Softek
{
    public class VentaRepository : IVentaRepository
    {
        public VentaRepository()
        {
            using (var context = new ApiContext())
            {
                var ventas = new List<Venta>
                {
                new Venta
                {
                    IdVenta = 1,
                    Cliente ="Empresa 1",
                    RUCCliente ="20202020202",
                    Detalles = new List<Detalle>()
                    {
                        new Detalle { IdDetalle=1, NombreProducto = "Producto 1", Cantidad = 1, Monto = 100.0m},
                        new Detalle { IdDetalle=2,NombreProducto = "Producto 2", Cantidad = 3, Monto = 300.0m},
                        new Detalle { IdDetalle=3,NombreProducto = "Producto 3", Cantidad = 5, Monto = 500.0m},
                        new Detalle { IdDetalle=4,NombreProducto = "Producto 4", Cantidad = 2, Monto = 200.0m},

                    }
                },
                new Venta
                {
                    IdVenta = 2,
                    Cliente ="Empresa 2",
                    RUCCliente ="20202020203",
                    Detalles = new List<Detalle>()
                    {
                        new Detalle { IdDetalle=5,NombreProducto = "Producto 5", Cantidad = 5, Monto = 500.0m},
                        new Detalle { IdDetalle=6,NombreProducto = "Producto 6", Cantidad = 2, Monto = 200.0m},
                        new Detalle { IdDetalle=7,NombreProducto = "Producto 7", Cantidad = 2, Monto = 200.0m},
                        new Detalle { IdDetalle=8,NombreProducto = "Producto 8", Cantidad = 2, Monto = 200.0m},

                    }
                },
                };
                context.Ventas.AddRange(ventas);
                context.SaveChanges();
            }
        }
        public List<Venta> ObtenerVentas()
        {
            using (var context = new ApiContext())
            {
                var list = context.Ventas
                    .Include(a => a.Detalles)
                    .ToList();
                return list;
            }
        }
        /*
        public Venta ObtenerVentasPorId(int id)
        {
            using (var context = new ApiContext())
            {
                var venta = context.Ventas.Find(id);
              
                return venta;
            }
        }
        */

    }
}