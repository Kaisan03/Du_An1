using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
namespace _3.PL.Views
{
    public partial class FrmPrint : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        IChiTietGiayService chiTietGiayService;
        public FrmPrint()
        {
            InitializeComponent();
        }
        public FrmPrint(HoaDon a)
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            chiTietGiayService = new ChiTietGiayService();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            LoadData(a);
            loadpanel(a);
        }
        private void LoadData(HoaDon a)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Tên sản phẩm";
            dataGridView1.Columns[1].Name = "Số lượng";
            dataGridView1.Columns[2].Name = "Giá";
            dataGridView1.Columns[3].Name = "Tổng giá";
            dataGridView1.Rows.Clear();
            foreach (var item in hoaDonChiTietService.GetAllHoaDonCT().Where(c=>c.IdHoaDon==a.Id))
            {
                var x= chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == item.IdChiTietGiay);
                dataGridView1.Rows.Add(x.TenSanPham , item.SoLuong, item.DonGia, item.SoLuong* item.DonGia);
            }
        }
        private void loadpanel(HoaDon a)
        {
            lbl_SOHd.Text = a.Ma;
            string[] arr = DateTime.Now.ToString().Split("/");
            lbl_Ngay.Text = arr[0];
            lbl_Thang.Text = arr[1];
            lbl_Nam.Text = arr[2];
            lbl_KhachHang.Text = a.TenNguoiNhan;
            lbl_SdtKhachHang.Text = a.Sdt;
            lbl_DiaChi.Text = a.DiaChi;
            int x = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                x += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lbl_TongTienHang.Text = x.ToString();
            lbl_ThanhToan.Text = x.ToString();
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
