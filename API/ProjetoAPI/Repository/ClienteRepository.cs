using ProjetoAPI.Model;
using System.Xml.Linq;

namespace ProjetoAPI.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public ClienteRepository(DataBaseContext dataBaseContext)
        {

            _dataBaseContext = dataBaseContext;

        }
        public bool DeleteCliente(int id)
        {
            if (GetClienteById(id) == null)
            { return false; }

            _dataBaseContext.Remove(id);
            _dataBaseContext.SaveChanges();
            return true;
        }

        public ClienteModel? GetClienteById(int id)
        {
            return _dataBaseContext.TabelaClientes.Where(obj => obj.id == id).FirstOrDefault();
        }

        public ClienteModel? GetClienteByName(string name)
        {
            return _dataBaseContext.TabelaClientes.Where(obj => obj.nome == name).FirstOrDefault();

        }

        public List<ClienteModel> GetClienteList()
        {
            return _dataBaseContext.TabelaClientes.ToList();
        }

        public ClienteModel? SetCliente(ClienteModel newCliente)
        {
            if (GetClienteById(newCliente.id) != null)
            { return null; }

            _dataBaseContext.Add(newCliente);
            _dataBaseContext.SaveChanges();
            
            return newCliente;
        }

        public ClienteModel? UpdateCliente(ClienteModel UpdateCliente)
        {
            var item = GetClienteById(UpdateCliente.id);
            if (item == null)
                return null;
            _dataBaseContext.Update(item);
            _dataBaseContext.SaveChanges();
            return item;
        }
    }
}
