using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeM.SistemaVentas.CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario oUsuario { get; set; }      
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; }
        public List<Venta> oDetalle_Venta { get; set; }

    }
}
