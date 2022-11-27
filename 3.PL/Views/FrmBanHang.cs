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
        private int rowindex = 0;
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

            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "Id";
            dgrid_chitietgiay.Columns[0].Visible = false;
            dgrid_chitietgiay.Columns[1].Name = "Mã";
            dgrid_chitietgiay.Columns[2].Name = "Tên";
            dgrid_chitietgiay.Columns[3].Name = "Số Lượng tồn";
            dgrid_chitietgiay.Columns[4].Name = "Đơn giá";
            dgrid_chitietgiay.Columns[5].Name = "Size";
            dgrid_chitietgiay.Columns[5].Visible = false;
            dgrid_chitietgiay.Columns[6].Name = "Chất liệu";
            dgrid_chitietgiay.Columns[6].Visible = false;
            dgrid_chitietgiay.Columns[7].Name = "Nhà sản xuất";
            dgrid_chitietgiay.Columns[7].Visible = false;
            dgrid_chitietgiay.Columns[8].Name = "Màu sắc";
            dgrid_chitietgiay.Columns[8].Visible = false;
            dgrid_chitietgiay.Columns[9].Name = "Đế giày";
            dgrid_chitietgiay.Columns[9].Visible = false;
            dgrid_chitietgiay.Columns[10].Name = "Kiểu dáng";
            dgrid_chitietgiay.Columns[10].Visible = false;
            dgrid_chitietgiay.Columns[11].Name = "Ảnh";
            dgrid_chitietgiay.Columns[11].Visible = false;
            dgrid_chitietgiay.Rows.Clear();


            foreach (var x in _chiTietGiayService.GetAllSPView().OrderBy(c => c.SanPham.Ma).ToList())
            {
                Image img2 = Image.FromFile(x.Anh.DuongDan);


                dgrid_chitietgiay.Rows.Add(x.ChiTietGiay.Id,
                    x.SanPham.Ma,
                    x.SanPham.Ten,
                    x.ChiTietGiay.SoLuongTon,
                    x.ChiTietGiay.GiaBan,
                    x.Size.Ten, x.ChatLieu.Ten, x.Nsx.Ten, x.MauSac.Ten, x.DeGiay.Ten, x.KieuDang.Ten, x.Anh.DuongDan
                    );
            }
            anhcaidmm();

        }
        public void loadGiohang()
        {
            dgrid_giaydachon.Rows.Clear();
            dgrid_giaydachon.ColumnCount = 5;
            dgrid_giaydachon.Columns[0].Name = "id";
            dgrid_giaydachon.Columns[0].Visible = false;
            dgrid_giaydachon.Columns[1].Name = "Tên sản phẩm";
            dgrid_giaydachon.Columns[2].Name = "Số lượng";
            dgrid_giaydachon.Columns[3].Name = "Giá sản phẩm";
            dgrid_giaydachon.Columns[4].Name = "Thành tiền";

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
                dgrid_giaydachon.Rows.Add(x.Id, g.TenSanPham, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong);
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

                for (int i = 0; i < dgrid_chitietgiay.RowCount-1; i++)
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
            //_ctspId = Guid.Parse(r.Cells[10].Value.ToString());
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
                    IdHoaDon = _hoaDonService.GetallHoadon().Max(c => c.Id),
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

        private void gr_thanhtoan_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_HoaDon.Visible = true;
            pn_HoaDon.BringToFront();
            pn_GiaoHang.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pn_GiaoHang.Visible = true;
            pn_HoaDon.BringToFront();
            pn_HoaDon.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string tenhh = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[2].Value);
            string size = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[5].Value);
            string chatlieu = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[6].Value);
            string mausac = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[8].Value);
            string kieudang = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[10].Value);
            string degiay = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[9].Value);
            string giaban = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[4].Value);
            string anh = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[11].Value);
            FrmThongTinSP frmttSP = new FrmThongTinSP(tenhh, size, chatlieu, mausac, kieudang, degiay, giaban, anh);
            frmttSP.Show();
        }

        private void flp_SanPham_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void dgrid_chitietgiay_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgrid_chitietgiay.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dgrid_chitietgiay.CurrentCell = this.dgrid_chitietgiay.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgrid_chitietgiay, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
//dgrid_chitietgiay.Columns[0].Name = "Id";
//dgrid_chitietgiay.Columns[0].Visible = false;
//dgrid_chitietgiay.Columns[1].Name = "Mã";
//dgrid_chitietgiay.Columns[2].Name = "Tên";
//dgrid_chitietgiay.Columns[3].Name = "Số Lượng tồn";
//dgrid_chitietgiay.Columns[4].Name = "Đơn giá";