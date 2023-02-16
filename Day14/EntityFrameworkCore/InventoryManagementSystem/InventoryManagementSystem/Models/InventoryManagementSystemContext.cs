using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventoryManagementSystem.Models
{
    public partial class InventoryManagementSystemContext : DbContext
    {
        public InventoryManagementSystemContext()
        {
        }

        public InventoryManagementSystemContext(DbContextOptions<InventoryManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VF0EORP;Database='Inventory Management System'; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PK__PRODUCT___B40F3AA5997DDB8C");

                entity.ToTable("PRODUCT_MASTER");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("TRANSACTION");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TansactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__TRANSACTI__Produ__412EB0B6");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__TRANSACTI__Updat__4222D4EF");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__USERS__1788CCACBBE2C324");

                entity.ToTable("USERS");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Admin')");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("userEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
