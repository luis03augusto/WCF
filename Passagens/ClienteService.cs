using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
            CLienteDao dao = new CLienteDao();
            dao.Add(c);

            return true;
        }

        public Cliente Buscar(string nome)
        {
            CLienteDao dao = new CLienteDao();
            return dao.Buscar(nome);
        }

        public List<Cliente> getClientes()
        {
            return CLienteDao.clientes;
        }
    }
}
