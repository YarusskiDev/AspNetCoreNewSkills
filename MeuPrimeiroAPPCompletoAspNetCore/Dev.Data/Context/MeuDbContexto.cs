using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev.Business.Models;

namespace Dev.Data.Context
{
    public class MeuDbContexto:DbContext
    {
        public MeuDbContexto( DbContextOptions<MeuDbContexto> options): base(options)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //        .Where(p => p.ClrType == typeof(string))))
            //    property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContexto).Assembly);

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Concessionaria> Concessionarias { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}
