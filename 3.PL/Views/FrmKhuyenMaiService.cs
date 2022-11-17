using _1.DAL.DomainClass;
using _1.DAL.Repositories;
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
    public partial class FrmKhuyenMaiService : Form
    {
        private IKhuyenMaiService _iKhuyenMaiService;
        public Guid _id;
        public FrmKhuyenMaiService()
        {
            InitializeComponent();
            _iKhuyenMaiService = new KhuyenMaiService();
            Loaddata();
        }
        public void Loaddata()
        {
            dgrid_view.ColumnCount = 5;
            dgrid_view.Columns[0].Name = "ID";
            dgrid_view.Columns[0].Visible = false;
            dgrid_view.Columns[1].Name = "Mã";
            dgrid_view.Columns[2].Name = "Tên";
            dgrid_view.Columns[3].Name = "Mô Tả";
            dgrid_view.Columns[4].Name = "Trạng Thái";
            dgrid_view.Rows.Clear();
            foreach (var x in _iKhuyenMaiService.GetAllKhuyenMai())
            {
                dgrid_view.Rows.Add(x.Id,x.Ma,x.Ten,x.Mota,x.TrangThai == 1 ? "Hoạt Động" :"Không Hoạt Động");
            }
        }

        private void dgrid_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrid_view.Rows[e.RowIndex];
            _id = Guid.Parse(r.Cells[0].Value.ToString());
            var KM = _iKhuyenMaiService.GetAllKhuyenMai().FirstOrDefault(c => c.Id == _id);
            tbx_ma.Text = r.Cells[1].Value.ToString();
            tbx_ten.Text = r.Cells[2].Value.ToString();
            tbx_mota.Text = r.Cells[3].Value.ToString();
            rbtn_hoatdong.Checked = KM.TrangThai  == 1;
            rbtn_khonghoatdong.Checked = KM.TrangThai == 0;
        }
        public KhuyenMai dataadd()
        {
            return new KhuyenMai
            {
                Id = Guid.NewGuid(),
                Ma = tbx_ma.Text,
                Ten = tbx_ten.Text,
                Mota = tbx_mota.Text,
                TrangThai = rbtn_hoatdong.Checked ? 1 : 2,
            };
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc Chăn Muốn thêm ? ", "Thông Báo!!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iKhuyenMaiService.Add(dataadd());
                MessageBox.Show("Thành Công!!");
                Loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc Chăn Muốn Sửa ? ", "Thông Báo!!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KhuyenMai x = new KhuyenMai()
                {
                    Id = _id,
                    Ma = tbx_ma.Text,
                    Ten = tbx_ten.Text, 
                    Mota = tbx_mota.Text,
                    TrangThai = rbtn_hoatdong.Checked ? 1:0,
                };
                _iKhuyenMaiService.Update(x);
                MessageBox.Show("Thành Công!!");
                Loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc Chăn Muốn Xóa ? ", "Thông Báo!!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KhuyenMai x = new KhuyenMai()
                {
                    Id = _id,
                };
                _iKhuyenMaiService.DeleteD(x);
                MessageBox.Show("Thành Công!!");
                Loaddata();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
