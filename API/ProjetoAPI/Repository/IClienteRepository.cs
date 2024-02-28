using ProjetoAPI.Model;

namespace ProjetoAPI.Repository
{
    public interface IClienteRepository
    {
        public ClienteModel? GetClienteById(int id);
        public ClienteModel? GetClienteByName(string name);
        public List<ClienteModel> GetClienteList();
        public ClienteModel? SetCliente(ClienteModel newCliente);
        public ClienteModel? UpdateCliente(ClienteModel UpdateCliente);
        public bool DeleteCliente(int id);
    }
}
