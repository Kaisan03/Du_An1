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
    public partial class FrmPrintGiaoHang : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        IChiTietGiayService chiTietGiayService;
        IHoaDonService hoadonService;
        public FrmPrintGiaoHang()
        {
            InitializeComponent();
        }
        public FrmPrintGiaoHang(HoaDon a)
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            chiTietGiayService = new ChiTietGiayService();
            hoadonService = new HoaDonService();
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
            foreach (var item in hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == a.Id))
            {
                var x = chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == item.IdChiTietGiay);
                dataGridView1.Rows.Add(x.TenSanPham, item.SoLuong, item.DonGia, item.SoLuong * item.DonGia);
            }
        }
        private void loadpanel(HoaDon a)
        {
            lbl_SOHd.Text = a.Ma;
            string[] arr = DateTime.Now.ToString().Split("/");
            lbl_Ngay.Text = arr[1];
            lbl_Thang.Text = arr[0];
            lbl_Nam.Text = arr[2];
            lbl_KhachHang.Text = a.TenNguoiNhan;
            lbl_SdtKhachHang.Text = a.Sdt;
            lbl_DiaChi.Text = a.DiaChi;
            int x = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                x += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lbl_tiendatra.Text = a.TienCoc.ToString();
            lbl_TongTienHang.Text = x.ToString();
            lbl_ThanhToan.Text = (x-a.TienCoc).ToString();
            lbl_tienChu.Text = NumberToText(Convert.ToDouble(lbl_TongTienHang.Text));
          

            //lbl_ThanhChu.Text = x.ToString();
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
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[]
                      {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length; // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }

                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }

                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }

                    result = " " + result;
                }
            }

            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");

        }
    }
}
