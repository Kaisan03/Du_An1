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
        int k500;
        int k200;
        int k100;
        int k50;
        int k20;
        int k10;
        int k5;
        int k2;
        int k1;
        decimal tienmat;
        decimal chuyenkhoan;
        decimal tongtientrongket;
        public FrmGiaoCa()
        {
            InitializeComponent();
            _iGiaocaService = new GiaoCaService();
            _ihoadonservice = new HoaDonService();
            _iHoaDonchitietservice = new HoaDonChiTietService();
            _iNhanVienservice = new NhanVienService();
            
            pan_tientrongket.Enabled = false;
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
            lb_thoigianbatdau.Text = Convert.ToString(giaoca.ThoiGianNhanCa);
            lb_thoigianketthuc.Text = Convert.ToString(DateTime.Now);
            lb_tienbandau.Text = Convert.ToString(giaoca.TienBatDauCa);

            foreach (var z in _ihoadonservice.GetallHoadon().Where(c=>c.IdCa == x))
            {
                lb_tienchuyenkhoan.Text =Convert.ToString(chuyenkhoan += Convert.ToDecimal(z.ChuyenKhoan));
                lb_tienmat.Text = Convert.ToString(tienmat += Convert.ToDecimal(z.TienMat));
            }
            lb_tongdoanhthutrongca.Text = Convert.ToString(tienmat + chuyenkhoan);
            lb_tongtienmat.Text = Convert.ToString(tienmat + Convert.ToDecimal(lb_tienbandau.Text));
            lb_tongdoanhthu.Text = Convert.ToString(tienmat + chuyenkhoan + Convert.ToDecimal(lb_tienbandau.Text));

        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                pan_tientrongket.Enabled = false;
            }
            else
            {
                pan_tientrongket.Enabled = true;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            k500++;
            tbx_500k.Text = Convert.ToString(k500);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            k500--;
            tbx_500k.Text = Convert.ToString(k500);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            k200--;
            tbx_200k.Text = Convert.ToString(k200);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            k200++;
            tbx_200k.Text = Convert.ToString(k200);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            k100--;
            tbx_100k.Text = Convert.ToString(k100);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            k100++;
            tbx_100k.Text = Convert.ToString(k100);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            k50--;
            tbx_50k.Text = Convert.ToString(k50);
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            k50++;
            tbx_50k.Text = Convert.ToString(k50);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            k20--;
            tbx_20k.Text = Convert.ToString(k20);
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {

            k20++;
            tbx_20k.Text = Convert.ToString(k20);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            k10--;
            tbx_10k.Text = Convert.ToString(k10);
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {

            k10++;
            tbx_10k.Text = Convert.ToString(k10);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

            k5--;
            tbx_5k.Text = Convert.ToString(k5);
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {

            k5++;
            tbx_5k.Text = Convert.ToString(k5);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

            k2--;
            tbx_2k.Text = Convert.ToString(k2);
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            k2++;
            tbx_2k.Text = Convert.ToString(k2);
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            k1--;
            tbx_1k.Text = Convert.ToString(k1);
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            k1++;
            tbx_1k.Text = Convert.ToString(k1);
        }

        private void lb_tientrongket_TextChanged(object sender, EventArgs e)
        {
            tongtientrongket = (k500 * 500000) + (k200 * 200000) + (k100 * 100000) + (k50 * 50000) + (k20 * 20000) + (k10 * 10000) + (k5 * 5000) + (k2 * 2000) + (k1 * 1000);
            lb_tientrongket.Text = String.Format("{0:0,00}", tongtientrongket);
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            _idgiaoca = giaoca;
            _idgiaoca.TongTienMat = Convert.ToDecimal(lb_tienmat.Text);
            _idgiaoca.TongTienTrongCa = Convert.ToDecimal(lb_tongdoanhthutrongca.Text);
            _idgiaoca.TongTienPhatSinh = Convert.ToDecimal(tbx_tienphatsinh.Text);
            _idgiaoca.GhiChuPhatSinh = tbx_ghichu.Text;
            _idgiaoca.ThoiGianReset = DateTime.Now;
            _iGiaocaService.Update(_idgiaoca);
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
        }
    }
}
