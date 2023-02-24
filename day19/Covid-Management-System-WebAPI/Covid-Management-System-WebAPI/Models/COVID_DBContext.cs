using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Covid_Management_System_WebAPI.Models
{
    public partial class COVID_DBContext : DbContext
    {
        public COVID_DBContext()
        {
        }

        public COVID_DBContext(DbContextOptions<COVID_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VF0EORP;Database='COVID_DB'; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("DEVICE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
                entity.HasQueryFilter(t => t.IsActive == true);
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.PatientInfo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PATIENT_INFO");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DEVICE__PATIENT___267ABA7A");
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.ToTable("NURSE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
                entity.HasQueryFilter(t => t.IsActive == true);
                entity.Property(e => e.Mobile).HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Nurses)
                    .HasForeignKey(d => d.DeviceId)
                    .HasConstraintName("FK__NURSE__DEVICE_ID__2A4B4B5E");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Nurses)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__NURSE__PATIENT_I__29572725");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("PATIENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
                entity.HasQueryFilter(t => t.IsActive == true);
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Mobile).HasColumnName("MOBILE");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
