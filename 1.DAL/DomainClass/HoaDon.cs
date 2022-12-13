using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            HinhThucThanhToans = new HashSet<HinhThucThanhToan>();
         
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idKhachHang")]
        public Guid? IdKhachHang { get; set; }
        public int? IdCa { get; set; } 
        [Column("idNhanVien")]
        public Guid? IdNhanVien { get; set; }
        [StringLength(10)]
        public string Ma { get; set; }
        [Column("TenSP")]
        [StringLength(50)]
        public string TenSp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayGiao { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Column("SDT")]
        [StringLength(50)]
        public string Sdt { get; set; }
        [StringLength(10)]
        public string GiamGia { get; set; }
        [StringLength(250)]
        public string GhiChu { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? TienShip { get; set; }
        public decimal? TienCoc { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? TienMat { get; set; }
        public decimal? ChuyenKhoan { get; set; }
        public int? TrangThai { get; set; }
        [Column("idSanPham")]
        public Guid? IdSanPham { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhanHang { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTraHang { get; set; }

        [ForeignKey(nameof(IdCa))]
        [InverseProperty(nameof(GiaoCa.HoaDons))]
        public virtual GiaoCa IdCaNavigation { get; set; }
        [ForeignKey(nameof(IdKhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang IdKhachHangNavigation { get; set; }
        [ForeignKey(nameof(IdNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNhanVienNavigation { get; set; }
        [ForeignKey(nameof(IdSanPham))]
        [InverseProperty(nameof(SanPham.HoaDons))]
        public virtual SanPham IdSanPhamNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        
    }
}
