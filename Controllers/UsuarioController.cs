using Microsoft.AspNetCore.Mvc;
using ApiSistemaDeVentas.ADO.NET;
using ApiSistemaDeVentas.Models;

namespace ApiSistemaDeVentas.Controllers
{
    [ApiController]
    [Route("controller")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        [Route("Usuarios")]
        public List<UsuarioModel> GetUsuario()
        {
            return ADO_Usuario.listarUsuario();
        }
    }
}
