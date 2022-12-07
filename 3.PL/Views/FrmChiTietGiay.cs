using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using _1.DAL.DomainClass;
using System.Data.OleDb;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using ZXing.OneD;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using Document = iTextSharp.text.Document;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;
using ZXing.QrCode;
//using OfficeOpenXml.Core.ExcelPackage;

namespace _3.PL.Views
{
    public partial class FrmChiTietGiay : Form
    {
        private ChiTietGiay _chiTietGiay;
        private IChiTietGiayService _IChiTietGiayService;
        private List<ViewChiTietGiay> _lstCTGiay;
        private ISanPhamService _ISanPhamService;
        private ISizeService _ISizeService;
        private IChatLieuService _IChatLieuService;
        private IMauSacService _IMauSacService;
        private IDeGiayService _IDeGiayService;
        private IKieuDangService _IKieuDangService;
        private INhaSanXuatService _INsxService;
        private IAnhService _IAnhService;
        private Guid _idCTGiay;
        SanPhamService sanPhams;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public FrmChiTietGiay()
        {
            InitializeComponent();
            _IChiTietGiayService = new ChiTietGiayService();
            _lstCTGiay = new List<ViewChiTietGiay>();
            _ISanPhamService = new SanPhamService();
            _ISizeService = new SizeService();
            _IDeGiayService = new DeGiayService();  
            _IKieuDangService = new KieuDangService();
            _INsxService = new NhaSanXuatService();
            _IMauSacService = new MauSacService();
            _IChatLieuService = new ChatLieuService();
            _IAnhService = new AnhService();
            LoadData();
            LoadComboBox();
            LoadLoc();
            cbx_HoatDong.Enabled = false;
            cbx_khongHD.Enabled = false;
            txt_Ma.Enabled = false;
            dgrid_ChiTietGiay.AllowUserToAddRows = false;
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
        private void LoadLoc()
        {
            var size11 = _IChiTietGiayService.GetAllCTGiay().Select(c => c.TrangThai == 1 ? "Hết hàng":"Còn hàng".ToString()).Distinct();
            foreach (var x in size11)
            {
                //cmb_Loc.Items.Add(x);
            }
        }
        private void LoadComboBox()
        {
            var size1 = _ISanPhamService.GetAllSanPham().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size1)
            {
              
                cmb_SanPham.Items.Add(x);
            }
            var size2 = _ISizeService.GetAllSize().Select(c => c.Ten.ToString()).Distinct();
            foreach (var owner in size2)
            {
                cmb_TenSize.Items.Add(owner);
            }
            var size3 = _IDeGiayService.GetAllDeGiay().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size3)
            {
                cmb_LoaiDe.Items.Add(x);
            }
            var size4 = _IKieuDangService.GetAllKieuDang().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size4)
            {
                cmb_KieuDang.Items.Add(x);
            }
            var size5 = _INsxService.GetAllNSX().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size5)
            {
                cmb_Nsx.Items.Add(x);
            }
            var size6 = _IMauSacService.GetAllMauSac().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size6)
            {
                cmb_MauSac.Items.Add(x);
            }
            var size7 = _IChatLieuService.GetAllChatLieu().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size7)
            {
                cmb_ChatLieu.Items.Add(x);
            }
            var size8 = _IAnhService.GetAllAnh().Select(c => c.DuongDan.ToString()).Distinct();
            foreach (var x in size8)
            {
                cmb_Anh.Items.Add(x);
            }
        }
        private void LoadData()
        {
            dgrid_ChiTietGiay.ColumnCount = 17;
            dgrid_ChiTietGiay.Columns[0].Name = "ID";
            dgrid_ChiTietGiay.Columns[0].Visible = false;
            dgrid_ChiTietGiay.Columns[1].Name = "Mã sản phẩm";
            dgrid_ChiTietGiay.Columns[2].Name = "Màu sắc";
            dgrid_ChiTietGiay.Columns[3].Name = "Chất liệu";
            dgrid_ChiTietGiay.Columns[4].Name = "Loại đế";
            dgrid_ChiTietGiay.Columns[5].Name = "Nhà sản xuất";
            dgrid_ChiTietGiay.Columns[6].Name = "Kiểu dáng";
            dgrid_ChiTietGiay.Columns[7].Name = "Tên sản phẩm";
            dgrid_ChiTietGiay.Columns[8].Name = "Size";
            dgrid_ChiTietGiay.Columns[9].Name = "Giá nhập";
            dgrid_ChiTietGiay.Columns[10].Name = "Giá bán";
            dgrid_ChiTietGiay.Columns[11].Name = "Số lượng";
            dgrid_ChiTietGiay.Columns[12].Name = "Số lượng tồn";
            dgrid_ChiTietGiay.Columns[13].Name = "Ảnh";
            dgrid_ChiTietGiay.Columns[14].Name = "Mô tả";
            dgrid_ChiTietGiay.Columns[15].Name = "Trạng thái";
            dgrid_ChiTietGiay.Columns[16].Name = "Mã vạch";
            dgrid_ChiTietGiay.Rows.Clear();
            //_lstCTGiay = _IChiTietGiayService.GetViewChiTietGiay();
            //if (txt_TimKiem.Text != "")
            //{
            //    _lstCTGiay = _lstCTGiay.Where(p => p.Ma.ToLower().Contains(txt_Ma.Text.ToLower())).ToList();
            //}
            foreach (var x in _IChiTietGiayService.GetViewChiTietGiay().OrderBy(c => c.Ma).ToList())
            {
                if (x.SoLuongTon > 0) x.TrangThai = 1;
                else x.TrangThai = 0;
                dgrid_ChiTietGiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenMauSac,
                    x.TenChatLieu,
                    x.TenDeGiay,
                    x.TenNSX,
                    x.TenKieuDang,
                    x.TenSanPham,
                    x.TenSize,
                    x.GiaNhap,
                    x.GiaBan,
                    x.SoLuong,
                    x.SoLuongTon,
                    x.Anh,
                    x.MoTa,
                    x.TrangThai ==1? "Còn hàng": "Hết hàng",
                    x.MaVach
                    ) ;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Ma.Text = MaCTGiay();
                AddChiTietSPView addCTGiay = new AddChiTietSPView()
                {
                    IdSP = cmb_SanPham.Text != null ? _ISanPhamService.GetAllSanPham().FirstOrDefault(c => c.Ten == cmb_SanPham.Text).Id : null,
                    IdChatLieu = cmb_ChatLieu.Text != null ? _IChatLieuService.GetAllChatLieu().FirstOrDefault(c => c.Ten == cmb_ChatLieu.Text).Id : null,
                    IdMauSac = cmb_MauSac.Text != null ? _IMauSacService.GetAllMauSac().FirstOrDefault(c => c.Ten == cmb_MauSac.Text).Id : null,
                    IdNsx = cmb_Nsx.Text != null ? _INsxService.GetAllNSX().FirstOrDefault(c => c.Ten == cmb_Nsx.Text).Id : null,
                    IdDeGiay = cmb_LoaiDe.Text != null ? _IDeGiayService.GetAllDeGiay().FirstOrDefault(c => c.Ten == cmb_LoaiDe.Text).Id : null,
                    IdKieuDang = cmb_KieuDang.Text != null ? _IKieuDangService.GetAllKieuDang().FirstOrDefault(c => c.Ten == cmb_KieuDang.Text).Id : null,
                    IdSize = cmb_TenSize.Text != null ? _ISizeService.GetAllSize().FirstOrDefault(c => c.Ten == cmb_TenSize.Text).Id : null,
                    Ma = txt_Ma.Text,
                    IdAnh = cmb_Anh.Text != null ? _IAnhService.GetAllAnh().FirstOrDefault(c => c.DuongDan == cmb_Anh.Text).Id : null,
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    GiaNhap = Convert.ToInt32(txt_NgayNhap.Text),
                    GiaBan = Convert.ToInt32(txt_NgayBan.Text),
                    SoLuongTon = Convert.ToInt32(txt_SoLuongTon.Text),
                    MaVach = txt_MaVach.Text,
                    MoTa = txt_moTa.Text,
                    
                };
                _IChiTietGiayService.AddCTGiay(addCTGiay);
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.ShowDialog();
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Ma.Text = MaCTGiay();
                UpdateChiTietSPView updateGiay = new UpdateChiTietSPView()
                {
                    Id = _idCTGiay,
                    IdSP = cmb_SanPham.Text != null ? _ISanPhamService.GetAllSanPham().FirstOrDefault(c => c.Ten == cmb_SanPham.Text).Id : null,
                    IdChatLieu = cmb_ChatLieu.Text != null ? _IChatLieuService.GetAllChatLieu().FirstOrDefault(c => c.Ten == cmb_ChatLieu.Text).Id : null,
                    IdMauSac = cmb_MauSac.Text != null ? _IMauSacService.GetAllMauSac().FirstOrDefault(c => c.Ten == cmb_MauSac.Text).Id : null,
                    IdNsx = cmb_Nsx.Text != null ? _INsxService.GetAllNSX().FirstOrDefault(c => c.Ten == cmb_Nsx.Text).Id : null,
                    IdDeGiay = cmb_LoaiDe.Text != null ? _IDeGiayService.GetAllDeGiay().FirstOrDefault(c => c.Ten == cmb_LoaiDe.Text).Id : null,
                    IdKieuDang = cmb_KieuDang.Text != null ? _IKieuDangService.GetAllKieuDang().FirstOrDefault(c => c.Ten == cmb_KieuDang.Text).Id : null,
                    IdSize = cmb_TenSize.Text != null ? _ISizeService.GetAllSize().FirstOrDefault(c => c.Ten == cmb_TenSize.Text).Id : null,
                    Ma = txt_Ma.Text,
                    IdAnh = cmb_Anh.Text != null ? _IAnhService.GetAllAnh().FirstOrDefault(c => c.DuongDan == cmb_Anh.Text).Id : null,
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    GiaNhap = Convert.ToInt32(txt_NgayNhap.Text),
                    GiaBan = Convert.ToInt32(txt_NgayBan.Text),
                    SoLuongTon = Convert.ToInt32(txt_SoLuongTon.Text),
                    MoTa = txt_moTa.Text,  
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0,
                    MaVach = txt_MaVach.Text
                };
                _IChiTietGiayService.UpdateCTGiay(updateGiay);
                FrmThongBao frmThongBao = new FrmThongBao();
                frmThongBao.ShowDialog();
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật trạng thái không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.OK)
            {
               

                LoadData();
            }
           
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn clear?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgrid_ChiTietGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowindex = e.RowIndex;
                if (rowindex == _IChiTietGiayService.GetAllCTGiay().Count) return;
                DataGridViewRow r = dgrid_ChiTietGiay.Rows[e.RowIndex];
                _idCTGiay = Guid.Parse(r.Cells[0].Value.ToString());
                var sp = _IChiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == _idCTGiay);
                cmb_TenSize.Text = r.Cells[1].Value.ToString();
                cmb_MauSac.Text = r.Cells[2].Value.ToString();
                cmb_ChatLieu.Text = r.Cells[3].Value.ToString();
                cmb_LoaiDe.Text = r.Cells[4].Value.ToString();
                cmb_Nsx.Text = r.Cells[5].Value.ToString();
                cmb_KieuDang.Text = r.Cells[6].Value.ToString();
                cmb_SanPham.Text = r.Cells[7].Value.ToString();
                txt_Ma.Text = sp.Ma;
                txt_NgayNhap.Text = sp.GiaNhap.ToString();
                txt_NgayBan.Text = sp.GiaBan.ToString();
                txt_SoLuong.Text = sp.SoLuong.ToString();
                txt_SoLuongTon.Text = sp.SoLuongTon.ToString();
                cmb_Anh.Text = r.Cells[13].Value.ToString();
                txt_moTa.Text = sp.MoTa;
                if (Convert.ToInt32(r.Cells[12].Value) > 0) sp.TrangThai=1;
                else sp.TrangThai=0;
                
                cbx_HoatDong.Checked = sp.TrangThai == 1;
                cbx_khongHD.Checked = sp.TrangThai == 0;
                pic_ImageGiay.ImageLocation = cmb_Anh.Text;
                txt_MaVach.Text = sp.MaVach;
                //pic_QuetBarcode.Image = cmb_Anh.Text;
            }
        }
        private void cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HoatDong.Checked)
            {
                cbx_khongHD.Checked = false;
            }
            else
            {
                cbx_khongHD.Checked = true;
            }
        }

        private void cbx_khongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_khongHD.Checked)
            {
                cbx_HoatDong.Checked = false;
            }
            else
            {
                cbx_HoatDong.Checked = true;
            }
        }
        private void FrmChiTietGiay_Load_1(object sender, EventArgs e)
        {
            //CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo Device in CaptureDevice)
            ////    comboBox1.Items.Add(Device.Name);
            ////comboBox1.SelectedIndex = 0;
            //FinalFrame = new VideoCaptureDevice();
            ////groupBox1.Location = new Point(
            ////this.ClientSize.Width /10 - groupBox1.Size.Width/7 ,
            ////this.ClientSize.Height  - groupBox1.Size.Height );
            //groupBox1.Anchor = AnchorStyles.None;
            //groupBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, groupBox1.Width,
            //groupBox1.Height, 30, 30));
            
            ////
            ////dgrid_ChiTietGiay.Location = new Point(
            ////this.ClientSize.Width / 2 - dgrid_ChiTietGiay.Size.Width / 2,
            ////this.ClientSize.Height / 2 - dgrid_ChiTietGiay.Size.Height / 2);
            //dgrid_ChiTietGiay.Anchor = AnchorStyles.None;
            //dgrid_ChiTietGiay.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dgrid_ChiTietGiay.Width,
            //dgrid_ChiTietGiay.Height, 35, 30));
            
            ////
            ////groupBox2.Location = new Point(
            ////this.ClientSize.Width / 1 - groupBox2.Size.Width / 2.5,
            ////this.ClientSize.Height  - groupBox2.Size.Height );
            //groupBox2.Anchor = AnchorStyles.None;
            //groupBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, groupBox2.Width,
            //groupBox2.Height, 30, 30));
            ////
            //btn_AddSize.FlatStyle = FlatStyle.Flat;
            //btn_AddSize.FlatAppearance.BorderSize = 0;
            //btn_AddNsx.FlatStyle = FlatStyle.Flat;
            //btn_AddNsx.FlatAppearance.BorderSize = 0;
            //btn_AddMauSac.FlatStyle = FlatStyle.Flat;
            //btn_AddMauSac.FlatAppearance.BorderSize = 0;
            //btn_DeGiay.FlatStyle = FlatStyle.Flat;
            //btn_DeGiay.FlatAppearance.BorderSize = 0;
            //btn_KieuDang.FlatStyle = FlatStyle.Flat;
            //btn_KieuDang.FlatAppearance.BorderSize = 0;
            //btn_addchatLieu.FlatStyle = FlatStyle.Flat;
            //btn_addchatLieu.FlatAppearance.BorderSize = 0;
            //btn_AddSp.FlatStyle = FlatStyle.Flat;
            //btn_AddSp.FlatAppearance.BorderSize = 0;
            //btn_AddAnh1.FlatStyle = FlatStyle.Flat;
            //btn_AddAnh1.FlatAppearance.BorderSize = 0;
            ////
            //cmb_TenSize.FlatStyle = FlatStyle.Flat;
            //cmb_Nsx.FlatStyle = FlatStyle.Flat;
            //cmb_MauSac.FlatStyle = FlatStyle.Flat;
            //cmb_LoaiDe.FlatStyle = FlatStyle.Flat;
            //cmb_KieuDang.FlatStyle = FlatStyle.Flat;
            //cmb_ChatLieu.FlatStyle = FlatStyle.Flat;
            //cmb_Anh.FlatStyle = FlatStyle.Flat;
            //cmb_SanPham.FlatStyle = FlatStyle.Flat;
            ////txt_NgayNhap.FlatStyle = FlatStyle.Flat;
            ////
            //btn_Them.Anchor = AnchorStyles.None;
            //btn_Them.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Them.Width,
            //btn_Them.Height, 35, 30));
            //btn_Sua.Anchor = AnchorStyles.None;
            //btn_Sua.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Sua.Width,
            //btn_Sua.Height, 35, 30));
            ////btn_Xoa.Anchor = AnchorStyles.None;
            ////btn_Xoa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Xoa.Width,
            ////btn_Xoa.Height, 35, 30));
        }
        private void LoadData_timKiem(string txt)
        {
            dgrid_ChiTietGiay.ColumnCount = 16;
            dgrid_ChiTietGiay.Columns[0].Name = "ID";
            dgrid_ChiTietGiay.Columns[0].Visible = false;
            dgrid_ChiTietGiay.Columns[1].Name = "Size";
            dgrid_ChiTietGiay.Columns[2].Name = "Màu sắc";
            dgrid_ChiTietGiay.Columns[3].Name = "Chất liệu";
            dgrid_ChiTietGiay.Columns[4].Name = "Loại đế";
            dgrid_ChiTietGiay.Columns[5].Name = "Nhà sản xuất";
            dgrid_ChiTietGiay.Columns[6].Name = "Kiểu dáng";
            dgrid_ChiTietGiay.Columns[7].Name = "Tên sản phẩm";
            dgrid_ChiTietGiay.Columns[8].Name = "Mã";
            dgrid_ChiTietGiay.Columns[9].Name = "Giá nhập";
            dgrid_ChiTietGiay.Columns[10].Name = "Giá bán";
            dgrid_ChiTietGiay.Columns[11].Name = "Số lượng";
            dgrid_ChiTietGiay.Columns[12].Name = "Số lượng tồn";
            dgrid_ChiTietGiay.Columns[13].Name = "Ảnh";
            dgrid_ChiTietGiay.Columns[14].Name = "Mô tả";
            dgrid_ChiTietGiay.Columns[15].Name = "Trạng thái";
            dgrid_ChiTietGiay.Rows.Clear();
            //_lstCTGiay = _IChiTietGiayService.GetViewChiTietGiay();
            //if (txt_TimKiem.Text != "")
            //{
            //    _lstCTGiay = _lstCTGiay.Where(p => p.Ma.ToLower().Contains(txt_Ma.Text.ToLower())).ToList();
            //}
            foreach (var x in _IChiTietGiayService.GetViewChiTietGiay().Where(c => c.Ma.ToLower().Contains(txt_TimKiem.Text)).OrderBy(c => c.Ma).ToList())
            {
                dgrid_ChiTietGiay.Rows.Add(x.Id,
                    x.TenSize,
                    x.TenMauSac,
                    x.TenChatLieu,
                    x.TenDeGiay,
                    x.TenNSX,
                    x.TenKieuDang,
                    x.TenSanPham,
                    x.Ma,
                    x.GiaNhap,
                    x.GiaBan,
                    x.SoLuong,
                    x.SoLuongTon,
                    x.Anh,
                    x.MoTa,
                    x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                    );
            }
        }

        private void txt_TimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            LoadData_timKiem(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {


                LoadData();
                return;
            }
        }

        private void btn_AddSize_Click(object sender, EventArgs e)
        {
            FrmSize frmSize = new FrmSize();
            frmSize.ShowDialog();
            cmb_TenSize.Items.Clear();
            LoadComboBox();
        }

        private void btn_AddNsx_Click(object sender, EventArgs e)
        {
            FrmNhaSanXuat frmNsx = new FrmNhaSanXuat();
            frmNsx.ShowDialog();
            cmb_Nsx.Items.Clear();
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSize frmSize = new FrmSize();
            frmSize.ShowDialog();
            cmb_TenSize.Items.Clear();
            LoadComboBox();
        }

        private void btn_AddMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac();
            frmMauSac.ShowDialog();
            cmb_MauSac.Items.Clear();
            LoadComboBox();
        }

        private void btn_AddLoaiDe(object sender, EventArgs e)
        {
            FrmDeGiay frmDeGiay = new FrmDeGiay();
            frmDeGiay.ShowDialog();
            cmb_LoaiDe.Items.Clear();
            LoadComboBox();
        }

        private void btn_kieuDang(object sender, EventArgs e)
        {
            FrmKieuDang frmKieuDang = new FrmKieuDang();
            frmKieuDang.ShowDialog();
            cmb_KieuDang.Items.Clear();
            LoadComboBox();
        }
        private void btn_AddChatLieu(object sender, EventArgs e)
        {
            FrmChatLieu frmchatLieu = new FrmChatLieu();
            frmchatLieu.ShowDialog();
            cmb_ChatLieu.Items.Clear();
            LoadComboBox();
        }

        //private void btn_AddSanPham(object sender, EventArgs e)
        //{
        //    FrmSanPham frmSanPham = new FrmSanPham();
        //    frmSanPham.ShowDialog();
        //    cmb_SanPham.Items.Clear();
        //    LoadComboBox();
        //}

        private void btn_AddSp_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.ShowDialog();
            cmb_SanPham.Items.Clear();
            LoadComboBox();
        }

        private void btn_AddAnh1_Click(object sender, EventArgs e)
        {
            FrmAnh frmAnh = new FrmAnh();
            frmAnh.ShowDialog();
            cmb_Anh.Items.Clear();
            LoadComboBox();
        }
        private void ImportExcel(string path)
        {
            using (var excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRow = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRow.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRow.ToArray());
                }
                dgrid_ChiTietGiay.DataSource = dataTable;
            }
        }

        private void btn_NhapExcel_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Import file";
            //openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //openFileDialog.ShowDialog();
            //var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + openFileDialog.FileName + "';Extended Properties=Excel 12.0 Xml;");
            //conn.Open();
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", conn);
            //DataSet theSD = new DataSet();
            //DataTable dt = new DataTable();
            //dataAdapter.Fill(dt);
            //dgrid_ChiTietGiay.DataSource = dt.DefaultView;
            //if (dt.Columns.Count != 16)
            //{
            //    MessageBox.Show("Bạn Đã Chọn Sai File Để Thêm Số Lượng Lớn Sản Phẩm Số Cột Không Đáp Ứng Đúng Format", "Thông Báo");
            //    txt_TimKiem.Text = "";
            //    return;
            //}
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        ImportExcel(openFileDialog.FileName);
            //        MessageBox.Show("OK");
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("Khong dc roi\n" + ex.Message);
            //    }
            //}
            FrmImportExcel frmImportExcel = new FrmImportExcel();
            frmImportExcel.ShowDialog();
        }

       
        public void exportdata(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header;
            foreach (DataGridViewColumn col in dgrid_ChiTietGiay.Columns)
            {
                PdfPCell pdfPCell = new PdfPCell(new Phrase(col.HeaderText));
                pdfPTable.AddCell(pdfPCell);
            }
            foreach (DataGridViewRow row in dgrid_ChiTietGiay.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(Convert.ToString(cell.Value), text));
                }



            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A1, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }


        }
        private void btn_XuatPDF_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("bạn có muốn Xuất Ra File PDF Hay Không", "Thông Báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    exportdata(dgrid_ChiTietGiay, "test");
                    for (int i = 0; i < 2; i++)
                    {

                        MessageBox.Show("Xuất Ra File PDF Thành Công");

                    }
                    return;
                }
                if (dialogResult == DialogResult.No)
                {
                    for (int i = 0; i < 2; i++)
                    {

                        MessageBox.Show("Xuất Ra File PDF Thất Bại");

                    }
                    return;
                }

            }
            catch (Exception ex)
            {
                for (int i = 0; i < 2; i++)
                {

                    MessageBox.Show("Lỗi Rồi" + ex.Message);

                }

                return;
            }
        }

        private void txt_SoLuongTon_TextChanged(object sender, EventArgs e)
        {
            //if(Convert.ToInt32(txt_NgayBan.Text) > 0)
            //{
            //    cbx_HoatDong.Checked = true;
            //    cbx_khongHD.Checked = false;
            //}
            //else {
            //    cbx_HoatDong.Checked = false;
            //    cbx_khongHD.Checked = true;
            //}
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgrid_ChiTietGiay.ColumnCount = 16;
            //dgrid_ChiTietGiay.Columns[0].Name = "ID";
            //dgrid_ChiTietGiay.Columns[0].Visible = false;
            //dgrid_ChiTietGiay.Columns[1].Name = "Size";
            //dgrid_ChiTietGiay.Columns[2].Name = "Màu sắc";
            //dgrid_ChiTietGiay.Columns[3].Name = "Chất liệu";
            //dgrid_ChiTietGiay.Columns[4].Name = "Loại đế";
            //dgrid_ChiTietGiay.Columns[5].Name = "Nhà sản xuất";
            //dgrid_ChiTietGiay.Columns[6].Name = "Kiểu dáng";
            //dgrid_ChiTietGiay.Columns[7].Name = "Tên sản phẩm";
            //dgrid_ChiTietGiay.Columns[8].Name = "Mã sản phẩm";
            //dgrid_ChiTietGiay.Columns[9].Name = "Giá nhập";
            //dgrid_ChiTietGiay.Columns[10].Name = "Giá bán";
            //dgrid_ChiTietGiay.Columns[11].Name = "Số lượng";
            //dgrid_ChiTietGiay.Columns[12].Name = "Số lượng tồn";
            //dgrid_ChiTietGiay.Columns[13].Name = "Ảnh";
            //dgrid_ChiTietGiay.Columns[14].Name = "Mô tả";
            //dgrid_ChiTietGiay.Columns[15].Name = "Trạng thái";
            //dgrid_ChiTietGiay.Rows.Clear();
            ////_lstCTGiay = _IChiTietGiayService.GetViewChiTietGiay();
            ////if (txt_TimKiem.Text != "")
            ////{
            ////    _lstCTGiay = _lstCTGiay.Where(p => p.Ma.ToLower().Contains(txt_Ma.Text.ToLower())).ToList();
            ////}
            //foreach (var x in _IChiTietGiayService.GetViewChiTietGiay().Where(c => c.TrangThai == cmb_Loc.SelectedIndex).OrderBy(c => c.Ma).ToList())
            //{
            //    dgrid_ChiTietGiay.Rows.Add(x.Id,
            //        x.TenSize,
            //        x.TenMauSac,
            //        x.TenChatLieu,
            //        x.TenDeGiay,
            //        x.TenNSX,
            //        x.TenKieuDang,
            //        x.TenSanPham,
            //        x.Ma,
            //        x.GiaNhap,
            //        x.GiaBan,
            //        x.SoLuong,
            //        x.SoLuongTon,
            //        x.Anh,
            //        x.MoTa,
            //        x.TrangThai == 1 ? "Còn hàng" : "Hết hàng"
            //        );
            //}
        }

        private void cmb_Loc_Leave(object sender, EventArgs e)
        {
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgrid_ChiTietGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string DuongDan = @"D:\PRO131\QRCode";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = DuongDan;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pic_QuetBarcode.Image.Save(dialog.FileName);
            }
            //FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            //FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            //FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic_QuetBarcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmChiTietGiay_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    if (FinalFrame.IsRunning == true)
        //        FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pic_QuetBarcode.Image);
            try
            {
                string decoded = result?.ToString().Trim();
                if (decoded != "")
                {
                    txt_MaVach.Text = decoded;
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txt_MaVach_Leave(object sender, EventArgs e)
        {
            var options = new QrCodeEncodingOptions
            {
                Height = pic_QuetBarcode.Height,
                Width = pic_QuetBarcode.Width,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var text = txt_MaVach.Text;
            var result = writer.Write(text);
            pic_QuetBarcode.Image = result;
        }
        public string ChuCaiDau(string value)
        {
            return Convert.ToString(value[0]);
        }
        public string MaCTGiay()
        {
            string name = string.Concat(ChuCaiDau(cmb_MauSac.Text), ChuCaiDau(cmb_Nsx.Text), ChuCaiDau(cmb_ChatLieu.Text), ChuCaiDau(cmb_LoaiDe.Text), ChuCaiDau(cmb_KieuDang.Text),
                ChuCaiDau(cmb_SanPham.Text)/* ,cmb_TenSize.Text ,*/,_IChiTietGiayService.GetAllCTGiay().Count + 1);
            return name;
        }
    }
}
//XNVĐsV4
//CNVĐsV4
