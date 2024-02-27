using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    [Table("livro")]
    public class Livros
    {
        /// <summary>
        /// Nome do Livro
        /// </summary>
        [Column("livro")]
        public string Livro { get; set; }
        /// <summary>
        /// Quantidade de Páginas
        /// </summary>
        [Column("pg")]
        public string Paginas { get; set; }
        /// <summary>
        /// CODIGO ISBN (International Standard Book Number)
        /// </summary>
        [Key]
        [Column("cod")]
        public int Cod { get; set; }
        /// <summary>
        /// Valor do Livro em Reais (BRL)
        /// </summary>
        [Column("valor")]
        public decimal Valor { get; set; }

        /// <summary>
        /// Construtor para Livro padrão 
        /// </summary>
        /// <param name="livro">Nome do Livro</param>
        /// <param name="paginas">Numero de Paginas</param>
        /// <param name="codigo">Código ISBN</param>
        /// <param name="valor"> Preço (BRL)</param>
        public Livros(string livro, string paginas, int codigo, decimal valor)
        {
            Livro = livro;

            Paginas = paginas;

            Codigo = codigo;

            Valor = valor;
        }

        public override string ToString()
        {
            return Livro;
        }
    }
}
