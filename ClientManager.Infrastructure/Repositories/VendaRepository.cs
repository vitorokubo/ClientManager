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
                                 .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Venda>> GetVendasAsync()
        {
            return await _context.Vendas
                                 .Include(v => v.Vendas) 
                                 .ThenInclude(pv => pv.Produto) 
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
            _context.Update(venda);
            await _context.SaveChangesAsync();
            return venda;
        }
    }
}
