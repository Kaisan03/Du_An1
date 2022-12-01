using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    [Table("HinhThucThanhToan")]
    public partial class HinhThucThanhToan
    {
        
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
 
        public int IdHoaDon { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(50)]

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [StringLength(50)]
        public DateTime? NgaySua { get; set; }
        
        public int? LoaiHinhThanhToan { get; set; }
        
        public decimal? TongTienThanhToan { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HinhThucThanhToans))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}

