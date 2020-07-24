using Microsoft.EntityFrameworkCore;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.ObjetoDeValor;
using LojaVirtual.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Contexto
{
    public class LojaVirtualContexto : DbContext
    {
        public LojaVirtualContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>()
                .HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de Pagamento Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Credito",
                    Descricao = "Forma de Pagamento Cartão de Credito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de Pagamento Depósito"
                }

                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
