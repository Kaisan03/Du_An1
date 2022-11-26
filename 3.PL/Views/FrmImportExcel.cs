using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmImportExcel : Form
    {
        public FrmImportExcel()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecl file";
            openFileDialog.FileName = txt_TimKiem.Text;
            openFileDialog.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_TimKiem.Text = openFileDialog.FileName;
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + txt_TimKiem.Text + "';Extended Properties=Excel 12.0 Xml;");
            oleDbConnection.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", oleDbConnection);
            DataSet theSd = new DataSet();
            DataTable dt = new DataTable();
            oleDbDataAdapter.Fill(dt);
            this.dgrid_AddExcel.DataSource = dt.DefaultView;
        }
    }
}
