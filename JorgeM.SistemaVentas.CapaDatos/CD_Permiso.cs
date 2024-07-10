using JorgeM.SistemaVentas.CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeM.SistemaVentas.CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            try
            {
                var lista = new List<Permiso>();
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idrol, p.nombremenu from permiso p");
                    query.AppendLine("inner join rol r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");


   
                    using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@idusuario",idUsuario);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var permiso = new Permiso();
                                permiso.oRol = new Rol { IdRol = Convert.ToInt32(dr["idrol"] )};
                                permiso.NombreMenu = dr["NombreMenu"].ToString();                           

                                lista.Add(permiso);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
