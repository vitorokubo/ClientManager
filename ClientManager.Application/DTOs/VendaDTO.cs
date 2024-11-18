using ClientManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Application.DTOs
{
    public class VendaDTO
    {
        public int VendaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<ProdutoVendaDTO> ProdutoVendaDTOs { get; set; }
        public double VendaTotal { get; set; }
    }
}
