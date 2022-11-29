using Microsoft.AspNetCore.Mvc;
using ApiSistemaDeVentas.ADO.NET;
using ApiSistemaDeVentas.Models;

namespace ApiSistemaDeVentas.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ProductoVendidoController : Controller
    {
        [HttpGet]
        [Route("ProductoVendido")]
        public List<ProductoVendidoModel> Get()
        {
            return ADO_ProductoVendido.ListarProductoVendido();
        }
    }
}
