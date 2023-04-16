using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnTapKiemTra2.Models
{
    public partial class SQL_SinhVienContext : DbContext
    {
        public SQL_SinhVienContext()
        {
        }

        public SQL_SinhVienContext(DbContextOptions<SQL_SinhVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sinhvien> Sinhviens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-517BT7F\\SQLEXPRESS; Database=SQL_SinhVien; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.HasKey(e => e.Msv);

                entity.ToTable("SINHVIEN");

                entity.Property(e => e.Msv)
                    .HasMaxLength(50)
                    .HasColumnName("MSV");

                entity.Property(e => e.Lop).HasMaxLength(50);

                entity.Property(e => e.TenSinhVien).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
