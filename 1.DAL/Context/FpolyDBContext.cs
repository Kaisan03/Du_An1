using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChiTietGiay> ChiTietGiays { get; set; }
        public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DeGiay> DeGiays { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<KieuDang> KieuDangs { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Nsx> Nsxes { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-OF-KHAI\\SQLEXPRESS;Initial Catalog=Duan1;Persist Security Info=True;User ID=khainq03;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Anh>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaAnh).IsUnicode(false);

                entity.Property(e => e.TenAnh).IsUnicode(false);
            });

            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<ChiTietGiay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);

                entity.HasOne(d => d.IdAnhNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdAnh)
                    .HasConstraintName("FK_ChiTietGiay_Anh");

                entity.HasOne(d => d.IdChatLieuNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdChatLieu)
                    .HasConstraintName("FK_ChiTietGiay_ChatLieu");

                entity.HasOne(d => d.IdDeGiayNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdDeGiay)
                    .HasConstraintName("FK_ChiTietGiay_DeGiay");

                entity.HasOne(d => d.IdKieuDangNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdKieuDang)
                    .HasConstraintName("FK_ChiTietGiay_KieuDang");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK_ChiTietGiay_MauSac");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK_ChiTietGiay_NSX");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK_ChiTietGiay_SanPham");

                entity.HasOne(d => d.IdSizeNavigation)
                    .WithMany(p => p.ChiTietGiays)
                    .HasForeignKey(d => d.IdSize)
                    .HasConstraintName("FK_ChiTietGiay_Size");
            });

            modelBuilder.Entity<ChiTietKhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdChiTietGiayNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdChiTietGiay)
                    .HasConstraintName("FK_ChiTietKhuyenMai_ChiIietGiay");

                entity.HasOne(d => d.IdKhuyenMaiNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdKhuyenMai)
                    .HasConstraintName("FK_ChiTietKhuyenMai_KhuyenMai");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<DeGiay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TenNguoiNhan).IsUnicode(false);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.IdKhachHang)
                    .HasConstraintName("FK_GioHangKhachHang");
            });

            modelBuilder.Entity<GioHangChiTiet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdChiTietGiayNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdChiTietGiay)
                    .HasConstraintName("FK_GioHangChiTiet_ChiTietGiay");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.GioHangChiTiets)
                    .HasForeignKey(d => d.IdGioHang)
                    .HasConstraintName("FK_GioHangChiTiet");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GiamGia).IsFixedLength(true);

                entity.Property(e => e.Ma).IsFixedLength(true);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhachHang)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("FK_HoaDon_NhanVien");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdSanPham)
                    .HasConstraintName("FK_HoaDon_SanPham");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdChiTietGiayNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietGiay)
                    .HasConstraintName("FK_HoaDonChiTiet_ChiTietGiay");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK_HoaDonChiTiet_HoaDon");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<KieuDang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);

                entity.HasOne(d => d.IdChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdChucVu)
                    .HasConstraintName("FK_NhanVien_ChucVu");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ma).IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
