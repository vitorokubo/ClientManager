﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Entities
{
    public sealed class ProdutoVenda: Entity
    {
        public int QuantidadeVendida { get; private set; }
        public double PrecoPorUnidade { get; private set; }
        public int ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public int VendaId { get; private set; }
        public Venda Venda { get; private set; }

        public double PrecoTotal => QuantidadeVendida * PrecoPorUnidade;

    }
}
