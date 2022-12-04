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
        public IGiaoCaService _iGiaoCaService;

        public FrmGiaoCa()
        {
            InitializeComponent();
            _iGiaoCaService= new GiaoCaService();
            _ihoadonservice = new HoaDonService();
            _iHoaDonchitietservice = new HoaDonChiTietService();
            _iNhanVienservice = new NhanVienService();

        }

        private void FrmGiaoCa_Load(object sender, EventArgs e)
        {
            lb_maca.Text = Convert.ToString(_iGiaoCaService.GetAllGiaoca().Max(c => c.Id));
           // lb_thoigianbatdau;

        }
    }
}
