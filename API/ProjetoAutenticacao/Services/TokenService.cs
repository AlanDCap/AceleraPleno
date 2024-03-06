using Microsoft.IdentityModel.Tokens;
using ProjetoAutenticacao.Model;
using ProjetoAutenticacao.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace ProjetoAutenticacao.Services
{
    public static class TokenService
    {
        public static string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(ServiceSettings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()), //user.identity.Name
                    new Claim(ClaimTypes.Role, user.Role.ToString()) //user.identity.Role
                }),
                Expires = DateTime.UtcNow.AddHours(1), //Vida útil de uma hora
                SigningCredentials  = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
