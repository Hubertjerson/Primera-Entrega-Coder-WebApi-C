using Microsoft.AspNetCore.Mvc;
using ApiSistemaDeVentas.ADO.NET;
using ApiSistemaDeVentas.Models;

namespace ApiSistemaDeVentas.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ProductoController : Controller
    {
        [HttpGet]
        [Route("Producto")]
        public List<ProductoModel> Get() 
        {
            return ADO_Producto.ListarProducto();
        }
    }
}
