using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ecommers.Models.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<ecommers.Models.Clientes> Clientes { get; set; }

        public DbSet<ecommers.Models.Pedido> Pedidos { get; set; }

        public DbSet<ecommers.Models.PedidoItem> PedidoItem { get; set; }

        public DbSet<ecommers.Models.TipoPessoa> TipoPessoas { get; set; }

        public DbSet<ecommers.Models.Produtos> Produtos { get; set; }


    }
}
