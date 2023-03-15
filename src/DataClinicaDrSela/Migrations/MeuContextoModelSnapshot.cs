﻿// <auto-generated />
using System;
using DataClinicaDrSela.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataClinicaDrSela.Migrations
{
    [DbContext(typeof(MeuContexto))]
    partial class MeuContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("AtendimentoProfissional", b =>
                {
                    b.Property<int>("AtendimentosId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfissionaisId")
                        .HasColumnType("integer");

                    b.HasKey("AtendimentosId", "ProfissionaisId");

                    b.HasIndex("ProfissionaisId");

                    b.ToTable("AtendimentoProfissional");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("timestamp");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("integer");

                    b.Property<int>("IdTipoAtendimento")
                        .HasColumnType("integer");

                    b.Property<int>("IdTipoStatus")
                        .HasColumnType("integer");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoAtendimentoId")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoStatusAtendimentoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TipoAtendimentoId");

                    b.HasIndex("TipoStatusAtendimentoId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa")
                        .IsUnique();

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NomeDaMae")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NomeDoPai")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Rg")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa")
                        .IsUnique();

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.TipoAtendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("TipoAtendimentos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.TipoStatusAtendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TipoStatusAtendimentos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AtendimentoProfissional", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Atendimento", null)
                        .WithMany()
                        .HasForeignKey("AtendimentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessClinicaDrSela.Modelos.Profissional", null)
                        .WithMany()
                        .HasForeignKey("ProfissionaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Atendimento", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Paciente", "Paciente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("PacienteId");

                    b.HasOne("BusinessClinicaDrSela.Modelos.TipoAtendimento", "TipoAtendimento")
                        .WithMany("Atendimentos")
                        .HasForeignKey("TipoAtendimentoId");

                    b.HasOne("BusinessClinicaDrSela.Modelos.TipoStatusAtendimento", "TipoStatusAtendimento")
                        .WithMany("Atendimentos")
                        .HasForeignKey("TipoStatusAtendimentoId");

                    b.Navigation("Paciente");

                    b.Navigation("TipoAtendimento");

                    b.Navigation("TipoStatusAtendimento");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Endereco", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("BusinessClinicaDrSela.Modelos.Endereco", "IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Paciente", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Pessoa", "Pessoa")
                        .WithOne("Paciente")
                        .HasForeignKey("BusinessClinicaDrSela.Modelos.Paciente", "IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Profissional", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Pessoa", "Pessoa")
                        .WithOne("Profissional")
                        .HasForeignKey("BusinessClinicaDrSela.Modelos.Profissional", "IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Usuario", b =>
                {
                    b.HasOne("BusinessClinicaDrSela.Modelos.Pessoa", "Pessoa")
                        .WithOne("Usuario")
                        .HasForeignKey("BusinessClinicaDrSela.Modelos.Usuario", "IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Paciente", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.Pessoa", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Paciente");

                    b.Navigation("Profissional");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.TipoAtendimento", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("BusinessClinicaDrSela.Modelos.TipoStatusAtendimento", b =>
                {
                    b.Navigation("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
