using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommers.Models
{
    public class PedidoItem
    {
        public int CodigoPedidoItem { get; set; }

        public int CodigoProduto { get; set; }

        public float Preco { get; set; }

        public int Quantidade { get; set; }
    }
}
