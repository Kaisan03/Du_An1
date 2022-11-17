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
using Size = _1.DAL.DomainClass.Size;

namespace _3.PL.Views
{
    public partial class FrmSize : Form
    {
        private ISizeService _ISizeService;
        private Size _Size;
        private List<Size> _lstSize;
        public FrmSize()
        {
            InitializeComponent();
            _ISizeService = new SizeService();
            _lstSize = new List<Size>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_Size.ColumnCount = 4;
            dgrid_Size.Columns[0].Name = "ID";
            dgrid_Size.Columns[0].Visible = false;
            dgrid_Size.Columns[1].Name = "Mã";
            dgrid_Size.Columns[2].Name = "Tên";
            dgrid_Size.Columns[3].Name = "Trạng thái";
            dgrid_Size.Rows.Clear();
            _lstSize = _ISizeService.GetAllSize();
            if (txt_TimKiem.Text != "")
            {
                _lstSize = _lstSize.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstSize.OrderBy(c => c.Ma).ToList())
            {
                dgrid_Size.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private Size GetDataFromGuid()
        {
            return new Size()
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
                _ISizeService.AddSize(GetDataFromGuid());
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
                _Size.Ma = txt_Ma.Text;
                _Size.Ten = txt_Ten.Text;
                _Size.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _ISizeService.UpdateSize(_Size);
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
                _ISizeService.DeleteSize(_Size);
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

        private void dgrid_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_Size.Rows[e.RowIndex];
                _Size = _ISizeService.GetAllSize().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _Size.Ma;
                txt_Ten.Text = _Size.Ten;
                cbx_HoatDong.Checked = _Size.TrangThai == 1;
                cbx_KhongHD.Checked = _Size.TrangThai == 0;
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

        private void FrmSize_Load(object sender, EventArgs e)
        {

        }
    }
}
