using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            LoadData();
            LoadDataCbxThang();
            lbl_SoHDTaiQuay.Text = _IHoaDonService.GetallHoadon().Where(c => c.TrangThai == 0).Count().ToString();
            lbl_SoHDDangGiao.Text = _IHoaDonService.GetallHoadon().Where(c => c.TrangThai == 1).Count().ToString();
            LoadDataNam();
            dgrid_ThongKe.AllowUserToAddRows = false;
        }
        private void LoadDataCbxThang()
        {
            cmb_LocThang.Items.Add("1");
            cmb_LocThang.Items.Add("2");
            cmb_LocThang.Items.Add("3");
            cmb_LocThang.Items.Add("4");
            cmb_LocThang.Items.Add("5");
            cmb_LocThang.Items.Add("6");
            cmb_LocThang.Items.Add("7");
            cmb_LocThang.Items.Add("8");
            cmb_LocThang.Items.Add("9");
            cmb_LocThang.Items.Add("10");
            cmb_LocThang.Items.Add("11");
            cmb_LocThang.Items.Add("12");
        }
        private void LoadDataNam()
        {
            cmb_LocNam.Items.Add("2018");
            cmb_LocNam.Items.Add("2019");
            cmb_LocNam.Items.Add("2020");
            cmb_LocNam.Items.Add("2021");
            cmb_LocNam.Items.Add("2022");
            cmb_LocNam.Items.Add("2023");
            cmb_LocNam.Items.Add("2024");
            cmb_LocNam.Items.Add("2025");
        }
        private void LoadData()
        {
            dgrid_ThongKe.ColumnCount = 6;
            dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
            dgrid_ThongKe.Columns[0].Visible = false;
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
                dgrid_ThongKe.Rows.Add(x.IdHoaDon, x1.Ma, x.SoLuong, x.SoLuong * x2.GiaBan, x1.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x1.NgayThanhToan);
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
            var ok = _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan > date_NgayBD.Value.AddDays(-1) && c.HoaDon.NgayThanhToan < date_NgayKT.Value);
            foreach (var x in ok.OrderBy(c => c.HoaDon.Id).ToList())
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
        }

        private void rbtn_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            //lbl_DoanhThuHomNay.Text = Convert.ToString(_IHoaDonService.GetallHoadon().Where(c => c.NgayThanhToan.Value.ToString().Substring(0,10) == DateTime.Now.ToString().Substring(0, 10)).Sum(c => c.TongTien));
        }

        private void rbtn_Thang_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void date_LocTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgrid_ThongKe.ColumnCount = 6;
                dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
                dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
                dgrid_ThongKe.Columns[2].Name = "Số SP";
                dgrid_ThongKe.Columns[3].Name = "Doanh thu";
                dgrid_ThongKe.Columns[4].Name = "Loại HD";
                dgrid_ThongKe.Columns[5].Name = "Ngày TT";
                dgrid_ThongKe.Rows.Clear();
                string[] a = date_LocTheoNgay.Value.ToString().Split(" ");

                foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan.Value.ToString().Substring(0, 10) == a[0]))
                {
                    var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
                    var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
                    dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
                }
                lbl_DoanhThuHomNay.Text = Convert.ToString(_IHoaDonService.GetallHoadon().Where(c => c.NgayThanhToan.Value.ToString().Substring(0, 10) == date_LocTheoNgay.Value.ToString().Substring(0, 10)).Sum(c => c.TongTien));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên Hệ Với KaiSan");
            }
        }

        private void cmb_LocThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgrid_ThongKe.ColumnCount = 6;
            //dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
            //dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
            //dgrid_ThongKe.Columns[2].Name = "Số SP";
            //dgrid_ThongKe.Columns[3].Name = "Doanh thu";
            //dgrid_ThongKe.Columns[4].Name = "Loại HD";
            //dgrid_ThongKe.Columns[5].Name = "Ngày TT";
            //dgrid_ThongKe.Rows.Clear();
            //foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan.Value.ToString("MM:yyyy") == Convert.ToString(cmb_LocThang.Text)))
            //{
            //    var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
            //    var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
            //    dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
            //}
        }

        private void lbl_SoHDTaiQuay_TextChanged(object sender, EventArgs e)
        {
            //lbl_SoHDTaiQuay.Text = _IHoaDonService.GetallHoadon().Where(c => c.TrangThai != 1).ToString();
        }

        private void cmb_LocThang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgrid_ThongKe.ColumnCount = 6;
                dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
                dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
                dgrid_ThongKe.Columns[2].Name = "Số SP";
                dgrid_ThongKe.Columns[3].Name = "Doanh thu";
                dgrid_ThongKe.Columns[4].Name = "Loại HD";
                dgrid_ThongKe.Columns[5].Name = "Ngày TT";
                dgrid_ThongKe.Rows.Clear();
                foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan.Value.ToString().Substring(0, 2) == cmb_LocThang.Text))
                {
                    var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
                    var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
                    dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
                }
                lbl_DoanhThuHomNay.Text = Convert.ToString(_IHoaDonService.GetallHoadon().Where(c => c.NgayThanhToan.Value.ToString().Substring(0, 2) == cmb_LocThang.Text.ToString().Substring(0, 2)).Sum(c => c.TongTien));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên Hệ Với KaiSan");
            }
        }
        private void cmb_LocNam_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgrid_ThongKe.ColumnCount = 6;
                dgrid_ThongKe.Columns[0].Name = "ID Hóa đơn";
                dgrid_ThongKe.Columns[1].Name = "Mã hóa đơn";
                dgrid_ThongKe.Columns[2].Name = "Số SP";
                dgrid_ThongKe.Columns[3].Name = "Doanh thu";
                dgrid_ThongKe.Columns[4].Name = "Loại HD";
                dgrid_ThongKe.Columns[5].Name = "Ngày TT";
                dgrid_ThongKe.Rows.Clear();
                foreach (var x in _IHoaDonCTService.GetViewHoaDonCT().Where(c => c.HoaDon.NgayThanhToan.Value.ToString().Substring(6, 4) == cmb_LocNam.Text))
                {
                    var x1 = _IHoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.HoaDon.Id);
                    var x2 = _ICTGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.ChiTietGiay.Id);
                    dgrid_ThongKe.Rows.Add(x.HoaDon.Id, x.HoaDon.Ma, x.HoaDonChiTiet.SoLuong, x.HoaDonChiTiet.SoLuong * x.ChiTietGiay.GiaBan, x.HoaDon.TrangThai == 1 ? "Giao hàng" : "Mua tại quầy", x.HoaDon.NgayThanhToan);
                }
                lbl_DoanhThuHomNay.Text = Convert.ToString(_IHoaDonService.GetallHoadon().Where(c => c.NgayThanhToan.Value.ToString().Substring(6, 4) == cmb_LocNam.Text.ToString().Substring(6, 4)).Sum(c => c.TongTien));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message), "Liên Hệ Với KaiSan");
            }
        }
    }
}
