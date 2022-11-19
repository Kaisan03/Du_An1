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
    public partial class FrmMauSac : Form
    {
        private IMauSacService _IMauSacService;
        private MauSac _mauSac;
        private List<MauSac> _lstMauSac;
        public FrmMauSac()
        {
            InitializeComponent();
            _IMauSacService = new MauSacService();
            _lstMauSac = new List<MauSac>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_MauSac.ColumnCount = 4;
            dgrid_MauSac.Columns[0].Name = "ID";
            dgrid_MauSac.Columns[0].Visible = false;
            dgrid_MauSac.Columns[1].Name = "Mã";
            dgrid_MauSac.Columns[2].Name = "Tên";
            dgrid_MauSac.Columns[3].Name = "Trạng thái";
            dgrid_MauSac.Rows.Clear();
            _lstMauSac = _IMauSacService.GetAllMauSac();
            if (txt_TimKiem.Text != "")
            {
                _lstMauSac = _lstMauSac.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstMauSac.OrderBy(c => c.Ma).ToList())
            {
                dgrid_MauSac.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private MauSac GetDataFromGuid()
        {
            return new MauSac()
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
                _IMauSacService.AddMauSac(GetDataFromGuid());
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
                _mauSac.Ma = txt_Ma.Text;
                _mauSac.Ten = txt_Ten.Text;
                _mauSac.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IMauSacService.UpdateMauSac(_mauSac);
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
                _IMauSacService.DeleteMauSac(_mauSac);
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

        private void dgrid_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_MauSac.Rows[e.RowIndex];
                _mauSac = _IMauSacService.GetAllMauSac().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _mauSac.Ma;
                txt_Ten.Text = _mauSac.Ten;
                cbx_HoatDong.Checked = _mauSac.TrangThai == 1;
                cbx_KhongHD.Checked = _mauSac.TrangThai == 0;
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
    }
}
