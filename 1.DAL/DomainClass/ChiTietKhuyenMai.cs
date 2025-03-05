using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public class ChiTietKhuyenMai
    {
        public Guid Id { get; set; }
        public Guid? IdKhuyenMai { get; set; }
        public int? TrangThai { get; set; }
        public Guid? IdChiTietGiay { get; set; }
        public virtual ChiTietGiay IdChiTietGiayNavigation { get; set; }
        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; }
    }
}
