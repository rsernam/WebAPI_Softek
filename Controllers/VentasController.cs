using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Softek.Models;
using WebAPI_Softek.Attributes;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Softek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class VentasController : ControllerBase
    {

        private readonly VentasContext _context;

        public VentasController(VentasContext context)
        {
            _context = context;





        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> ObtenerVentas()
        {
            return await _context.Ventas.Include(a => a.Detalles).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> ObtenerVenta(int id)
        {
            var venta = await _context.Ventas
                .FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }


        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta(Venta venta)
        {

            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(ObtenerVenta),
                new { id = venta.IdVenta},
                venta);
        }

    }
}
