using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Model;
using ProjetoAPI.Repository;

namespace ProjetoAPI.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(ILogger<ClientesController> logger, IClienteRepository repository)
        {
            _logger = logger;
            _clienteRepository = repository;
        }

        [HttpGet("ConsultarPorId/{id}")]
        [Authorize(Roles = "")]
        public IActionResult GetClientById([FromRoute] int id)
        {
            if (id < 0) { return BadRequest("Requestou mal"); }
            return Ok(_clienteRepository.GetClienteById(id));
        }

        [HttpGet("ConsultarPorNome/{nome}")]
        public IActionResult GetClientByName([FromRoute] string name)
        {
            if (String.IsNullOrEmpty(name))
                return BadRequest("Nome não vale");
            return Ok(_clienteRepository.GetClienteByName(name));
        }

        [HttpPost("NovoCliente")]
        public IActionResult SetNewClient([FromBody] ClienteModel newCliente)
        {
            if (newCliente is null)
                return BadRequest("Cliente inválido");
            return Ok(_clienteRepository.SetCliente(newCliente));
        }
        
        [HttpPut("AtualizaCliente")]
        public IActionResult UpdateClient([FromBody] ClienteModel cliente)
        {
            return Ok();
        }
        [HttpDelete("ApagaCliente/{id}")]
        public IActionResult DeleteClient([FromBody] int id)
        {
            return Ok();
        }
    }
}
