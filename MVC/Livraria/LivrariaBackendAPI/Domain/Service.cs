using Livraria;
using LivrariaBackend.DAO;

namespace LivrariaBackend.Domain
{
    public static class Service
    {
        public static bool ValidaId(int codLivro)
        {
            LivrosDAO livrosDAO = new LivrosDAO();
            Livros livro = livrosDAO.RetornaPorCod(codLivro);
            if (livro != null)
            {
                return false;
            }
            return true;
        }

    }
}
