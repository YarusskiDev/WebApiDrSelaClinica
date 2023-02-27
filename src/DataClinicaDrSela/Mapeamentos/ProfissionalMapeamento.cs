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
    public class ProfissionalMapeamento : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).HasColumnType("varchar(500)");
        }
    }
}
