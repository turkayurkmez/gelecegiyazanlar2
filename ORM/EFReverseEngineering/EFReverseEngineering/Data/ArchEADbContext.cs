using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFReverseEngineering.Models;

#nullable disable

namespace EFReverseEngineering.Data
{
    public partial class ArchEADbContext : DbContext
    {
        public ArchEADbContext()
        {
        }

        public ArchEADbContext(DbContextOptions<ArchEADbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ArchEADb");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<Category>(entity =>
        //    {
        //        entity.Property(e => e.Name).IsRequired();
        //    });

        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

        //        entity.HasOne(d => d.Category)
        //            .WithMany(p => p.Products)
        //            .HasForeignKey(d => d.CategoryId)
        //            .OnDelete(DeleteBehavior.ClientSetNull);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
