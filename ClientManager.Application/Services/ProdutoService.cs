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
    public class ProdutoService : IProdutoService
    {

        private IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository; 
            _mapper = mapper;
        }

        public async Task Add(ProdutoDTO produtoDTO)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDTO);
            await _produtoRepository.CreateAsync(produtoEntity);

        }

        public async Task<ProdutoDTO> GetById(int? id)
        {
            var produtoEntity = await _produtoRepository.GetByIdAsync(id);
            return _mapper.Map<ProdutoDTO>(produtoEntity);
        }

        public async Task<List<ProdutoDTO>> GetProdutos()
        {
            var produtosEntity = await _produtoRepository.GetProdutosAsync();
            return _mapper.Map<List<ProdutoDTO>>(produtosEntity);
        }

        public async Task Remove(int? id)
        {
            var produtoEntity = _produtoRepository.GetByIdAsync(id).Result; 
            if(produtoEntity != null) await _produtoRepository.RemoveAsync(produtoEntity);
        }

        public async Task Update(ProdutoDTO produtoDTO)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDTO);
            await _produtoRepository.UpdateAsync(produtoEntity);
        }
    }
}
