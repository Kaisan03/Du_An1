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
        private readonly ISanPhamService _ISanPhamService;
        private readonly IChiTietGiayService _IChiTietSPService;
        
        private IHoaDonService _IHoaDonService;
        private IHoaDonChiTietService _IHoaDonCTService;
        
        public ChiTietGiay _chiTietGiay;
       
        public Guid _ctspId;
        public HoaDon _hoaDonCho;
        public List<ViewHoaDon> _ViewHoaDonList;
        int? slt;
        public FrmBanHang()
        {
            InitializeComponent();
            _ISanPhamService = new SanPhamService();
            _IChiTietSPService = new ChiTietGiayService();
           
            _IHoaDonService = new HoaDonService();
            _IHoaDonCTService = new _2.BUS.Services.HoaDonChiTiet();
            
            LoadSanPham();
            LoadGioHang();
            LoadHDcho();
            anhcaidmm();
           
        }
        public void LoadHDcho()
        {
            dgrid_HoaDonCho.ColumnCount = 3;
            dgrid_HoaDonCho.Columns[0].Name = "ID";
            dgrid_HoaDonCho.Columns[0].Visible = false;
            dgrid_HoaDonCho.Columns[1].Name = "Mã";
            dgrid_HoaDonCho.Columns[2].Name = "Trạng thái";
            dgrid_HoaDonCho.Rows.Clear();
            foreach (var x in _IHoaDonService.GetallHoadon())// .Where(c => c.TrangThai == 1).OrderBy(c => c.Ma).ToList()
            {
                dgrid_HoaDonCho.Rows.Add(x.Id, x.Ma, x.TrangThai == 1 ? "Chưa Sử Lý" : "Đã thanh toán");
            }

        }
        public void LoadGioHang()
        {
            dgrid_GioHang.ColumnCount = 11;
            dgrid_GioHang.Columns[0].Name = "Mã";
            dgrid_GioHang.Columns[1].Name = "Tên";
            dgrid_GioHang.Columns[2].Name = "Số Lượng";
            dgrid_GioHang.Columns[3].Name = "Đơn Giá";
            dgrid_GioHang.Columns[4].Name = "Tổng";
            dgrid_GioHang.Columns[5].Name = "Màu sắc";
            dgrid_GioHang.Columns[6].Name = "Kiểu dáng";
            dgrid_GioHang.Columns[7].Name = "NSX";
            dgrid_GioHang.Columns[8].Name = "Size";
            dgrid_GioHang.Columns[9].Name = "Đế giày";
            dgrid_GioHang.Columns[10].Name = "ID ctsp";
            dgrid_GioHang.Columns[10].Visible = false;
            dgrid_GioHang.Rows.Clear();
            //DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //column.HeaderText = "Add";
            //column.Text = "Add";
            //column.Name = "txt_add";
            //column.UseColumnTextForButtonValue = true;
            //dgrid_GioHang.Columns.Add(column);
            //foreach (var x in _lstGiohang)
            //{
            //    var ctsp = _IChiTietSPService.GetAllSPView().FirstOrDefault(c => c.ChiTietGiay.Id == x.IdChiTietGiay);
            //    dgrid_GioHang.Rows.Add(
            //        ctsp.SanPham.Ma,
            //        ctsp.SanPham.Ten,
            //        x.SoLuong,
            //        x.DonGia,
            //        x.SoLuong * x.DonGia,
            //        ctsp.MauSac.Ten,
            //        ctsp.KieuDang.Ten,
            //        ctsp.Nsx.Ten,
            //        ctsp.Size.Ten,
            //        ctsp.DeGiay.Ten,
            //        x.IdChiTietGiay
            //        );
            //}
        }
        public void LoadSanPham()
        {
            dgrid_SanPham.ColumnCount = 10;
            dgrid_SanPham.Columns[0].Name = "Id";
            dgrid_SanPham.Columns[0].Visible = false;
            dgrid_SanPham.Columns[1].Name = "Mã";
            dgrid_SanPham.Columns[2].Name = "Tên";
            dgrid_SanPham.Columns[3].Name = "Số Lượng tồn";
            dgrid_SanPham.Columns[4].Name = "Đơn giá";
            dgrid_SanPham.Columns[5].Name = "Kiểu dáng";
            dgrid_SanPham.Columns[6].Name = "Màu Sắc";
            dgrid_SanPham.Columns[7].Name = "NSX";
            dgrid_SanPham.Columns[8].Name = "Sizee";
            dgrid_SanPham.Columns[9].Name = "Đế giày";
            
            
            dgrid_SanPham.Rows.Clear();
            foreach (var x in _IChiTietSPService.GetAllSPView().OrderBy(c => c.SanPham.Ma).ToList())
            {
               // Image img2 = Image.FromFile(x.Anh.DuongDan);
                dgrid_SanPham.Rows.Add(
                    x.ChiTietGiay.Id,
                    x.SanPham.Ma,
                    x.SanPham.Ten,
                    x.ChiTietGiay.SoLuongTon,
                    x.ChiTietGiay.GiaBan,
                    x.KieuDang.Ten,
                    x.MauSac.Ten,
                    x.Nsx.Ten,
                    x.Size.Ten,
                    x.DeGiay.Ten
                    );
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
                dgrid_SanPham.Columns.Add(img);
                
                for (int i = 0; i < dgrid_SanPham.RowCount; i++)
                {

                    foreach (var x in _IChiTietSPService.GetAllSPView().OrderBy(c => c.SanPham.Ma).ToList())
                    {
                        Image img2 = Image.FromFile(x.Anh.DuongDan);
                        dgrid_SanPham.Rows[i].Cells["img_anh"].Value = img2;

                    }

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
          //  var sp = _IChiTietSPService.GetAllCTGiay().FirstOrDefault(c => c.Id == id);
          ////  var data = .FirstOrDefault(c => c.IdChiTietGiay == id);
          //  if (sp.SoLuongTon <= 0)
          //  {
          //      MessageBox.Show("Số lượng hàng đã hết");
          //  }
          //  else
          //  if (data == null)
          //  {
              
          //  }
          //  else
          //  {
          //      data.SoLuong++;
          //  }
            
            LoadGioHang();
        }
        private void dgrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var x in _IChiTietSPService.GetViewChiTietGiay())
            {
                x.SoLuong -= 1;
                if (x.SoLuongTon == 0)
                {
                     MessageBox.Show("Sản Phẩm đã hết");
                    return;
                }
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow r = dgrid_SanPham.Rows[e.RowIndex];
                    _ctspId = _IChiTietSPService.GetAllSPView().FirstOrDefault(c => c.ChiTietGiay.Id == Guid.Parse(r.Cells[0].Value.ToString())).ChiTietGiay.Id;

                    AddGioHang(_ctspId);
                    return;
                }
                LoadSanPham();
            }
            
            
        }
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tạo hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{

            //    var hoaDon = new ViewHoaDon()
            //    {
            //        Id = Guid.NewGuid(),
            //        Ma = (_IHoaDonService.GetallHoadon().Count + 1).ToString(),
                    
            //        TrangThai = 1
            //    };
            //    _IHoaDonService.Add(hoaDon);
            //    MessageBox.Show("Tạo hóa đơn thành công");
            //    _lstGiohang = new List<GioHangChiTiet>();
            //    LoadGioHang();
            //    LoadSanPham();
            //    LoadHDcho();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
            //Gr_sanpham.Enabled = true;
            //Gr_giohang.Enabled = true;
        }

        private void dgrid_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _IChiTietSPService.GetAllSPView().Count) return;
            DataGridViewRow r = dgrid_GioHang.Rows[e.RowIndex];
            _ctspId = Guid.Parse(r.Cells[10].Value.ToString());
        }

        private void dgrid_HoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_HoaDonCho.Rows[e.RowIndex];
                _hoaDonCho = _IHoaDonService.GetallHoadon().FirstOrDefault(x => x.Id == Convert.ToInt16(r.Cells[0].Value.ToString()));
                lbl_MahoaDon.Text = r.Cells[1].Value.ToString();
                lbl_TongTien.Text = _IHoaDonCTService.GetAllHoaDonCT().Where(x => x.IdHoaDon == _hoaDonCho.Id).Sum(x => x.DonGia * x.SoLuong).ToString();
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
            //if (_lstGiohang.Any())
            //{

            //    foreach (var item in _lstGiohang)
            //    {
            //        var hoaDon = new ViewHoaDon();
            //        var idhd = _IHoaDonService.GetallHoadon().Max(x => x.Id);

            //        var hdct = new _1.DAL.DomainClass.HoaDonChiTiet()
            //        {
            //            Id = Guid.NewGuid(),
            //            IdHoaDon = idhd,
            //            IdChiTietGiay = item.IdChiTietGiay,
            //            SoLuong = item.SoLuong,
            //            DonGia = item.DonGia
            //        };

            //        var sp = _IChiTietSPService.GetAllCTGiay().FirstOrDefault(x => x.Id == item.IdChiTietGiay);
            //        if (sp.SoLuongTon<=0)
            //        {
            //            MessageBox.Show("Số lượng sản phẩm không đủ");
            //            return;
            //        }
            //        else
            //        {
            //            sp.SoLuongTon -= item.SoLuong;
            //            _IChiTietSPService.UpdateCTGiay2(sp);
            //            _IHoaDonCTService.Add(hdct);
            //        }

            //    }

            //}
            //else
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
            //        _IHoaDonService.Update(_hoaDonCho);
            //        LoadHDcho();
            //        MessageBox.Show("Thanh toán thành công");
            //    }
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    var x = _lstGiohang.FirstOrDefault(x => x.IdChiTietGiay == _ctspId);
            //    _lstGiohang.Remove(x);
            //    MessageBox.Show("Xóa sản phẩm thành công");
            //    LoadGioHang();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void btn_XoaHet_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    _lstGiohang = new List<GioHangChiTiet>();
            //    MessageBox.Show("Đã xóa hết");
            //    LoadGioHang();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void FrmBanHang_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgrid_HoaDonCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_TongTien_Click(object sender, EventArgs e)
        {
            
        }
    }
}