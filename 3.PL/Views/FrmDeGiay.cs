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
    public partial class FrmDeGiay : Form
    {
        private IDeGiayService _IDeGiayService;
        private DeGiay _deGiay;
        private List<DeGiay> _lstDeGiay;
        public FrmDeGiay()
        {
            InitializeComponent();
            _IDeGiayService = new DeGiayService();
            _lstDeGiay = new List<DeGiay>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_DeGiay.ColumnCount = 6;
            dgrid_DeGiay.Columns[0].Name = "ID";
            dgrid_DeGiay.Columns[0].Visible = false;
            dgrid_DeGiay.Columns[1].Name = "Mã";
            dgrid_DeGiay.Columns[2].Name = "Tên";
            dgrid_DeGiay.Columns[3].Name = "Chất liệu";
            dgrid_DeGiay.Columns[4].Name = "Chiều cao";
            dgrid_DeGiay.Columns[5].Name = "Trạng thái";
            dgrid_DeGiay.Rows.Clear();
            _lstDeGiay = _IDeGiayService.GetAllDeGiay();
            if (txt_TimKiem.Text != "")
            {
                _lstDeGiay = _lstDeGiay.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstDeGiay.OrderBy(c => c.Ma).ToList())
            {
                dgrid_DeGiay.Rows.Add(x.Id, x.Ma, x.Ten, x.ChatLieu, x.ChieuCao, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private DeGiay GetDataFromGuid()
        {
            return new DeGiay()
            {
                Id = Guid.NewGuid(),
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                ChatLieu = txt_ChatLieu.Text,
                ChieuCao = Convert.ToInt32(txt_ChieuCao.Text),
                TrangThai = cbx_HoatDong.Checked ? 1 : 0
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _IDeGiayService.AddDeGiay(GetDataFromGuid());
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
                _deGiay.Ma = txt_Ma.Text;
                _deGiay.Ten = txt_Ten.Text;
                _deGiay.ChatLieu = txt_ChatLieu.Text;
                _deGiay.ChieuCao = Convert.ToInt32(txt_ChieuCao.Text);
                _deGiay.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IDeGiayService.UpdateDeGiay(_deGiay);
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
                _IDeGiayService.DeleteDeGiay(_deGiay);
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
                txt_ChatLieu.Clear();
                txt_ChieuCao.Clear();
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

        private void dgrid_DeGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_DeGiay.Rows[e.RowIndex];
                _deGiay = _IDeGiayService.GetAllDeGiay().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _deGiay.Ma;
                txt_Ten.Text = _deGiay.Ten;
                txt_ChatLieu.Text = _deGiay.ChatLieu;
                txt_ChieuCao.Text = Convert.ToString(_deGiay.ChieuCao);
                cbx_HoatDong.Checked = _deGiay.TrangThai == 1;
                cbx_KhongHD.Checked = _deGiay.TrangThai == 0;
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

        private void FrmDeGiay_Load(object sender, EventArgs e)
        {

        }
    }
}
