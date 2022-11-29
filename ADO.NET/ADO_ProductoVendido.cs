using ApiSistemaDeVentas.Models;
using System.Data.SqlClient;

namespace ApiSistemaDeVentas.ADO.NET
{
    public class ADO_ProductoVendido
    {
        public static List<ProductoVendidoModel> ListarProductoVendido()
        {
            List<ProductoVendidoModel> lisProducVendido = new List<ProductoVendidoModel>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoVendidoModel productoVendido = new ProductoVendidoModel();
                            productoVendido.Id = Convert.ToInt32(dr["Id"].ToString());
                            productoVendido.Stock = Convert.ToInt32(dr["Stock"].ToString());
                            productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"].ToString());
                            productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"].ToString());
                            lisProducVendido.Add(productoVendido);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lisProducVendido;
        }
    }
}
