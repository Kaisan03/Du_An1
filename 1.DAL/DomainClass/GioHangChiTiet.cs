using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("GioHangChiTiet")]
    public partial class GioHangChiTiet
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? IdChiTietGiay { get; set; }
        public Guid? IdGioHang { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DonGia { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? DonGiaKhiGiam { get; set; }

        [ForeignKey(nameof(IdChiTietGiay))]
        [InverseProperty(nameof(ChiTietGiay.GioHangChiTiets))]
        public virtual ChiTietGiay IdChiTietGiayNavigation { get; set; }
        [ForeignKey(nameof(IdGioHang))]
        [InverseProperty(nameof(GioHang.GioHangChiTiets))]
        public virtual GioHang IdGioHangNavigation { get; set; }
    }
}
