﻿// <auto-generated />
using Contexto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contexto.Migrations
{
    [DbContext(typeof(SistemaContext))]
    partial class SistemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Contexto.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cepId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("primeiroNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexoIdM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            id = 1,
                            cepId = "12345",
                            cidade = "cidade nv",
                            complemento = "compl",
                            email = "teste@teste.com",
                            endereco = "end",
                            estado = "rj",
                            nomeCompleto = "nm completo",
                            numero = 1,
                            primeiroNome = "primeiro nm",
                            senha = "123",
                            sexoIdM = "M"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
