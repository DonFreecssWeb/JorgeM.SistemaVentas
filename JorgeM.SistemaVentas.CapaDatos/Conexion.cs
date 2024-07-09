
using System.Configuration;
namespace JorgeM.SistemaVentas.CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
    }
}
