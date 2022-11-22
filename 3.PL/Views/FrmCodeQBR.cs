using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmCodeQBR : Form
    { 
        bool generrated = false;
        public FrmCodeQBR()
        {
            InitializeComponent();
        }

        private void FrmCodeQBR_Load(object sender, EventArgs e)
        {

        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            generrated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(btn_barcode.Text, 200);
        }

        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            generrated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(btn_barcode.Text, 200);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (generrated)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                pictureBox1.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",ImageFormat.Jpeg);
            }
        }
    }
}
