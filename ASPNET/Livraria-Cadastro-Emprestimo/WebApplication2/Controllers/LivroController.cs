using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LivroController : Controller
    {
        List<LivroModel> livros = new List<LivroModel> { };

        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var livros = contexto.Livros.ToList();

            return View(livros);
        }

        [HttpPost]
        public IActionResult Index(LivroModel livroCadastro)
        {

            contexto.Livros.Add(livroCadastro);

            contexto.SaveChanges();

            var livrosDb = contexto.Livros.ToList();

            return View(livrosDb);
        }

        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(LivroModel livroCadastro)
        {
            livros.Add(livroCadastro);
            return View(livroCadastro);
        }
    }
}
