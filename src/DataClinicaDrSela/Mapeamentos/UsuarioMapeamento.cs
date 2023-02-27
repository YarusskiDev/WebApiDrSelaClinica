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
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(u => u.Nome).IsRequired().HasColumnType("varchar(200)");
            builder.Property(u => u.Email).IsRequired().HasColumnType("varchar(200)");
            builder.Property(u => u.Telefone).IsRequired().HasColumnType("varchar(40)");
            builder.Property(u => u.Senha).IsRequired().HasColumnType("varchar(50)");

            builder.HasOne(u => u.Pessoa).WithOne(p => p.Usuario).HasForeignKey<Usuario>(f => f.IdPessoa); // perguntar pro gordo qual a garantia que estou criando na classe correta
        }
    }
}
