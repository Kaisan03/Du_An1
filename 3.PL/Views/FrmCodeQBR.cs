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
using ZXing.QrCode;
using ZXing;
using ZXing.Windows.Compatibility;

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
            //generrated = true;
           
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pic_qrcode.Image = barcode.Draw(txt_qrcode.Text, 200);
        }

        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            //generrated = true;
          
            //Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //pic_qrcode.Image = qrcode.Draw(txt_qrcode.Text, 200);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //if (generrated)
            //{
            //    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    pic_qrcode.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",ImageFormat.Jpeg);
            //}
        }

        private void btn_addbarcode_Click(object sender, EventArgs e)
        {
            var options = new QrCodeEncodingOptions
            {
                Height = pic_qrcode.Height,
                Width = pic_qrcode.Width,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var text = txt_qrcode.Text;
            var result = writer.Write(text);
            //pic_qrcode.Image = result;
        }

        private void btn_saveqrcode_Click(object sender, EventArgs e)
        {
            string DuongDan = @"D:\PRO131\QRCode";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = DuongDan;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pic_qrcode.Image.Save(dialog.FileName);
            }
        }
    }
}
