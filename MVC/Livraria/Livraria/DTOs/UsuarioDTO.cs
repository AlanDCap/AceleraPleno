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
    public class UsuarioDTO
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Login")]
        public string Login { get; set; }

        [JsonProperty("Senha")]
        public string Senha { get; set; }
    }
}
