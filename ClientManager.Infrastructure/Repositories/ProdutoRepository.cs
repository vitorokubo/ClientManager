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
    public class ProdutoRepository : IProdutoRepository
    {

        AppDbContext _produtoContext;

        public ProdutoRepository(AppDbContext context)
        {
            _produtoContext = context;
        }

        public async Task<Produto> CreateAsync(Produto produto)
        {
            _produtoContext.Add(produto);
            await _produtoContext.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto?> GetByIdAsync(int? id)
        {
            return await _produtoContext.Produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            return await _produtoContext.Produtos.ToListAsync();
        }

        public async Task<Produto> RemoveAsync(Produto produto)
        {
            _produtoContext.Remove(produto);
            await _produtoContext.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> UpdateAsync(Produto produto)
        {
            _produtoContext.Update(produto);
            await _produtoContext.SaveChangesAsync();
            return produto;
        }
    }
}
