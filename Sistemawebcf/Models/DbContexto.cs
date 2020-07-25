using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemawebcf.Models
{
    public class DbContexto: DbContext
    {
        public DbContexto()
        {

        }
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity => {
                entity.ToTable("categoria");
                entity.HasKey(e => e.idcategoria);
                entity.Property(e => e.idcategoria).HasColumnName("idcategoria");
                
                entity.Property(e => e.nombre)
                    .HasColumnName("nombre")
                    .IsRequired()                    
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<Producto>(entity => {
                entity.ToTable("producto");
                entity.HasKey(e => e.idproducto);
                entity.Property(e => e.idproducto).HasColumnName("idproducto");

                entity.Property(e => e.idcategoria).HasColumnName("idcategoria");

                entity.Property(e => e.codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.nombre)
                    .HasColumnName("nombre")
                    .IsRequired()                    
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.HasIndex(e => e.nombre)
                    .IsUnique();

                entity.Property(e => e.precio_venta)
                    .HasColumnName("precio_venta")
                    .IsRequired()                    
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.stock)
                    .HasColumnName("stock")
                    .IsRequired();

                entity.Property(e => e.descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(p => p.categoria)
                    .WithMany(c => c.productos)
                    .HasForeignKey(p => p.idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_categoria");
            });
        }
    }
}
