using AcomulePontos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcomulePontos.Application
{
    public class ClienteAppService
    {
        IRepositoryBase repositorie;

        public ClienteAppService(IRepositoryBase repositorie)
        {

        }

        public IEnumerable<Cliente> GetAll() {

            return null;
        }
    }
}
