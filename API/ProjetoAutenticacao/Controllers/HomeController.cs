using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ProjetoAutenticacao.Controllers
{
    [ApiController]
    [Route("V1/Account")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Anonimo")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("Autenticado")]
        [Authorize]
        public string Authenticated() => string.Format($"Autenticado - {User.Identity.Name}");

        [HttpGet]
        [Route("Manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Manager";
        
        [HttpGet]
        [Route("Employee")]
        [Authorize(Roles = "employee")]
        public string Employee() => "Empregado";
        
        [HttpGet]
        [Route("Group")]
        [Authorize(Roles = "employee, manager")]
        public string Group () => "Empregado ou Manager";
    }
}
