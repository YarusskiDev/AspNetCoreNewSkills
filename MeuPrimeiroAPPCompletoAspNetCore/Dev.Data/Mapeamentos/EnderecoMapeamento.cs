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
    class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Bairro).IsRequired();

            builder.Property(p => p.Cidade).IsRequired(false);

            builder.Property(p => p.Rua).IsRequired();

            builder.Property(p => p.Numero).IsRequired();

            builder.Property(p => p.Estado).HasColumnType("varchar(50)").IsRequired();

            builder.ToTable("Endereco");
        }

       
    }
}
