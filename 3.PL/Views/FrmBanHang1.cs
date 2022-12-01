using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

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

        public List<SanPhamCTView> _sanPhamCTView;
        public List<ViewHoaDonChiTiet> _viewHoaDonChiTiets;
        public HoaDon _hoaDonCho;
        public List<HoaDonChiTiet> hoaDonChiTiets;
        private INhanVienService _nhanVienService;
        private IKhachHangService _khachHangService;
        private List<HoaDonChiTiet> _lstHDCT;
        private int rowindex = 0;
        private IKhachHangService _KHService;

        public FrmBanHang1()
        {
            InitializeComponent();
            _chiTietGiayService = new ChiTietGiayService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _hoaDonService = new HoaDonService();

            LoadSanPham();
            anhcaidmm();
            cookroi();
            cookroi1();

            dgrid_chitietgiay.AllowUserToAddRows = false;
            this.dgrid_chitietgiay.DefaultCellStyle.ForeColor = Color.Red;
            _KHService = new KhachHangService();
            FuckYou();
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
            dgrid_chitietgiay.Columns[11].Name = "Ảnh";
            dgrid_chitietgiay.Columns[11].Visible = false;
            dgrid_chitietgiay.Rows.Clear();
            var lstCTG = _chiTietGiayService.GetViewChiTietGiay();
            if (txt_TimKiem.Text != "" && txt_TimKiem.Text != "Tìm kiếm....")
            {
                lstCTG = _chiTietGiayService.GetViewChiTietGiay().Where(p => p.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower()) || p.TenSanPham.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstCTG)
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


            foreach (var i in _hoaDonService.GetallHoadon().Where(c => c.TrangThai == 2 || c.TrangThai == 3))
            {
                Button btn_HoaDonCho = new Button();

                btn_HoaDonCho.Text = i.Ma + Environment.NewLine + (i.TrangThai == 2 ? "Đang giao hàng" : (i.TrangThai == 3 ? "Đã đặt cọc" : "Đã hủy"));
                btn_HoaDonCho.ForeColor = Color.FromArgb(255, 89, 136);
                switch (i.TrangThai)
                {
                    case 2:
                        {
                            btn_HoaDonCho.BackColor = Color.Red;
                            btn_HoaDonCho.ForeColor = Color.White;
                            break;
                        }
                    case 3:
                        btn_HoaDonCho.BackColor = Color.BlueViolet;
                        btn_HoaDonCho.ForeColor = Color.White;
                        break;
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
            foreach (var x in _hoaDonChiTietService.GetAllHoaDonCT().Where(c => c.IdHoaDon == Convert.ToInt32(_hoaDonService.GetallHoadon().Where(c => c.Ma == acbc && (c.TrangThai == 2 || c.TrangThai == 3)).Select(c => c.Id).FirstOrDefault())))
            {

                var g = _chiTietGiayService.GetViewChiTietGiay().FirstOrDefault(c => c.Id == x.IdChiTietGiay);


                dgrid_GioHang.Rows.Add(x.Id, g.TenSanPham, x.SoLuong, g.GiaBan, g.GiaBan * x.SoLuong);
            }
            var temp = _hoaDonService.GetallHoadon().FirstOrDefault(c => c.Ma == acbc && (c.TrangThai == 2 || c.TrangThai == 3));
            lbl_TongTienDatHang.Text = temp.TongTien.ToString();
            txt_TienCoc.Text = temp.TienCoc.ToString();
            txt_TienShipHang.Text = temp.TienShip.ToString();
            Date_NgayShip.Value = temp.NgayGiao.Value;
            Date_NgayNhan.Value = temp.NgayNhanHang.Value;
            txt_DiaChi.Text = temp.DiaChi;
            if (temp.TrangThai == 1)
            {
                rbtn_DatHangDaTT.Checked = true;
            }
            else
            if (temp.TrangThai == 0)
            {
                rbtn_DatHangCTT.Checked = true;
            }
            else
            if (temp.TrangThai == 2)
            {
                rbtn_DatHangChoGiaoHang.Checked = true;
            }
            else
            if (temp.TrangThai == 3)
            {
                rbtn_DatHangDaCoc.Checked = true;
            }
            else rbtn_DatHangDaHuy.Checked = true;
            txt_DatHangGhiChu.Text = temp.GhiChu;
            txt_TenKH.Text = temp.TenNguoiNhan;
            txt_Sdt.Text = temp.Sdt;
            loadTien1();
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
            string anh = Convert.ToString(dgrid_chitietgiay.Rows[rowindex].Cells[11].Value);
            FrmThongTinSP frmttSP = new FrmThongTinSP(tenhh, size, chatlieu, mausac, kieudang, degiay, giaban, anh);
            frmttSP.Show();
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
            connection.ConnectionString = "Data Source=LAPTOP-OF-KHAI\\SQLEXPRESS;Initial Catalog=Duan1;Persist Security Info=True;User ID=khainq03;Password=123456";

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
                updateHoaDon.TrangThai = rbtn_ThanhToanTaiQuay.Checked ? 1 : 0;
                updateHoaDon.GhiChu = richTextBox1.Text;
                updateHoaDon.NgayThanhToan = DateTime.Now;

                _hoaDonService.Update(updateHoaDon);
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
                updateHoaDon.TrangThai = rbtn_DatHangDaTT.Checked ? 1 : rbtn_DatHangCTT.Checked ? 0 : rbtn_DatHangChoGiaoHang.Checked ? 2 : rbtn_DatHangDaCoc.Checked ? 3 : 4;
                updateHoaDon.NgayThanhToan = DateTime.Now;
                updateHoaDon.NgayGiao = Date_NgayShip.Value;
                updateHoaDon.NgayNhanHang = Date_NgayNhan.Value;
                updateHoaDon.TienCoc = Convert.ToInt32(txt_TienCoc.Text);
                updateHoaDon.TienShip = Convert.ToInt32(txt_TienShipHang.Text);
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
            if (string.IsNullOrEmpty(txt_TienKhachDua.Text))
            {
                i = "0";
            }
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
            pn_HoaDon.Visible = true;
            pn_HoaDon.BringToFront();
            pn_DatHang.Visible = false;
            ResetControlValues(pn_HoaDon);
            ResetControlValues(Gr_Thongtin);
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            pn_DatHang.Visible = true;
            pn_DatHang.BringToFront();
            pn_HoaDon.Visible = false;
            ResetControlValues(pn_DatHang);
            ResetControlValues(Gr_Thongtin);
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
    }
}
