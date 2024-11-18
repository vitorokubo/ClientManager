using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Interfaces
{
    public interface IProdutoVendaRepository
    {
        Task<IEnumerable<ProdutoVenda>> GetProdutoVendasAsync();
        Task<ProdutoVenda> GetByIdAsync(int? id);
        Task<ProdutoVenda> CreateAsync(ProdutoVenda produtoVenda);
        Task<ProdutoVenda> UpdateAsync(ProdutoVenda produtoVenda);
        Task<ProdutoVenda> RemoveAsync(ProdutoVenda produtoVenda);

    }
}
