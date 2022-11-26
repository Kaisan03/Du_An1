using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace _3.PL.Views
{
    public partial class FrmImportExcel : Form
    {
        Anh anh;
        ChatLieu chatLieu;
        ChiTietGiay chiTietGiay;
        ChucVu chucVu;
        DeGiay deGiay;
        HoaDon hoaDon;
 
        MauSac mausac;
        KieuDang kieuDang;
        SanPham sp;
        _1.DAL.DomainClass.Size size1;
        IChatLieuService _ChatLieu;
        IChiTietGiayService _ChiTietGiay;
        IChucVuService _ChucVu;
        IDeGiayService _DeGiay;
        IHoaDonService _HoaDon;

        IKieuDangService _KieuDang;
        IMauSacService _MauSac;
        ISanPhamService _SanPham;
        INhaSanXuatService _Nsx;
        IAnhService anhs;
        ISizeService _Size;
        AddChiTietSPView addChiTietSPView;
        int sl;
        int giaNhap;
        int giaBan;
        int slt;
        int trangThai;
        public FrmImportExcel()
        {
            InitializeComponent();
            _ChatLieu = new ChatLieuService();
            _ChiTietGiay = new ChiTietGiayService();
            _ChucVu = new ChucVuService();
            _DeGiay = new DeGiayService();
            _HoaDon = new HoaDonService();
            _KieuDang = new KieuDangService();
            _MauSac = new MauSacService();
            _SanPham = new SanPhamService();
            _Nsx = new NhaSanXuatService();
            anhs = new AnhService();
            _Size = new SizeService();
            anh = new Anh();
            chatLieu = new ChatLieu();
            chucVu = new ChucVu();
            deGiay = new DeGiay();
            hoaDon = new HoaDon();
            mausac = new MauSac();
            kieuDang = new KieuDang();
            addChiTietSPView = new AddChiTietSPView();
            sp = new SanPham();
            size1 = new _1.DAL.DomainClass.Size();
        }

        //private void btn_OpenFile_Click(object sender, EventArgs e)
        //{
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Selecl file";
            //openFileDialog.FileName = txt_TimKiem.Text;
            //openFileDialog.Filter = "Excel Files| *.xls; *.xlsx; *.xlsm";
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txt_TimKiem.Text = openFileDialog.FileName;
            //}
            //OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + txt_TimKiem.Text + "';Extended Properties=Excel 12.0 Xml;");
            //oleDbConnection.Open();
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", oleDbConnection);
            //DataSet theSd = new DataSet();
            //DataTable dt = new DataTable();
            //oleDbDataAdapter.Fill(dt);
            //this.dgrid_AddExcel.DataSource = dt.DefaultView;
        //}

        private void btn_Import_Click(object sender, EventArgs e)
        {

            
                for (int i = 0; i < dgrid_AddExcel.Rows.Count-1; i++)
                {
                sl = Convert.ToInt32(dgrid_AddExcel.Rows[i].Cells[11].Value);
                giaNhap = Convert.ToInt32(dgrid_AddExcel.Rows[i].Cells[9].Value);
                giaBan = Convert.ToInt32(dgrid_AddExcel.Rows[i].Cells[10].Value);
                slt = Convert.ToInt32(dgrid_AddExcel.Rows[i].Cells[12].Value);
                trangThai = Convert.ToInt32(dgrid_AddExcel.Rows[i].Cells[15].Value);
                    var Bu1 = new Anh()
                    {
                        Id = Guid.NewGuid(),
                        DuongDan = @"D:\AnhDuAn1",
                        MaAnh = $"MA{anhs.GetAllAnh().Count}",
                        TenAnh = $"Anh{anhs.GetAllAnh().Count}",
                        TrangThai = 1
                    };
                    anhs.AddAnh(Bu1);
                    var Bu2 = new _1.DAL.DomainClass.Size()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"S{_Size.GetAllSize().Count}",
                        Ten = "40",
                        TrangThai = 1
                    };
                    _Size.AddSize(Bu2);

                    var Bu3 = new ChatLieu()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"CL{_ChatLieu.GetAllChatLieu().Count}",
                        Ten = "Da",
                        TrangThai = 1
                    };
                    _ChatLieu.AddChatLieu(Bu3);
                    var Bu4 = new MauSac()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"MS{_MauSac.GetAllMauSac().Count}",
                        Ten = "Trắng",
                        TrangThai = 1
                    };
                    _MauSac.AddMauSac(Bu4);
                    var Bu5 = new Nsx()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"N{_Nsx.GetAllNSX().Count}",
                        Ten = "Nike",
                        TrangThai = 1
                    };
                    _Nsx.AddNSX(Bu5);
                    var Bu6 = new DeGiay()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"DG{_DeGiay.GetAllDeGiay().Count}",
                        Ten = "Nhựa cao cấp",
                        TrangThai = 1
                    };
                    _DeGiay.AddDeGiay(Bu6);
                    var Bu7 = new SanPham()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"SP{_SanPham.GetAllSanPham().Count}",
                        Ten = "NIKE air1",
                        TrangThai = 1
                    };
                    _SanPham.AddSanPham(Bu7);
                    var Bu8 = new KieuDang()
                    {
                        Id = Guid.NewGuid(),
                        Ma = $"KD{_KieuDang.GetAllKieuDang().Count}",
                        Ten = "Đần đần",
                        TrangThai = 1
                    };
                    _KieuDang.AddKieuDang(Bu8);
                    var BuHet = new AddChiTietSPView()
                    {
                        IdSP = Bu7.Id,
                        Ma = $"CT{_ChiTietGiay.GetAllCTGiay().Count}",
                        IdNsx = Bu5.Id,
                        IdMauSac = Bu4.Id,
                        IdChatLieu = Bu3.Id,
                        IdKieuDang = Bu8.Id,
                        SoLuong = sl,
                        GiaNhap = giaNhap,
                        GiaBan = giaBan,
                        SoLuongTon =slt,
                        TrangThai = trangThai,
                        MoTa = dgrid_AddExcel.Rows[i].Cells[14].Value.ToString(),
                        IdSize = Bu2.Id,
                        IdDeGiay = Bu6.Id,
                        IdAnh = Bu1.Id
                    };
                    _ChiTietGiay.AddCTGiay(BuHet);
                }
                
            MessageBox.Show("Đumacuoidungcximportxong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            this.Close();

        }
        #region Xuất file excel
        //Xuất file excel
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgrid_AddExcel.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgrid_AddExcel.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgrid_AddExcel.RowCount; i++)
            {
                for (int j = 0; j < dgrid_AddExcel.Columns.Count; j++)
                {
                    application.Cells[i+2, j + 1] = dgrid_AddExcel.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Ngu thì chết!");
                }
            }
        }
        #endregion
        private void ImportExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                if (excelWorksheet.Dimension.End.Column != 16)
                {
                    MessageBox.Show("Bạn Đã Chọn Sai File Để Thêm Số Lượng Lớn Sản Phẩm Số Cột Không Đáp Ứng Đúng Format", "Thông Báo");
                    txt_TimKiem.Text = "";
                    return;
                }
                for (int i = excelWorksheet.Dimension.Start.Column;i<= excelWorksheet.Dimension.End.Column;i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                
                for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> lstRows = new List<string>();
                    for(int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        lstRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(lstRows.ToArray());
                    
                }
                dgrid_AddExcel.DataSource = dataTable;
            };
        }
        private void btn_OpenExcel_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Export Excel";
            openFileDialog.Filter = "Excel (*.xlsx)| *.xls; *.xlsx; *.xlsm | Excel 2003 (*.xls)|*.xls";
            openFileDialog.RestoreDirectory = true;

            
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_TimKiem.Text = openFileDialog.FileName.ToString();
                
                        ImportExcel(txt_TimKiem.Text);
                if(txt_TimKiem.Text=="")
                    MessageBox.Show("Import file không thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                MessageBox.Show("Import file thành công!");
                
               
                }
        }
    }
    
}
