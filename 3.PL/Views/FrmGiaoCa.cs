﻿using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.PL.Views
{
    public partial class FrmGiaoCa : Form
    {

        public INhanVienService _iNhanVienservice;
        public IHoaDonChiTietService _iHoaDonchitietservice;
        public IHoaDonService _ihoadonservice;
        public IGiaoCaService _iGiaocaService;
        public GiaoCa _idgiaoca;
        decimal tienmat;
        decimal chuyenkhoan;
        FrmDangNhap dangNhap ;
        
        public FrmGiaoCa()
        {
            InitializeComponent();
            _iGiaocaService = new GiaoCaService();
            _ihoadonservice = new HoaDonService();
            _iHoaDonchitietservice = new HoaDonChiTietService();
            _iNhanVienservice = new NhanVienService();
            dangNhap = new FrmDangNhap();
            
            LoadData();
            
        }

        private void LoadData()
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            var nhanvien = _iNhanVienservice.GetAllNhanVien().FirstOrDefault(c=>c.Id == giaoca.IdNhanVienTrongCa);
            var hoadon = _ihoadonservice.GetallHoadon().FirstOrDefault(c => c.IdNhanVien == nhanvien.Id);
            var hoadonchitiet  = _iHoaDonchitietservice.GetAllHoaDonCT().FirstOrDefault(c => c.IdHoaDon == hoadon.Id);
            _idgiaoca = giaoca;
            lb_maca.Text = giaoca.Ma;
            foreach (var z in _ihoadonservice.GetallHoadon().Where(c=>c.IdCa == x))
            {
                lb_tienchuyenkhoan.Text =Convert.ToString(chuyenkhoan += Convert.ToDecimal(z.ChuyenKhoan));
                lb_tienmat.Text = Convert.ToString(tienmat += Convert.ToDecimal(z.TienMat));
            }
            lb_tongdoanhthutrongca.Text = Convert.ToString(tienmat + chuyenkhoan);
            lb_tongtienmat.Text = Convert.ToString(giaoca.TienBatDauCa);
            lb_tongdoanhthu.Text = Convert.ToString(giaoca.TienBatDauCa+ Convert.ToDecimal(chuyenkhoan));
            lb_thoigianbatdau.Text = Convert.ToString(giaoca.ThoiGianNhanCa);
            lb_thoigianketthuc.Text = Convert.ToString(DateTime.Now);
            lb_tienbandau.Text = Convert.ToString(giaoca.TienBatDauCa - tienmat);
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var x = _iGiaocaService.GetAllGiaoca().Max(c => c.Id);
            var giaoca = _iGiaocaService.GetAllGiaoca().FirstOrDefault(c => c.Id == x);
            _idgiaoca = giaoca;
            
            _idgiaoca.TongTienTrongCa = Convert.ToDecimal(lb_tongdoanhthutrongca.Text);
            _idgiaoca.TongTienPhatSinh = Convert.ToDecimal(tbx_tienphatsinh.Text);
            _idgiaoca.GhiChuPhatSinh = tbx_tienphatsinh.Text;
            _idgiaoca.TongTienPhatSinh = Convert.ToDecimal(tbx_tienphatsinh.Text);
            _idgiaoca.TongTienMat = Convert.ToDecimal(lb_tongtienmat.Text) - Convert.ToDecimal(tbx_tienphatsinh.Text);
            _idgiaoca.ThoiGianReset = DateTime.Now;
            if(tbx_tienphatsinh.Text!=null&& tbx_tienphatsinh.Text=="")
            {
                MessageBox.Show("Bạn phải ghi rõ lý do của tiền phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbx_tienphatsinh.Focus();
                return;
            }
            _iGiaocaService.Update(_idgiaoca);
            Application.Exit();

        }
        
        private void btn_ruttien_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmruttien ruttien = new Frmruttien();
            ruttien.ShowDialog();
            LoadData();
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_tienphatsinh_TextChanged(object sender, EventArgs e)
        {
            if(tbx_tienphatsinh.Text=="")
            {
                return;
            }
            if (Convert.ToInt32(tbx_tienphatsinh.Text)> Convert.ToDecimal(lb_tongdoanhthutrongca.Text))
            {
                MessageBox.Show("Tổng tiền trong ca không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbx_tienphatsinh.Text = "";
                return;
            }
            if (Regex.IsMatch(tbx_tienphatsinh.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("Tiền phát sinh không được chứa ký tự đặc biệt", "ERR");
                return;
            }
            if (Regex.IsMatch(tbx_tienphatsinh.Text, @"^\d+$") == false)
            {

                MessageBox.Show("Tiền phát sinh không được chứa ký tự đặc biệt", "ERR");
                return;
            }
            if (tbx_tienphatsinh.Text.Length > 13)
            {
                MessageBox.Show("Tiền phát sinh Không Cho Phép", "ERR");
                return;
            }
            if (Convert.ToInt32(tbx_tienphatsinh.Text) < 0)
            {
                MessageBox.Show("Tiền phát sinh Không Cho Phép Âm", "ERR");
                return;
            }
        }
    }
}
