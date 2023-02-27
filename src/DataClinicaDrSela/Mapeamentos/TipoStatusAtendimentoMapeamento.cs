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
    public class TipoStatusAtendimentoMapeamento : IEntityTypeConfiguration<TipoStatusAtendimento>
    {
        public void Configure(EntityTypeBuilder<TipoStatusAtendimento> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao).IsRequired().HasColumnType("varchar(20)");

        }
    }
}
