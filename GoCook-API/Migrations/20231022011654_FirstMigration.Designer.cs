﻿// <auto-generated />
using GoCook_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoCook_API.Migrations
{
    [DbContext(typeof(GoCookDbContext))]
    [Migration("20231022011654_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoCook_API.Model.Ingrediente", b =>
                {
                    b.Property<int>("Cd_Ingrediente")
                        .HasColumnType("int");

                    b.Property<int>("Cd_Receita")
                        .HasColumnType("int");

                    b.Property<string>("Nm_Ingrediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qt_Ingrediente")
                        .HasColumnType("int");

                    b.HasKey("Cd_Ingrediente", "Cd_Receita");

                    b.HasIndex("Cd_Receita");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("GoCook_API.Model.Receita", b =>
                {
                    b.Property<int>("Cd_Receita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cd_Receita"));

                    b.Property<int>("Cd_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Ds_ModoPreparo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nm_Receita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qt_PessoasServidas")
                        .HasColumnType("int");

                    b.Property<int>("Qt_TempoPreparo")
                        .HasColumnType("int");

                    b.HasKey("Cd_Receita");

                    b.HasIndex("Cd_Usuario");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("GoCook_API.Model.Usuario", b =>
                {
                    b.Property<int>("Cd_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cd_Usuario"));

                    b.Property<string>("Ds_Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nm_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nm_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cd_Usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GoCook_API.Model.Ingrediente", b =>
                {
                    b.HasOne("GoCook_API.Model.Receita", "Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("Cd_Receita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("GoCook_API.Model.Receita", b =>
                {
                    b.HasOne("GoCook_API.Model.Usuario", "Usuario")
                        .WithMany("Receitas")
                        .HasForeignKey("Cd_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GoCook_API.Model.Receita", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("GoCook_API.Model.Usuario", b =>
                {
                    b.Navigation("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
