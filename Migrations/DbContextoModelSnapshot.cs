﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc_entity.Servicos;

namespace mvc_entity.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mvc_entity.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cidade")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("cidade");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("Datetime")
                        .HasColumnName("Data/Nascimento");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Rua")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("rua");

                    b.Property<string>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("telefone");

                    b.Property<string>("numero")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("numero");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}