using System;
using System.Reflection;
using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _1.DAL.Context
{
    public class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {

        }
        public FpolyDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Anh> Anhs { get; set; }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<ChiTietGiay> ChiTietGiays { get; set; }
        public DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DeGiay> DeGiays { get; set; }
        public DbSet<GiaoCa> GiaoCas { get; set; }
        public DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<KieuDang> KieuDangs { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Nsx> Nsxes { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<Size> Sizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-46F72MJA\SQLEXPRESS;Initial Catalog=DUAN1;User ID=sa;Password=azx1azx1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

