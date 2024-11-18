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
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IMapper _mapper;

        public VendaService(IVendaRepository vendaRepository, IMapper mapper)
        {
            _vendaRepository = vendaRepository;
            _mapper = mapper;
        }

        public async Task Add(VendaDTO vendaDTO)
        {
            var vendaEntity = _mapper.Map<Venda>(vendaDTO);
            await _vendaRepository.CreateAsync(vendaEntity);
        }

        public async Task<VendaDTO> GetById(int? id)
        {
            var vendaEntity = await _vendaRepository.GetByIdAsync(id);
            return _mapper.Map<VendaDTO>(vendaEntity);
        }

        public async Task<List<VendaDTO>> GetVendas()
        {
            var vendasEntity = await _vendaRepository.GetVendasAsync();
            return _mapper.Map<List<VendaDTO>>(vendasEntity);
        }

        public async Task Remove(int? id)
        {
            var vendaEntity = await _vendaRepository.GetByIdAsync(id);
            if (vendaEntity != null)
            {
                await _vendaRepository.RemoveAsync(vendaEntity);
            }
        }

        public async Task Update(VendaDTO vendaDTO)
        {
            var vendaEntity = _mapper.Map<Venda>(vendaDTO);
            await _vendaRepository.UpdateAsync(vendaEntity);
        }
    }

}
