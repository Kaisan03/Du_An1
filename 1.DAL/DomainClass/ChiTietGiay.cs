using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class ChiTietGiay
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public Guid? IdSize { get; set; }
        public Guid? IdNsx { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdChatLieu { get; set; }
        public Guid? IdKieuDang { get; set; }
        public int? SoLuong { get; set; }
        public string MaVach { get; set; }
        public int? GiaNhap { get; set; }
        public int? GiaBan { get; set; }
        public int? SoLuongTon { get; set; }
        public int? TrangThai { get; set; }
        public string MoTa { get; set; }
        public Guid? IdSanPham { get; set; }
        public Guid? IdDeGiay { get; set; }
        public Guid? IdAnh { get; set; }
        public virtual Anh IdAnhNavigation { get; set; }
        public virtual ChatLieu IdChatLieuNavigation { get; set; }
        public virtual DeGiay IdDeGiayNavigation { get; set; }
        public virtual KieuDang IdKieuDangNavigation { get; set; }
        public virtual MauSac IdMauSacNavigation { get; set; }
        public virtual Nsx IdNsxNavigation { get; set; }
        public virtual SanPham IdSanPhamNavigation { get; set; }
        public virtual Size IdSizeNavigation { get; set; }
        public virtual List<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
