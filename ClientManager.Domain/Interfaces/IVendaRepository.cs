using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Interfaces
{
    public interface IVendaRepository
    {
        Task<IEnumerable<Venda>> GetVendasAsync();
        Task<Venda> GetByIdAsync(int? id);

        Task<Venda> CreateAsync(Venda venda);
        Task<Venda> UpdateAsync(Venda venda);
        Task<Venda> RemoveAsync(Venda venda);

    }
}
