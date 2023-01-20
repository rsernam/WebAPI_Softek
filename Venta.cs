using System;

public class Venta
{
    public int IdVenta { get; set; }
    public string Cliente { get; set; }
    public string RUCCliente { get; set; }
    public List<Detalle> Detalles { get; set; }
}
