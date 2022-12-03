using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    [Table("GiaoCa")]
    public partial class GiaoCa
    {
        [Key]
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public Guid IdNhanVienTrongCa { get; set; }
        public Guid IdNhanVienTiepTheo { get; set; }
        public DateTime ThoiGianNhanCa { get; set; }
        public DateTime ThoiGianGiaoCa { get; set; }
        public decimal TienBatDauCa{ get; set; }
        public decimal TongTienMat { get; set; }
        public decimal TongTienTrongCa   { get; set; }
        public decimal TongTienKhac { get; set; }
        public decimal TongTienPhatSinh { get; set; }
        public string GhiChuPhatSinh { get; set; }
        public decimal TongTienMatCaTruoc { get; set; }
        public DateTime ThoiGianReset { get; set; }
        public Guid IdChuCuaHang { get; set; }
        public decimal TongTienMatRut { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey(nameof(IdNhanVienTrongCa))]
        [InverseProperty(nameof(NhanVien.GiaoCas))]
        public virtual NhanVien IdNhanViennNavigation { get; set; }
    }
}
