using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            _idgiaoca = giaoca;
            lb_maca.Text = giaoca.Ma;
            lb_thoigianbatdau.Text = Convert.ToString(giaoca.ThoiGianNhanCa);
            lb_thoigianketthuc.Text = Convert.ToString(DateTime.Now);
            lb_tienbandau.Text = Convert.ToString(giaoca.TienBatDauCa);
            //  lb_tongdoanhthutrongca.Text = hoadon.TongTien.ToString();



            // pan tien trong ket

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

        private void iconButton1_Click(object sender, EventArgs e)
        {
           // tbx_500k.Text =  Convert.ToInt64(tbx_500k.Text) -=1;
        }  
    }
}
