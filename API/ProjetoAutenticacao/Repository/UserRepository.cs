using ProjetoAutenticacao.Model;

namespace ProjetoAutenticacao.Repository
{
    public class UserRepository
    {
        public static User? Get(string userName, string password)
        {
            var users = new List<User>()
            {
                new() { Id = 1, UserName = "admin", Password = "admin", Role = "manager"},
                new() { Id = 1, UserName = "Alan", Password = "1234", Role = "employee"},
                new() { Id = 1, UserName = "Joseph", Password = "5678", Role = "client"}
            };
            return users.FirstOrDefault(user => user.UserName == userName && user.Password == password); 
        }
    }
}
