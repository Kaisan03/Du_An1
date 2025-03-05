using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class HoaDon
    {
        public int Id { get; set; }
        public Guid? IdKhachHang { get; set; }
        public int? IdCa { get; set; } 
        public Guid? IdNhanVien { get; set; }
        public string Ma { get; set; }
        public string TenSp { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string GiamGia { get; set; }
        public string GhiChu { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? TienShip { get; set; }
        public decimal? TienCoc { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? TienMat { get; set; }
        public decimal? ChuyenKhoan { get; set; }
        public int? TrangThai { get; set; }
        public Guid? IdSanPham { get; set; }
        public DateTime? NgayNhanHang { get; set; }
        public DateTime? NgayTraHang { get; set; }
        public virtual GiaoCa IdCaNavigation { get; set; }
        public virtual KhachHang IdKhachHangNavigation { get; set; }
        public virtual NhanVien IdNhanVienNavigation { get; set; }
        public virtual SanPham IdSanPhamNavigation { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual List<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        
    }
}
