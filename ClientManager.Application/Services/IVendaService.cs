using ClientManager.Application.DTOs;

namespace ClientManager.Application.Services
{
    public interface IVendaService
    {
        Task Add(VendaDTO vendaDTO);
        Task<VendaDTO> GetById(int? id);
        Task<List<VendaDTO>> GetVendas();
        Task Remove(int? id);
        Task Update(VendaDTO vendaDTO);
    }
}