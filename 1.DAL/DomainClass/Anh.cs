using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Anh")]
    public partial class Anh
    {
        public Anh()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("maAnh")]
        [StringLength(50)]
        public string MaAnh { get; set; }
        [Column("tenAnh")]
        [StringLength(50)]
        public string TenAnh { get; set; }
        [Column("duongDan")]
        [StringLength(50)]
        public string DuongDan { get; set; }
        [Column("trangThai")]
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietGiay.IdAnhNavigation))]
        public virtual ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
