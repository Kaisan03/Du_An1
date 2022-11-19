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
    public partial class FrmKieuDang : Form
    {
        private IKieuDangService _IKieuDangService;
        private KieuDang _kieuDang;
        private List<KieuDang> _lstKieuDang;
        public FrmKieuDang()
        {
            InitializeComponent();
            _IKieuDangService = new KieuDangService();
            _lstKieuDang = new List<KieuDang>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_KieuDang.ColumnCount = 4;
            dgrid_KieuDang.Columns[0].Name = "ID";
            dgrid_KieuDang.Columns[0].Visible = false;
            dgrid_KieuDang.Columns[1].Name = "Mã";
            dgrid_KieuDang.Columns[2].Name = "Tên";
            dgrid_KieuDang.Columns[3].Name = "Trạng thái";
            dgrid_KieuDang.Rows.Clear();
            _lstKieuDang = _IKieuDangService.GetAllKieuDang();
            if (txt_TimKiem.Text != "")
            {
                _lstKieuDang = _lstKieuDang.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstKieuDang.OrderBy(c => c.Ma).ToList())
            {
                dgrid_KieuDang.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private KieuDang GetDataFromGuid()
        {
            return new KieuDang()
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
                _IKieuDangService.AddKieuDang(GetDataFromGuid());
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
                _kieuDang.Ma = txt_Ma.Text;
                _kieuDang.Ten = txt_Ten.Text;
                _kieuDang.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IKieuDangService.UpdateKieuDang(_kieuDang);
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
                _IKieuDangService.DeleteKieuDang(_kieuDang);
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

        private void dgrid_KieuDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_KieuDang.Rows[e.RowIndex];
                _kieuDang = _IKieuDangService.GetAllKieuDang().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _kieuDang.Ma;
                txt_Ten.Text = _kieuDang.Ten;
                cbx_HoatDong.Checked = _kieuDang.TrangThai == 1;
                cbx_KhongHD.Checked = _kieuDang.TrangThai == 0;
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

        private void FrmKieuDang_Load(object sender, EventArgs e)
        {

        }
    }
}
