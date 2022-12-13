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
using XAct;

namespace _3.PL.Views
{
    public partial class FrmXacNhanGiaoCa : Form
    {
        public IGiaoCaService _iGiaocaService;
        public GiaoCa _idgiaoca;
        FrmMain2 frmm;
        public FrmXacNhanGiaoCa()
        {
            InitializeComponent();
            _iGiaocaService = new GiaoCaService();
        }
        public FrmXacNhanGiaoCa(string a)
        {
            InitializeComponent();
            _iGiaocaService = new GiaoCaService();
            frmm = new FrmMain2(a);
        }
        private void FrmXacNhanGiaoCa_Load(object sender, EventArgs e)
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            var catruoc = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == (x-1));
            _idgiaoca = giaoca;
            lb_thoigianbatdau.Text = Convert.ToString(giaoca.ThoiGianNhanCa);
            lb_maca.Text = giaoca.Ma;
            tbx_Tiendauca.Text = Convert.ToString(catruoc.TienBatDauCa + giaoca.TongTienTrongCa);

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            _idgiaoca.TienBatDauCa = Convert.ToDecimal(tbx_Tiendauca.Text);
            this.Close();
            _iGiaocaService.Update(_idgiaoca);
            frmm.ShowDialog();
            Application.Exit();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            
        }

    }
}
