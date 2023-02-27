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
    public class AtendimentoMapeamento : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.DataInclusao).IsRequired().HasColumnType("datetime");
            builder.Property(a => a.DataUltimaAtualizacao).IsRequired().HasColumnType("datetime");
            builder.Property(a => a.DataAgendamento).IsRequired().HasColumnType("datetime");

            builder.HasOne(a => a.TipoStatusAtendimento).WithMany(p => p.Atendimentos);
            builder.HasOne(a => a.TipoAtendimento).WithMany(p => p.Atendimentos);
            builder.HasOne(a => a.Paciente).WithMany(p => p.Atendimentos);

            builder.HasMany(a => a.Profissionais).WithMany(p => p.Atendimentos);

        }
    }
}
