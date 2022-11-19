using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmSanPham : Form
    {
        private ISanPhamService _ISanPhamService;
        private SanPham _sanPham;
        private List<SanPham> _lstSanPham;
        public FrmSanPham()
        {
            InitializeComponent();
            _ISanPhamService = new SanPhamService();
            _lstSanPham = new List<SanPham>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_SanPham.ColumnCount = 4;
            dgrid_SanPham.Columns[0].Name = "ID";
            dgrid_SanPham.Columns[0].Visible = false;
            dgrid_SanPham.Columns[1].Name = "Mã";
            dgrid_SanPham.Columns[2].Name = "Tên";
            dgrid_SanPham.Columns[3].Name = "Trạng thái";
            dgrid_SanPham.Rows.Clear();
            _lstSanPham = _ISanPhamService.GetAllSanPham();
            if (txt_TimKiem.Text != "")
            {
                _lstSanPham = _lstSanPham.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstSanPham.OrderBy(c => c.Ma).ToList())
            {
                dgrid_SanPham.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private SanPham GetDataFromGuid()
        {
            return new SanPham()
            {
                Id = Guid.NewGuid(),
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                TrangThai = cbx_HoatDong.Checked ? 1 : 0
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _ISanPhamService.AddSanPham(GetDataFromGuid());
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
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _sanPham.Ma = txt_Ma.Text;
                _sanPham.Ten = txt_Ten.Text;
                _sanPham.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _ISanPhamService.UpdateSanPham(_sanPham);
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
                _ISanPhamService.DeleteSanPham(_sanPham);
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
                txt_Ten.Clear();
                cbx_KhongHD.Checked = true;
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_SanPham.Rows[e.RowIndex];
                _sanPham = _ISanPhamService.GetAllSanPham().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _sanPham.Ma;
                txt_Ten.Text = _sanPham.Ten;
                cbx_HoatDong.Checked = _sanPham.TrangThai == 1;
                cbx_KhongHD.Checked = _sanPham.TrangThai == 0;
            }
        }

        private void cbx_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_HoatDong.Checked)
            {
                cbx_KhongHD.Checked = false;
            }
        }

        private void cbx_KhongHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_KhongHD.Checked)
            {
                cbx_HoatDong.Checked = false;
            }
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
