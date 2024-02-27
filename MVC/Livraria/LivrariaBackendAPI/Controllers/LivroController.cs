using Livraria;
using LivrariaBackend.DAO;
using LivrariaBackend.Domain;
using Microsoft.AspNetCore.Mvc;


namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private LivrariaContext contextBD;

        public LivroController(LivrariaContext context)
        {
            contextBD = new LivrariaContext();
        }

        [HttpGet]
        public JsonResult GetLivros()
        {
            var livrosFromDatabase = contextBD.Livros.ToList();

            return new JsonResult(livrosFromDatabase);
        }
        
        //[HttpPost]
        //public IActionResult InserLivros(Livros livro)
        //{
        //    contextBD.Livros.Add(livro);
        //    contextBD.SaveChanges();
        //    return Ok();
        //}

        [HttpPost]
        public IActionResult InsertLivros(Livros livro)
        {
            bool idValido = Service.ValidaId(livro.Cod);
            if (idValido)
            {
                contextBD.Livros.Add(livro);
                contextBD.SaveChanges();
                return Ok();
            } else 
                return BadRequest();
        }

    }
}