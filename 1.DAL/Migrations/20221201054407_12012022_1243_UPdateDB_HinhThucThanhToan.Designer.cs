﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(FpolyDBContext))]
    [Migration("20221201054407_12012022_1243_UPdateDB_HinhThucThanhToan")]
    partial class _12012022_1243_UPdateDB_HinhThucThanhToan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.DomainClass.Anh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DuongDan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("duongDan");

                    b.Property<string>("MaAnh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("maAnh");

                    b.Property<string>("TenAnh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenAnh");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trangThai");

                    b.HasKey("Id");

                    b.ToTable("Anh");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IX_ChatLieu");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<int?>("GiaBan")
                        .HasColumnType("int");

                    b.Property<int?>("GiaNhap")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdAnh")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idAnh");

                    b.Property<Guid?>("IdChatLieu")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idChatLieu");

                    b.Property<Guid?>("IdDeGiay")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idDeGiay");

                    b.Property<Guid?>("IdKieuDang")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idKieuDang");

                    b.Property<Guid?>("IdMauSac")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idMauSac");

                    b.Property<Guid?>("IdNsx")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idNSX");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idSanPham");

                    b.Property<Guid?>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAnh");

                    b.HasIndex("IdChatLieu");

                    b.HasIndex("IdDeGiay");

                    b.HasIndex("IdKieuDang");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSanPham");

                    b.HasIndex("IdSize");

                    b.ToTable("ChiTietGiay");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietKhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid?>("IdChiTietGiay")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idChiTietGiay");

                    b.Property<Guid?>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idKhuyenMai");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietGiay");

                    b.HasIndex("IdKhuyenMai");

                    b.ToTable("ChiTietKhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.DeGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ChatLieu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ChieuCao")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeGiay");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HinhThucThanhToan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<int>("IdHoaDon")
                        .HasColumnType("int");

                    b.Property<int?>("LoaiHinhThanhToan")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NgaySua")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasMaxLength(50)
                        .HasColumnType("date");

                    b.Property<decimal?>("TongTienThanhToan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HinhThucThanhToan");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GiamGia")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("IdKhachHang")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idKhachHang");

                    b.Property<Guid?>("IdNhanVien")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idNhanVien");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idSanPham");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayNhanHang")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayTraHang")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenNguoiNhan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenSp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenSP");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.HasIndex("IdSanPham");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<decimal?>("DonGia")
                        .HasColumnType("decimal(18,0)");

                    b.Property<Guid?>("IdChiTietGiay")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idChiTietGiay");

                    b.Property<int>("IdHoaDon")
                        .HasColumnType("int")
                        .HasColumnName("idHoaDon");

                    b.Property<Guid?>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idKhuyenMai");

                    b.Property<Guid?>("IdTichDiem")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idTichDIem");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietGiay");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("QuocGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mota")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KieuDang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KieuDang");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("GioiTInh");

                    b.Property<string>("Ho")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date")
                        .HasColumnName("NgaySInh");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SDT");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDem")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NSX");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Ma")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietGiay", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.Anh", "IdAnhNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdAnh");

                    b.HasOne("_1.DAL.DomainClass.ChatLieu", "IdChatLieuNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdChatLieu");

                    b.HasOne("_1.DAL.DomainClass.DeGiay", "IdDeGiayNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdDeGiay");

                    b.HasOne("_1.DAL.DomainClass.KieuDang", "IdKieuDangNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdKieuDang");

                    b.HasOne("_1.DAL.DomainClass.MauSac", "IdMauSacNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdMauSac");

                    b.HasOne("_1.DAL.DomainClass.Nsx", "IdNsxNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdNsx");

                    b.HasOne("_1.DAL.DomainClass.SanPham", "IdSanPhamNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdSanPham");

                    b.HasOne("_1.DAL.DomainClass.Size", "IdSizeNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdSize");

                    b.Navigation("IdAnhNavigation");

                    b.Navigation("IdChatLieuNavigation");

                    b.Navigation("IdDeGiayNavigation");

                    b.Navigation("IdKieuDangNavigation");

                    b.Navigation("IdMauSacNavigation");

                    b.Navigation("IdNsxNavigation");

                    b.Navigation("IdSanPhamNavigation");

                    b.Navigation("IdSizeNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietKhuyenMai", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietGiay", "IdChiTietGiayNavigation")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IdChiTietGiay");

                    b.HasOne("_1.DAL.DomainClass.KhuyenMai", "IdKhuyenMaiNavigation")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IdKhuyenMai");

                    b.Navigation("IdChiTietGiayNavigation");

                    b.Navigation("IdKhuyenMaiNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HinhThucThanhToan", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HinhThucThanhToans")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.KhachHang", "IdKhachHangNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang");

                    b.HasOne("_1.DAL.DomainClass.NhanVien", "IdNhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien");

                    b.HasOne("_1.DAL.DomainClass.SanPham", "IdSanPhamNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("IdKhachHangNavigation");

                    b.Navigation("IdNhanVienNavigation");

                    b.Navigation("IdSanPhamNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChiTietGiay", "IdChiTietGiayNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietGiay");

                    b.HasOne("_1.DAL.DomainClass.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdChiTietGiayNavigation");

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.ChucVu", "IdChucVuNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdChucVu");

                    b.Navigation("IdChucVuNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Anh", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChatLieu", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChiTietGiay", b =>
                {
                    b.Navigation("ChiTietKhuyenMais");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.DeGiay", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.Navigation("HinhThucThanhToans");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietKhuyenMais");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KieuDang", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.MauSac", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Nsx", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.Navigation("ChiTietGiays");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Size", b =>
                {
                    b.Navigation("ChiTietGiays");
                });
#pragma warning restore 612, 618
        }
    }
}