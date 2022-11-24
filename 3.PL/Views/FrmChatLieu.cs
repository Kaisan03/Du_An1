using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections;
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
        void LoadData()
        {
            dgrid_ChatLieu.ColumnCount = 4;
            dgrid_ChatLieu.Columns[0].Name = "ID";
            dgrid_ChatLieu.Columns[0].Visible = false;
            dgrid_ChatLieu.Columns[1].Name = "Mã chất liệu";
            dgrid_ChatLieu.Columns[2].Name = "Tên chất chất liệu";
            dgrid_ChatLieu.Columns[3].Name = "Trạng thái";
            dgrid_ChatLieu.Rows.Clear();
            _lstChatLieu = _IChatLieuService.GetAllChatLieu();
            if (txt_TimKiem.Text != "")
            {
                _lstChatLieu = _lstChatLieu.Where(p => p.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower()) || p.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstChatLieu.OrderBy(c => c.Ma).ToList())
            {
                dgrid_ChatLieu.Rows.Add(x.Id, x.Ma, x.Ten,
                    x.TrangThai == 1 ? "Sử dụng" : "Không sử dụng");
            }
            DataGridViewComboBoxColumn dcColumn = new DataGridViewComboBoxColumn();
            dcColumn.HeaderText = "CRUD";
            dcColumn.Items.Add("Thêm");
            dcColumn.Items.Add("Sửa");
            dcColumn.Items.Add("Xóa");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Xác nhận";
            buttonColumn.Text = "OK";
            buttonColumn.Name = "OK";

            dgrid_ChatLieu.Columns.Add(dcColumn);
            dgrid_ChatLieu.Columns.Add(buttonColumn);
        }
        //private ChatLieu GetDataFromGuid()
        //{
        //    return new ChatLieu()
        //    {
        //        Id = Guid.NewGuid(),
        //        Ma = txt_Ma.Text,
        //        Ten = txt_Ten.Text,
        //        TrangThai = cbx_HoatDong.Checked ? 1 : 0
        //    };
        //}
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    _IChatLieuService.AddChatLieu(GetDataFromGuid());
            //    MessageBox.Show("Thêm thành công");
            //    LoadData();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    _chatLieu.Ma = txt_Ma.Text;
            //    _chatLieu.Ten = txt_Ten.Text;
            //    _chatLieu.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
            //    _IChatLieuService.UpdateChatLieu(_chatLieu);
            //    MessageBox.Show("Sửa thành công");
            //    LoadData();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    _IChatLieuService.DeleteChatLieu(_chatLieu);
            //    MessageBox.Show("Xóa thành công");
            //    LoadData();
            //}
            //if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
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
            //int rowIndex = e.RowIndex;
            //if ((rowIndex > _IChatLieuService.GetAllChatLieu().Count) || rowIndex < 0) return;
            //txt_Ma.Text = dgrid_ChatLieu.Rows[rowIndex].Cells[1].Value.ToString();
            //txt_Ten.Text = dgrid_ChatLieu.Rows[rowIndex].Cells[2].Value.ToString();
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

        private void dgrid_ChatLieu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (e.ColumnIndex == dgrid_ChatLieu.Columns["Ok"].Index)
            {
                if (dgrid_ChatLieu.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString() == "Thêm")
                {
                    var x = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (x == DialogResult.No)
                    {
                        return;
                    }

                    _1.DAL.DomainClass.ChatLieu chatLieu = new _1.DAL.DomainClass.ChatLieu()
                    {
                        Id = Guid.NewGuid(),
                        Ma = dgrid_ChatLieu.Rows[rowIndex].Cells[1].Value.ToString(),
                        Ten = dgrid_ChatLieu.Rows[rowIndex].Cells[2].Value.ToString(),
                        TrangThai = dgrid_ChatLieu.Rows[rowIndex].Cells[3].Value == "Không sử dụng" ? 1 : 0
                    };
                    _IChatLieuService.AddChatLieu(chatLieu);
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                    return;
                }

                if (Convert.ToString(dgrid_ChatLieu.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value) == "Sửa")
                {
                    var x = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (x == DialogResult.No)
                    {
                        return;
                    }
                    var chatlieu = _IChatLieuService.GetAllChatLieu().FirstOrDefault(x =>
                    x.Id == Guid.Parse(dgrid_ChatLieu.Rows[rowIndex].Cells[0].Value.ToString()));
                    chatlieu.Ma = dgrid_ChatLieu.Rows[rowIndex].Cells[1].Value.ToString();
                    chatlieu.Ten = dgrid_ChatLieu.Rows[rowIndex].Cells[2].Value.ToString();
                    chatlieu.TrangThai = Convert.ToInt32(dgrid_ChatLieu.Rows[rowIndex].Cells[3].Value);


                    _IChatLieuService.UpdateChatLieu(chatlieu);
                    LoadData();
                }
                if (Convert.ToString(dgrid_ChatLieu.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value) == "Xóa")
                {
                    var x = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (x == DialogResult.No)
                    {
                        return;
                    }

                    var chatLieu = _IChatLieuService.GetAllChatLieu().FirstOrDefault(x =>
                    x.Id == Guid.Parse(dgrid_ChatLieu.Rows[rowIndex].Cells[0].Value.ToString()));
                    _IChatLieuService.DeleteChatLieu(chatLieu);
                    LoadData();
                    return;
                }

                LoadData();
            }
        }

        private void dgrid_ChatLieu_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _IChatLieuService.GetAllChatLieu().Count || rowindex == -1) return;
            _chatLieu = _IChatLieuService.GetAllChatLieu().ToList().FirstOrDefault(c => c.Id == Guid.Parse(dgrid_ChatLieu.Rows[rowindex].Cells[0].Value.ToString()));
            txt_Ma.Text = dgrid_ChatLieu.Rows[rowindex].Cells[1].Value.ToString();
            txt_Ten.Text = dgrid_ChatLieu.Rows[rowindex].Cells[2].Value.ToString();
            cbx_HoatDong.Checked = dgrid_ChatLieu.Rows[rowindex].Cells[3].Value == "Sử dụng" ? true : false;
            cbx_KhongHD.Checked = dgrid_ChatLieu.Rows[rowindex].Cells[3].Value == "Không sử dụng" ? true : false;
        }
    }
}
