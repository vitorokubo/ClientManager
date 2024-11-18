using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Entities
{
    public sealed class Venda : Entity
    {

        public int ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<ProdutoVenda> Vendas {  get; private set; }

        public double VendaTotal => Vendas.Sum(x=> x.PrecoTotal);
        

    }
}
