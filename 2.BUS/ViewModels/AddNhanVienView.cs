using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class AddNhanVienView
    {
        public Guid? Id { get; set; }

        public string Ma { get; set; }

        public string Ho { get; set; }

        public string TenDem { get; set; }

        public string Ten { get; set; }

        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string Sdt { get; set; }

        public string MatKhau { get; set; }
        public Guid? IdChucVu { get; set; }
        public int? TrangThai { get; set; }
    }
}
