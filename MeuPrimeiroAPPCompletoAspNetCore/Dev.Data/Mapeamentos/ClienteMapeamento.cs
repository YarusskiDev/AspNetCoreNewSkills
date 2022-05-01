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
    class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Cpf).IsRequired();

            builder.Property(p => p.Nome).IsRequired(false);

            builder.Property(p => p.Telefone).IsRequired();

            builder.HasOne(e => e.Endereco)
                .WithOne(c => c.Cliente);

            builder.ToTable("Clientes");


        }

    }
}
