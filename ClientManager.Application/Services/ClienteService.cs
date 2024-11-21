using AutoMapper;
using ClientManager.Application.DTOs;
using ClientManager.Application.Interfaces;
using ClientManager.Domain.Entities;
using ClientManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.Services
{
    public class ClienteService : IClienteService
    {

        private IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository; 
            _mapper = mapper;
        }

        public async Task Add(ClienteDTO clienteDTO)
        {
            var clienteEntity = _mapper.Map<Cliente>(clienteDTO);
            await _clienteRepository.CreateAsync(clienteEntity);
        }

        public async Task<ClienteDTO> GetById(int? id)
        {
            var clienteEntity = await _clienteRepository.GetByIdAsync(id);
            return _mapper.Map<ClienteDTO>(clienteEntity);
        }

        public async Task<List<ClienteDTO>> GetClientes()
        {
            var clientesEntity = await _clienteRepository.GetClientesAsync();
            return _mapper.Map<List<ClienteDTO>>(clientesEntity);
        }

        public async Task Remove(int id)
        {
            
            await _clienteRepository.RemoveAsync(id);
        }

        public async Task Update(ClienteDTO clienteDTO)
        {
            var clienteEntity = new Cliente(clienteDTO.Name);
            clienteEntity.Id = clienteDTO.Id;

            Console.WriteLine(clienteEntity.Id);
            await _clienteRepository.UpdateAsync(clienteEntity);
        }

    }
}
