using ApiSistemaDeVentas.Models;
using System.Data.SqlClient;

namespace ApiSistemaDeVentas.ADO.NET
{
    public class ADO_Venta
    {
        public static List<VentaModel> ventasLista()
        {
            List<VentaModel> listaVenta = new List<VentaModel>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venta", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            VentaModel ventas = new VentaModel();
                            ventas.Id = Convert.ToInt32(rd["Id"].ToString());
                            ventas.Comentarios = rd["Comentarios"].ToString();
                            ventas.IdUsuario = Convert.ToInt32(rd["IdUsuario"].ToString());
                            listaVenta.Add(ventas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaVenta;
        }
    }
}
