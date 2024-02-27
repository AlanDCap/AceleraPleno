using Livraria;
using LivrariaBackend.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private LivrariaContext contextBD;

        public UsuarioController(LivrariaContext context)
        {
            contextBD = new LivrariaContext();
        }

        [HttpGet]
        public JsonResult GetUsuarios()
        {
            var usuariosFromDatabase = contextBD.Usuarios.ToList();

            return new JsonResult(usuariosFromDatabase);
        }

        [HttpPost]
        public IActionResult InsertUsuarios(Usuario usuario)
        {
            contextBD.Usuarios.Add(usuario);
            contextBD.SaveChanges();
            return Ok();
        }

    }
}