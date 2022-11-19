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
    public partial class FrmChatLieu : Form
    {
        private IChatLieuService _IChatLieuService;
        private ChatLieu _chatLieu;
        private List<ChatLieu> _lstChatLieu;
        public FrmChatLieu()
        {
            InitializeComponent();
            _IChatLieuService = new ChatLieuService();
            _lstChatLieu = new List<ChatLieu>();
            LoadData();
        }
        public void LoadData()
        {
            dgrid_ChatLieu.ColumnCount = 4;
            dgrid_ChatLieu.Columns[0].Name = "ID";
            dgrid_ChatLieu.Columns[0].Visible = false;
            dgrid_ChatLieu.Columns[1].Name = "Mã";
            dgrid_ChatLieu.Columns[2].Name = "Tên";
            dgrid_ChatLieu.Columns[3].Name = "Trạng thái";
            dgrid_ChatLieu.Rows.Clear();
            _lstChatLieu = _IChatLieuService.GetAllChatLieu();
            if (txt_TimKiem.Text != "")
            {
                _lstChatLieu = _lstChatLieu.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstChatLieu.OrderBy(c => c.Ma).ToList())
            {
                dgrid_ChatLieu.Rows.Add(x.Id, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private ChatLieu GetDataFromGuid()
        {
            return new ChatLieu()
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
                _IChatLieuService.AddChatLieu(GetDataFromGuid());
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
                _chatLieu.Ma = txt_Ma.Text;
                _chatLieu.Ten = txt_Ten.Text;
                _chatLieu.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IChatLieuService.UpdateChatLieu(_chatLieu);
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
                _IChatLieuService.DeleteChatLieu(_chatLieu);
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
        private void dgrid_ChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgrid_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_ChatLieu.Rows[e.RowIndex];
                _chatLieu = _IChatLieuService.GetAllChatLieu().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _chatLieu.Ma;
                txt_Ten.Text = _chatLieu.Ten;
                cbx_HoatDong.Checked = _chatLieu.TrangThai == 1;
                cbx_KhongHD.Checked = _chatLieu.TrangThai == 0;
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
