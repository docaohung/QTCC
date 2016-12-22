namespace QTCC_QuanLyBenhVien.Model.DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLBenhVienDBContext : DbContext
    {
        public QLBenhVienDBContext()
            : base("name=QLBenhVienDBContext")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<LichSuKhamBenh> LichSuKhamBenhs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.LichSuKhamBenhs)
                .WithRequired(e => e.BenhNhan)
                .WillCascadeOnDelete(false);
        }
    }
}
