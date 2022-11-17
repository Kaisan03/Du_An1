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
    public partial class FrmNhanVien : Form
    {
        private INhanVienService _iNhanVienService;
        private IChucVuService _chucVuService;
        //private ViewNhanVien _lstViewNhanVien;
        private List<ViewNhanVien> _lstViewNhanVien;
        private Guid _Idnhanvien;
        public FrmNhanVien()
        {
            InitializeComponent();
            _iNhanVienService = new NhanVienService();
            _chucVuService = new ChucVuService();
            _lstViewNhanVien = new List<ViewNhanVien>();
            LoadDataNhanVien();
            LoadComboBox();

        }
        public void LoadComboBox()
        {
            foreach (var x in _chucVuService.GetAllChucVu())
            {
                cmb_idChucVu.Items.Add(x.Ten);
            }
        }
            public void LoadDataNhanVien()
        {
            drgid_NhanVien.ColumnCount = 12;
            drgid_NhanVien.Columns[0].Name = "ID";
            drgid_NhanVien.Columns[0].Visible = false; 
            drgid_NhanVien.Columns[1].Name = "Mã";
            drgid_NhanVien.Columns[2].Name = "Họ";
            drgid_NhanVien.Columns[3].Name = "Tên Đệm";
            drgid_NhanVien.Columns[4].Name = "Tên";
            drgid_NhanVien.Columns[5].Name = "Giới Tính";
            drgid_NhanVien.Columns[6].Name = "Ngày Sinh";
            drgid_NhanVien.Columns[7].Name = "Địa Chỉ";
            drgid_NhanVien.Columns[8].Name = "SDt ";
            drgid_NhanVien.Columns[9].Name = "Mật Khẩu ";
            drgid_NhanVien.Columns[10].Name = "Ten chức Vụ ";
            //drgid_NhanVien.Columns[13].Name = "ID GuiBC ";
            drgid_NhanVien.Columns[11].Name = "Trạng Thái ";
            drgid_NhanVien.Rows.Clear();
            var lstNhanVien = _iNhanVienService.GetViewNhanVien();
            //if (txt_TimKiem.Text != "")
            //{
            //    _lstNhanVien = lstNhanVien.Where(p => p.Ma.ToLower().Contains(txt_Ma.Text.ToLower())).ToList();
            //}
            foreach (var x in lstNhanVien)
            {
               
                drgid_NhanVien.Rows.Add(x.Id, x.Ma, x.Ho, x.TenDem, x.Ten, x.GioiTinh == "Nam" ? 0: 1, x.NgaySinh, x.DiaChi, x.Sdt,
                  x.MatKhau,x.TenChuCVu, x.TrangThai == 1 ? "Hoat dong":"Khong hoat dong");
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AddNhanVienView addNhanVienView = new AddNhanVienView()
                {
                   
                    IdChucVu = cmb_idChucVu.Text != null ? _chucVuService.GetAllChucVu().FirstOrDefault(c => c.Ten == cmb_idChucVu.Text).Id : null,
                    Ma = txt_Ma.Text,
                    Ho = txt_Ho.Text,
                    TenDem = txt_TenDem.Text,
                    Ten = txt_Ten.Text,
                    GioiTinh = rbtn_Nam.Checked ?"Nam":"Nu",
                    NgaySinh = dateTime_NgaySinh.Value,
                    DiaChi = txt_DiaChi.Text,
                    Sdt = txt_Sdt.Text,
                    MatKhau = txt_MatKhau.Text,
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0
                };
                _iNhanVienService.AddNhanVien(addNhanVienView);
                MessageBox.Show("Thêm thành công");
                LoadDataNhanVien();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sua?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateNhanVienView updateNhanVienView = new UpdateNhanVienView()
                {
                    Id = _Idnhanvien,
                    IdChucVu = cmb_idChucVu.Text != null ? _iNhanVienService.GetAllNhanVien().FirstOrDefault(c => c.Ten == cmb_idChucVu.Text).Id : null,
                    Ma = txt_Ma.Text,
                    Ho = txt_Ho.Text,
                    TenDem = txt_TenDem.Text,
                    Ten = txt_Ten.Text,
                    GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nu",
                    NgaySinh = dateTime_NgaySinh.Value,
                    DiaChi = txt_DiaChi.Text,
                    Sdt = txt_Sdt.Text,
                    MatKhau = txt_MatKhau.Text,
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0
                };
                _iNhanVienService.UpdateNhanVien(updateNhanVienView);
                MessageBox.Show("Sửa thành công");
                LoadDataNhanVien();
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
                _iNhanVienService.Delete(_Idnhanvien);
                MessageBox.Show("Xóa thành công");
                LoadDataNhanVien();
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
                LoadDataNhanVien();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void drgid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = drgid_NhanVien.Rows[e.RowIndex];
            _Idnhanvien = Guid.Parse(r.Cells[0].Value.ToString());
            //cmb_ChucVu.Text = _NhanVienService.GetAllNV().FirstOrDefault(c => c.Id == _idNV).Ten;
            cmb_idChucVu.Text = r.Cells[2].Value.ToString();
            var x = _iNhanVienService.GetViewNhanVien().FirstOrDefault(c => c.Id == _Idnhanvien);
            txt_Ma.Text = x.Ma;
            txt_Ten.Text = x.Ten;
            txt_DiaChi.Text = x.DiaChi;
            dateTime_NgaySinh.Value = x.NgaySinh.Value;
            if (x.TrangThai == 1)
            {
                cbx_HoatDong.Checked = true;
                return;
            }
            else
            {
                cbx_KhongHoatDong.Checked = true;
            }
        }
  

        private void drgid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
          
            
        }
        private void cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HoatDong.Checked)
            {
                cbx_KhongHoatDong.Checked = false;
            }
        }

        private void cbx_khongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_KhongHoatDong.Checked)
            {
                cbx_HoatDong.Checked = false;
            }
        }

       
        private void cmb_idChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
