using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDon
    {
        public Guid Id { get; set; }
        public Guid? IdKhachHang { get; set; }
        public string khachhang { get; set; }
        public Guid? IdSanPham { get; set; }
        public string sanpham { get; set; }
        public Guid? IdNhanVien { get; set; }
        public string nhanvien { get; set; }
        public string Ma { get; set; }
        public string TenSp { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string GiamGia { get; set; }
        public int? TrangThai { get; set; }
        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public HoaDon HoaDon { get; set; }
        public DateTime? NgayNhanHang { get; set; }

        public DateTime? NgayTraHang { get; set; }
    }
}
