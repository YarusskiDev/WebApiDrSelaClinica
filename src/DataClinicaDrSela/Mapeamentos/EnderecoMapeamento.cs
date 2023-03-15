using BusinessClinicaDrSela.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClinicaDrSela.Mapeamentos
{
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(e => e.Uf).IsRequired().HasColumnType("varchar(2)");
            builder.Property(e => e.Cidade).IsRequired().HasColumnType("varchar(30)");
            builder.Property(e => e.Bairro).IsRequired().HasColumnType("varchar(40)");
            builder.Property(e => e.Rua).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Complemento).IsRequired(false).HasColumnType("varchar(300)");
            builder.Property(e => e.Cep).IsRequired().HasColumnType("varchar(20)");
            builder.Property(e => e.Numero).IsRequired().HasColumnType("int");
        }
    }
}
