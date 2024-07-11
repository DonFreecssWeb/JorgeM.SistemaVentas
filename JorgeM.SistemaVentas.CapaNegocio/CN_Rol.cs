using JorgeM.SistemaVentas.CapaDatos;
using JorgeM.SistemaVentas.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeM.SistemaVentas.CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol oRol = new CD_Rol();

        public List<Rol> Listar()
        {
            return oRol.Listar();
        }
    }
}
