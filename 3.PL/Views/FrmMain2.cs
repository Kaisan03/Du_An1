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
        private Form _childform;
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
                _iconbuton.BackColor = Color.FromArgb(31, 32, 71);
                _iconbuton.ForeColor = Color.Gainsboro;
                _iconbuton.TextAlign = ContentAlignment.MiddleLeft;
                _iconbuton.IconColor = Color.Gainsboro;
                _iconbuton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _iconbuton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenChildForm(Form childform)
        {
            if (_childform != null)
            {
                _childform.Close();
            }
            _childform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_dektop.Controls.Add(childform);
            panel_dektop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lb_change.Text = childform.Text;
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FrmHoadon());
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
        }

        private void btn_tuychon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void btn_caidat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _childform.Close();
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
    }
}
