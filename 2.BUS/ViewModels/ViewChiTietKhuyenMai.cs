using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewChiTietKhuyenMai
    {
        public Guid Id { get; set; }

        public Guid? IdKhuyenMai { get; set; }

        public Guid? IdChiTietGiay { get; set; }
        public int? TrangThai { get; set; }
    }
}
