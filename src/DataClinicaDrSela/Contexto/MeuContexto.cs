using BusinessClinicaDrSela.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClinicaDrSela.Contexto
{
    public class MeuContexto:DbContext
    {
        public MeuContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuContexto).Assembly);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<TipoAtendimento> TipoAtendimentos { get; set; }
        public DbSet<TipoStatusAtendimento> TipoStatusAtendimentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
