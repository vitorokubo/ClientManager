using ClientManager.Application.DTOs;

namespace ClientManager.Application.Interfaces
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