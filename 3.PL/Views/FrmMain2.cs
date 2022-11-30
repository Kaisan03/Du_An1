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
using FontAwesome.Sharp;

namespace _3.PL.Views
{
    public partial class FrmMain2 : Form
    {
        private IconButton _iconbuton;
        private Panel Leftboderbtn;
       
        public FrmMain2()
        {
            InitializeComponent();
            _iconbuton = new IconButton();
            Leftboderbtn = new Panel();
            Leftboderbtn.Size = new Size(10, 63);
            panel_menu.Controls.Add(Leftboderbtn);

            this.WindowState = FormWindowState.Maximized;

            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActiveButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();



                _iconbuton = (IconButton)senderbtn;
                _iconbuton.BackColor = Color.FromArgb(37, 36, 81);
                _iconbuton.ForeColor = color;
                _iconbuton.TextAlign = ContentAlignment.MiddleCenter;
                _iconbuton.IconColor = color;
                _iconbuton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _iconbuton.ImageAlign = ContentAlignment.MiddleCenter;

                Leftboderbtn.BackColor = color;
                Leftboderbtn.Location = new Point(0, _iconbuton.Location.Y);
                Leftboderbtn.Visible = true;
                Leftboderbtn.BringToFront();

                IconChange.IconChar = _iconbuton.IconChar;
                IconChange.IconColor = color;

            }

        }
        private void DisableButton()
        {
            if (_iconbuton != null)
            {
                _iconbuton.BackColor = Color.FromArgb(192, 255, 255);
                //_iconbuton.ForeColor = Color.Gainsboro;
                _iconbuton.TextAlign = ContentAlignment.MiddleLeft;
                //_iconbuton.IconColor = Color.Gainsboro;
                _iconbuton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _iconbuton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private Form currentFormChild;
        private void OpenChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panel_dektop.Controls.Add(formChild);
            panel_dektop.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            lb_change.Text = btn_trangchu.Text;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            lb_change.Text = btn_orders.Text;
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FrmBanHang1());
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            lb_change.Text = btn_sanpham.Text;
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FrmChiTietGiay());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            lb_change.Text = btn_hoadon.Text;
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FrmHoadon());
        }

        private void btn_tuychon_Click(object sender, EventArgs e)
        {
            lb_change.Text = btn_tuychon.Text;
            ActiveButton(sender, RGBColors.color5);
            if (iconButton1.Visible == true )
            {
                iconButton1.Visible = false;
                iconButton2.Visible = false;
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                iconButton5.Visible = false;
                iconButton6.Visible = false;
                iconButton7.Visible = false;
                iconButton8.Visible = false;
                iconButton9.Visible = false;
                iconButton10.Visible = false;
                iconButton11.Visible = false;
            }
            else
            {
                iconButton1.Visible = true;
                iconButton2.Visible = true;
                iconButton3.Visible = true;
                iconButton4.Visible = true;
                iconButton5.Visible = true;
                iconButton6.Visible = true;
                iconButton7.Visible = true;
                iconButton8.Visible = true;
                iconButton9.Visible = true;
                iconButton10.Visible = true;
                iconButton11.Visible = true;
            }
        }

        private void btn_caidat_Click(object sender, EventArgs e)
        {
            lb_change.Text = btn_caidat.Text;
            ActiveButton(sender, RGBColors.color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            Reset();
        }
       
        private void Reset()
        {
            DisableButton();
            Leftboderbtn.Visible = false;
            IconChange.IconChar = IconChar.Home;
            IconChange.IconColor = Color.Gainsboro;
            lb_change.Text = "Home";
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txt_Date.Text = DateTime.Now.ToLongDateString();
            txt_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton1.Text;
            OpenChildForm(new FrmSanPham());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton2.Text;
            OpenChildForm(new FrmAnh());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton3.Text;
            OpenChildForm(new FrmChatLieu());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton4.Text;
            OpenChildForm(new FrmChucVu());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton5.Text;
            OpenChildForm(new FrmDeGiay());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton6.Text;
            OpenChildForm(new FrmKhachHang());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton7.Text;
            OpenChildForm(new FrmKieuDang());
        }
        private void iconButton8_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton8.Text;
            OpenChildForm(new FrmMauSac());
        }
        private void iconButton9_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton9.Text;
            OpenChildForm(new FrmNhanVien());
        }
        private void iconButton10_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton10.Text;
            OpenChildForm(new FrmNhaSanXuat());
        }
        private void iconButton11_Click(object sender, EventArgs e)
        {
            lb_change.Text = iconButton11.Text;
            OpenChildForm(new FrmSize());
        }
        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
            iconButton3.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton4_MouseHover(object sender, EventArgs e)
        {
            iconButton4.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton5_MouseHover(object sender, EventArgs e)
        {
            iconButton5.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton6_MouseHover(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton7_MouseHover(object sender, EventArgs e)
        {
            iconButton7.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton8_MouseHover(object sender, EventArgs e)
        {
            iconButton8.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton9_MouseHover(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton10_MouseHover(object sender, EventArgs e)
        {
            iconButton10.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void iconButton11_MouseHover(object sender, EventArgs e)
        {
            iconButton11.BackColor = Color.FromArgb(255, 255, 192);
        }

        

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.White;
        }
        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.White;
        }
        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.BackColor = Color.White;
        }
        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.BackColor = Color.White;
        }
        private void iconButton5_MouseLeave(object sender, EventArgs e)
        {
            iconButton5.BackColor = Color.White;
        }
        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.White;
        }
        private void iconButton7_MouseLeave(object sender, EventArgs e)
        {
            iconButton7.BackColor = Color.White;
        }
        private void iconButton8_MouseLeave(object sender, EventArgs e)
        {
            iconButton8.BackColor = Color.White;
        }
        private void iconButton9_MouseLeave(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.White;
        }
        private void iconButton10_MouseLeave(object sender, EventArgs e)
        {
            iconButton10.BackColor = Color.White;
        }
        private void iconButton11_MouseLeave(object sender, EventArgs e)
        {
            iconButton11.BackColor = Color.White;
        }
    }
}
