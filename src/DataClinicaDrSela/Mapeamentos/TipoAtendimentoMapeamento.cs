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
    public class TipoAtendimentoMapeamento : IEntityTypeConfiguration<TipoAtendimento>
    {
        public void Configure(EntityTypeBuilder<TipoAtendimento> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao).HasColumnType("varchar(500)").IsRequired();
            builder.HasMany(t => t.Atendimentos).WithOne(t => t.TipoAtendimento);
        }
    }
}
