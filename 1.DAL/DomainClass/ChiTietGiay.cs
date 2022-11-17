using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietGiay")]
    public partial class ChiTietGiay
    {
        public ChiTietGiay()
        {
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
            GioHangChiTiets = new HashSet<GioHangChiTiet>();
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Ma { get; set; }
        public Guid? IdSize { get; set; }
        [Column("idNSX")]
        public Guid? IdNsx { get; set; }
        [Column("idMauSac")]
        public Guid? IdMauSac { get; set; }
        [Column("idChatLieu")]
        public Guid? IdChatLieu { get; set; }
        [Column("idKieuDang")]
        public Guid? IdKieuDang { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaNhap { get; set; }
        public int? GiaBan { get; set; }
        public int? SoLuongTon { get; set; }
        public int? TrangThai { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
        [Column("idSanPham")]
        public Guid? IdSanPham { get; set; }
        [Column("idDeGiay")]
        public Guid? IdDeGiay { get; set; }
        [Column("idAnh")]
        public Guid? IdAnh { get; set; }

        [ForeignKey(nameof(IdAnh))]
        [InverseProperty(nameof(Anh.ChiTietGiays))]
        public virtual Anh IdAnhNavigation { get; set; }
        [ForeignKey(nameof(IdChatLieu))]
        [InverseProperty(nameof(ChatLieu.ChiTietGiays))]
        public virtual ChatLieu IdChatLieuNavigation { get; set; }
        [ForeignKey(nameof(IdDeGiay))]
        [InverseProperty(nameof(DeGiay.ChiTietGiays))]
        public virtual DeGiay IdDeGiayNavigation { get; set; }
        [ForeignKey(nameof(IdKieuDang))]
        [InverseProperty(nameof(KieuDang.ChiTietGiays))]
        public virtual KieuDang IdKieuDangNavigation { get; set; }
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.ChiTietGiays))]
        public virtual MauSac IdMauSacNavigation { get; set; }
        [ForeignKey(nameof(IdNsx))]
        [InverseProperty(nameof(Nsx.ChiTietGiays))]
        public virtual Nsx IdNsxNavigation { get; set; }
        [ForeignKey(nameof(IdSanPham))]
        [InverseProperty(nameof(SanPham.ChiTietGiays))]
        public virtual SanPham IdSanPhamNavigation { get; set; }
        [ForeignKey(nameof(IdSize))]
        [InverseProperty(nameof(Size.ChiTietGiays))]
        public virtual Size IdSizeNavigation { get; set; }
        [InverseProperty(nameof(ChiTietKhuyenMai.IdChiTietGiayNavigation))]
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        [InverseProperty(nameof(GioHangChiTiet.IdChiTietGiayNavigation))]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdChiTietGiayNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
