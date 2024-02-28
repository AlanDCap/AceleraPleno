using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Repository
{
    public class DataBaseContext : DbContext 
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base (options) { }

        public DbSet<ClienteModel> TabelaClientes { get; set; }
    }
}
