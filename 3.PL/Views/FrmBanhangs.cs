using _1.DAL.DomainClass;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmBanhangs : Form
    {
        //private ViewChiTietGiay _viewChiTietGiays;
        //private ViewHoaDonChiTiet _viewHoaDonChiTiet;

        private IChiTietGiayService _chiTietGiayService;
        private IHoaDonService _hoaDonService;
        private IHoaDonChiTietService _hoaDonChiTietService;
        private IAnhService _anhService;
        private IDeGiayService _DeGiayService;
        private IChatLieuService _chatLieuService;
        private INhaSanXuatService _nhaSanXuatService;
        private IMauSacService _MausacService;
        private ISizeService _sizeService;
        private ISanPhamService _sanPhamService;

        private Guid id12;
        private List<SanPhamCTView> _sanPhamCTView;
        private List<ViewHoaDonChiTiet> _viewHoaDonChiTiets;

        public FrmBanhangs()
        {
            InitializeComponent();
            _chiTietGiayService = new ChiTietGiayService();
            _hoaDonService = new HoaDonService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _anhService = new AnhService();
            _DeGiayService = new DeGiayService();
            _chatLieuService = new ChatLieuService();
            _nhaSanXuatService = new NhaSanXuatService();
            _MausacService = new MauSacService();
            _sizeService = new SizeService();
            _sanPhamService = new SanPhamService();
            _sanPhamCTView = new List<SanPhamCTView>();
            _viewHoaDonChiTiets = new List<ViewHoaDonChiTiet>();
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
            foreach (var x in _hoaDonChiTietService.GetViewHoaDonCT())
            {
                dgrid_giaydachon.Rows.Add(x.HoaDonChiTiet.Id, x.HoaDon.TenNguoiNhan, x.HoaDon.TenSp, x.HoaDonChiTiet.SoLuong, x.ChiTietGiay.GiaBan, x.ChiTietGiay.GiaBan * x.HoaDonChiTiet.SoLuong, x.HoaDon.NgayTao, x.HoaDonChiTiet.TrangThai == 0 ? "Chưa Xử Lý" : x.HoaDon.TrangThai == 1 ? "Đã Thanh Toán" : "Đang Giao", x.ChiTietGiay.Id);
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

        private void button3_Click(object sender, EventArgs e)
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
                gr_chonsanpham.Enabled = true;
                MessageBox.Show("Mời bạn chọn sản phẩm", Convert.ToString(MessageBoxButtons.OK));
                dgrid_hoadondatao.Enabled = false;

            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        private void dgrid_chitietgiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (var item in _hoaDonChiTietService.GetAllHoaDonCT())
            //{
            //    var hoaDon = new ViewHoaDon();
            //    var idhd = _hoaDonService.GetallHoadon().Max(x => x.Id);

            //    var hdct = new HoaDonChiTiet()
            //    {
            //        Id = Guid.NewGuid(),
            //        IdHoaDon = idhd,
            //        IdChiTietGiay = item.IdChiTietGiay,
            //        SoLuong = item.SoLuong,
            //        DonGia = item.DonGia
            //    };

            //    var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(x => x.Id == item.IdChiTietGiay);
            //    if (sp.SoLuongTon <= 0)
            //    {
            //        MessageBox.Show("Số lượng sản phẩm không đủ");
            //        return;
            //    }
            //    else
            //    {
            //        sp.SoLuongTon -= item.SoLuong;
            //        _chiTietGiayService.UpdateCTGiay2(sp);
            //        _hoaDonChiTietService.Add(hdct);
            //    }


            //}
            foreach (var item in _hoaDonChiTietService.GetAllHoaDonC1())
            {
                DataGridViewRow r = dgrid_chitietgiay.Rows[e.RowIndex];
               
                var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(x => x.Id == item.IdChiTietGiay);
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm vào giỏ hàng không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HoaDonChiTiet hoaDonChitiet = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        IdChiTietGiay = Guid.Parse(r.Cells[8].Value.ToString()),
                        IdHoaDon = _hoaDonService.GetallHoadon().Max(c => c.Id)+1,
                        TrangThai = 0,
                        DonGia = Convert.ToInt16(r.Cells[8].Value.ToString()),
                        SoLuong = +1,
                        ThanhTien = item.SoLuong  * item.DonGia,

                    }; _hoaDonChiTietService.Add(hoaDonChitiet);
                }
               
                LoadDataGiay();
                loadGiohang();
                Loaddatahoadon();
            }
        }
        private void dgrid_giaydachon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_giaydachon.Rows[e.RowIndex];
                var h =_hoaDonService.GetallHoadon().FirstOrDefault(x => x.Id == Convert.ToInt16(r.Cells[0].Value.ToString()));
                lbl_MahoaDon.Text = r.Cells[1].Value.ToString();
                lbl_TongTien.Text = _hoaDonChiTietService.GetAllHoaDonC1().Where(x => x.IdHoaDon == h.Id).Sum(x => x.DonGia * x.SoLuong).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // DataGridViewRow r = dgrid_chitietgiay.Rows[e.RowIndex];
           // var idhoadonchitiet = Guid.Parse(r.Cells[0].Value.ToString());
            HoaDonChiTiet hoaDonChi = new HoaDonChiTiet()
            {
                //Id = idhoadonchitiet,
            };
        }
    }
}
