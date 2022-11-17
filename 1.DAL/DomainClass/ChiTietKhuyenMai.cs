using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietKhuyenMai")]
    public partial class ChiTietKhuyenMai
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("idKhuyenMai")]
        public Guid? IdKhuyenMai { get; set; }
        public int? TrangThai { get; set; }
        [Column("idChiTietGiay")]
        public Guid? IdChiTietGiay { get; set; }

        [ForeignKey(nameof(IdChiTietGiay))]
        [InverseProperty(nameof(ChiTietGiay.ChiTietKhuyenMais))]
        public virtual ChiTietGiay IdChiTietGiayNavigation { get; set; }
        [ForeignKey(nameof(IdKhuyenMai))]
        [InverseProperty(nameof(KhuyenMai.ChiTietKhuyenMais))]
        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; }
    }
}
