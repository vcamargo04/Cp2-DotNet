﻿// <auto-generated />
using System;
using Cp2_DotNet.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cp2_DotNet.Migrations
{
    [DbContext(typeof(FIAPDbContext))]
    [Migration("20240424231638_AttPediatra")]
    partial class AttPediatra
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cp2_DotNet.Models.COREN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("tb_coren");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.CRM", b =>
                {
                    b.Property<int>("CRMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CRMId"));

                    b.Property<int>("CirurgiaoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PediatraId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CRMId");

                    b.HasIndex("CirurgiaoId");

                    b.HasIndex("PediatraId")
                        .IsUnique();

                    b.ToTable("tb_crm");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Cirurgiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CRMId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.HasIndex("CRMId");

                    b.ToTable("tb_cirurgioes");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.ClinicoGeral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CRMId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.HasIndex("CRMId");

                    b.ToTable("tb_clinicosGerais");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClinicoGeralId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicoGeralId");

                    b.HasIndex("PacienteId");

                    b.ToTable("tb_consultas");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Enfermeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CORENId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.HasIndex("CORENId");

                    b.ToTable("tb_enfermeiros");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("NVARCHAR2(11)");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.ToTable("tb_pacientes");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Pediatra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CRMId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.ToTable("tb_pediatras");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.CRM", b =>
                {
                    b.HasOne("Cp2_DotNet.Models.Cirurgiao", "Cirurgiao")
                        .WithMany()
                        .HasForeignKey("CirurgiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cp2_DotNet.Models.Pediatra", "Pediatra")
                        .WithOne("CRM")
                        .HasForeignKey("Cp2_DotNet.Models.CRM", "PediatraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cirurgiao");

                    b.Navigation("Pediatra");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Cirurgiao", b =>
                {
                    b.HasOne("Cp2_DotNet.Models.CRM", "CRM")
                        .WithMany()
                        .HasForeignKey("CRMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CRM");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.ClinicoGeral", b =>
                {
                    b.HasOne("Cp2_DotNet.Models.CRM", "CRM")
                        .WithMany()
                        .HasForeignKey("CRMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CRM");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Consulta", b =>
                {
                    b.HasOne("Cp2_DotNet.Models.ClinicoGeral", "ClinicoGeral")
                        .WithMany()
                        .HasForeignKey("ClinicoGeralId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cp2_DotNet.Models.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId");

                    b.Navigation("ClinicoGeral");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Enfermeiro", b =>
                {
                    b.HasOne("Cp2_DotNet.Models.COREN", "COREN")
                        .WithMany("Enfermeiros")
                        .HasForeignKey("CORENId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("COREN");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.COREN", b =>
                {
                    b.Navigation("Enfermeiros");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Cp2_DotNet.Models.Pediatra", b =>
                {
                    b.Navigation("CRM");
                });
#pragma warning restore 612, 618
        }
    }
}
