using JorgeM.SistemaVentas.CapaDatos;
using JorgeM.SistemaVentas.CapaEntidad;

namespace JorgeM.SistemaVentas.CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario oUsuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return oUsuario.Listar();
        }
    }
}
