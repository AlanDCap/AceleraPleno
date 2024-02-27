using Livraria;
using Microsoft.EntityFrameworkCore;

namespace LivrariaBackend.DAO
{
    public class LivrariaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "server=193.203.175.59;port=3306;database=u123648597_livraria;user=u123648597_livraria;password=Livraria#123";
            //var conexao = "server=zapcidade.app;port=3306;database=livraria;uid=livraria;password=aceleranet";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }
        public DbSet<Livros> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Emprestimo> Emprestimos { get; set; }

    }
}