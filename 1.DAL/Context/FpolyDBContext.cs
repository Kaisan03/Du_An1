﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public class FpolyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionBuilder)
        {
            OptionBuilder.UseSqlServer("Data Source=LAPTOP-46F72MJA\\SQLEXPRESS;Initial Catalog=Duan11;Persist Security Info=True;User ID=duyvtph24890;Password=123456");
        }

        public  DbSet<Anh> Anhs { get; set; }
        public  DbSet<ChatLieu> ChatLieus { get; set; }
        public  DbSet<ChiTietGiay> ChiTietGiays { get; set; }
        public  DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public  DbSet<ChucVu> ChucVus { get; set; }
        public  DbSet<DeGiay> DeGiays { get; set; }
        public  DbSet<HoaDon> HoaDons { get; set; }
        public  DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public  DbSet<KhachHang> KhachHangs { get; set; }
        public  DbSet<KhuyenMai> KhuyenMais { get; set; }
        public  DbSet<KieuDang> KieuDangs { get; set; }
        public  DbSet<MauSac> MauSacs { get; set; }
        public  DbSet<NhanVien> NhanViens { get; set; }
        public  DbSet<Nsx> Nsxes { get; set; }
        public  DbSet<SanPham> SanPhams { get; set; }
        public  DbSet<Size> Sizes { get; set; }
        public  DbSet<GiaoCa> GiaoCas { get; set; }
    }
}

