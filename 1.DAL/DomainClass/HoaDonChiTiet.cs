using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdChiTietGiay { get; set; }
        public int IdHoaDon { get; set; }
        public Guid? IdTichDiem { get; set; }
        public Guid? IdKhuyenMai { get; set; }
        public int? SoLuong { get; set; }
        public int? TrangThai { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public virtual ChiTietGiay IdChiTietGiayNavigation { get; set; }
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}
