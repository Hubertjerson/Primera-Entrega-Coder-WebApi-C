using ApiSistemaDeVentas.Models;
using System.Data.SqlClient;

namespace ApiSistemaDeVentas.ADO.NET
{
    public class ADO_Producto
    {
        public static List<ProductoModel> ListarProducto()
        {
            List<ProductoModel> lisProducto = new List<ProductoModel>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadenaConexion))
                try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoModel producto = new ProductoModel();
                            producto.Id = Convert.ToInt32(dr["Id"].ToString());
                            producto.Descripciones = dr["Descripciones"].ToString();
                            producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                            producto.Costo = Convert.ToDouble(dr["Costo"]);
                            producto.Stock = Convert.ToInt32(dr["Stock"].ToString());
                            producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                            lisProducto.Add(producto);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lisProducto;
        }
    }
}
