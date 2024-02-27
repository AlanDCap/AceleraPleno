using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class ListaDeLivros
    {
        List<Livros> list;

        public ListaDeLivros()
        {
            list = new List<Livros> ();
        }

        public void CadastraLivro(Livros livro)
        {
            list.Add(livro);
        }

        public List<Livros> Lista() {
            return list;
        }

        public void PopulaLivros(List<Livros> livros)
        {
            list.AddRange(livros);
        }
    }
}
