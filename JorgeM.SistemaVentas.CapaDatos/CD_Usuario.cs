using JorgeM.SistemaVentas.CapaEntidad;
using Microsoft.Data.SqlClient;
using System.Data;


namespace JorgeM.SistemaVentas.CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            try
            {
                var lista = new List<Usuario>();
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {                
                    string query = "Select idusuario, documento, nombrecompleto, correo, clave, estado from usuario";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.IdUsuario = Convert.ToInt32(dr["idusuario"]);
                                usuario.NombreCompleto = dr["nombrecompleto"].ToString();
                                usuario.Documento = dr["documento"].ToString();
                                usuario.Correo = dr["Correo"].ToString();
                                usuario.Clave = dr["Clave"].ToString();
                                usuario.Estado = Convert.ToBoolean( dr["Estado"]);

                                lista.Add(usuario);
                            }
                        }                       
                    }
                 }               
                    return lista;
             }
            catch (Exception ex)
            {
                throw ;                
            }

        }
    }
}
