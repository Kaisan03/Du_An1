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
    public partial class FrmThongBao : Form
    {
        public FrmThongBao()
        {
            InitializeComponent();
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
        private void FrmThongBao_Load(object sender, EventArgs e)
        {
            //btn_Ok.Location = new Point(
            //this.ClientSize.Width / 10 - btn_Ok.Size.Width / 7,
            //this.ClientSize.Height - btn_Ok.Size.Height);
            //btn_Ok.Anchor = AnchorStyles.None;
            btn_Ok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Ok.Width,
            btn_Ok.Height, 30, 30));
            //btn_Ok.Dock = DockStyle.Top;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showAlert(string msg)
        {
        }
    }
}
