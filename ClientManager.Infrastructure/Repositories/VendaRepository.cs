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
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;

        public VendaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Venda> CreateAsync(Venda venda)
        {
            _context.Add(venda);
            await _context.SaveChangesAsync();
            return venda;
        }

        public async Task<Venda?> GetByIdAsync(int? id)
        {
            return await _context.Vendas
                                 .Include(v => v.Vendas) 
                                 .ThenInclude(pv => pv.Produto)
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Venda>> GetVendasAsync()
        {
            return await _context.Vendas
                                 .Include(v => v.Vendas) 
                                 .ThenInclude(pv => pv.Produto) 
                                 .Include(x=> x.Cliente)
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<Venda> RemoveAsync(Venda venda)
        {
            _context.Remove(venda);
            await _context.SaveChangesAsync();
            return venda;
        }

        public async Task<Venda> UpdateAsync(Venda venda)
        {

            var existingVenda = await _context.Vendas
                                       .Include(x => x.Vendas) // Incluir as vendas (ProdutoVenda)
                                       .FirstOrDefaultAsync(v => v.Id == venda.Id);

            if (existingVenda != null)
            {
                // 1. Atualizar as propriedades da venda
                _context.Entry(existingVenda).CurrentValues.SetValues(venda);

                // 2. Atualizar a lista de ProdutoVenda
                if (venda.Vendas != null)
                {
                    foreach (var produtoVenda in venda.Vendas)
                    {
                        var existingProdutoVenda = existingVenda.Vendas
                            .FirstOrDefault(pv => pv.Id == produtoVenda.Id);

                        if (existingProdutoVenda != null)
                        {
                            // 3. Atualiza os campos da ProdutoVenda que já existem
                            _context.Entry(existingProdutoVenda).CurrentValues.SetValues(produtoVenda);
                        }
                        else
                        {
                            // 4. Adiciona novos produtos de venda (se não existir)
                            existingVenda.Vendas.Add(produtoVenda);
                        }
                    }

                    // 5. Remover os produtos de venda antigos que não estão na nova lista
                    var produtoVendasToRemove = existingVenda.Vendas
                        .Where(existingPV => !venda.Vendas.Any(newPV => newPV.Id == existingPV.Id))
                        .ToList();

                    foreach (var produtoVendaToRemove in produtoVendasToRemove)
                    {
                        existingVenda.Vendas.Remove(produtoVendaToRemove);
                    }
                }

                // Salva as alterações no banco de dados
                await _context.SaveChangesAsync();
            }

            return venda;
        }
    }
}
