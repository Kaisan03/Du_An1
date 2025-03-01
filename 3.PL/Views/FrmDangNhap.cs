﻿using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmDangNhap : Form
    {
        public IGiaoCaService _igiaocaservice;
        public INhanVienService _inhanvienservice;
        public FrmDangNhap()
        {
            InitializeComponent();
            _igiaocaservice = new GiaoCaService();
            _inhanvienservice = new NhanVienService();
            FuckYou1();
            this.WindowState = FormWindowState.Maximized;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void FrmTest_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txt_tk.Text = Properties.Settings.Default.UserName;
                txt_mk.Text = Properties.Settings.Default.Password;
            }
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
        }

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            if (cbx_NhoMk.Checked == true)
            {
                Properties.Settings.Default.UserName = txt_tk.Text;
                Properties.Settings.Default.Password = txt_mk.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Save();
            }
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-OF-KHAI\SQLEXPRESS;Initial Catalog=Duan1;Persist Security Info=True;User ID=khainq03;Password=123456");
            try
            {
                conn.Open();
                string taiKhoan = txt_tk.Text;
                string matKhau = txt_mk.Text;
                string sql = "select Email,Matkhau from NhanVien where Email='" + taiKhoan + "' and Matkhau='" + matKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var nv = _inhanvienservice.GetAllNhanVien().FirstOrDefault(x => x.Email == taiKhoan);
                    int id11 = _igiaocaservice.GetAllGiaoca().Count + 1;
                    GiaoCa Giaoca = new GiaoCa()
                    {
                        Id = id11,
                        Ma = "CA00" + (_igiaocaservice.GetAllGiaoca().Count + 1),
                        ThoiGianNhanCa = DateTime.Now,
                        TienBatDauCa = 1000000,
                        TrangThai = 0,
                        IdNhanVienTrongCa = nv.Id,
                    };
                    _igiaocaservice.Add(Giaoca);

                    FrmXacNhanGiaoCa frmgiaoca = new FrmXacNhanGiaoCa(taiKhoan);
                    frmgiaoca.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '*')
            {

                txt_mk.PasswordChar = '\0';
            }
            else txt_mk.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmQuenMatKhau frmquenMk = new FrmQuenMatKhau();
            
            frmquenMk.ShowDialog();
 
        }
        public void FuckYou1()
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = @"Data Source=LAPTOP-46F72MJA\SQLEXPRESS;Initial Catalog=Duan11;Persist Security Info=True;User ID=duyvtph24890;Password=123456";
            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand("select Email FROM NhanVien", connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //SqlDataReader dr = sqlCommand.ExecuteReader();

            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            //while (dr.Read())
            //{
            //    col.Add(dr.GetString(0));
            //}
            //txt_tk.AutoCompleteCustomSource = col;
            //connection.Close();
        }
    }
}
