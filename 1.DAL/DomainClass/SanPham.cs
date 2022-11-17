using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietGiay.IdSanPhamNavigation))]
        public virtual ICollection<ChiTietGiay> ChiTietGiays { get; set; }
        [InverseProperty(nameof(HoaDon.IdSanPhamNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
