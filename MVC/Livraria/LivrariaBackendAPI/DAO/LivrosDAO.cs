using Livraria;

namespace LivrariaBackend.DAO
{
    public class LivrosDAO
    {
        private LivrariaContext contextBD;

        public LivrosDAO(LivrariaContext context)
        {
            contextBD = new LivrariaContext();

        }
        public LivrosDAO()
        {
            contextBD = new LivrariaContext();

        }

        public Livros RetornaPorCod(int codLivro)
        {
            return contextBD.Livros.Find(codLivro);

        }
    }
}
