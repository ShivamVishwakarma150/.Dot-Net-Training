using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApartmentMaintenanceCalculator.Models
{
    public partial class ApartmentMaintenanceCalculatorContext : DbContext
    {
        public ApartmentMaintenanceCalculatorContext()
        {
        }

        public ApartmentMaintenanceCalculatorContext(DbContextOptions<ApartmentMaintenanceCalculatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblApartmentInformation> TblApartmentInformation { get; set; }
        public virtual DbSet<TblTenantInformation> TblTenantInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VF0EORP; Database=ApartmentMaintenanceCalculator; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblApartmentInformation>(entity =>
            {
                entity.HasKey(e => e.ApartmentNumber)
                    .HasName("PK__tblApart__C75B2DDFA1E2D238");

                entity.ToTable("tblApartmentInformation");

                entity.Property(e => e.ApartmentNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlatNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TenantAdhaarNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TenantAdhaarNumberNavigation)
                    .WithMany(p => p.TblApartmentInformation)
                    .HasForeignKey(d => d.TenantAdhaarNumber)
                    .HasConstraintName("FK__tblApartm__Tenan__267ABA7A");
            });

            modelBuilder.Entity<TblTenantInformation>(entity =>
            {
                entity.HasKey(e => e.AdhaarNumber)
                    .HasName("PK__tblTenan__00897230F31FD74C");

                entity.ToTable("tblTenantInformation");

                entity.Property(e => e.AdhaarNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OccupantName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
