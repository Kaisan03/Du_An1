using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmBanHang : Form
    {
        public IChiTietGiayService _chiTietGiayService;
        public IHoaDonService _hoaDonService;
        public IHoaDonChiTietService _hoaDonChiTietService;
        public IAnhService _anhService;
        public IDeGiayService _DeGiayService;
        public IChatLieuService _chatLieuService;
        public INhaSanXuatService _nhaSanXuatService;
        public IMauSacService _MausacService;
        public ISizeService _sizeService;
        public ISanPhamService _sanPhamService;
        public Guid _ctspId;
        public List<SanPhamCTView> _sanPhamCTView;
        public List<ViewHoaDonChiTiet> _viewHoaDonChiTiets;
        public HoaDon _hoaDonCho;
        public FrmBanHang()
        {
            InitializeComponent();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _chiTietGiayService = new ChiTietGiayService();
            _hoaDonService = new HoaDonService();
            _anhService = new AnhService();
            _DeGiayService = new DeGiayService();
            _chatLieuService = new ChatLieuService();
            _nhaSanXuatService = new NhaSanXuatService();
            _MausacService = new MauSacService();
            _sizeService = new SizeService();
            _sanPhamService = new SanPhamService();
            _sanPhamCTView = new List<SanPhamCTView>();
            _viewHoaDonChiTiets = new List<ViewHoaDonChiTiet>();
            _hoaDonCho = new HoaDon();
            LoadDataGiay();
            loadGiohang();
            Loaddatahoadon();
        }


        public void LoadDataGiay()
        {

            dgrid_chitietgiay.Rows.Clear();
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "id";
            dgrid_chitietgiay.Columns[0].Visible = false;
            dgrid_chitietgiay.Columns[1].Name = "Tên Sản Phẩm";
            dgrid_chitietgiay.Columns[2].Name = "Size";
            dgrid_chitietgiay.Columns[3].Name = "Nhà Sản Xuất";
            dgrid_chitietgiay.Columns[4].Name = "Màu";
            dgrid_chitietgiay.Columns[5].Name = "Chất Liệu";
            dgrid_chitietgiay.Columns[6].Name = "Kiểu Dáng";
            dgrid_chitietgiay.Columns[7].Name = "Số Lượng";
            dgrid_chitietgiay.Columns[8].Name = "Giá bán";
            dgrid_chitietgiay.Columns[9].Name = "Trạng Thái";
            dgrid_chitietgiay.Columns[10].Name = "Mô tả";
            dgrid_chitietgiay.Columns[11].Name = "Ảnh";
           
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay())
            {
                dgrid_chitietgiay.Rows.Add(x.Id, x.TenSanPham, x.TenSize, x.TenNSX, x.TenMauSac, x.TenChatLieu, x.TenKieuDang, x.SoLuong, x.GiaBan, x.TrangThai == 1 ? "Còn Hàng" : "Hết Hàng", x.MoTa, x.Anh);
            }
        }
        public void loadGiohang()
        {
            dgrid_giaydachon.Rows.Clear();
            dgrid_giaydachon.ColumnCount = 9;
            dgrid_giaydachon.Columns[0].Name = "id";
            dgrid_giaydachon.Columns[0].Visible = false;
            dgrid_giaydachon.Columns[1].Name = "Tên Người Nhận";
            dgrid_giaydachon.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_giaydachon.Columns[3].Name = "Số Lượng";
            dgrid_giaydachon.Columns[4].Name = "Giá sản Phẩm";
            dgrid_giaydachon.Columns[5].Name = "Thành Tiên";
            dgrid_giaydachon.Columns[6].Name = "Ngày Tạo Hóa Đơn";
            dgrid_giaydachon.Columns[7].Name = "Trạng Thái";
            dgrid_giaydachon.Columns[8].Name = "idchitietgiay";
            dgrid_giaydachon.Columns[8].Visible = false;
            //dgrid_giaydachon.Columns[9].Name = "id";
            //dgrid_giaydachon.Columns[10].Name = "id";
            foreach (var x in _hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == _hoaDonService.GetallHoadon().Max(c => c.Id)))
            {
                var hd = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Id == x.IdHoaDon);
                var g = _chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);
                //dgrid_giaydachon.Rows.Add(
                //    x.HoaDonChiTiet.Id,
                //    x.HoaDon.TenNguoiNhan,
                //    x.HoaDon.TenSp,
                //    x.HoaDonChiTiet.SoLuong,
                //    x.ChiTietGiay.GiaBan,
                //    x.ChiTietGiay.GiaBan * x.HoaDonChiTiet.SoLuong,
                //    x.HoaDon.NgayTao, 
                //    x.HoaDonChiTiet.TrangThai == 0 ? "Chưa Xử Lý" : x.HoaDon.TrangThai == 1 ? "Đã Thanh Toán" : "Đang Giao",
                //    x.ChiTietGiay.Id)
                //    ;
                dgrid_giaydachon.Rows.Add(x.Id, x.IdHoaDon, hd.TenSp, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong, hd.NgayTao, x.TrangThai == 0 ? "Chưa Xử Lý" : x.TrangThai == 1 ? "Đã Thanh Toán" : "Đang Giao", x.IdChiTietGiay);
            }
        }
        public void Loaddatahoadon()
        {
            dgrid_hoadondatao.Rows.Clear();
            dgrid_hoadondatao.ColumnCount = 5;
            dgrid_hoadondatao.Columns[0].Name = "id";
            dgrid_hoadondatao.Columns[0].Visible = false;
            dgrid_hoadondatao.Columns[1].Name = "Mã";
            dgrid_hoadondatao.Columns[2].Name = "Ngày Tạo ";
            dgrid_hoadondatao.Columns[3].Name = "Ngày thanh toán";
            dgrid_hoadondatao.Columns[4].Name = "Trạng Thái";
            //dgrid_hoadondatao.Columns[5].Name = "id";
            //dgrid_hoadondatao.Columns[6].Name = "id";
            //dgrid_hoadondatao.Columns[7].Name = "id";
            foreach (var x in _hoaDonService.GetallHoadon())
            {
                dgrid_hoadondatao.Rows.Add(x.Id, x.Ma, x.NgayTao, x.NgayThanhToan, x.TrangThai == 0 ? "Chưa sử lý" : x.TrangThai == 1 ? "Đã Thanh Toán" : "Đang giao hàng");
            }
        }

        public void anhcaidmm()
        {
            try
            {
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.HeaderText = "Ảnh";
                img.Name = "img_anh";
                img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgrid_chitietgiay.Columns.Add(img);

                for (int i = 0; i < dgrid_chitietgiay.RowCount; i++)
                {

                    var x = _chiTietGiayService.GetAllSPView().FirstOrDefault(c => c.SanPham.Ma == dgrid_chitietgiay.Rows[i].Cells["Mã"].Value);

                    Image img2 = Image.FromFile(x.Anh.DuongDan.ToString());
                    dgrid_chitietgiay.Rows[i].Cells["img_anh"].Value = img2;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex), "Lỗi cmm");
                return;

            }
        }

        public void AddGioHang(Guid id)
        {
            var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == id);
            var data = _viewHoaDonChiTiets.FirstOrDefault(c => c.HoaDonChiTiet.IdChiTietGiay == id);

            if (sp.SoLuongTon <= 0)
            {
                MessageBox.Show("Số lượng hàng đã hết");
            }
            else
            if (data == null)
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                {
                    Id = Guid.NewGuid(),
                    IdChiTietGiay = id,
                    DonGia = sp.GiaBan,
                    // IdHoaDon = data.IdHoaDon,
                    SoLuong = 1,

                };
                _hoaDonChiTietService.Add(hoaDonChiTiet);
            }
            else
            {
                data.HoaDonChiTiet.SoLuong++;
            }
            loadGiohang();
        }
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tạo hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int id11 = (_hoaDonService.GetallHoadon().Max(c => c.Id) + 1);
                var hoaDon = new ViewHoaDon()
                {
                    Id = id11,
                    Ma = "HD00" + (_hoaDonService.GetallHoadon().Max(c => c.Id) + 1).ToString(),
                    NgayTao = DateTime.Now,
                    TrangThai = 0,

                };
                _hoaDonService.Add(hoaDon);
                MessageBox.Show("Tạo hóa đơn thành công");
                LoadDataGiay();
                loadGiohang();
                Loaddatahoadon();

                MessageBox.Show("Mời bạn chọn sản phẩm", Convert.ToString(MessageBoxButtons.OK));
               // dgrid_hoadondatao.Enabled = false;
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Gr_sanpham.Enabled = true;
            Gr_giohang.Enabled = true;
        }

        private void dgrid_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _chiTietGiayService.GetAllSPView().Count) return;
            DataGridViewRow r = dgrid_giaydachon.Rows[e.RowIndex];
            _ctspId = Guid.Parse(r.Cells[10].Value.ToString());
        }

        private void dgrid_HoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_hoadondatao.Rows[e.RowIndex];
                _hoaDonCho = _hoaDonService.GetallHoadon().FirstOrDefault(x => x.Id == Convert.ToInt16(r.Cells[0].Value.ToString()));
                lbl_MahoaDon.Text = r.Cells[1].Value.ToString();
                lbl_TongTien.Text = _hoaDonChiTietService.GetAllHoaDonCT().Where(x => x.IdHoaDon == _hoaDonCho.Id).Sum(x => x.DonGia * x.SoLuong).ToString();
            }
        }
        private void txt_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_TienKhachDua.Text, out int x))
            {
                lbl_TienThua.Text = (decimal.Parse(txt_TienKhachDua.Text) - decimal.Parse(lbl_TongTien.Text)).ToString();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

            foreach (var item in _hoaDonChiTietService.GetAllHoaDonCT())
            {
                var hoaDon = new ViewHoaDon();
                var idhd = _hoaDonService.GetallHoadon().Max(x => x.Id);

                var hdct = new _1.DAL.DomainClass.HoaDonChiTiet()
                {
                    Id = Guid.NewGuid(),
                    IdHoaDon = idhd,
                    IdChiTietGiay = item.IdChiTietGiay,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia
                };

                var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(x => x.Id == item.IdChiTietGiay);
                if (sp.SoLuongTon <= 0)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ");
                    return;
                }
                else
                {
                    sp.SoLuongTon -= item.SoLuong;
                    _chiTietGiayService.UpdateCTGiay2(sp);
                    _hoaDonChiTietService.Add(hdct);
                }
                //if (sp.s)
                //{

                //}
                // else
                //{
                //    MessageBox.Show("Chưa có sản phẩm trong giỏ hàng");
                //}

                //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    if (txt_TienKhachDua.Text == "")
                //    {
                //        MessageBox.Show("Không được để trống!");
                //    }
                //    else if (int.Parse(lbl_TienThua.Text) < 0)
                //    {
                //        MessageBox.Show("Thiếu tiền");
                //    }
                //    else if (!int.TryParse(txt_TienKhachDua.Text, out int x))
                //    {
                //        MessageBox.Show("Tiền khách đưa phải là số");
                //    }
                //    else
                //    {
                //        _hoaDonCho.TrangThai = 2;
                //        _hoaDonService.Update(_hoaDonCho);
                //        Loaddatahoadon();
                //        MessageBox.Show("Thanh toán thành công");
                //    }
                //}
                //if (dialogResult == DialogResult.No)
                //{
                //    return;
                //}
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = _hoaDonChiTietService.GetAllHoaDonCT().FirstOrDefault(x => x.IdChiTietGiay == _ctspId);
                _hoaDonChiTietService.Delete(x);
                MessageBox.Show("Xóa sản phẩm thành công");
                loadGiohang();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_XoaHet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //_hoaDonChiTietService = new List<HoaDonChiTiet>();
                MessageBox.Show("Đã xóa hết");
                loadGiohang();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }  
        private void dgrid_SanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrid_chitietgiay.Rows[e.RowIndex];
            var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
            var data = _viewHoaDonChiTiets.FirstOrDefault(c => c.HoaDonChiTiet.IdChiTietGiay == Guid.Parse(r.Cells[0].Value.ToString()));
            if (sp.SoLuongTon <= 0)
            {
                 
            }

            if (data == null)
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                {
                    Id = Guid.NewGuid(),
                    IdChiTietGiay = Guid.Parse(r.Cells[0].Value.ToString()),
                    DonGia = sp.GiaBan,
                    IdHoaDon = _hoaDonService.GetallHoadon().Max(c=>c.Id),
                    SoLuong = 1,
                };
                _hoaDonChiTietService.Add(hoaDonChiTiet);
                sp.SoLuong--;
            }
            else
            {
                data.HoaDonChiTiet.SoLuong++;
                sp.SoLuong--;
            }
            loadGiohang();
            LoadDataGiay();
            
        }
    }
}