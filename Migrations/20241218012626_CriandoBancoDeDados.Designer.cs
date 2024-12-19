﻿// <auto-generated />
using API_Cadastro_e_Gerenciamento_de_Clientes.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241218012626_CriandoBancoDeDados")]
    partial class CriandoBancoDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core.ContaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Saldo")
                        .HasColumnType("real");

                    b.Property<int>("TitularId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitularId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core.ContaModel", b =>
                {
                    b.HasOne("API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core.ClienteModel", "Titular")
                        .WithMany()
                        .HasForeignKey("TitularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Titular");
                });
#pragma warning restore 612, 618
        }
    }
}
