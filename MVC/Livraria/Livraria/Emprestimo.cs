using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    [Table("EMPRESTIMO")]
    public class Emprestimo
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Livro emprestado
        /// </summary>
        [Column("ID_LIVRO")]
        public int Livros { get; set; }

        /// <summary>
        /// Usuario leitor
        /// </summary>
        [Column("ID_USUARIO")]
        public string Usuario { get; set; }

        /// <summary>
        /// Data da Retirada
        /// </summary>
        [Column("DT_EMPRESTIMO")]
        public DateTime Retirada { get; set; }

        /// <summary>
        /// Data da devolução
        /// </summary>
        [Column("DT_DEVOLUCAO")]
        public DateTime? Devolucao { get; set; }

        /// <summary>
        /// Construct padrão
        /// </summary>
        /// <param name="livros">Livro a emprestar</param>
        /// <param name="usuario">Usuario leitor</param>
        public Emprestimo(int livros, string usuario)
        {
            ID = new Random().Next();
            Livros = livros;
            Usuario = usuario;
            Retirada = DateTime.Now;
            Devolucao = DateTime.Now.AddDays(3);
        }
    }
}