using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmHoadon : Form
    {

        private IKhachHangService _Ikhachhangservice;
        private INhanVienService _Inhanvienservice;
        private IHoaDonService _ihoadonservice;
        private FpolyDBContext fpolyDBContext;
        private IChiTietGiayService chiTietGiayService;
        private IHoaDonChiTietService hoaDonChiTietService;
        private List<ViewHoaDon> _viewHoaDon;
        private int _idhoadon;

        public FrmHoadon()
        {
            InitializeComponent();
            _Ikhachhangservice = new KhachHangService();
            _Inhanvienservice = new NhanVienService();
            _ihoadonservice = new HoaDonService();
            _viewHoaDon = new List<ViewHoaDon>();
            fpolyDBContext = new FpolyDBContext();
            hoaDonChiTietService = new HoaDonChiTietService();
            chiTietGiayService = new ChiTietGiayService();
            Loaddata();
            cookroi();
            //LoaddataCombobox();
        }
        public void Loaddata()
        {
            //dgrid_view.ColumnCount = 15;
            //dgrid_view.Columns[0].Name = "id";
            //dgrid_view.Columns[0].Visible = false;
            //dgrid_view.Columns[1].Name = "Ma ";
            //dgrid_view.Columns[2].Name = "Khách Hàng";
            //dgrid_view.Columns[3].Name = "Nhân Viên";
            //dgrid_view.Columns[4].Name = "Tên Sản Phẩm";
            //dgrid_view.Columns[5].Name = "Tên Người Nhận";
            //dgrid_view.Columns[6].Name = "Ngày Tạo";
            //dgrid_view.Columns[7].Name = "Ngày Giao";
            //dgrid_view.Columns[8].Name = "Ngày Thanh Toán";
            //dgrid_view.Columns[9].Name = "Ngày nhận";
            //dgrid_view.Columns[10].Name = "Ngày trả";
            //dgrid_view.Columns[11].Name = "Dịa Chỉ";
            //dgrid_view.Columns[12].Name = "Sdt";
            //dgrid_view.Columns[13].Name = "Giảm GIá";
            //dgrid_view.Columns[14].Name = "Trạng Thái";
            //dgrid_view.Rows.Clear();
            //foreach (var x in _ihoadonservice.GetallHoadon())
            //{
            //   // dgrid_view.Rows.Add(x.Id, x.Ma, x.khachhang, x.nhanvien, x.TenSp, x.TenNguoiNhan, x.NgayTao, x.NgayGiao, x.NgayThanhToan, x.NgayNhanHang, x.NgayTraHang, x.DiaChi, x.Sdt, x.GiamGia, x.TrangThai == 1 ? "Chờ xử lý":"Hoàn thành");
            //    //var kh = _Ikhachhangservice.GetAll().FirstOrDefault(c => c.Id == x.IdKhachHang);
            //    //var nv = _Inhanvienservice.GetAllNhanVien().FirstOrDefault(c => c.Id == x.IdNhanVien);
            //    dgrid_view.Rows.Add(x.Id,x.Ma,x.IdKhachHang,x.IdNhanVien,x.TenSp,x.TenNguoiNhan,x.NgayTao,x.NgayGiao,x.NgayThanhToan,x.DiaChi,x.Sdt,x.GiamGia,x.TrangThai);
            //};

        }

        #region CellClick
        private void dgrid_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowindex = e.RowIndex;
                if (rowindex == _ihoadonservice.GetallHoadon().Count) return;
                DataGridViewRow r = dgrid_view.Rows[e.RowIndex];
                _idhoadon = Convert.ToInt16(r.Cells[0].Value.ToString());
                var hd = _ihoadonservice.GetAll().FirstOrDefault(c => c.Id == _idhoadon);
                //tbx_ma.Text = r.Cells[1].Value.ToString();
                //cbx_khachhang.Text =  r.Cells[2].Value.ToString();
                ////cbx_sanpham.Text = r.Cells[3].Value.ToString();
                //cbx_nhanvien.Text = r.Cells[3].Value.ToString();
                //tbx_tensanpham.Text = r.Cells[4].Value.ToString();
                //tbx_tennguoinhan.Text = r.Cells[5].Value.ToString();
                //date_ngaytao.Value = Convert.ToDateTime(r.Cells[6].Value);
                //date_ngaygiao.Value = Convert.ToDateTime(r.Cells[7].Value);
                //date_ngaythanhtoan.Value = Convert.ToDateTime(r.Cells[8].Value);
                //date_NgayNhan.Value = hd.NgayNhanHang.Value;
                //date_NgayTra.Value = hd.NgayTraHang.Value;
                //tbx_diachi.Text = r.Cells[11].Value.ToString();
                //tbx_sdt.Text = r.Cells[12].Value.ToString();
                //tbx_giamgia.Text = r.Cells[13].Value.ToString();
                //rbtn_hoatdong.Checked = hd.TrangThai == 1;
                //rbtn_khonghoatdong.Checked = hd.TrangThai == 0;
            }
        }
        //public ViewHoaDon dataadd()
        //{
        //    int id1 = 0;
        //    id1 += 1;
        //    return new ViewHoaDon()
        //    {
        //        //Id = id1,
        //        //Ma = tbx_ma.Text,
        //        //TenSp = tbx_tensanpham.Text,
        //        //TenNguoiNhan = tbx_tennguoinhan.Text,
        //        //NgayTao = date_ngaytao.Value,
        //        //NgayGiao = date_ngaytao.Value,
        //        //NgayThanhToan = date_ngaytao.Value,
        //        //NgayNhanHang = date_NgayNhan.Value,
        //        //NgayTraHang = date_NgayTra.Value,
        //        //DiaChi = tbx_diachi.Text,
        //        //Sdt = tbx_sdt.Text,
        //        //GiamGia = tbx_giamgia.Text,
        //        //TrangThai = rbtn_hoatdong.Checked ? 1 : 0,
        //        ////IdSanOham  = cbx_sanpham.Text != null ? _iSanphamService.GetAllSanPham().FirstOrDefault(c => c.Ten == cbx_sanpham.Text).Id : null,
        //        //IdKhachHang = cbx_khachhang.Text != null ? _Ikhachhangservice.GetAll().FirstOrDefault(c => c.Ten == cbx_khachhang.Text).Id : null,
        //        //IdNhanVien = cbx_nhanvien.Text != null ? _Inhanvienservice.GetAllNhanVien().FirstOrDefault(c => c.Ten == cbx_nhanvien.Text).Id : null,

        //    };
        //}
        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        _ihoadonservice.Add(dataadd());
        //        MessageBox.Show("Thêm thành công");
        //        Loaddata();
        //    }
        //    if (dialogResult == DialogResult.No)
        //    {
        //        return;
        //    }
        //}

        //private void btn_sua_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn Sửa?", "Thông báo", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        HoaDon hoadonview = new HoaDon()
        //        {
        //            Id = _idhoadon,
        //            Ma = dataadd().Ma,
        //            TenSp = dataadd().TenSp,
        //            TenNguoiNhan = dataadd().TenNguoiNhan,
        //            NgayGiao = dataadd().NgayGiao,
        //            NgayTao = dataadd().NgayTao,
        //            NgayThanhToan = dataadd().NgayThanhToan,
        //            NgayNhanHang = dataadd().NgayNhanHang,
        //            NgayTraHang = dataadd().NgayTraHang,
        //            DiaChi = dataadd().DiaChi,
        //            Sdt = dataadd().Sdt,
        //            GiamGia = dataadd().GiamGia,
        //            TrangThai = dataadd().TrangThai,
        //            IdKhachHang = dataadd().IdKhachHang,
        //            IdNhanVien = dataadd().IdNhanVien,

        //        };
        //        _ihoadonservice.Update(hoadonview);
        //        MessageBox.Show("Sửa thành công");
        //        Loaddata();
        //    }
        //    if (dialogResult == DialogResult.No)
        //    {
        //        return;
        //    }
        //}
        #endregion
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _ihoadonservice.Delete(_idhoadon);
                MessageBox.Show("Xóa thành công");
                Loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void cookroi()
        {
            while (flp_HoaDon.Controls.Count > 0)
            {
                flp_HoaDon.Controls[0].Dispose();
            }


            foreach (var i in _ihoadonservice.GetallHoadon().Where(c => c.TrangThai == 1 || c.TrangThai == 2 || c.TrangThai == 3))
            {
                Button btn_HoaDonCho = new Button();

                btn_HoaDonCho.Text = i.Ma + Environment.NewLine + "Đã thanh toán";
                btn_HoaDonCho.ForeColor = Color.FromArgb(255, 89, 136);
                btn_HoaDonCho.Tag = i;
                btn_HoaDonCho.Width = 60;
                btn_HoaDonCho.Height = 60;
                btn_HoaDonCho.Name = $"btn_HDCho{i}";
                flp_HoaDon.Controls.Add(btn_HoaDonCho);
                btn_HoaDonCho.Click += Btn_HoaDonCho_Click;

            }
        }

        private void Btn_HoaDonCho_Click(object? sender, EventArgs e)
        {
            string acbc = ((sender as Button).Tag as HoaDon).Ma;
            
            dgrid_view.Rows.Clear();
            dgrid_view.ColumnCount = 7;
            dgrid_view.Columns[0].Name = "id";
            dgrid_view.Columns[0].Visible = false;
            dgrid_view.Columns[1].Name = "Tên khách hàng";
            dgrid_view.Columns[2].Name = "Số điện thoại";
            dgrid_view.Columns[3].Name = "Tổng tiền";
            dgrid_view.Columns[4].Name = "Hình thức thanh toán";
            dgrid_view.Columns[5].Name = "Ngày thanh toán";
            dgrid_view.Columns[6].Name = "Ghi chú";
            dgrid_view.AllowUserToAddRows = false;
            
            

            foreach (var x in _ihoadonservice.GetallHoadon().Where(c => c.Ma == acbc && (c.TrangThai == 1|| c.TrangThai == 2|| c.TrangThai == 3)))
            {
                var g = 
                dgrid_view.Rows.Add(x.Id, x.TenNguoiNhan, x.Sdt, x.TongTien, x.TrangThai==1? "Tiền mặt":x.TrangThai==2? "Chuyển khoản": "Chuyển khoản và tiền mặt", x.NgayThanhToan, x.GhiChu);
            }
            
        }
        #region MouseClick
        /*private void dgrid_view_MouseClick(object sender, MouseEventArgs e)
        {

            ContextMenuStrip _newmenu = new System.Windows.Forms.ContextMenuStrip();
            int position = dgrid_view.HitTest(e.X, e.Y).RowIndex;

            //_idhoadon = Guid.Parse(dgrid_view.HitTest(e.X, e.Y).RowIndex.ToString());
            //MessageBox.Show("right");
            // MessageBox.Show(position.ToString());
            if (e.Button == MouseButtons.Right)
            {
                _newmenu.Items.Add("Add").Name = "Add";
                _newmenu.Items.Add("Del").Name = "Del";
                _newmenu.Items.Add("Edit").Name = "Edit";

            }
            _newmenu.Show(dgrid_view, new Point(e.X, e.Y));
            _newmenu.ItemClicked += _newmenu_ItemClicked;
        }
        private void _newmenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(e.ClickedItem.ToString());
            switch (e.ClickedItem.Name.ToString())
            {
                case "Add":
                    DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //_ihoadonservice.Add(dataadd());
                        MessageBox.Show("Thêm thành công");
                        Loaddata();
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
                case "Del":
                    DialogResult dialogResult1 = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        _ihoadonservice.Delete(_idhoadon);
                        MessageBox.Show("Xóa thành công");
                        Loaddata();
                    }
                    if (dialogResult1 == DialogResult.No)
                    {
                        return;
                    }
                    break;
                case "Edit":
                    DialogResult dialogResult2 = MessageBox.Show("Bạn chắc chắn muốn Sửa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        HoaDon hoadonview = new HoaDon()
                        {
                            //Id = _idhoadon,
                            //Ma = dataadd().Ma,
                            //TenSp = dataadd().TenSp,
                            //TenNguoiNhan = dataadd().TenNguoiNhan,
                            //NgayGiao = dataadd().NgayGiao,
                            //NgayTao = dataadd().NgayTao,
                            //NgayThanhToan = dataadd().NgayThanhToan,
                            //DiaChi = dataadd().DiaChi,
                            //Sdt = dataadd().Sdt,
                            //GiamGia = dataadd().GiamGia,
                            //TrangThai = dataadd().TrangThai,
                            //IdKhachHang = dataadd().IdKhachHang,
                            //IdNhanVien = dataadd().IdNhanVien,

                        };
                        _ihoadonservice.Update(hoadonview);
                        MessageBox.Show("Sửa thành công");
                        Loaddata();
                    }
                    if (dialogResult2 == DialogResult.No)
                    {
                        return;
                    }
                    break;
            }
        }*/

        #endregion
    }
}
