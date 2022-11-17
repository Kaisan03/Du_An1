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
    public partial class FrmChucVu : Form
    {

        private IChucVuService _IchucVuService;
        Guid _id;
        public FrmChucVu()
        {
            InitializeComponent();
            _IchucVuService = new ChucVuService();
            loaddata();
        }
        private void loaddata()
        {
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = "ID";
            dgrid_ChucVu.Columns[0].Visible = false;
            dgrid_ChucVu.Columns[1].Name = "Mã";
            dgrid_ChucVu.Columns[2].Name = "Tên";
            dgrid_ChucVu.Columns[3].Name = "Trạng thái";

            dgrid_ChucVu.Rows.Clear();
            var x = _IchucVuService.GetAllChucVu();
            foreach (var item in x)
            {
                dgrid_ChucVu.Rows.Add(
                    item.Id, item.Ma, item.Ten,
                    item.TrangThai);
            }
        }
        private ViewChucVu GetDataFromGuid()
        {
            return new ViewChucVu()
            {
                Id = Guid.NewGuid(),
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                TrangThai = cbx_HoatDong.Checked ? 1 : 0
            };
        }
        

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _IchucVuService.Add(GetDataFromGuid());
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var temp = GetDataFromGuid();

                temp.Id = _id;

                _IchucVuService.Update(temp);
                MessageBox.Show("Sửa thành công");
                loaddata();

            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var temp = GetDataFromGuid();

                temp.Id = _id;
                _IchucVuService.Delete(temp);
                MessageBox.Show("Xóa thành công");
                loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dgrid_ChatLieu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _IchucVuService.GetAllChucVu().Count) return;
            _id = Guid.Parse(dgrid_ChucVu.CurrentRow.Cells[0].Value.ToString());
            var cv = _IchucVuService.GetAllChucVu().FirstOrDefault(c => c.Id == _id);
            txt_Ten.Text = Convert.ToString(cv.Ma);
            txt_Ma.Text = cv.Ten;
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn clear?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Ma.Clear();
                txt_Ten.Clear();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {

        }
    }
}
