using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IclienteService
    {
        public void Add(Cliente c)
        {
            CLienteDao dao = new CLienteDao();
            dao.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            CLienteDao dao = new CLienteDao();
            return dao.Buscar(nome);
        }
    }
}
