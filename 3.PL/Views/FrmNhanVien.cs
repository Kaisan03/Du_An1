﻿using _2.BUS.IServices;
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
        private IChucVuService _IChucVuService;
        //private ViewNhanVien _lstViewNhanVien;
        private List<ViewNhanVien> _lstViewNhanVien;
        private Guid _Idnhanvien;
        public FrmNhanVien()
        {
            InitializeComponent();
            _iNhanVienService = new NhanVienService();
            _IChucVuService = new ChucVuService();
            _lstViewNhanVien = new List<ViewNhanVien>();
            LoadDataNhanVien();
            LoadComboBox();
            saringan.BackgroundImageLayout = ImageLayout.Zoom;
            saringanfake.BackgroundImageLayout = ImageLayout.Zoom;
            txt_Ma.Enabled = false;
            drgid_NhanVien.AllowUserToAddRows = false;
        }
        public void LoadComboBox()
        {
            var cv = _IChucVuService.GetAllChucVu().Select(c => c.Ten.ToString()).Distinct();
            foreach (var x in cv)
            {
                cmb_idChucVu.Items.Add(x);
            }
        }
        public void LoadDataNhanVien()
        {
            drgid_NhanVien.ColumnCount = 14;
            drgid_NhanVien.Columns[0].Name = "ID";
            drgid_NhanVien.Columns[0].Visible = false;
            drgid_NhanVien.Columns[1].Name = "Mã";
            drgid_NhanVien.Columns[2].Name = "Họ";
            drgid_NhanVien.Columns[3].Name = "Tên Đệm";
            drgid_NhanVien.Columns[4].Name = "Tên";
            drgid_NhanVien.Columns[5].Name = "Giới Tính";
            drgid_NhanVien.Columns[6].Name = "Ngày Sinh";
            drgid_NhanVien.Columns[7].Name = "Địa Chỉ";
            drgid_NhanVien.Columns[8].Name = "Sdt ";
            drgid_NhanVien.Columns[9].Name = "Email";
            drgid_NhanVien.Columns[10].Name = "Mật Khẩu ";
            drgid_NhanVien.Columns[11].Name = "Tên chức Vụ ";
            //drgid_NhanVien.Columns[13].Name = "ID GuiBC ";
            drgid_NhanVien.Columns[12].Name = "Trạng Thái ";
            drgid_NhanVien.Columns[13].Name = "Ảnh";
            drgid_NhanVien.Rows.Clear();
            var lstNhanVien = _iNhanVienService.GetViewNhanVien();
            if (txt_TimKiem.Text != "")
            {
                lstNhanVien = lstNhanVien.Where(p => p.Ma.ToLower().Contains(txt_Ma.Text.ToLower()) || p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstNhanVien)
            {

                drgid_NhanVien.Rows.Add(x.Id, x.Ma, x.Ho, x.TenDem, x.Ten, x.GioiTinh == "Nam" ? "Nam" : "Nữ", x.NgaySinh, x.DiaChi, x.Sdt,
                  x.Email, x.MatKhau, x.TenChuCVu, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.duongDan);
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            //pic_Image.AllowDrop = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Ma.Text = MaNhanVien();
                AddNhanVienView addNhanVienView = new AddNhanVienView()
                {

                    IdChucVu = cmb_idChucVu.Text != null ? _IChucVuService.GetAllChucVu().FirstOrDefault(c => c.Ten == cmb_idChucVu.Text).Id : null,
                    Ma = txt_Ma.Text,
                    Ho = txt_Ho.Text,
                    TenDem = txt_TenDem.Text,
                    Ten = txt_Ten.Text,
                    GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                    NgaySinh = dateTime_NgaySinh.Value,
                    DiaChi = txt_DiaChi.Text,
                    Sdt = txt_Sdt.Text,
                    Email = txt_Email.Text,
                    MatKhau = txt_MatKhau.Text,
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0,
                    duongDan = txt_DuongDan.Text

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
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Ma.Text = MaNhanVien();
                UpdateNhanVienView updateNhanVienView = new UpdateNhanVienView()
                {
                    Id = _Idnhanvien,
                    IdChucVu = cmb_idChucVu.Text != null ? _IChucVuService.GetAllChucVu().FirstOrDefault(c => c.Ten == cmb_idChucVu.Text).Id : null,
                    Ma = txt_Ma.Text,
                    Ho = txt_Ho.Text,
                    TenDem = txt_TenDem.Text,
                    Ten = txt_Ten.Text,
                    GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                    NgaySinh = dateTime_NgaySinh.Value,
                    DiaChi = txt_DiaChi.Text,
                    Sdt = txt_Sdt.Text,
                    Email = txt_Email.Text,
                    MatKhau = txt_MatKhau.Text,
                    TrangThai = cbx_HoatDong.Checked ? 1 : 0,
                    duongDan = txt_DuongDan.Text
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

        }


        private void drgid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int rowindex = e.RowIndex;
                if (rowindex == _iNhanVienService.GetAllNhanVien().Count) return;
                DataGridViewRow r = drgid_NhanVien.Rows[e.RowIndex];
                _Idnhanvien = Guid.Parse(r.Cells[0].Value.ToString());
                cmb_idChucVu.Text = r.Cells[10].Value.ToString();
                var x = _iNhanVienService.GetViewNhanVien().FirstOrDefault(c => c.Id == _Idnhanvien);
                txt_Ho.Text = x.Ho;
                txt_TenDem.Text = x.TenDem;
                cmb_idChucVu.Text = x.TenChuCVu;
                txt_Ten.Text = x.Ten;
                txt_Sdt.Text = x.Sdt;
                txt_Email.Text = x.Email;
                txt_MatKhau.Text = x.MatKhau;
                txt_DiaChi.Text = x.DiaChi;
                dateTime_NgaySinh.Value = x.NgaySinh.Value;
                txt_Ma.Text = MaNhanVien();
                txt_Ma.Text = x.Ma;
                txt_DuongDan.Text = x.duongDan;
                pic_Image.ImageLocation = r.Cells[13].Value.ToString();
                if (x.GioiTinh == "Nam")
                {
                    rbtn_Nam.Checked = true;
                    return;
                }
                rbtn_Nu.Checked = true;
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }

        private void btn_Them_MouseHover(object sender, EventArgs e)
        {
            btn_Them.BackColor = Color.FromArgb(255, 89, 136);
        }

        private void btn_Them_MouseLeave(object sender, EventArgs e)
        {
            btn_Them.BackColor = Color.White;
        }

        private void btn_Sua_MouseHover(object sender, EventArgs e)
        {
            btn_Sua.BackColor = Color.FromArgb(255, 89, 136);
        }

        private void btn_Sua_MouseLeave(object sender, EventArgs e)
        {
            btn_Sua.BackColor = Color.White;
        }

        private void btn_Xoa_MouseHover(object sender, EventArgs e)
        {
            btn_Xoa.BackColor = Color.FromArgb(255, 89, 136);
        }

        private void btn_Xoa_MouseLeave(object sender, EventArgs e)
        {
            btn_Xoa.BackColor = Color.White;
        }

        private void btn_Clear_MouseHover(object sender, EventArgs e)
        {
            btn_Clear.BackColor = Color.FromArgb(255, 89, 136);
        }

        private void btn_Clear_MouseLeave(object sender, EventArgs e)
        {
            btn_Clear.BackColor = Color.White;
        }

        private void saringan_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.PasswordChar == '*')
            {
                saringanfake.BringToFront();
                txt_MatKhau.PasswordChar = '\0';
            }
        }

        private void saringanfake_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.PasswordChar == '\0')
            {
                saringan.BringToFront();
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void btn_AddCV_Click(object sender, EventArgs e)
        {
            FrmChucVu frmcv = new FrmChucVu();
            frmcv.ShowDialog();
            cmb_idChucVu.Items.Clear();
            LoadComboBox();
        }
        public string MaNhanVien()
        {
            string name = string.Concat(ConvertToUnsign(txt_Ten.Text), ChuCaiDau(txt_Ho.Text), ChuCaiDau(txt_TenDem.Text), _iNhanVienService.GetAllNhanVien().Count + 1);
            return name;
        }
        public string ChuCaiDau(string value)
        {
            return Convert.ToString(value[0]);
        }
        public string ConvertToUnsign(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        private void pic_Image_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pic_Image.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void pic_Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void txt_DuongDan_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txt_DuongDan.Text = FileList[0];
        }

        private void txt_DuongDan_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
