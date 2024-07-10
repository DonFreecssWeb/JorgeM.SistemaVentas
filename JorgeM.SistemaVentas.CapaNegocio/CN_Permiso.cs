using JorgeM.SistemaVentas.CapaDatos;
using JorgeM.SistemaVentas.CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeM.SistemaVentas.CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso oPermiso = new CD_Permiso();

        public List<Permiso> Listar(int idusuario)
        {
            return oPermiso.Listar(idusuario);
        }
    }
}
