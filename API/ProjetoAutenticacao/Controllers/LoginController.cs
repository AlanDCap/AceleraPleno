using Microsoft.AspNetCore.Mvc;
using ProjetoAutenticacao.Model;
using ProjetoAutenticacao.Repository;
using ProjetoAutenticacao.Services;

namespace ProjetoAutenticacao.Controllers
{
    [ApiController]
    [Route("V1/Auth")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authentication([FromBody] User model)
        {
            var user = UserRepository.Get(model.UserName, model.Password);
            if (user is null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token,
            };
        }
    }
}
