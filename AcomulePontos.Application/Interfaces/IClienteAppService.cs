using AcomulePontos.Domain.Entities;
using System.Collections.Generic;

namespace AcomulePontos.Application.Interfaces
{

    public interface IClienteAppService
    {
        IEnumerable<Cliente> GetAll();
    }
}
