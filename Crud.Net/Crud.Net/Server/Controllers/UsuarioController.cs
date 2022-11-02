using Crud.Net.Server.Servicios;
using Crud.Net.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud.Net.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario iUsuario;
        public UsuarioController(IUsuario iUser)
        {
            iUsuario = iUser;
        }
        [HttpGet]
        public async Task<List<Usuario>> ListaUsuarios()
        {
            return await Task.FromResult(iUsuario.DatosUsuarios());
        }

        [HttpPost]
        public void Post(Usuario usuario)
        {
            iUsuario.NuevoUsuario(usuario);
        }

        //[HttpGet("{id")]
        //public IActionResult DameUsuario(int id)
        //{
        //    Usuario u = iUsuario.DatosUsuario(id);
        //    if (u != null)
        //    {
        //        return Ok(u);
        //    }
        //    return NotFound();
        //}
    }
}
