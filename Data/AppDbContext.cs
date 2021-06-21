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

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(p => p.nome)
                    .HasMaxLength(50);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.nacionalidade)
                    .HasMaxLength(20);

            modelBuilder.Entity<Cliente>()
                .HasData(
                    new Cliente
                    {
                        Id = 1,
                        nome = "Joao Silva",
                        rg = 521854225,
                        cpf = 88554522274,
                        sexo = "M",
                        nascimento = DateTime.Now,
                        nacionalidade = "Brasileiro",
                        altura = 00175,
                        dataCadastro = DateTime.Now,
                        ativo = "S"
                    },

                    new Cliente
                    {
                        Id = 1,
                        nome = "Aline Dias",
                        rg = 845625874,
                        cpf = 37409703830,
                        sexo = "M",
                        nascimento = DateTime.Now,
                        nacionalidade = "Brasileiro",
                        altura = 00175,
                        dataCadastro = DateTime.Now,
                        ativo = "S"
                    },

                    new Cliente
                    {
                        Id = 1,
                        nome = "Marcio Souza",
                        rg = 416499089,
                        cpf = 33355577741,
                        sexo = "M",
                        nascimento = DateTime.Now,
                        nacionalidade = "Brasileiro",
                        altura = 00175,
                        dataCadastro = DateTime.Now,
                        ativo = "S"
                    }
                );
        }
    }
}
