using Embagel.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Embagel.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Vendedor> Vendedores { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
