using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommers.Models
{
    public class Pedido
    {
        public int CodigodoProduto { get; set; }

        public DateTime Datasolicitacao { get; set; }

        public int FlagPago { get; set; }

        public float TotalPedido { get; set; }

        public int CodigodoCliente { get; set; }
    }
}
