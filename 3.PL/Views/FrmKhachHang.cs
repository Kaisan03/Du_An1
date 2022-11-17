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
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService _IKhachHangService;
        private KhachHang _KhachHang;
        private List<KhachHang> _lstKhachHang;
        

        
        public FrmKhachHang()
        {
            InitializeComponent();
            _IKhachHangService = new KhachHangService();
            _lstKhachHang = new List<KhachHang>();

            LoadData();
        }
        public void LoadData()
        {
            dgridKhachHang.ColumnCount = 10;
            dgridKhachHang.Columns[0].Name = "ID";
            dgridKhachHang.Columns[0].Visible = false;
            dgridKhachHang.Columns[1].Name = "Mã";
            dgridKhachHang.Columns[2].Name = "Họ";
            dgridKhachHang.Columns[3].Name = "Tên Đệm";
            dgridKhachHang.Columns[4].Name = "Tên";
            dgridKhachHang.Columns[5].Name = "Ngày Sinh";
            dgridKhachHang.Columns[6].Name = "Số Điện Thoại";
            dgridKhachHang.Columns[7].Name = "Địa Chỉ";
            dgridKhachHang.Columns[8].Name = "Quốc Gia";
            dgridKhachHang.Columns[9].Name = "Trạng Thái";
            dgridKhachHang.Rows.Clear();
            _lstKhachHang = _IKhachHangService.GetAll();
            if (txt_TimKiem.Text != "")
            {
                _lstKhachHang = _lstKhachHang.Where( p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstKhachHang.OrderBy(c => c.Ma).ToList())
            {
                dgridKhachHang.Rows.Add(x.Id, x.Ma,x.Ho,x.TenDem, x.Ten, x.NgaySinh, x.Sdt,x.DiaChi,x.QuocGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private KhachHang GetDataFromGuid()
        {
            return new KhachHang()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ho = txt_Ho.Text,
                TenDem = txt_TenDem.Text,
                Ten = txt_Ten.Text,
                NgaySinh = datetime_ngaysinh.Value,
                Sdt = txt_SoDienThoai.Text,
                DiaChi = txt_DiaChi.Text,
                QuocGia = txt_QuocGia.Text,
                TrangThai = cbx_HoatDong.Checked ? 1 : 0,

            };
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void dgridKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            

        //}

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _IKhachHangService.Add(GetDataFromGuid());
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
            DialogResult dialogResult = MessageBox.Show("bạn có muốn sửa không?", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                _KhachHang.Ma = txt_Ma.Text ;
                _KhachHang.Ho = txt_Ho.Text ;
                _KhachHang.TenDem = txt_TenDem.Text ;
                _KhachHang.Ten = txt_Ten.Text ;
                _KhachHang.NgaySinh = datetime_ngaysinh.Value;
                _KhachHang.Sdt = txt_SoDienThoai.Text;
                _KhachHang.DiaChi = txt_DiaChi.Text ;
                _KhachHang.QuocGia = txt_QuocGia.Text ;
                _KhachHang.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IKhachHangService.Update(_KhachHang);
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
                _IKhachHangService.Delete(_KhachHang);
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
                txt_Ma.Clear();
                txt_Ho.Clear();
                txt_TenDem.Clear();
                txt_Ten.Clear();
                txt_SoDienThoai.Clear();
                txt_DiaChi.Clear();
                txt_QuocGia.Clear();
                cbx_KhongHoatDong.Checked = true;
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HoatDong.Checked)
            {
                cbx_KhongHoatDong.Checked = false;
            }
        }

        private void cbx_KhongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_KhongHoatDong.Checked)
            {
                cbx_HoatDong.Checked = false;
            }
        }

        private void btn_TìmKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowindex = e.RowIndex;
            //if (rowindex == _IKhachHangService.GetAll().Count) return;
            //_idWhenClick = Guid.Parse(dgridKhachHang.Rows[rowindex].Cells[1].Value.ToString());
            //var kh = _IKhachHangService.GetAll().FirstOrDefault(c => c.Id == _idWhenClick);
            //txt_Ma.Text = kh.Ma;
            //txt_Ho.Text = kh.Ho;
            //txt_TenDem.Text = kh.TenDem;
            //txt_Ten.Text = kh.Ten;
            //datetime_ngaysinh.Value = Convert.ToDateTime(_KhachHang.NgaySinh);
            //txt_SoDienThoai.Text = _KhachHang.Sdt;
            //txt_DiaChi.Text = _KhachHang.DiaChi;
            //txt_QuocGia.Text = _KhachHang.QuocGia;
            //cbx_HoatDong.Checked = _KhachHang.TrangThai == 1;
            //cbx_KhongHoatDong.Checked = _KhachHang.TrangThai == 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgridKhachHang.Rows[e.RowIndex];
                _KhachHang = _IKhachHangService.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _KhachHang.Ma;
                txt_Ho.Text = _KhachHang.Ho;
                txt_TenDem.Text = _KhachHang.TenDem;
                txt_Ten.Text = _KhachHang.Ten;
                datetime_ngaysinh.Value = Convert.ToDateTime(_KhachHang.NgaySinh);
                txt_SoDienThoai.Text = _KhachHang.Sdt;
                txt_DiaChi.Text = _KhachHang.DiaChi;
                txt_QuocGia.Text = _KhachHang.QuocGia;
                cbx_HoatDong.Checked = _KhachHang.TrangThai == 1;
                cbx_KhongHoatDong.Checked = _KhachHang.TrangThai == 0;

            }

        }
    }
}
