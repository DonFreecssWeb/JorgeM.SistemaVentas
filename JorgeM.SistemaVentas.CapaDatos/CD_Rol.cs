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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            try
            {
                var lista = new List<Rol>();
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IDROL, descripcion from rol");      

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                    {
                        cmd.CommandType = CommandType.Text;
              
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var rol = new Rol();
                                rol.IdRol = Convert.ToInt32(dr["idrol"]) ;
                                rol.Descripcion = dr["Descripcion"].ToString();

                                lista.Add(rol);
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
