using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class Anh
    {
        public Guid Id { get; set; }
        public string MaAnh { get; set; }
        public string TenAnh { get; set; }
        public string DuongDan { get; set; }
        public int? TrangThai { get; set; }
        public virtual List<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
