using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class KhuyenMai
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public int? TrangThai { get; set; }
        public virtual List<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
    }
}
