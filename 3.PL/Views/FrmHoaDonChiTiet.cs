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
    public partial class FrmHoaDonChiTiet : Form
    {
        private IHoaDonChiTietService _IHoaDonChiTiet;
        public FrmHoaDonChiTiet()
        {
            InitializeComponent();
            _IHoaDonChiTiet = new HoaDonChiTiet();
            loaddata();
        }
        private void loaddata()
        {
            dgrid_hoaDonCT.ColumnCount = 8;
            dgrid_hoaDonCT.Columns[0].Name = "ID";
            dgrid_hoaDonCT.Columns[0].Visible = false;
            dgrid_hoaDonCT.Columns[1].Name = "IdHoaDon";
            dgrid_hoaDonCT.Columns[1].Visible = false;
            dgrid_hoaDonCT.Columns[2].Name = "IdChiTietKhuyenMai";
            dgrid_hoaDonCT.Columns[2].Visible = false;
            dgrid_hoaDonCT.Columns[3].Name = "IdChiTietGiay";
            dgrid_hoaDonCT.Columns[3].Visible = false;
            dgrid_hoaDonCT.Columns[4].Name = "Số lượng";
            dgrid_hoaDonCT.Columns[5].Name = "Đơn Giá";
            dgrid_hoaDonCT.Columns[6].Name = "Thành tiền";
            dgrid_hoaDonCT.Columns[7].Name = "Trạng thái";

            dgrid_hoaDonCT.Rows.Clear();
            
        }
        private ViewHoaDonChiTiet GetDataFromGuid()
        {
            ViewHoaDonChiTiet x = new ViewHoaDonChiTiet();
            x.HoaDonChiTiet = new _1.DAL.DomainClass.HoaDonChiTiet()
            {
                Id = Guid.NewGuid(),
                
                
               
            };
            return x;

            }


        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //_IchucVuService.Add(GetDataFromGuid());
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

                //temp.Id = _id;

                //_IchucVuService.Update(temp);
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

                //temp.Id = _id;
                //_IchucVuService.Delete(temp);
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
            //int rowindex = e.RowIndex;
            //if (rowindex == _IchucVuService.GetAllChucVu().Count) return;
            //_id = Guid.Parse(dgrid_ChatLieu.CurrentRow.Cells[0].Value.ToString());
            //var cv = _IchucVuService.GetAllChucVu().FirstOrDefault(c => c.Id == _id);
            //txt_Ten.Text = Convert.ToString(cv.Ma);
            //txt_Ma.Text = cv.Ten;
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn clear?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //txt_Ma.Clear();
                //txt_Ten.Clear();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
