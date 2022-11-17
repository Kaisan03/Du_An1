using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("DeGiay")]
    public partial class DeGiay
    {
        public DeGiay()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(50)]
        public string ChatLieu { get; set; }
        public int? ChieuCao { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietGiay.IdDeGiayNavigation))]
        public virtual ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
