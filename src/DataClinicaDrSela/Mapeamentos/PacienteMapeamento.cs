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
    public class PacienteMapeamento : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Pessoa).WithOne(e => e.Paciente).HasForeignKey<Paciente>(p => p.IdPessoa);
        }
    }
}
