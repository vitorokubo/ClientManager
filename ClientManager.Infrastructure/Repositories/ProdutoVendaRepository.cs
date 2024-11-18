using ClientManager.Domain.Entities;
using ClientManager.Domain.Interfaces;
using ClientManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Infrastructure.Repositories
{
    public class ProdutoVendaRepository : IProdutoVendaRepository
    {

        AppDbContext _produtoVendaContext;

        public ProdutoVendaRepository(AppDbContext context)
        {
            _produtoVendaContext = context;
        }

        public Task<ProdutoVenda> CreateAsync(ProdutoVenda produtoVenda)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoVenda> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoVenda>> GetProdutoVendasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoVenda> RemoveAsync(ProdutoVenda produtoVenda)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoVenda> UpdateAsync(ProdutoVenda produtoVenda)
        {
            throw new NotImplementedException();
        }
    }
}
