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
    public class PessoaMapeamento : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.Cpf).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Telefone).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.NomeDaMae).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.NomeDoPai).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.Rg).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.DataNascimento).HasColumnType("date").IsRequired();
            builder.Property(p => p.Imagem).HasColumnType("varchar(200)").IsRequired(false);


            builder.HasOne(p => p.Endereco).WithOne(e => e.Pessoa).HasForeignKey<Endereco>(e => e.IdPessoa);
            builder.HasOne(p => p.Profissional).WithOne(e => e.Pessoa).HasForeignKey<Profissional>(e => e.IdPessoa) ;
            builder.HasOne(p => p.Paciente).WithOne(e => e.Pessoa);
            builder.HasOne(p => p.Usuario).WithOne(e => e.Pessoa);

        }
    }
}
