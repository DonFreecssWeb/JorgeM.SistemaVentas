using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeM.SistemaVentas.CapaEntidad
{
    public class Detalle_Venta
    {
        public int IdDetalleVenta { get; set; }
        //se obvio el idVenta para poner una lista en Ventas
        public Producto oProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
