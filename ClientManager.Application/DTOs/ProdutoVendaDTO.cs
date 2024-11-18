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
        public int QuatidadeVendida { get; private set; }
        public double PrecoPorUnidade { get; private set; }
        public int ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public int VendaId { get; private set; }
        public Venda Venda { get; private set; }

        //public double PrecoTotal => QuatidadeVendida * PrecoPorUnidade;
    }
}
