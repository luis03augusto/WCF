using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class CLienteDao
    {
        public  static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            CLienteDao.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var reslt = CLienteDao.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return (Cliente)reslt;
        }
    }
}
