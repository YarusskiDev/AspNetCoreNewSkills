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
    class ConcessionariaMapeamento : IEntityTypeConfiguration<Concessionaria>
    {
        public void Configure(EntityTypeBuilder<Concessionaria> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("varchar(50)").IsRequired();


            builder.HasMany(p => p.Carro_EF)
               .WithOne(c => c.Concessionaria_EF);


            builder.ToTable("Concessionaria");
        }
    }
}
