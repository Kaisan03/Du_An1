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

namespace _3.PL.Views
{
    public partial class FrmChiTietGiay : Form
    {
        private FrmSize _frmSize;
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
            _frmSize = new FrmSize();
            LoadData();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            foreach (var x in _ISanPhamService.GetAllSanPham())
            {
                cmb_SanPham.Items.Add(x.Ten);
            }
            foreach (var x in _ISizeService.GetAllSize())
            {
                
                cmb_TenSize.Items.Add(x.Ten);
                
            }
            foreach (var x in _IDeGiayService.GetAllDeGiay())
            {
                cmb_LoaiDe.Items.Add(x.Ten);
            }
            foreach (var x in _IKieuDangService.GetAllKieuDang())
            {
                cmb_KieuDang.Items.Add(x.Ten);
            }
            foreach (var x in _INsxService.GetAllNSX())
            {
                cmb_Nsx.Items.Add(x.Ten);
            }
            foreach (var x in _IMauSacService.GetAllMauSac())
            {
                cmb_MauSac.Items.Add(x.Ten);
            }
            foreach (var x in _IChatLieuService.GetAllChatLieu())
            {
                cmb_ChatLieu.Items.Add(x.Ten);
            }
            foreach (var x in _IAnhService.GetAllAnh())
            {
                cmb_Anh.Items.Add(x.DuongDan);
            }
        }
        private void LoadData()
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
            foreach (var x in _IChiTietGiayService.GetViewChiTietGiay().OrderBy(c => c.Ma).ToList())
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
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
                    MoTa = txt_moTa.Text,
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0
                };
                _IChiTietGiayService.AddCTGiay(addCTGiay);
                MessageBox.Show("Thêm thành công");
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
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0
                };
                _IChiTietGiayService.UpdateCTGiay(updateGiay);
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _IChiTietGiayService.DeleteCTGiay(_idCTGiay);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
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
                cbx_HoatDong.Checked = sp.TrangThai == 1;
                cbx_khongHD.Checked = sp.TrangThai == 0;
                pic_ImageGiay.ImageLocation = cmb_Anh.Text;
            }
        }
        private void cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HoatDong.Checked)
            {
                cbx_khongHD.Checked = false;
            }
        }

        private void cbx_khongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_khongHD.Checked)
            {
                cbx_HoatDong.Checked = false;
            }
        }

        private void FrmChiTietGiay_Load(object sender, EventArgs e)
        {

        }

        private void FrmChiTietGiay_Load_1(object sender, EventArgs e)
        {

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
    }
}
