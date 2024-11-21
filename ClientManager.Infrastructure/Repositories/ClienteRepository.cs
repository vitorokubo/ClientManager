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
    public class ClienteRepository : IClienteRepository
    {

        AppDbContext _clienteContext;

        public ClienteRepository(AppDbContext context)
        {
            _clienteContext = context;
        }

        public async Task<Cliente> CreateAsync(Cliente Cliente)
        {
            _clienteContext.Add(Cliente);
            await _clienteContext.SaveChangesAsync();
            return Cliente;
        }

        public async Task<Cliente?> GetByIdAsync(int? id)
        {
            return await _clienteContext.Clientes
                          .AsNoTracking()
                          .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _clienteContext.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> RemoveAsync(int id)
        {

            var cliente = await _clienteContext.Clientes.FindAsync(id);

            if (cliente == null)
            {
                
                return null;
            }

            _clienteContext.Clientes.Remove(cliente);

            await _clienteContext.SaveChangesAsync();

            return cliente;
        }

        public async Task<Cliente> UpdateAsync(Cliente Cliente)
        {
            var clienteExistente = await _clienteContext.Clientes
                .FirstOrDefaultAsync(c => c.Id == Cliente.Id);

            clienteExistente.Update(name: Cliente.Name);
            await _clienteContext.SaveChangesAsync();
            return Cliente;
        }
    }
}
