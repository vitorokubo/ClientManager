using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetClientesAsync();
        Task<Cliente> GetByIdAsync(int? id);

        Task<Cliente> CreateAsync(Cliente cliente);
        Task<Cliente> UpdateAsync(Cliente cliente);
        Task<Cliente?> RemoveAsync(int id);

    }
}
