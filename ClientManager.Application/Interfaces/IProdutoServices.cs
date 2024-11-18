using AutoMapper;
using ClientManager.Application.DTOs;
using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoDTO>> GetProdutos();
        Task<ProdutoDTO> GetById(int? id);

        Task Add(ProdutoDTO produtoDTO);
        Task Update(ProdutoDTO produtoDTO);
        Task Remove(int? id);
    }
}
