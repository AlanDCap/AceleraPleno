using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        List<EmprestimoModel> emprestimos = new List<EmprestimoModel> { };

        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var emprestimos = contexto.Emprestimos.ToList();

            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Index(EmprestimoModel emprestimo)
        {

            contexto.Emprestimos.Add(emprestimo);

            contexto.SaveChanges();

            var emprestimosDb = contexto.Emprestimos.ToList();

            return View(emprestimosDb);
        }
        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel emprestimo)
        {
            emprestimos.Add(emprestimo);
            return View(emprestimo);
        }
    }
}
