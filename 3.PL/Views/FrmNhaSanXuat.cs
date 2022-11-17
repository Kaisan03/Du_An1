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
    public partial class FrmNhaSanXuat : Form
    {
        private INhaSanXuatService _INhaSanXuatService;
        private Nsx _nsx;
        private List<Nsx> _lstNsx;
        public FrmNhaSanXuat()
        {
            InitializeComponent();
            _INhaSanXuatService = new NhaSanXuatService();
            _lstNsx = new List<Nsx>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_Nsx.ColumnCount = 4;
            dgrid_Nsx.Columns[0].Name = "ID";
            dgrid_Nsx.Columns[0].Visible = false;
            dgrid_Nsx.Columns[1].Name = "Mã";
            dgrid_Nsx.Columns[2].Name = "Tên";
            dgrid_Nsx.Columns[3].Name = "Trạng thái";
            dgrid_Nsx.Rows.Clear();
            _lstNsx = _INhaSanXuatService.GetAllNSX();
            if (txt_TimKiem.Text != "")
            {
                _lstNsx = _lstNsx.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstNsx.OrderBy(c => c.Ma).ToList())
            {
                dgrid_Nsx.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private Nsx GetDataFromGuid()
        {
            return new Nsx()
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
                _INhaSanXuatService.AddNSX(GetDataFromGuid());
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
                _nsx.Ma = txt_Ma.Text;
                _nsx.Ten = txt_Ten.Text;
                _nsx.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _INhaSanXuatService.UpdateNSX(_nsx);
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
                _INhaSanXuatService.DeleteNSX(_nsx);
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

        private void dgrid_Nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_Nsx.Rows[e.RowIndex];
                _nsx = _INhaSanXuatService.GetAllNSX().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _nsx.Ma;
                txt_Ten.Text = _nsx.Ten;
                cbx_HoatDong.Checked = _nsx.TrangThai == 1;
                cbx_KhongHD.Checked = _nsx.TrangThai == 0;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
