using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewGioHangcs
    {
        public Guid Id { get; set; }
        public Guid? IdKh { get; set; }
        public Guid? IdNv { get; set; }
        public string Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int? TinhTrang { get; set; }
    }
}
