namespace _3.PL.Views
{
    partial class FrmBanHang
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
            this.txt_TienKhachDua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TienThua = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_MahoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_HoaDonCho = new System.Windows.Forms.DataGridView();
            this.dgrid_SanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaHet = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgrid_GioHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TienKhachDua
            // 
            this.txt_TienKhachDua.Location = new System.Drawing.Point(130, 81);
            this.txt_TienKhachDua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TienKhachDua.Name = "txt_TienKhachDua";
            this.txt_TienKhachDua.Size = new System.Drawing.Size(110, 23);
            this.txt_TienKhachDua.TabIndex = 2;
            this.txt_TienKhachDua.TextChanged += new System.EventHandler(this.txt_TienKhachDua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiền thừa:";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(111, 135);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(82, 22);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền khách đưa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền:";
            // 
            // lbl_TienThua
            // 
            this.lbl_TienThua.AutoSize = true;
            this.lbl_TienThua.Location = new System.Drawing.Point(111, 110);
            this.lbl_TienThua.Name = "lbl_TienThua";
            this.lbl_TienThua.Size = new System.Drawing.Size(16, 15);
            this.lbl_TienThua.TabIndex = 0;
            this.lbl_TienThua.Text = "...";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(111, 51);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(16, 15);
            this.lbl_TongTien.TabIndex = 0;
            this.lbl_TongTien.Text = "...";
            // 
            // lbl_MahoaDon
            // 
            this.lbl_MahoaDon.AutoSize = true;
            this.lbl_MahoaDon.Location = new System.Drawing.Point(111, 25);
            this.lbl_MahoaDon.Name = "lbl_MahoaDon";
            this.lbl_MahoaDon.Size = new System.Drawing.Size(16, 15);
            this.lbl_MahoaDon.TabIndex = 0;
            this.lbl_MahoaDon.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_TienKhachDua);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btn_ThanhToan);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbl_TienThua);
            this.groupBox4.Controls.Add(this.lbl_TongTien);
            this.groupBox4.Controls.Add(this.lbl_MahoaDon);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(801, 277);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(290, 161);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh toán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_HoaDonCho);
            this.groupBox3.Location = new System.Drawing.Point(801, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(290, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn chờ";
            // 
            // dgrid_HoaDonCho
            // 
            this.dgrid_HoaDonCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDonCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonCho.Location = new System.Drawing.Point(5, 20);
            this.dgrid_HoaDonCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_HoaDonCho.Name = "dgrid_HoaDonCho";
            this.dgrid_HoaDonCho.RowHeadersWidth = 51;
            this.dgrid_HoaDonCho.RowTemplate.Height = 29;
            this.dgrid_HoaDonCho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_HoaDonCho.Size = new System.Drawing.Size(280, 186);
            this.dgrid_HoaDonCho.TabIndex = 0;
            this.dgrid_HoaDonCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonCho_CellClick);
            // 
            // dgrid_SanPham
            // 
            this.dgrid_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SanPham.Location = new System.Drawing.Point(5, 10);
            this.dgrid_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_SanPham.Name = "dgrid_SanPham";
            this.dgrid_SanPham.RowHeadersWidth = 51;
            this.dgrid_SanPham.RowTemplate.Height = 29;
            this.dgrid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_SanPham.Size = new System.Drawing.Size(728, 141);
            this.dgrid_SanPham.TabIndex = 0;
            this.dgrid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SanPham_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_SanPham);
            this.groupBox2.Location = new System.Drawing.Point(47, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(738, 169);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(388, 188);
            this.btn_TaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(100, 22);
            this.btn_TaoHoaDon.TabIndex = 1;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // btn_XoaHet
            // 
            this.btn_XoaHet.Location = new System.Drawing.Point(267, 188);
            this.btn_XoaHet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaHet.Name = "btn_XoaHet";
            this.btn_XoaHet.Size = new System.Drawing.Size(82, 22);
            this.btn_XoaHet.TabIndex = 1;
            this.btn_XoaHet.Text = "Xóa hết";
            this.btn_XoaHet.UseVisualStyleBackColor = true;
            this.btn_XoaHet.Click += new System.EventHandler(this.btn_XoaHet_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(145, 188);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 22);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgrid_GioHang
            // 
            this.dgrid_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_GioHang.Location = new System.Drawing.Point(5, 20);
            this.dgrid_GioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_GioHang.Name = "dgrid_GioHang";
            this.dgrid_GioHang.RowHeadersWidth = 51;
            this.dgrid_GioHang.RowTemplate.Height = 29;
            this.dgrid_GioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_GioHang.Size = new System.Drawing.Size(718, 159);
            this.dgrid_GioHang.TabIndex = 0;
            this.dgrid_GioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_GioHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoHoaDon);
            this.groupBox1.Controls.Add(this.btn_XoaHet);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.dgrid_GioHang);
            this.groupBox1.Location = new System.Drawing.Point(47, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(738, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 475);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Leave += new System.EventHandler(this.FrmBanHang_Leave);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TienKhachDua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TienThua;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_MahoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_HoaDonCho;
        private System.Windows.Forms.DataGridView dgrid_SanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.Button btn_XoaHet;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgrid_GioHang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}