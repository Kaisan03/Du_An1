using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmGiaoCa : Form
    {

        public INhanVienService _iNhanVienservice;
        public IHoaDonChiTietService _iHoaDonchitietservice;
        public IHoaDonService _ihoadonservice;
        public IGiaoCaService _iGiaocaService;
        public GiaoCa _idgiaoca;
        decimal tienmat;
        decimal chuyenkhoan;
        public FrmGiaoCa()
        {
            InitializeComponent();
            _iGiaocaService = new GiaoCaService();
            _ihoadonservice = new HoaDonService();
            _iHoaDonchitietservice = new HoaDonChiTietService();
            _iNhanVienservice = new NhanVienService();
        }

        private void FrmGiaoCa_Load(object sender, EventArgs e)
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            var nhanvien = _iNhanVienservice.GetAllNhanVien().FirstOrDefault(c=>c.Id == giaoca.IdNhanVienTrongCa);
            var hoadon = _ihoadonservice.GetallHoadon().FirstOrDefault(c => c.IdNhanVien == nhanvien.Id);
            var hoadonchitiet  = _iHoaDonchitietservice.GetAllHoaDonCT().FirstOrDefault(c => c.IdHoaDon == hoadon.Id);
            _idgiaoca = giaoca;
            lb_maca.Text = giaoca.Ma;
            foreach (var z in _ihoadonservice.GetallHoadon().Where(c=>c.IdCa == x))
            {
                lb_tienchuyenkhoan.Text =Convert.ToString(chuyenkhoan += Convert.ToDecimal(z.ChuyenKhoan));
                lb_tienmat.Text = Convert.ToString(tienmat += Convert.ToDecimal(z.TienMat));
            }
            lb_tongdoanhthutrongca.Text = Convert.ToString(tienmat + chuyenkhoan);
            lb_tongtienmat.Text = Convert.ToString(giaoca.TienBatDauCa);
            lb_tongdoanhthu.Text = Convert.ToString(giaoca.TienBatDauCa+ Convert.ToDecimal(chuyenkhoan));
            lb_thoigianbatdau.Text = Convert.ToString(giaoca.ThoiGianNhanCa);
            lb_thoigianketthuc.Text = Convert.ToString(DateTime.Now);
            lb_tienbandau.Text = Convert.ToString(giaoca.TienBatDauCa - tienmat);
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            _idgiaoca = giaoca;
            _idgiaoca.TongTienMat = Convert.ToDecimal(lb_tienmat.Text);
            _idgiaoca.TongTienTrongCa = Convert.ToDecimal(lb_tongdoanhthutrongca.Text);
            _idgiaoca.TongTienPhatSinh = Convert.ToDecimal(lb_tongtienmat.Text) - Convert.ToDecimal(tbx_tienphatsinh.Text);
            _idgiaoca.GhiChuPhatSinh = tbx_ghichu.Text;
            _idgiaoca.ThoiGianReset = DateTime.Now;
            _iGiaocaService.Update(_idgiaoca);
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
        }

        private void btn_ruttien_Click(object sender, EventArgs e)
        {
            Frmruttien ruttien = new Frmruttien();
            ruttien.Show();
            this.Close();
        }
    }
}
