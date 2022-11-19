namespace _3.PL.Views
{
    partial class FrmNhanVien
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
            this.drgid_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_idChucVu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbx_KhongHoatDong = new System.Windows.Forms.CheckBox();
            this.cbx_HoatDong = new System.Windows.Forms.CheckBox();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_TenDem = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drgid_NhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drgid_NhanVien
            // 
            this.drgid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drgid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgid_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.drgid_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.drgid_NhanVien.Name = "drgid_NhanVien";
            this.drgid_NhanVien.RowHeadersWidth = 51;
            this.drgid_NhanVien.RowTemplate.Height = 29;
            this.drgid_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drgid_NhanVien.Size = new System.Drawing.Size(1314, 188);
            this.drgid_NhanVien.TabIndex = 0;
            this.drgid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgid_NhanVien_CellClick);
            this.drgid_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgid_NhanVien_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_idChucVu);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateTime_NgaySinh);
            this.panel1.Controls.Add(this.cbx_KhongHoatDong);
            this.panel1.Controls.Add(this.cbx_HoatDong);
            this.panel1.Controls.Add(this.rbtn_Nu);
            this.panel1.Controls.Add(this.rbtn_Nam);
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.txt_Sdt);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_Ten);
            this.panel1.Controls.Add(this.txt_TenDem);
            this.panel1.Controls.Add(this.txt_Ho);
            this.panel1.Controls.Add(this.txt_Ma);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 447);
            this.panel1.TabIndex = 1;
            // 
            // cmb_idChucVu
            // 
            this.cmb_idChucVu.FormattingEnabled = true;
            this.cmb_idChucVu.Location = new System.Drawing.Point(246, 340);
            this.cmb_idChucVu.Name = "cmb_idChucVu";
            this.cmb_idChucVu.Size = new System.Drawing.Size(151, 28);
            this.cmb_idChucVu.TabIndex = 25;
            this.cmb_idChucVu.SelectedIndexChanged += new System.EventHandler(this.cmb_idChucVu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = " Chức Vụ";
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(449, 59);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(250, 27);
            this.dateTime_NgaySinh.TabIndex = 23;
            // 
            // cbx_KhongHoatDong
            // 
            this.cbx_KhongHoatDong.AutoSize = true;
            this.cbx_KhongHoatDong.Location = new System.Drawing.Point(477, 325);
            this.cbx_KhongHoatDong.Name = "cbx_KhongHoatDong";
            this.cbx_KhongHoatDong.Size = new System.Drawing.Size(152, 24);
            this.cbx_KhongHoatDong.TabIndex = 22;
            this.cbx_KhongHoatDong.Text = "ĐộngKhông Hoạt ";
            this.cbx_KhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // cbx_HoatDong
            // 
            this.cbx_HoatDong.AutoSize = true;
            this.cbx_HoatDong.Location = new System.Drawing.Point(477, 286);
            this.cbx_HoatDong.Name = "cbx_HoatDong";
            this.cbx_HoatDong.Size = new System.Drawing.Size(105, 24);
            this.cbx_HoatDong.TabIndex = 21;
            this.cbx_HoatDong.Text = "Hoạt Động";
            this.cbx_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(217, 287);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(50, 24);
            this.rbtn_Nu.TabIndex = 20;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(127, 287);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rbtn_Nam.TabIndex = 19;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(493, 228);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(236, 27);
            this.txt_MatKhau.TabIndex = 18;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(490, 172);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(218, 27);
            this.txt_Sdt.TabIndex = 17;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(449, 127);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(259, 27);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(116, 231);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(213, 27);
            this.txt_Ten.TabIndex = 15;
            // 
            // txt_TenDem
            // 
            this.txt_TenDem.Location = new System.Drawing.Point(127, 172);
            this.txt_TenDem.Name = "txt_TenDem";
            this.txt_TenDem.Size = new System.Drawing.Size(192, 27);
            this.txt_TenDem.TabIndex = 14;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(106, 114);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(213, 27);
            this.txt_Ho.TabIndex = 13;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(106, 59);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(213, 27);
            this.txt_Ma.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mật Khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Đệm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 29);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(757, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 362);
            this.panel2.TabIndex = 2;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(91, 261);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(389, 29);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(91, 191);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(389, 29);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(91, 133);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(389, 29);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(91, 68);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(389, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 26);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(757, 229);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 29);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(882, 229);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(355, 27);
            this.txt_TimKiem.TabIndex = 4;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 708);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drgid_NhanVien);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drgid_NhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drgid_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.CheckBox cbx_KhongHoatDong;
        private System.Windows.Forms.CheckBox cbx_HoatDong;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_TenDem;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ComboBox cmb_idChucVu;
        private System.Windows.Forms.Label label11;
    }
}