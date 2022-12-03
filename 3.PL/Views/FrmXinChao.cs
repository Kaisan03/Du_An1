using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmXinChao : Form
    {
        INhanVienService nhanVienService;
        public FrmXinChao()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }
        public FrmXinChao(string a)
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            xinChao(a);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        private void xinChao(string a)
        {
            var x = nhanVienService.GetAllNhanVien().FirstOrDefault(c => c.Email == a).Ma;
            lbl_XinChao.Text = $"Xin chào {x}";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmXinChao_Load(object sender, EventArgs e)
        {
            btn_Ok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Ok.Width,
            btn_Ok.Height, 30, 30));
        }
    }
}
