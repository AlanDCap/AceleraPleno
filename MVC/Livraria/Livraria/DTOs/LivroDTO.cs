using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Livraria.DTOs
{
    public class LivroDTO
    {
        [JsonProperty("livro")]
        public string Livro { get; set; }

        [JsonProperty("pg")]
        public string Paginas { get; set; }

        [JsonProperty("cod")]
        public int Codigo { get; set; }

        [JsonProperty("valor")]
        public decimal Valor { get; set; }
    }
}