using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("GioHang")]
    public partial class GioHang
    {
        public GioHang()
        {
            GioHangChiTiets = new HashSet<GioHangChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid? IdKhachHang { get; set; }
        public Guid? IdNhanVien { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        public int? TinhTrang { get; set; }

        [ForeignKey(nameof(IdKhachHang))]
        [InverseProperty(nameof(KhachHang.GioHangs))]
        public virtual KhachHang IdKhachHangNavigation { get; set; }
        [InverseProperty(nameof(GioHangChiTiet.IdGioHangNavigation))]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
