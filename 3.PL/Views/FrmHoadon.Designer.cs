namespace _3.PL.Views
{
    partial class FrmHoadon
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.dgrid_view = new System.Windows.Forms.DataGridView();
            this.cbx_khachhang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_nhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_tennguoinhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_tensanpham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_giamgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.date_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.date_ngaygiao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtn_hoatdong = new System.Windows.Forms.RadioButton();
            this.rbtn_khonghoatdong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(1227, 443);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(177, 85);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.Location = new System.Drawing.Point(1227, 545);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(177, 85);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.Location = new System.Drawing.Point(1227, 648);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(177, 85);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lammoi.Location = new System.Drawing.Point(1227, 751);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(177, 85);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // dgrid_view
            // 
            this.dgrid_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_view.Location = new System.Drawing.Point(1, 1);
            this.dgrid_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrid_view.Name = "dgrid_view";
            this.dgrid_view.RowHeadersWidth = 51;
            this.dgrid_view.RowTemplate.Height = 25;
            this.dgrid_view.Size = new System.Drawing.Size(1417, 433);
            this.dgrid_view.TabIndex = 4;
            this.dgrid_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_view_CellClick);
            // 
            // cbx_khachhang
            // 
            this.cbx_khachhang.FormattingEnabled = true;
            this.cbx_khachhang.Location = new System.Drawing.Point(101, 461);
            this.cbx_khachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_khachhang.Name = "cbx_khachhang";
            this.cbx_khachhang.Size = new System.Drawing.Size(189, 28);
            this.cbx_khachhang.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách Hàng:";
            // 
            // cbx_nhanvien
            // 
            this.cbx_nhanvien.FormattingEnabled = true;
            this.cbx_nhanvien.Location = new System.Drawing.Point(101, 576);
            this.cbx_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_nhanvien.Name = "cbx_nhanvien";
            this.cbx_nhanvien.Size = new System.Drawing.Size(189, 28);
            this.cbx_nhanvien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 748);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "SDT:";
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(477, 748);
            this.tbx_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(203, 27);
            this.tbx_sdt.TabIndex = 14;
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(477, 675);
            this.tbx_diachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(203, 27);
            this.tbx_diachi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Địa Chỉ:";
            // 
            // tbx_tennguoinhan
            // 
            this.tbx_tennguoinhan.Location = new System.Drawing.Point(477, 601);
            this.tbx_tennguoinhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_tennguoinhan.Name = "tbx_tennguoinhan";
            this.tbx_tennguoinhan.Size = new System.Drawing.Size(203, 27);
            this.tbx_tennguoinhan.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên Người Nhận:";
            // 
            // tbx_tensanpham
            // 
            this.tbx_tensanpham.Location = new System.Drawing.Point(477, 528);
            this.tbx_tensanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_tensanpham.Name = "tbx_tensanpham";
            this.tbx_tensanpham.Size = new System.Drawing.Size(203, 27);
            this.tbx_tensanpham.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên Sản Phẩm:";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(477, 455);
            this.tbx_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(203, 27);
            this.tbx_ma.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã:";
            // 
            // tbx_giamgia
            // 
            this.tbx_giamgia.Location = new System.Drawing.Point(849, 451);
            this.tbx_giamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_giamgia.Name = "tbx_giamgia";
            this.tbx_giamgia.Size = new System.Drawing.Size(317, 27);
            this.tbx_giamgia.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Giảm Giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ngày Tạo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(722, 591);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ngày Thanh Toán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(722, 668);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ngày Giao:";
            // 
            // date_ngaytao
            // 
            this.date_ngaytao.Location = new System.Drawing.Point(849, 528);
            this.date_ngaytao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ngaytao.Name = "date_ngaytao";
            this.date_ngaytao.Size = new System.Drawing.Size(317, 27);
            this.date_ngaytao.TabIndex = 32;
            // 
            // date_ngaythanhtoan
            // 
            this.date_ngaythanhtoan.Location = new System.Drawing.Point(849, 593);
            this.date_ngaythanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ngaythanhtoan.Name = "date_ngaythanhtoan";
            this.date_ngaythanhtoan.Size = new System.Drawing.Size(317, 27);
            this.date_ngaythanhtoan.TabIndex = 33;
            // 
            // date_ngaygiao
            // 
            this.date_ngaygiao.Location = new System.Drawing.Point(849, 664);
            this.date_ngaygiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ngaygiao.Name = "date_ngaygiao";
            this.date_ngaygiao.Size = new System.Drawing.Size(317, 27);
            this.date_ngaygiao.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 725);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Trạng Thái:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(849, 725);
            this.rbtn_hoatdong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Size = new System.Drawing.Size(110, 24);
            this.rbtn_hoatdong.TabIndex = 35;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt động  ";
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(986, 725);
            this.rbtn_khonghoatdong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(146, 24);
            this.rbtn_khonghoatdong.TabIndex = 36;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không hoạt động";
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // FrmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 847);
            this.Controls.Add(this.rbtn_khonghoatdong);
            this.Controls.Add(this.rbtn_hoatdong);
            this.Controls.Add(this.date_ngaygiao);
            this.Controls.Add(this.date_ngaythanhtoan);
            this.Controls.Add(this.date_ngaytao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_giamgia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_tensanpham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_tennguoinhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_diachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_khachhang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_view);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoadon";
            this.Text = "FrmHoadon";
            this.Load += new System.EventHandler(this.FrmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DataGridView dgrid_view;
        private System.Windows.Forms.ComboBox cbx_khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_nhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_sdt;
        private System.Windows.Forms.TextBox tbx_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_tennguoinhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_tensanpham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_giamgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_ngaytao;
        private System.Windows.Forms.DateTimePicker date_ngaythanhtoan;
        private System.Windows.Forms.DateTimePicker date_ngaygiao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtn_hoatdong;
        private System.Windows.Forms.RadioButton rbtn_khonghoatdong;
    }
}