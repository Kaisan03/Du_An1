using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewChiTietGiay
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public Guid? IdSize { get; set; }
        public string? TenSize { get; set; }
        public Guid? IdNsx { get; set; }
        public string? TenNSX { get; set; }
        public Guid? IdMauSac { get; set; }
        public string? TenMauSac { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string? TenChatLieu { get; set; }
        public Guid? IdKieuDang { get; set; }
        public string? TenKieuDang { get; set; }
        public Guid? IdAnh { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaNhap { get; set; }
        public int? GiaBan { get; set; }
        public int? SoLuongTon { get; set; }
        public int? TrangThai { get; set; }
        public string MoTa { get; set; }
        public Guid? IdSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? IdDeGiay { get; set; }
        public string? TenDeGiay { get; set; }
    }
}
