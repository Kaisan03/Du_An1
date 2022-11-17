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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenFormChild(Form formChild)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panel_main.Controls.Add(formChild);
            panel_main.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }   

        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_muaH_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmBanHang());
            lbl_home.Text = btn_muaH.Text;
        }

        private void btn_MuaHang_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
