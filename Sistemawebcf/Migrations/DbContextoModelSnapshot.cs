﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistemawebcf.Models;

namespace Sistemawebcf.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistemawebcf.Models.Categoria", b =>
                {
                    b.Property<int>("idcategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idcategoria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("idcategoria");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("Sistemawebcf.Models.Producto", b =>
                {
                    b.Property<int>("idproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idproducto")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo")
                        .HasColumnName("codigo")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("descripcion")
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("idcategoria")
                        .HasColumnName("idcategoria");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal>("precio_venta")
                        .HasColumnName("precio_venta")
                        .HasColumnType("decimal(11, 2)");

                    b.Property<int>("stock")
                        .HasColumnName("stock");

                    b.HasKey("idproducto");

                    b.HasIndex("idcategoria");

                    b.HasIndex("nombre")
                        .IsUnique();

                    b.ToTable("producto");
                });

            modelBuilder.Entity("Sistemawebcf.Models.Producto", b =>
                {
                    b.HasOne("Sistemawebcf.Models.Categoria", "categoria")
                        .WithMany("productos")
                        .HasForeignKey("idcategoria")
                        .HasConstraintName("FK_producto_categoria")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}