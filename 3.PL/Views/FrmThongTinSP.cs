﻿using _1.DAL.DomainClass;
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
    public partial class FrmThongTinSP : Form
    {
        private string tenhh = "";
        private string size = "";
        private string chatlieu = "";
        private string mausac = "";
        private string kieudang = "";
        private string degiay = "";
        private string giaban = "";
        private string anh = "";
        //
        private ChiTietGiayService _ctGiayService;
        private SanPhamService _sanPhamService;
        private SizeService _sizeService;
        private ChatLieuService _chatLieuService;
        private MauSacService _mausacService;
        private KieuDangService _kieuDangService;
        private DeGiayService _degiayService;
        private AnhService _anhService;
        public FrmThongTinSP(string tenhh, string size, string chatlieu, string mausac, string kieudang, string degiay, string giaban, string anh, ChiTietGiayService ctGiayService, SanPhamService sanPhamService, SizeService sizeService, ChatLieuService chatLieuService, MauSacService mausacService, KieuDangService kieuDangService, DeGiayService degiayService, AnhService anhService, IContainer components, Panel panel1, Panel panel2, Label label7, Label label6, Label label5, Label label4, Label label3, Label label2, Label lbl_Ten, PictureBox pic_Image)
        {
            InitializeComponent();
            this.tenhh = tenhh;
            this.size = size;
            this.chatlieu = chatlieu;
            this.mausac = mausac;
            this.kieudang = kieudang;
            this.degiay = degiay;
            this.giaban = giaban;
            this.anh = anh;
            lbl_TenSp.Text = tenhh;
            lbl_Size.Text = size;
            lbl_ChatLieu.Text = chatlieu;
            lbl_MauSac.Text = mausac;
            lbl_KieuDang.Text = kieudang;
            lbl_LoaiDe.Text = degiay;
            lbl_GiaBan.Text = giaban;
            lbl_Anh.Text = anh;
            Image img = Image.FromFile(lbl_Anh.Text);
            pic_Image.Image = img;
            _ctGiayService = ctGiayService;
            _sanPhamService = sanPhamService;
            _sizeService = sizeService;
            _chatLieuService = chatLieuService;
            _mausacService = mausacService;
            _kieuDangService = kieuDangService;
            _degiayService = degiayService;
            _anhService = anhService;
        }
    }
}