using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Mapeamentos
{
    class CarroMapeamento : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataEntrada).IsRequired();

           

            builder.Property(p => p.Ano).IsRequired();

            builder.Property(p => p.Placa).IsRequired();

            builder.Property(p => p.Status).HasColumnType("varchar(50)").IsRequired();

            builder.HasMany(p => p.Clientes)
               .WithOne(c => c.Carro)
               .HasForeignKey(p => p.EnderecoId);

            builder.ToTable("Carros");

           
        }
    }
}
