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
    public partial class FrmXacNhanGiaoCa : Form
    {
        public FrmXacNhanGiaoCa()
        {
            InitializeComponent();
        }

        private void FrmXacNhanGiaoCa_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString().ToString();
            label4.Text = Convert.ToString("1000000") + "đ"; 
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            FrmMain2 frmm = new FrmMain2();
            frmm.ShowDialog();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
