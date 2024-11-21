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
    public interface IClienteService
    {
        Task<List<ClienteDTO>> GetClientes();
        Task<ClienteDTO> GetById(int? id);

        Task Add(ClienteDTO clienteDTO);
        Task Update(ClienteDTO clienteDTO);
        Task Remove(int id);
    }
}
