using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            GioHangs = new HashSet<GioHang>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(10)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ho { get; set; }
        [StringLength(50)]
        public string TenDem { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(50)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string QuocGia { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(GioHang.IdKhachHangNavigation))]
        public virtual ICollection<GioHang> GioHangs { get; set; }
        [InverseProperty(nameof(HoaDon.IdKhachHangNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
