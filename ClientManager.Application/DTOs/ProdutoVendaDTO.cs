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
    public class ProdutoVendaDTO
    {
        public int Id { get; set; }
        public int QuantidadeVendida { get; set; }
        public double PrecoPorUnidade { get; set; }
        public int ProdutoId { get;  set; }
        public Produto Produto { get;  set; }
        public int VendaId { get;  set; }
        public Venda Venda { get;  set; }

        //public double PrecoTotal => QuatidadeVendida * PrecoPorUnidade;
    }
}
