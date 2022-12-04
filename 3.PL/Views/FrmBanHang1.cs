using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using ZXing.Windows.Compatibility;
using Button = System.Windows.Forms.Button;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;
using TextBox = System.Windows.Forms.TextBox;

namespace _3.PL.Views
{
    public partial class FrmBanHang1 : Form
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
        public IKieuDangService _kieuDangService;
        public List<SanPhamCTView> _sanPhamCTView;
        public List<ViewHoaDonChiTiet> _viewHoaDonChiTiets;
        public HoaDon _hoaDonCho;
        public List<HoaDonChiTiet> hoaDonChiTiets;
        private INhanVienService _nhanVienService;
        private IKhachHangService _khachHangService;
        private List<HoaDonChiTiet> _lstHDCT;
        private int rowindex = 0;
        private IKhachHangService _KHService;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private Guid _idCTG;

        public FrmBanHang1()
        {
            InitializeComponent();
            _chiTietGiayService = new ChiTietGiayService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _hoaDonService = new HoaDonService();
            _sizeService = new SizeService();
            _MausacService = new MauSacService();
            _kieuDangService = new KieuDangService();
            _nhaSanXuatService = new NhaSanXuatService();
            LoadSanPham();
            anhcaidmm();
            cookroi();
            cookroi1();

            dgrid_chitietgiay.AllowUserToAddRows = false;
            this.dgrid_chitietgiay.DefaultCellStyle.ForeColor = Color.Red;
            _KHService = new KhachHangService();
            FuckYou();
            AutoDiaChi();
            LoadDataLoc();
        }
        public FrmBanHang1(string a)
        {
            InitializeComponent();
            _chiTietGiayService = new ChiTietGiayService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _hoaDonService = new HoaDonService();
            lblNhanVien(a);
            LoadSanPham();
            anhcaidmm();
            cookroi();
            cookroi1();

            dgrid_chitietgiay.AllowUserToAddRows = false;
            this.dgrid_chitietgiay.DefaultCellStyle.ForeColor = Color.Red;
            _KHService = new KhachHangService();
            FuckYou();
        }
        public void LoadDataLoc()
        {
            var size = _sizeService.GetAllSize().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in size)
            {
                cmb_LocSize.Items.Add(x);
            }
            var mausac = _MausacService.GetAllMauSac().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in mausac)
            {
                cmb_LocMau.Items.Add(x);
            }
            var kieudang = _kieuDangService.GetAllKieuDang().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in kieudang)
            {
                cmb_LocKieuDang.Items.Add(x);
            }
            var nsx = _nhaSanXuatService.GetAllNSX().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in nsx)
            {
                cmb_LocNsx.Items.Add(x);
            }
        }
        public void LoadSanPham()
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            dgrid_chitietgiay.Columns[10].Visible = false;
            dgrid_chitietgiay.Columns[11].Name = "Ảnh";
            dgrid_chitietgiay.Columns[11].Visible = false;
            dgrid_chitietgiay.Rows.Clear();
            //var lstCTG = _chiTietGiayService.GetViewChiTietGiay();
            //if (txt_TimKiem.Text != "" && txt_TimKiem.Text != "Tìm kiếm....")
            //{
            //    lstCTG = _chiTietGiayService.GetViewChiTietGiay().Where(p => p.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower()) || p.TenSanPham.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            //}
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().OrderBy(c => c.Ma).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
        }
        private void LoadGioHang()
        {
            dgrid_GioHang.ColumnCount = 5;
            dgrid_GioHang.Columns[0].Name = "id";
            dgrid_GioHang.Columns[0].Visible = false;
            dgrid_GioHang.Columns[1].Name = "Tên sản phẩm";
            dgrid_GioHang.Columns[2].Name = "Số lượng";
            dgrid_GioHang.Columns[3].Name = "Giá sản phẩm";
            dgrid_GioHang.Columns[4].Name = "Thành tiền";
            dgrid_GioHang.Rows.Clear();
            dgrid_GioHang.AllowUserToAddRows = false;
            DataGridViewButtonColumn dgridBtn = new DataGridViewButtonColumn();
            dgridBtn.HeaderText = "Delete";
            dgridBtn.Name = "btn_dlt";
            dgridBtn.Text = "Xóa";
            dgridBtn.UseColumnTextForButtonValue = true;
            dgrid_GioHang.Columns.Add(dgridBtn);
            foreach (var x in _hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == lbl_MahoaDon.Text).Id))
            {
                var g = _chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);
                dgrid_GioHang.Rows.Add(x.Id, g.TenSanPham, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong);
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

                for (int i = 0; i < dgrid_chitietgiay.RowCount - 1; i++)
                {

                    var x = _chiTietGiayService.GetAllSPView().FirstOrDefault(c => c.Anh.DuongDan == dgrid_chitietgiay.Rows[i].Cells["Ảnh"].Value);

                    Image img2 = Image.FromFile(x.Anh.DuongDan.ToString());
                    dgrid_chitietgiay.Rows[i].Cells["img_anh"].Value = img2;

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Không thấy file ảnh ");
            }
        }
        public void anhcaidmm1()
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

                    var x = _chiTietGiayService.GetAllSPView().FirstOrDefault(c => c.Anh.DuongDan == dgrid_chitietgiay.Rows[i].Cells["Ảnh"].Value);

                    Image img2 = Image.FromFile(x.Anh.DuongDan.ToString());
                    dgrid_chitietgiay.Rows[i].Cells["img_anh"].Value = img2;

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Không thấy file ảnh ");
            }
        }
        private void dgrid_chitietgiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_chitietgiay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _chiTietGiayService.GetAllSPView().Count) return;
            if (rowindex >= 0)
            {
                _ctspId = Guid.Parse(dgrid_chitietgiay.Rows[rowindex].Cells[0].Value.ToString());
                AddGioHang(_ctspId);
                loadTien();
                loadTien1();
            }
        }
        private void AddGioHang(Guid id)
        {
            string content = Interaction.InputBox("Mời Bạn Nhập Số Lượng Muốn Thêm", "Thêm Vào Giỏ Hàng", "", 500, 300);
            var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == id);
            var idTmp = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == lbl_MahoaDon.Text).Id;
            var data = _hoaDonChiTietService.GetAllHoaDonCT().FirstOrDefault(c => c.IdChiTietGiay == id && c.IdHoaDon == idTmp);
            if (Convert.ToInt32(content) <= sp.SoLuongTon)
            {

                if (data == null || data.IdHoaDon != idTmp)
                {
                    sp.SoLuongTon -= Convert.ToInt32(content);
                    var hoaDonChiTiet = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        IdChiTietGiay = id,
                        IdHoaDon = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == lbl_MahoaDon.Text).Id,
                        DonGia = sp.GiaBan,
                        SoLuong = Convert.ToInt32(content)
                    };
                    _hoaDonChiTietService.Add(hoaDonChiTiet);
                    _chiTietGiayService.UpdateCTGiay2(sp);
                }
                else
                {
                    sp.SoLuongTon -= Convert.ToInt32(content);
                    data.SoLuong += Convert.ToInt32(content);
                    _hoaDonChiTietService.Update(data);
                    _chiTietGiayService.UpdateCTGiay2(sp);

                }
                LoadGioHang();
                LoadSanPham();
                anhcaidmm1();
            }
            else
            {
                MessageBox.Show("Số lượng sản phẩm không đủ");
            }


        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                int i = _hoaDonService.GetallHoadon().Count + 1;
                var hoaDon = new ViewHoaDon()
                {
                    Id = i,
                    Ma = "HD00" + (_hoaDonService.GetallHoadon().Count + 1).ToString(),
                    NgayTao = DateTime.Now,
                    TrangThai = 0,

                };
                _hoaDonService.Add(hoaDon);
                cookroi();

            }
        }
        private void cookroi()
        {
            while (flow_HDChuaTT.Controls.Count > 0)
            {
                flow_HDChuaTT.Controls[0].Dispose();
            }


            foreach (var i in _hoaDonService.GetallHoadon().Where(c => c.TrangThai == 0))
            {
                Button btn_HoaDonCho = new Button();

                btn_HoaDonCho.Text = i.Ma + Environment.NewLine + (i.TrangThai == 0 ? "Chưa thanh toán" : "Đã hủy");
                btn_HoaDonCho.ForeColor = Color.FromArgb(255, 89, 136);
                btn_HoaDonCho.Tag = i;
                btn_HoaDonCho.Width = 60;
                btn_HoaDonCho.Height = 60;
                btn_HoaDonCho.Name = $"btn_HDCho{i}";
                flow_HDChuaTT.Controls.Add(btn_HoaDonCho);
                btn_HoaDonCho.Click += Btn_HoaDonCho_Click;

            }
        }
        private void cookroi1()
        {
            while (flow_DangGiao.Controls.Count > 0)
            {
                flow_DangGiao.Controls[0].Dispose();
            }


            foreach (var i in _hoaDonService.GetallHoadon().Where(c=>c.NgayGiao!=null&&c.TrangThai!=5 && c.TrangThai != 6))
            {
                Button btn_HoaDonCho = new Button();
                string[] a = i.NgayNhanHang.ToString().Split(" ");
                string[] b = DateTime.Now.ToString().Split(" ");
                if (a[0] == b[0]) i.TrangThai = 3;
                btn_HoaDonCho.Text = i.Ma + Environment.NewLine + (i.TrangThai == 1 ? "Đang giao hàng" : (i.TrangThai == 2 ? "Đã hủy" :(i.TrangThai==3?  "Đã nhận hàng": "Đang trả hàng")));
                btn_HoaDonCho.ForeColor = Color.FromArgb(255, 89, 136);
                switch (i.TrangThai)
                {
                    case 2:
                        {
                            btn_HoaDonCho.BackColor = Color.Red;
                            btn_HoaDonCho.ForeColor = Color.White;
                            break;
                        }
                    case 1:
                        {
                            btn_HoaDonCho.BackColor = Color.LightGoldenrodYellow;
                            btn_HoaDonCho.ForeColor = Color.Blue;
                            break;
                        }
                    case 3:
                        {
                            btn_HoaDonCho.BackColor = Color.Blue;
                            btn_HoaDonCho.ForeColor = Color.White;
                            break;
                        }
                    case 4:
                        {
                            btn_HoaDonCho.BackColor = Color.Green;
                            btn_HoaDonCho.ForeColor = Color.White;
                            break;
                        }
                }
                btn_HoaDonCho.Tag = i;
                btn_HoaDonCho.Width = 60;
                btn_HoaDonCho.Height = 60;
                btn_HoaDonCho.Name = $"btn_HDCho{i}";
                flow_DangGiao.Controls.Add(btn_HoaDonCho);
                btn_HoaDonCho.Click += Btn_HoaDonCho_Click1; ;

            }
        }

        private void Btn_HoaDonCho_Click1(object? sender, EventArgs e)
        {
            string acbc = ((sender as Button).Tag as HoaDon).Ma;
            lbl_MahoaDon.Text = acbc;
            dgrid_GioHang.Rows.Clear();
            dgrid_GioHang.ColumnCount = 5;
            dgrid_GioHang.Columns[0].Name = "id";
            dgrid_GioHang.Columns[0].Visible = false;
            dgrid_GioHang.Columns[1].Name = "Tên sản phẩm";
            dgrid_GioHang.Columns[2].Name = "Số lượng";
            dgrid_GioHang.Columns[3].Name = "Giá sản phẩm";
            dgrid_GioHang.Columns[4].Name = "Thành tiền";
            dgrid_GioHang.AllowUserToAddRows = false;
            //DataGridViewButtonColumn dgridBtn = new DataGridViewButtonColumn();
            //dgridBtn.HeaderText = "Delete";
            //dgridBtn.Name = "btn_dlt";
            //dgridBtn.Text = "Xóa";
            //dgridBtn.UseColumnTextForButtonValue = true;
            //dgrid_GioHang.Columns.Add(dgridBtn);
            btn_xoa();
            pn_DatHang.BringToFront();
            foreach (var x in _hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == Convert.ToInt32(_hoaDonService.GetallHoadon().Where(c => c.Ma == acbc).Select(c => c.Id).FirstOrDefault())))
            {

                var g = _chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);


                dgrid_GioHang.Rows.Add(x.Id, g.TenSanPham, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong);
            }

            var temp = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == acbc );
            lbl_TongTienDatHang.Text = temp.TongTien.ToString();
            txt_TienCoc.Text = temp.TienCoc.ToString();
            //txt_TienShipHang.Text = temp.TienShip.ToString();
            Date_NgayShip.Value = temp.NgayGiao.Value;
            Date_NgayNhan.Value = temp.NgayNhanHang.Value;
            txt_DiaChi.Text = temp.DiaChi;

           

           
            txt_DatHangGhiChu.Text = temp.GhiChu;
            txt_TenKH.Text = temp.TenNguoiNhan;
            txt_Sdt.Text = temp.Sdt;
            btn_DatHang2.BringToFront();
            if (temp.TrangThai==1)
            {
                btn_HuyDon.BringToFront();
                btn_DatHang2.SendToBack();
                btn_xacNhanThanhCong.SendToBack();
                btn_TraHang.SendToBack();
            }
            if (temp.TrangThai == 2)
            {
                btn_TraHang.BringToFront();
                btn_DatHang2.SendToBack();
                btn_xacNhanThanhCong.SendToBack();
                btn_HuyDon.SendToBack();
            }
            if (temp.TrangThai == 3)
            {
                btn_TraHang.SendToBack();
                btn_DatHang2.SendToBack();
                btn_xacNhanThanhCong.BringToFront();
                btn_HuyDon.SendToBack();
            }
            
            loadTien1();
            string[] i = txt_TienCoc.Text.Split(".");
            if (string.IsNullOrEmpty(i[0]) || Convert.ToInt32(i[0]) <= 0)
            {
                lbl_TienThuaTraKhach.Text = "0";
                return;
            }
            lbl_TienThuaTraKhach.Text = Convert.ToString(Convert.ToInt32(i[0]) - Convert.ToInt32(lbl_TongTienDatHang.Text));
        }

        private void Btn_HoaDonCho_Click(object? sender, EventArgs e)
        {
            string acbc = ((sender as Button).Tag as HoaDon).Ma;
            lbl_MahoaDon.Text = acbc;
            dgrid_GioHang.Rows.Clear();
            dgrid_GioHang.ColumnCount = 5;
            dgrid_GioHang.Columns[0].Name = "id";
            dgrid_GioHang.Columns[0].Visible = false;
            dgrid_GioHang.Columns[1].Name = "Tên sản phẩm";
            dgrid_GioHang.Columns[2].Name = "Số lượng";
            dgrid_GioHang.Columns[3].Name = "Giá sản phẩm";
            dgrid_GioHang.Columns[4].Name = "Thành tiền";
            dgrid_GioHang.AllowUserToAddRows = false;
            //DataGridViewButtonColumn dgridBtn = new DataGridViewButtonColumn();
            //dgridBtn.HeaderText = "Delete";
            //dgridBtn.Name = "btn_dlt";
            //dgridBtn.Text = "Xóa";
            //dgridBtn.UseColumnTextForButtonValue = true;
            //dgrid_GioHang.Columns.Add(dgridBtn);
            btn_xoa();
            pn_HoaDon.BringToFront();
            foreach (var x in _hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == Convert.ToInt32(_hoaDonService.GetallHoadon().Where(c => c.Ma == acbc && c.TrangThai == 0).Select(c => c.Id).FirstOrDefault())))
            {

                var g = _chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);


                dgrid_GioHang.Rows.Add(x.Id, g.TenSanPham, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong);
            }
            loadTien();
            loadTien1();
        }
        private void loadTien()
        {
            int n = 0;
            for (int i = 0; i < dgrid_GioHang.RowCount; i++)
            {
                int temp = 0;
                temp = Convert.ToInt32(dgrid_GioHang.Rows[i].Cells["Số lượng"].Value) * Convert.ToInt32(dgrid_GioHang.Rows[i].Cells["Giá sản phẩm"].Value);
                n += temp;
            }
            txt_TongTien.Text = Convert.ToString(n);
            
        }
        private void loadTien1()
        {
            int n = 0;
            for (int i = 0; i < dgrid_GioHang.RowCount; i++)
            {
                int temp = 0;
                temp = Convert.ToInt32(dgrid_GioHang.Rows[i].Cells["Số lượng"].Value) * Convert.ToInt32(dgrid_GioHang.Rows[i].Cells["Giá sản phẩm"].Value);
                n += temp;
            }
            lbl_TongTienDatHang.Text = Convert.ToString(n);
            
            
            
        }
        private void btn_xoa()
        {
            DataGridViewButtonColumn dgridBtn = new DataGridViewButtonColumn();
            dgridBtn.HeaderText = "Delete";
            dgridBtn.Name = "btn_dlt";
            dgridBtn.Text = "Xóa";
            dgridBtn.UseColumnTextForButtonValue = true;

            dgrid_GioHang.Columns.Add(dgridBtn);
            for (int i = 0; i < dgrid_GioHang.RowCount - 1; i++)
            {

                var x = _chiTietGiayService.GetAllSPView().FirstOrDefault(c => c.Anh.DuongDan == dgrid_chitietgiay.Rows[i].Cells["Ảnh"].Value);

                Image img2 = Image.FromFile(x.Anh.DuongDan.ToString());
                dgrid_GioHang.Rows[i].Cells["btn_dlt"].Value = img2;

            }
        }

        private void thôngTinChiTiếtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tenhh = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[2].Value);
            string size = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[5].Value);
            string chatlieu = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[6].Value);
            string mausac = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[8].Value);
            string kieudang = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[10].Value);
            string degiay = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[9].Value);
            string giaban = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[4].Value);
            string nsx = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[7].Value);
            string anh = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[11].Value);
            FrmThongTinSP frmttSP = new FrmThongTinSP(tenhh, size, chatlieu, mausac, kieudang, degiay, giaban, nsx, anh);
            frmttSP.Show();
        }
        private void txt_Sdt_TextChanged(object sender, EventArgs e)
        {
            txt_TenKH.Text = _KHService.GetAll().Where(x => x.Sdt == txt_Sdt.Text).Select(x => string.Concat(x.Ho, " ", x.TenDem, " ", x.Ten)).FirstOrDefault();
        }

        private void btn_AddKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKH = new FrmKhachHang();
            frmKH.ShowDialog();
        }
        public void FuckYou()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LAPTOP-46F72MJA\\SQLEXPRESS;Initial Catalog=Duan11;Persist Security Info=True;User ID=duyvtph24890;Password=123456";

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select Sdt FROM KhachHang", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                col.Add(dr.GetString(0));
            }


            txt_Sdt.AutoCompleteCustomSource = col;
            connection.Close();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn thanh toán hóa Đơn {lbl_MahoaDon.Text} không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(txt_TongTien.Text) || txt_TongTien.Text == "0")
                {
                    MessageBox.Show("Hóa đơn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToInt32(txt_TienKhachDua.Text) < Convert.ToInt32(txt_TongTien.Text))
                {
                    MessageBox.Show("Tiền khách đưa không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
                updateHoaDon.TenNguoiNhan = txt_TenKH.Text;
                updateHoaDon.TongTien = Convert.ToInt32(txt_TongTien.Text);
                updateHoaDon.Sdt = txt_Sdt.Text;
                updateHoaDon.TrangThai = rbtn_ThanhToanTaiQuay.Checked ? 1 : rbtn_ChuyenKhoan.Checked? 0:2;
                updateHoaDon.GhiChu = richTextBox1.Text;
                updateHoaDon.NgayThanhToan = DateTime.Now;
                
                _hoaDonService.Update(updateHoaDon);
                
                if (cb_inHoaDon.Checked)
                {
                    //inHoaDon();
                    FrmPrint frmPrint = new FrmPrint(updateHoaDon);
                    frmPrint.ShowDialog();
                }
                cookroi();
                dgrid_GioHang.Rows.Clear();
                lbl_MahoaDon.Text = "....";
            }
        }
        private void btn_DatHang2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn thanh toán hóa Đơn {lbl_MahoaDon.Text} không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(txt_TongTien.Text) || txt_TongTien.Text == "0")
                {
                    MessageBox.Show("Hóa đơn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if (Convert.ToInt32(txt_TienCoc.Text) < (Convert.ToInt32(txt_TongTien.Text)*40/100))
                //{
                //    MessageBox.Show("Tiền cọc không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
                updateHoaDon.TenNguoiNhan = txt_TenKH.Text;
                updateHoaDon.TongTien = Convert.ToInt32(txt_TongTien.Text);
                updateHoaDon.Sdt = txt_Sdt.Text;
                updateHoaDon.TrangThai =1;
                updateHoaDon.NgayThanhToan = DateTime.Now;
                updateHoaDon.NgayGiao = Date_NgayShip.Value;
                updateHoaDon.NgayNhanHang = Date_NgayNhan.Value;
                updateHoaDon.TienCoc = Convert.ToInt32(txt_TienCoc.Text);
               // updateHoaDon.TienShip = Convert.ToInt32(txt_TienShipHang.Text);
                updateHoaDon.DiaChi = txt_DiaChi.Text;
                updateHoaDon.GhiChu = txt_DatHangGhiChu.Text;
                _hoaDonService.Update(updateHoaDon);
                cookroi();
                cookroi1();
                dgrid_GioHang.Rows.Clear();
                lbl_MahoaDon.Text = "....";
            }
        }

        private void txt_TienKhachDua_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txt_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            string i = txt_TienKhachDua.Text;
            if (string.IsNullOrEmpty(txt_TienKhachDua.Text)|| Convert.ToInt32(txt_TienKhachDua.Text) <= 0)
            {
                i = "0";
                label13.Visible = false;
                lbl_TienThua.Visible = false;
                return;
            }
            label13.Visible = true;
            lbl_TienThua.Visible = true;
            lbl_TienThua.Text = Convert.ToString(Convert.ToInt32(i) - Convert.ToInt32(txt_TongTien.Text));
        }

        private void txt_TienKhachDua_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TienKhachDua.Text = string.Empty;
        }

        private void rbtn_DaTT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            
        }
        private void ResetControlValues(Control Parent)
        {
            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {
                    (mycontrols as TextBox).Text = string.Empty;
                }
                else if (mycontrols is DateTimePicker)
                {
                    (mycontrols as DateTimePicker).Value = DateTime.Now;
                }
        }
        private void rbtn_DatHangDaTT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

            LoadSanPham();
            anhcaidmm1();
        }

        private void txt_TimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TimKiem.Text = "";
        }
        public void lblNhanVien(string a)
        {
            lbl_TenNhanVien.Text = a;
        }
        public void AutoDiaChi()
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data Source=LAPTOP-46F72MJA\\SQLEXPRESS;Initial Catalog=Duan11;Persist Security Info=True;User ID=duyvtph24890;Password=123456";

            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand("select Sdt FROM KhachHang", connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //SqlDataReader dr = sqlCommand.ExecuteReader();
            txt_DiaChi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_DiaChi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            string[] DiaChi = new string[] {"An Giang" , "Kon Tum",  "Bà Rịa – Vũng Tàu" , "Lai Châu ",  "Bắc Giang" , "Lâm Đồng" , "Bắc Kạn" , "Lạng Sơn", " Bạc Liêu" , "Lào Cai" , "Bắc Ninh" , "Long An" , "Bến Tre" , "Nam Định","Bình Định","Nghệ An",
                                            "Bình Dương","Ninh Bình" ,"Bình Phước" , "Ninh Thuận","Bình Thuận" , "Phú Thọ","Cà Mau" , "Phú Yên" , "Cần Thơ" , "Quảng Bình","Cao Bằng" , "Quảng Nam", "Đà Nẵng" , "Quảng Ngãi",
                                            "Đắk Lắk" , "Quảng Ninh","Đắk Nông" , "Quảng Trị", "Điện Biên" , "Sóc Trăng","Đồng Nai" , "Sơn La",   "Đồng Tháp" , "Tây Ninh","  Gia Lai" , "Thái Bình", "Hà Giang" , "Thái Nguyên",
                                            "Hà Nam" , "Thanh Hóa",  "Hà Nội" , "Thừa Thiên Huế", "Hà Tĩnh" , "Tiền Giang", "Hải Dương" , "TP Hồ Chí Minh", "Hải Phòng" , "Trà Vinh",  "Hậu Giang" , "Tuyên Quang",
                                            "Hòa Bình" , "Vĩnh Long","Hưng Yên" , "Vĩnh Phúc", "Khánh Hòa" , "Yên Bái", "Kiên Giang"
            };
            col.AddRange(DiaChi);
            txt_DiaChi.AutoCompleteCustomSource = col;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Mở Camera Hay Không ?", "Thông Báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {


                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmb_QRCode.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                    for (int i = 0; i < 1; i++)
                    {
                        MessageBox.Show("Mở Camera Thành Công");
                    }
                };

                if (dialogResult == DialogResult.No)
                {

                    for (int i = 0; i < 2; i++)
                    {
                        MessageBox.Show("Mở Camera Thất Bại");
                    }
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Liên Hệ Với 19008198 để sửa lỗi");
                return;
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmb_QRCode.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                videoCaptureDevice.Start();
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                //pic_qrcode.Image = bitmap;
                string content = Interaction.InputBox("Mời Bạn Nhập Số Lượng Muốn Thêm", "Thêm Vào Giỏ Hàng", "", 500, 300);
                var sp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == _ctspId);
                var idTmp = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == lbl_MahoaDon.Text).Id;
                var data = _hoaDonChiTietService.GetAllHoaDonCT().FirstOrDefault(c => c.IdChiTietGiay == _ctspId && c.IdHoaDon == idTmp);
                if (Convert.ToString(result) == _chiTietGiayService.GetAllCTGiay()
                            .Where(c => c.MaVach == Convert.ToString(result))
                            .Select(c => c.MaVach).FirstOrDefault())
                {
                    if (Convert.ToInt32(content) <= sp.SoLuongTon)
                    {

                        if (data == null || data.IdHoaDon != idTmp)
                        {
                            sp.SoLuongTon -= Convert.ToInt32(content);
                            var hoaDonChiTiet = new HoaDonChiTiet()
                            {
                                Id = Guid.NewGuid(),
                                IdChiTietGiay = _ctspId,
                                IdHoaDon = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == lbl_MahoaDon.Text).Id,
                                DonGia = sp.GiaBan,
                                SoLuong = Convert.ToInt32(content)
                            };
                            _hoaDonChiTietService.Add(hoaDonChiTiet);
                            _chiTietGiayService.UpdateCTGiay2(sp);
                        }
                        else
                        {
                            sp.SoLuongTon -= Convert.ToInt32(content);
                            data.SoLuong += Convert.ToInt32(content);
                            _hoaDonChiTietService.Update(data);
                            _chiTietGiayService.UpdateCTGiay2(sp);

                        }
                        LoadGioHang();
                        LoadSanPham();
                        anhcaidmm1();
                        refreshcam();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm không đủ");
                    }
                }
                if (Convert.ToInt32(content) >= Convert.ToInt32(_chiTietGiayService.GetAllCTGiay().Where(c => c.MaVach == Convert.ToString(result)).Select(c => c.SoLuong).FirstOrDefault()))
                {
                    MessageBox.Show("Số Lượng Không Đủ", "ERR");
                    return;
                }
            }
            catch
            {

            }
        }
        void refreshcam()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(refreshcam));
                    return;
                }
                //if (pic_qrcode.Image != null)
                //{
                //    pic_qrcode.Image = null;
                //    pic_qrcode.ImageLocation = null;
                //    //pic_cam.Image = null;
                //    pic_qrcode.Update();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex), "Liên Hệ Với 19008198 để sửa lỗi");
                return;

            }
        }

        private void FrmBanHang1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cmb_QRCode.Items.Add(Device.Name);
            cmb_QRCode.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           // pic_qrcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            //pn_banNhanh.Visible = true;
           // pn_banNhanh.BringToFront();
            pn_DatHang.Visible = false;
            pn_HoaDon.Visible = false;
           // ResetControlValues(pn_banNhanh);
            ResetControlValues(Gr_Thongtin);
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            pn_HoaDon.Visible = true;
            pn_HoaDon.BringToFront();
            pn_DatHang.Visible = false;
            btn_DatHang2.BringToFront();
            //pn_banNhanh.Visible = false;
            ResetControlValues(pn_HoaDon);
            ResetControlValues(Gr_Thongtin);
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            pn_DatHang.Visible = true;
            pn_DatHang.BringToFront();
            pn_HoaDon.Visible = false;
            //pn_banNhanh.Visible = false;
            ResetControlValues(pn_DatHang);
            ResetControlValues(Gr_Thongtin);
            txt_TienCoc.Text = "0";
        }

        private void Gr_SanPham_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            lbl_tenKhachHang.Visible = true;
            lbl_tenKhachHang.Text = txt_TenKH.Text;
            if(txt_TenKH.Text=="")
            {
                lbl_tenKhachHang.Text = "Khách lẻ";
            }
        }
        public void LoadSanPham_TimKiem(string txt)
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().Where(c => c.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower()) || c.TenSanPham.ToLower().Contains(txt_TimKiem.Text)).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
        }

        private void txt_TimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            LoadSanPham_TimKiem(txt_TimKiem.Text);
            anhcaidmm1();
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
                txt_TimKiem.Text = "Tìm kiếm ở đây....";
                LoadSanPham();
                anhcaidmm1();
                return;
            }
        }

        private void txt_TimKiem_MouseUp(object sender, MouseEventArgs e)
        {
            txt_TimKiem.Text = "";
        }

        private void cmb_LocSize_Leave(object sender, EventArgs e)
        {
            LoadSanPham();
            anhcaidmm1();
            cmb_LocSize.Text = "Lọc size";
        }

        private void cmb_LocMau_SelectedValueChanged(object sender, EventArgs e)
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().Where(c => c.TenMauSac == cmb_LocMau.Text).OrderBy(c => c.Ma).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
            anhcaidmm1();
        }

        private void cmb_LocMau_Leave(object sender, EventArgs e)
        {
            LoadSanPham();
            anhcaidmm1();
            cmb_LocMau.Text = "Lọc màu";
        }

        private void cmb_LocKieuDang_SelectedValueChanged(object sender, EventArgs e)
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().Where(c => c.TenKieuDang == cmb_LocKieuDang.Text).OrderBy(c => c.Ma).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
            anhcaidmm1();
        }

        private void cmb_LocKieuDang_Leave(object sender, EventArgs e)
        {
            LoadSanPham();
            anhcaidmm1();
            cmb_LocKieuDang.Text = "Lọc kiểu dáng";
        }

        private void cmb_LocNsx_SelectedValueChanged(object sender, EventArgs e)
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().Where(c => c.TenNSX == cmb_LocNsx.Text).OrderBy(c => c.Ma).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
            anhcaidmm1();
        }

        private void cmb_LocNsx_Leave(object sender, EventArgs e)
        {
            LoadSanPham();
            anhcaidmm1();
            cmb_LocNsx.Text = "Lọc nsx";
        }

        private void dgrid_GioHang_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgrid_GioHang.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dgrid_GioHang.CurrentCell = this.dgrid_GioHang.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip2.Show(this.dgrid_chitietgiay, e.Location);
                contextMenuStrip2.Show(Cursor.Position);
            }
        }
        private void sửaSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////this.dgrid_Size.Rows.RemoveAt(this.rowindex);
            //var size = _hoaDonChiTietService.ge().FirstOrDefault(x =>
            //x.Id == Guid.Parse(dgrid_Size.Rows[rowindex].Cells[0].Value.ToString()));
            //_ISizeService.DeleteSize(size);
            //LoadData();
            //return;
        }

        private void cmb_LocSize_SelectedValueChanged_1(object sender, EventArgs e)
        {
            dgrid_chitietgiay.ColumnCount = 12;
            dgrid_chitietgiay.Columns[0].Name = "IdCtg";
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
            foreach (var x in _chiTietGiayService.GetViewChiTietGiay().Where(c => c.TenSize == cmb_LocSize.Text).OrderBy(c => c.Ma).ToList())
            {
                dgrid_chitietgiay.Rows.Add(x.Id,
                    x.Ma,
                    x.TenSanPham,
                    x.SoLuongTon,
                    x.GiaBan,
                    x.TenSize, x.TenChatLieu, x.TenNSX, x.TenMauSac, x.TenDeGiay, x.TenKieuDang, x.Anh);
            }
            anhcaidmm1();
        }

        private void dgrid_chitietgiay_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
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

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Hủy hóa đơn {lbl_MahoaDon.Text} không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
               
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
               
                updateHoaDon.TrangThai = 2;
                
                _hoaDonService.Update(updateHoaDon);
                cookroi();
                cookroi1();
                ResetControlValues(pn_DatHang);
                ResetControlValues(Gr_Thongtin);
                lbl_TongTienDatHang.Text = "0";
                dgrid_GioHang.Rows.Clear();
                lbl_MahoaDon.Text = "....";
            }
        }

        private void txt_TienCoc_TextChanged(object sender, EventArgs e)
        {
            string[] i = txt_TienCoc.Text.Split(".");
            string[] x = lbl_TongTienDatHang.Text.Split(".");
            if (string.IsNullOrEmpty(i[0]) || Convert.ToInt32(i[0]) <= 0)
            {
                lbl_TienThuaTraKhach.Text = "0";
                return;
            }
            if (Convert.ToInt32(i[0]) >= Convert.ToInt32(x[0])) cb_cod.Checked = false;
            lbl_TienThuaTraKhach.Text = Convert.ToString(Convert.ToInt32(i[0]) - Convert.ToInt32(x[0]));
        }

        private void cb_cod_CheckedChanged(object sender, EventArgs e)
        {
            string[] i = txt_TienCoc.Text.Split(".");
            string[] x = lbl_TongTienDatHang.Text.Split(".");
            if (cb_cod.Checked==true)
            {
                lbl_COD.Text = (Convert.ToInt32(lbl_TongTienDatHang.Text) - Convert.ToInt32(i[0])).ToString();
            }
            else
            lbl_COD.Text = "0";
            lbl_TienThuaTraKhach.Text = (Convert.ToInt32(i[0]) - Convert.ToInt32(x[0])).ToString();
        }

        private void pn_HoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TraHang_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xác nhận trả hàng cho hóa đơn {lbl_MahoaDon.Text} không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
                if(updateHoaDon.TienCoc>0)
                {
                     MessageBox.Show($"Khách hàng đã trả trước cho hóa đơn {lbl_MahoaDon.Text} {updateHoaDon.TienCoc} VND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dialogResult1 = MessageBox.Show($"Khách hàng sẽ được hoàn tiền sau khi hóa đơn {lbl_MahoaDon.Text} được trả về", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(dialogResult1 == DialogResult.Yes)
                    {
                        updateHoaDon.NgayTraHang = DateTime.Today;
                        // updateHoaDon.TienShip = Convert.ToInt32(txt_TienShipHang.Text);
                        updateHoaDon.TrangThai = 4;
                        _hoaDonService.Update(updateHoaDon);
                        cookroi();
                        cookroi1();
                        dgrid_GioHang.Rows.Clear();
                        lbl_MahoaDon.Text = "....";
                    }
                }
               
            }
        }

        private void btn_xacNhanThanhCong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Xác nhận giao hàng thành công hóa đơn {lbl_MahoaDon.Text} ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(dialogResult ==DialogResult.OK)
            {
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
                //xác nhận giaohàng thành công
                updateHoaDon.TrangThai = 5;
                        _hoaDonService.Update(updateHoaDon);
                        cookroi();
                        cookroi1();
                        dgrid_GioHang.Rows.Clear();
                        lbl_MahoaDon.Text = "....";
            }




        }

        private void btn_traHangThanhCong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Xác nhận trả hàng thành công hóa đơn {lbl_MahoaDon.Text} ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                var updateHoaDon = _hoaDonService.GetallHoadon().Where(c => c.Ma == lbl_MahoaDon.Text).FirstOrDefault();
                foreach (var item in _hoaDonChiTietService.GetAllHoaDonCT().Where(c=>c.IdHoaDon== updateHoaDon.Id))
                {
                    var updatectsp = _chiTietGiayService.GetAllCTGiay().FirstOrDefault(c => c.Id == item.IdChiTietGiay);
                    updatectsp.SoLuongTon += item.SoLuong;
                    _chiTietGiayService.UpdateCTGiay2(updatectsp);
                    item.SoLuong = 0;
                }
                //xác nhận trả hàng thành công
                updateHoaDon.TrangThai = 6;
                _hoaDonService.Update(updateHoaDon);
                
                LoadSanPham();
                anhcaidmm1();
                cookroi();
                cookroi1();
                dgrid_GioHang.Rows.Clear();
                lbl_MahoaDon.Text = "....";
            }
        }
    }
}
