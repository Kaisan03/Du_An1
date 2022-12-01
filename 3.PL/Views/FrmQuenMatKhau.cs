using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _3.PL.Views
{
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienRepository _iNhanVienRepos;
        string email;
        List<NhanVien> lstNhanVien;
        private string hemail = "duyvtph24890@fpt.edu.vn";
        private string haha = "Gửi mail từ phần mềm bán giày Zen Sports";
        private string hihi;
        private string a;
        private string tk;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _iNhanVienRepos = new NhanVienRepository();
            email = tk;
            lstNhanVien = new List<NhanVien>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var m = _iNhanVienRepos.GetAllNhanVien().Where(c => c.Email == email).Select(c => c.MatKhau).FirstOrDefault();
                if (txt_mxn.Text == m)
                {
                    if (txt_nlmk.Text == txt_mk.Text)
                    {
                        var nv = _iNhanVienRepos.GetAllNhanVien().Where(c => c.Email == txt_email.Text).FirstOrDefault();
                        nv.MatKhau = txt_nlmk.Text;
                        _iNhanVienRepos.GetAllNhanVien();
                        _iNhanVienRepos.Save(nv);
                        MessageBox.Show("Đổi Mật Khẩu Thành công");
                        FrmDangNhap mm = new FrmDangNhap();
                        this.Hide();
                        mm.Show();
                    }
                    else
                    {
                        MessageBox.Show("mật khẩu phải trùng nhau ");
                    }
                }
                else
                {
                    MessageBox.Show("mã xác nhận không chính xác ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex.Message), "Hãy Liên Hệ Với 08pt Để Sửa Lỗi");
            }
        }
        public string ramdomMK()
        {
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            return s;
        }
        public void guiMail(string text)
        {
            MailMessage mess = new MailMessage(hemail, email, haha, hihi);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("duyvtph24890@fpt.edu.vn", "vutuongduy16102003");
            client.Send(mess);
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                var nhanVien = _iNhanVienRepos.GetAllNhanVien().Where(c => c.Email == txt_email.Text).Select(c => c.Email)
                        .FirstOrDefault();
                if (nhanVien == txt_email.Text)
                {
                    email = txt_email.Text;
                    a = ramdomMK();
                    hihi = "mã xác nhận của bạn là: " + a;
                    guiMail(txt_email.Text);
                    MessageBox.Show("gửi mail Thành Công ", "thông báo");
                    var nv = _iNhanVienRepos.GetAllNhanVien().Where(c => c.Email == txt_email.Text).FirstOrDefault();
                    nv.MatKhau = a;
                    _iNhanVienRepos.GetAllNhanVien();
                    _iNhanVienRepos.Save(nv);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex.Message), "Hãy Liên Hệ Với 08pt Để Sửa Lỗi");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_mk.UseSystemPasswordChar = true;
            }
            else
            {
                txt_mk.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txt_nlmk.UseSystemPasswordChar = true;
            }
            else
            {
                txt_nlmk.UseSystemPasswordChar = false;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            string patter = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txt_email.Text, patter))
            {

            }
            else
            {
                MessageBox.Show("Mời bạn nhập lại email, Thông Báo");
                return;
            }
        }
        public bool Check()
        {
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Email không được bỏ trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrEmpty(txt_mxn.Text))
            {
                MessageBox.Show("Mã xác nhận không được bỏ trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrEmpty(txt_mk.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrEmpty(txt_nlmk.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không được bỏ trống", "Thông báo");
                return false;
            }

            //tên
            if (txt_mk.Text.Length <= 3)
            {
                MessageBox.Show("Mật khẩu phải trên 3 ký tự", "ERR");
                return false;
            }

            if (txt_nlmk.Text.Length <= 3)
            {
                MessageBox.Show("Mật khẩu nhập lại phải trên 3 ký tự", "ERR");
                return false;
            }
            return true;
        }
    }
}
