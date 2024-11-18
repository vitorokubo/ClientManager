using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Domain.Entities
{
    public sealed class Produto : Entity
    {
        public string Name { get; private set; }
        public string Descricao { get; private set; }
        public int Estoque {  get; private set; }

    }
}
