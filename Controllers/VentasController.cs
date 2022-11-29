using Microsoft.AspNetCore.Mvc;
using ApiSistemaDeVentas.ADO.NET;
using ApiSistemaDeVentas.Models;

namespace ApiSistemaDeVentas.Controllers
{
    [ApiController]
    [Route("controller")]
    public class VentasController : Controller
    {
        [HttpGet]
        [Route("Ventas")]
        public List<VentaModel> get()
        {
            return ADO_Venta.ventasLista();
        }
    }
}
