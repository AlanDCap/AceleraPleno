using Livraria;
using LivrariaBackend.DAO;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private LivrariaContext contextBD;

        public EmprestimoController(LivrariaContext context)
        {
            contextBD = new LivrariaContext();
        }

        [HttpGet]
        public JsonResult GetEmprestimos()
        {
            var emprestimoFromDatabase = contextBD.Emprestimos.ToList();

            return new JsonResult(emprestimoFromDatabase);
        }

        [HttpPost]
        public IActionResult InsertEmprestimos(Emprestimo emprestimo)
        {
            contextBD.Emprestimos.Add(emprestimo);
            contextBD.SaveChanges();
            return Ok();
        }

    }
}
