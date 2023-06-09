﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MostWanted.Repository.Context;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MostWanted.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230520140743_Procurado")]
    partial class Procurado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MostWasted.Models.ProcuradoModel", b =>
                {
                    b.Property<int>("ProcuradoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcuradoId"));

                    b.Property<string>("Acusacao")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CorCabelo")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CorOlhos")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DescricaoCorporal")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DescricaoRosto")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("FotoProcurado")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Idade")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LinguaFalada")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LugarNascimento")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NomeAgencia")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NomeProcurado")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Raca")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Recompensa")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Sexo")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ProcuradoId");

                    b.ToTable("Procurado");
                });
#pragma warning restore 612, 618
        }
    }
}
