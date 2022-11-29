using ApiSistemaDeVentas.Models;
using System.Data.SqlClient;

namespace ApiSistemaDeVentas.ADO.NET
{
    public class ADO_Usuario
    {
        public static List<UsuarioModel> listarUsuario()
        {
            List<UsuarioModel> listaADO = new List<UsuarioModel>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            UsuarioModel usuario = new UsuarioModel();
                            usuario.Id = Convert.ToInt32(rd["Id"].ToString());
                            usuario.Nombre = rd["Nombre"].ToString();
                            usuario.Apellido = rd["Apellido"].ToString();
                            usuario.NombreUsuario = rd["NombreUsuario"].ToString();
                            usuario.Contrasenia = rd["Contraseña"].ToString();
                            usuario.Mail = rd["Mail"].ToString();
                            listaADO.Add(usuario);

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaADO;
        }
    }
}
