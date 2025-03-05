using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string QuocGia { get; set; }
        public int? TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
