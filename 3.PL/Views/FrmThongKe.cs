using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct;

namespace _3.PL.Views
{
    public partial class FrmThongKe : Form
    {
        private IHoaDonService _IHoaDonService;
        private IHoaDonChiTietService _IHoaDonCTService;
        private IChiTietGiayService _ICTGiayService;
        private FrmBanHang1 frmbh1;
        public FrmThongKe()
        {
            InitializeComponent();
            _IHoaDonCTService = new HoaDonChiTietService();
            _IHoaDonService = new HoaDonService();
            _ICTGiayService = new ChiTietGiayService();
            frmbh1 = new FrmBanHang1();
            //LoadData();
        }
        private void LoadData()
        {
            dgrid_ThongKe.ColumnCount = 6;
            dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
            dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
            dgrid_ThongKe.Columns[2].Name = "Số SP";
            dgrid_ThongKe.Columns[3].Name = "Doanh thu";
            dgrid_ThongKe.Columns[4].Name = "Loại HD";
            dgrid_ThongKe.Columns[5].Name = "Ngày TT";
            dgrid_ThongKe.Rows.Clear();
            foreach (var x in _IHoaDonCTService.GetAllHoaDonCT().OrderBy(c => c.IdHoaDon).ToList())
            {
                var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.IdHoaDon);
                var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);
                dgrid_ThongKe.Rows.Add(x.IdHoaDon, x1.Ma, x.SoLuong, x.SoLuong * x2.GiaBan, x1.TrangThai == 1 ? "Giao hàng":"Mua tại quầy", x1.NgayThanhToan);
            }
        }
        private void LoadDataTimKiem()
        {
            dgrid_ThongKe.ColumnCount = 6;
            dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
            dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
            dgrid_ThongKe.Columns[2].Name = "Số SP";
            dgrid_ThongKe.Columns[3].Name = "Doanh thu";
            dgrid_ThongKe.Columns[4].Name = "Loại HD";
            dgrid_ThongKe.Columns[5].Name = "Ngày TT";
            dgrid_ThongKe.Rows.Clear();
            foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan == date_LocTheoNgay.Value).OrderBy(c => c.HoaDon.Id).ToList())
            {
                var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
                var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
                dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDataTimKiem();
        }

        private void lbl_DoanhThuHomNay_TextChanged(object sender, EventArgs e)
        {
            //var x2 = _ICTGiayService.GetViewChiTietGiay().Select(c => c.SoLuong && c.TrangThai);
            //lbl_DoanhThuHomNay.Text = DateTime.Now.Day();
        }

        private void rbtn_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            lbl_DoanhThuHomNay.Text = Convert.ToString(_IHoaDonService.GetallHoadon().Where(c => c.NgayThanhToan == DateTime.Today).Sum(c => c.TongTien));
        }

        private void rbtn_Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void date_LocTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            dgrid_ThongKe.ColumnCount = 6;
            dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
            dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
            dgrid_ThongKe.Columns[2].Name = "Số SP";
            dgrid_ThongKe.Columns[3].Name = "Doanh thu";
            dgrid_ThongKe.Columns[4].Name = "Loại HD";
            dgrid_ThongKe.Columns[5].Name = "Ngày TT";
            dgrid_ThongKe.Rows.Clear();
            foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan == date_LocTheoNgay.Value).OrderBy(c => c.HoaDon.Id).ToList())
            {
                var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
                var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
                dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
            }
        }
    }
}
