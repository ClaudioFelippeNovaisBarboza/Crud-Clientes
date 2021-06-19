using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Crud_Clientes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Descricao)
                    .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { Id = 1, Descricao = "Caderno", Estoque = 4, Preco = 7.12M },
                    new Produto { Id = 2, Descricao = "Lapis", Estoque = 4, Preco = 7.12M },
                    new Produto { Id = 3, Descricao = "Estojo", Estoque = 4, Preco = 7.12M },
                    new Produto { Id = 4, Descricao = "Borracha", Estoque = 4, Preco = 7.12M },
                    new Produto { Id = 5, Descricao = "Apontador", Estoque = 4, Preco = 7.12M }
                );
        }
    }
}
