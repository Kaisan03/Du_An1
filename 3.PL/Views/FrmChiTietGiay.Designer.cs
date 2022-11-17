namespace _3.PL.Views
{
    partial class FrmChiTietGiay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrid_ChiTietGiay = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_khongHD = new System.Windows.Forms.CheckBox();
            this.cbx_HoatDong = new System.Windows.Forms.CheckBox();
            this.cmb_SanPham = new System.Windows.Forms.ComboBox();
            this.cmb_ChatLieu = new System.Windows.Forms.ComboBox();
            this.txt_NgayBan = new System.Windows.Forms.TextBox();
            this.txt_NgayNhap = new System.Windows.Forms.TextBox();
            this.txt_moTa = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_Anh = new System.Windows.Forms.TextBox();
            this.txt_SoLuongTon = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.cmb_KieuDang = new System.Windows.Forms.ComboBox();
            this.cmb_LoaiDe = new System.Windows.Forms.ComboBox();
            this.cmb_MauSac = new System.Windows.Forms.ComboBox();
            this.cmb_Nsx = new System.Windows.Forms.ComboBox();
            this.cmb_TenSize = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietGiay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid_ChiTietGiay
            // 
            this.dgrid_ChiTietGiay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietGiay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_ChiTietGiay.Location = new System.Drawing.Point(0, 0);
            this.dgrid_ChiTietGiay.Name = "dgrid_ChiTietGiay";
            this.dgrid_ChiTietGiay.RowHeadersWidth = 51;
            this.dgrid_ChiTietGiay.RowTemplate.Height = 29;
            this.dgrid_ChiTietGiay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ChiTietGiay.Size = new System.Drawing.Size(1474, 295);
            this.dgrid_ChiTietGiay.TabIndex = 0;
            this.dgrid_ChiTietGiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChiTietGiay_CellClick);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(47, 43);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(285, 27);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(338, 41);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 29);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_khongHD);
            this.groupBox1.Controls.Add(this.cbx_HoatDong);
            this.groupBox1.Controls.Add(this.cmb_SanPham);
            this.groupBox1.Controls.Add(this.cmb_ChatLieu);
            this.groupBox1.Controls.Add(this.txt_NgayBan);
            this.groupBox1.Controls.Add(this.txt_NgayNhap);
            this.groupBox1.Controls.Add(this.txt_moTa);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.txt_Anh);
            this.groupBox1.Controls.Add(this.txt_SoLuongTon);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.cmb_KieuDang);
            this.groupBox1.Controls.Add(this.cmb_LoaiDe);
            this.groupBox1.Controls.Add(this.cmb_MauSac);
            this.groupBox1.Controls.Add(this.cmb_Nsx);
            this.groupBox1.Controls.Add(this.cmb_TenSize);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 447);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbx_khongHD
            // 
            this.cbx_khongHD.AutoSize = true;
            this.cbx_khongHD.Location = new System.Drawing.Point(548, 296);
            this.cbx_khongHD.Name = "cbx_khongHD";
            this.cbx_khongHD.Size = new System.Drawing.Size(147, 24);
            this.cbx_khongHD.TabIndex = 2;
            this.cbx_khongHD.Text = "Không hoạt động";
            this.cbx_khongHD.UseVisualStyleBackColor = true;
            this.cbx_khongHD.CheckedChanged += new System.EventHandler(this.cbx_khongHD_CheckedChanged);
            // 
            // cbx_HoatDong
            // 
            this.cbx_HoatDong.AutoSize = true;
            this.cbx_HoatDong.Location = new System.Drawing.Point(548, 263);
            this.cbx_HoatDong.Name = "cbx_HoatDong";
            this.cbx_HoatDong.Size = new System.Drawing.Size(106, 24);
            this.cbx_HoatDong.TabIndex = 2;
            this.cbx_HoatDong.Text = "Hoạt động:";
            this.cbx_HoatDong.UseVisualStyleBackColor = true;
            this.cbx_HoatDong.CheckedChanged += new System.EventHandler(this.cbx_HoatDong_CheckedChanged);
            // 
            // cmb_SanPham
            // 
            this.cmb_SanPham.FormattingEnabled = true;
            this.cmb_SanPham.Location = new System.Drawing.Point(144, 255);
            this.cmb_SanPham.Name = "cmb_SanPham";
            this.cmb_SanPham.Size = new System.Drawing.Size(240, 28);
            this.cmb_SanPham.TabIndex = 1;
            // 
            // cmb_ChatLieu
            // 
            this.cmb_ChatLieu.FormattingEnabled = true;
            this.cmb_ChatLieu.Location = new System.Drawing.Point(144, 221);
            this.cmb_ChatLieu.Name = "cmb_ChatLieu";
            this.cmb_ChatLieu.Size = new System.Drawing.Size(240, 28);
            this.cmb_ChatLieu.TabIndex = 1;
            // 
            // txt_NgayBan
            // 
            this.txt_NgayBan.Location = new System.Drawing.Point(144, 322);
            this.txt_NgayBan.Name = "txt_NgayBan";
            this.txt_NgayBan.Size = new System.Drawing.Size(240, 27);
            this.txt_NgayBan.TabIndex = 1;
            // 
            // txt_NgayNhap
            // 
            this.txt_NgayNhap.Location = new System.Drawing.Point(144, 289);
            this.txt_NgayNhap.Name = "txt_NgayNhap";
            this.txt_NgayNhap.Size = new System.Drawing.Size(240, 27);
            this.txt_NgayNhap.TabIndex = 1;
            // 
            // txt_moTa
            // 
            this.txt_moTa.Location = new System.Drawing.Point(548, 214);
            this.txt_moTa.Name = "txt_moTa";
            this.txt_moTa.Size = new System.Drawing.Size(282, 27);
            this.txt_moTa.TabIndex = 1;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(548, 171);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(282, 27);
            this.txt_SoLuong.TabIndex = 1;
            // 
            // txt_Anh
            // 
            this.txt_Anh.Location = new System.Drawing.Point(548, 136);
            this.txt_Anh.Name = "txt_Anh";
            this.txt_Anh.Size = new System.Drawing.Size(282, 27);
            this.txt_Anh.TabIndex = 1;
            // 
            // txt_SoLuongTon
            // 
            this.txt_SoLuongTon.Location = new System.Drawing.Point(548, 96);
            this.txt_SoLuongTon.Name = "txt_SoLuongTon";
            this.txt_SoLuongTon.Size = new System.Drawing.Size(282, 27);
            this.txt_SoLuongTon.TabIndex = 1;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(548, 55);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(282, 27);
            this.txt_Ma.TabIndex = 1;
            // 
            // cmb_KieuDang
            // 
            this.cmb_KieuDang.FormattingEnabled = true;
            this.cmb_KieuDang.Location = new System.Drawing.Point(144, 187);
            this.cmb_KieuDang.Name = "cmb_KieuDang";
            this.cmb_KieuDang.Size = new System.Drawing.Size(240, 28);
            this.cmb_KieuDang.TabIndex = 1;
            // 
            // cmb_LoaiDe
            // 
            this.cmb_LoaiDe.FormattingEnabled = true;
            this.cmb_LoaiDe.Location = new System.Drawing.Point(144, 150);
            this.cmb_LoaiDe.Name = "cmb_LoaiDe";
            this.cmb_LoaiDe.Size = new System.Drawing.Size(240, 28);
            this.cmb_LoaiDe.TabIndex = 1;
            // 
            // cmb_MauSac
            // 
            this.cmb_MauSac.FormattingEnabled = true;
            this.cmb_MauSac.Location = new System.Drawing.Point(144, 118);
            this.cmb_MauSac.Name = "cmb_MauSac";
            this.cmb_MauSac.Size = new System.Drawing.Size(240, 28);
            this.cmb_MauSac.TabIndex = 1;
            // 
            // cmb_Nsx
            // 
            this.cmb_Nsx.FormattingEnabled = true;
            this.cmb_Nsx.Location = new System.Drawing.Point(144, 84);
            this.cmb_Nsx.Name = "cmb_Nsx";
            this.cmb_Nsx.Size = new System.Drawing.Size(240, 28);
            this.cmb_Nsx.TabIndex = 1;
            // 
            // cmb_TenSize
            // 
            this.cmb_TenSize.FormattingEnabled = true;
            this.cmb_TenSize.Location = new System.Drawing.Point(144, 50);
            this.cmb_TenSize.Name = "cmb_TenSize";
            this.cmb_TenSize.Size = new System.Drawing.Size(240, 28);
            this.cmb_TenSize.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mô tả:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số lượng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ảnh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng tồn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chất liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kiểu dáng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại đế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Màu sắc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà sản xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1006, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 447);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(47, 307);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(385, 57);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(47, 240);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(385, 57);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(47, 169);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(385, 57);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(47, 99);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(385, 57);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmChiTietGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 742);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrid_ChiTietGiay);
            this.Name = "FrmChiTietGiay";
            this.Text = "FrmChiTietGiay";
            this.Load += new System.EventHandler(this.FrmChiTietGiay_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietGiay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_ChiTietGiay;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_khongHD;
        private System.Windows.Forms.CheckBox cbx_HoatDong;
        private System.Windows.Forms.ComboBox cmb_SanPham;
        private System.Windows.Forms.ComboBox cmb_ChatLieu;
        private System.Windows.Forms.TextBox txt_NgayBan;
        private System.Windows.Forms.TextBox txt_NgayNhap;
        private System.Windows.Forms.TextBox txt_moTa;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_Anh;
        private System.Windows.Forms.TextBox txt_SoLuongTon;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.ComboBox cmb_KieuDang;
        private System.Windows.Forms.ComboBox cmb_LoaiDe;
        private System.Windows.Forms.ComboBox cmb_MauSac;
        private System.Windows.Forms.ComboBox cmb_Nsx;
        private System.Windows.Forms.ComboBox cmb_TenSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
    }
}