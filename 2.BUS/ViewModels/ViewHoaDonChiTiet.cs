using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public ChiTietKhuyenMai ChiTietKhuyenMai { get; set; }
        public ChiTietGiay ChiTietGiay { get; set; }
    }
}
