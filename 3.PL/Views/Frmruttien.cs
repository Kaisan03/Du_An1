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
    public partial class Frmruttien : Form
    {
        public IGiaoCaService _igiaocaService;
        public INhanVienService _inhanVienService;
        public IHoaDonService _ihoaodonservice;
        public IChucVuService _ichucvuservice;
        
        public Frmruttien()
        {
            InitializeComponent();
            _igiaocaService = new GiaoCaService();
            _inhanVienService = new NhanVienService();
            _ihoaodonservice = new HoaDonService();
            _ichucvuservice = new ChucVuService();
        }

        private void btn_ruttien_Click(object sender, EventArgs e)
        {
            var _idgiaoca = _igiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == _igiaocaService.GetAllGiaoca().Max(c => c.Id));
            var quanly = _inhanVienService.GetAllNhanVien().FirstOrDefault(c => c.Email =="khai030720037@gmail.com");
            if (tbx_makhau.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mật khẩu !!!");
                tbx_makhau.Focus();
            }
            if (tbx_ruttien.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số tiền !!!");
                tbx_ruttien.Focus();
            }
            if (tbx_makhau.Text != quanly.MatKhau)
            {
                MessageBox.Show("Sai mật khẩu !");
                tbx_makhau.Focus();
            }
            if (Convert.ToDecimal(tbx_ruttien.Text) < _igiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == _igiaocaService.GetAllGiaoca().Max(c=>c.Id)).TongTienMat)
            {
                MessageBox.Show("Bạn thật tham lam rút quá nhiều tiền !! để tiền trả khách nữa chứ !!");
                  tbx_ruttien.Focus();
            }
            else
            {
                _idgiaoca.TienBatDauCa = _idgiaoca.TienBatDauCa - Convert.ToDecimal(tbx_ruttien.Text);
                _igiaocaService.Update(_idgiaoca);
            }
            
        }

       
    }
}
