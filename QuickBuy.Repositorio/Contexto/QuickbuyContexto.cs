using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetodeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
   public class QuickbuyContexto: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Itempedido> Itempedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }


        public QuickbuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /// classe de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
