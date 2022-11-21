using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;


namespace _3.PL.Views
{
    public partial class FrmAnh : Form
    {
        private IAnhService _IAnhService;
        private Anh _Anh;
        private List<Anh> _lstAnh;
        public FrmAnh()
        {
            InitializeComponent();
            _IAnhService = new AnhService();
            _lstAnh = new List<Anh>();
            LoadData();
            anhcaidmm();
        }
        public void LoadData()
        {
            dgrid_Anh.ColumnCount = 5;
            dgrid_Anh.Columns[0].Name = "ID";
            dgrid_Anh.Columns[0].Visible = false;
            dgrid_Anh.Columns[1].Name = "Mã";
            dgrid_Anh.Columns[2].Name = "Tên";
            dgrid_Anh.Columns[3].Name = "Đường dẫn";
            dgrid_Anh.Columns[4].Name = "Trạng thái";
            dgrid_Anh.Rows.Clear();
            _lstAnh = _IAnhService.GetAllAnh();
            if (txt_TimKiem.Text != "")
            {
                _lstAnh = _lstAnh.Where(p => p.TenAnh.ToLower().Contains(txt_TimKiem.Text.ToLower()) || p.MaAnh.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in _lstAnh.OrderBy(c => c.MaAnh).ToList())
            {
                dgrid_Anh.Rows.Add(x.Id, x.MaAnh, x.TenAnh, x.DuongDan, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private Anh GetDataFromGuid()
        {
            return new Anh()
            {
                Id = Guid.NewGuid(),
                MaAnh = txt_Ma.Text,
                TenAnh = txt_Ten.Text,
                DuongDan = txt_duongDan.Text,
                TrangThai = cbx_HoatDong.Checked ? 1 : 0
            };
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thêm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _IAnhService.AddAnh(GetDataFromGuid());
                MessageBox.Show("Thêm thành công");
                LoadData();
                anhcaidmm();
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
                _Anh.MaAnh = txt_Ma.Text;
                _Anh.TenAnh = txt_Ten.Text;
                _Anh.DuongDan = txt_duongDan.Text;
                _Anh.TrangThai = cbx_HoatDong.Checked ? 1 : 0;
                _IAnhService.UpdateAnh(_Anh);
                MessageBox.Show("Sửa thành công");
                LoadData();
                anhcaidmm();
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
                _IAnhService.DeleteAnh(_Anh);
                MessageBox.Show("Xóa thành công");
                LoadData();
                anhcaidmm();
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
                txt_duongDan.Clear();
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
            anhcaidmm();
        }

        private void dgrid_Anh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowindex = e.RowIndex;
                if (rowindex == _IAnhService.GetAllAnh().Count) return;
                DataGridViewRow r = dgrid_Anh.Rows[e.RowIndex];
                _Anh = _IAnhService.GetAllAnh().FirstOrDefault(c => c.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = _Anh.MaAnh;
                txt_Ten.Text = _Anh.TenAnh;
                txt_duongDan.Text = _Anh.DuongDan;
                cbx_HoatDong.Checked = _Anh.TrangThai == 1;
                cbx_KhongHD.Checked = _Anh.TrangThai == 0;
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

        private void btn_fileName_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image file(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png;)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_duongDan.Text = openFileDialog.FileName;
            }
        }
        public void anhcaidmm()
        {
            try
            {
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.HeaderText = "Ảnh";
                img.Name = "img_sanPham";
                img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgrid_Anh.Columns.Add(img);
                
                for (int i = 0; i < dgrid_Anh.RowCount; i++)
                {
                    if(Convert.ToString(dgrid_Anh.Rows[i].Cells["Đường dẫn"].Value)=="")
                    {
                        return;
                    }
                    else { 
                    Image img1 = Image.FromFile(Convert.ToString(dgrid_Anh.Rows[i].Cells["Đường dẫn"].Value));

                    dgrid_Anh.Rows[i].Cells["img_sanPham"].Value = img1;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex), "Lỗi cmm");
                return;

            }
        }
    }
}
