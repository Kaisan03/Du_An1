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
    public partial class crudgiaoca : Form
    {
        private IGiaoCaService _iGiaocaservice;
        private INhanVienService _inhanvienservice;
        public crudgiaoca()
        {
            InitializeComponent();
            _inhanvienservice = new NhanVienService();
            _iGiaocaservice = new GiaoCaService();
            showdata();

        }

        public void showdata()
        {
            dataGridView1.ColumnCount = 10;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].Name = "lol";
            dataGridView1.Columns[1].Name = "lol";
            dataGridView1.Columns[2].Name = "lol";
            dataGridView1.Columns[3].Name = "lol";
            dataGridView1.Columns[4].Name = "lol";
            dataGridView1.Columns[5].Name = "lol";
            dataGridView1.Columns[6].Name = "lol";
            dataGridView1.Columns[7].Name = "lol";
            dataGridView1.Columns[8].Name = "lol";
            dataGridView1.Columns[9].Name = "lol";
            foreach (var x in _iGiaocaservice.GetAllGiaoca())
            {
                dataGridView1.Rows.Add(x.Id,x.Ma,x.IdNhanVienTiepTheo,x.ThoiGianNhanCa,x.ThoiGianGiaoCa,x.TienBatDauCa,x.TongTienKhac,x.TongTienMat,x.TongTienMatCaTruoc,x.TongTienTrongCa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var nv = _inhanvienservice.GetAllNhanVien().FirstOrDefault(x => x.Email == taiKhoan);
            int id11 = _iGiaocaservice.GetAllGiaoca().Count + 1;
            var Giaoca = new GiaoCa()
            {
                Id = id11,
                Ma = "CA00"+ (_iGiaocaservice.GetAllGiaoca().Max(c=>c.Id) + 1),
                ThoiGianNhanCa = DateTime.Now,
                TienBatDauCa = 1000000,
                TrangThai = 0,
              
            };
            _iGiaocaservice.Add(Giaoca);
            showdata();
            //FrmXacNhanGiaoCa frmgiaoca = new FrmXacNhanGiaoCa();
            //frmgiaoca.Show();
            //this.Close();
        }

        private void crudgiaoca_Load(object sender, EventArgs e)
        {

        }
    }
}
