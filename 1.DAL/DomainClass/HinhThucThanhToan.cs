using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainClass
{
    public class HinhThucThanhToan
    {
        public Guid Id { get; set; }
        public int IdHoaDon { get; set; }
        public string Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? LoaiHinhThanhToan { get; set; }     
        public decimal? TongTienThanhToan { get; set; }
        public int? TrangThai { get; set; }
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}

