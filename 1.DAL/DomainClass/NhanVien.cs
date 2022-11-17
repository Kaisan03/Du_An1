using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
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
        [Column("GioiTInh")]
        [StringLength(50)]
        public string GioiTinh { get; set; }
        [Column("NgaySInh", TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Column("SDT")]
        [StringLength(50)]
        public string Sdt { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        public Guid? IdChucVu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdChucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
