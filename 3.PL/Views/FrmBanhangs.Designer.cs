namespace _3.PL.Views
{
    partial class FrmBanhangs
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
            this.gr_chonsanpham = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_chitietgiay = new System.Windows.Forms.DataGridView();
            this.dgrid_giaydachon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TienKhachDua = new System.Windows.Forms.TextBox();
            this.btn_taohoadon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TienThua = new System.Windows.Forms.Label();
            this.dgrid_hoadondatao = new System.Windows.Forms.DataGridView();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_MahoaDon = new System.Windows.Forms.Label();
            this.gr_chonsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_chitietgiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giaydachon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadondatao)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_chonsanpham
            // 
            this.gr_chonsanpham.Controls.Add(this.label1);
            this.gr_chonsanpham.Controls.Add(this.dgrid_chitietgiay);
            this.gr_chonsanpham.Controls.Add(this.dgrid_giaydachon);
            this.gr_chonsanpham.Location = new System.Drawing.Point(0, 2);
            this.gr_chonsanpham.Name = "gr_chonsanpham";
            this.gr_chonsanpham.Size = new System.Drawing.Size(796, 650);
            this.gr_chonsanpham.TabIndex = 0;
            this.gr_chonsanpham.TabStop = false;
            this.gr_chonsanpham.Text = "Chọn sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sản Phẩm";
            // 
            // dgrid_chitietgiay
            // 
            this.dgrid_chitietgiay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_chitietgiay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_chitietgiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_chitietgiay.Location = new System.Drawing.Point(6, 245);
            this.dgrid_chitietgiay.Name = "dgrid_chitietgiay";
            this.dgrid_chitietgiay.RowTemplate.Height = 25;
            this.dgrid_chitietgiay.Size = new System.Drawing.Size(784, 399);
            this.dgrid_chitietgiay.TabIndex = 1;
            this.dgrid_chitietgiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_chitietgiay_CellClick);
            // 
            // dgrid_giaydachon
            // 
            this.dgrid_giaydachon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_giaydachon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_giaydachon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_giaydachon.Location = new System.Drawing.Point(6, 22);
            this.dgrid_giaydachon.Name = "dgrid_giaydachon";
            this.dgrid_giaydachon.RowTemplate.Height = 25;
            this.dgrid_giaydachon.Size = new System.Drawing.Size(784, 180);
            this.dgrid_giaydachon.TabIndex = 0;
            this.dgrid_giaydachon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_giaydachon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TienKhachDua);
            this.groupBox1.Controls.Add(this.btn_taohoadon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_TienThua);
            this.groupBox1.Controls.Add(this.dgrid_hoadondatao);
            this.groupBox1.Controls.Add(this.lbl_TongTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_MahoaDon);
            this.groupBox1.Location = new System.Drawing.Point(802, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 650);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // txt_TienKhachDua
            // 
            this.txt_TienKhachDua.Location = new System.Drawing.Point(110, 474);
            this.txt_TienKhachDua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TienKhachDua.Name = "txt_TienKhachDua";
            this.txt_TienKhachDua.Size = new System.Drawing.Size(110, 23);
            this.txt_TienKhachDua.TabIndex = 10;
            // 
            // btn_taohoadon
            // 
            this.btn_taohoadon.Location = new System.Drawing.Point(5, 621);
            this.btn_taohoadon.Name = "btn_taohoadon";
            this.btn_taohoadon.Size = new System.Drawing.Size(128, 23);
            this.btn_taohoadon.TabIndex = 3;
            this.btn_taohoadon.Text = "Tạo hóa đơn";
            this.btn_taohoadon.UseVisualStyleBackColor = true;
            this.btn_taohoadon.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền thừa:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(157, 621);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(83, 23);
            this.btn_thanhtoan.TabIndex = 2;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền khách đưa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng tiền:";
            // 
            // lbl_TienThua
            // 
            this.lbl_TienThua.AutoSize = true;
            this.lbl_TienThua.Location = new System.Drawing.Point(110, 503);
            this.lbl_TienThua.Name = "lbl_TienThua";
            this.lbl_TienThua.Size = new System.Drawing.Size(16, 15);
            this.lbl_TienThua.TabIndex = 6;
            this.lbl_TienThua.Text = "...";
            // 
            // dgrid_hoadondatao
            // 
            this.dgrid_hoadondatao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_hoadondatao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_hoadondatao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadondatao.Location = new System.Drawing.Point(6, 22);
            this.dgrid_hoadondatao.Name = "dgrid_hoadondatao";
            this.dgrid_hoadondatao.RowTemplate.Height = 25;
            this.dgrid_hoadondatao.Size = new System.Drawing.Size(596, 373);
            this.dgrid_hoadondatao.TabIndex = 0;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(110, 444);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(16, 15);
            this.lbl_TongTien.TabIndex = 7;
            this.lbl_TongTien.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // lbl_MahoaDon
            // 
            this.lbl_MahoaDon.AutoSize = true;
            this.lbl_MahoaDon.Location = new System.Drawing.Point(110, 418);
            this.lbl_MahoaDon.Name = "lbl_MahoaDon";
            this.lbl_MahoaDon.Size = new System.Drawing.Size(16, 15);
            this.lbl_MahoaDon.TabIndex = 8;
            this.lbl_MahoaDon.Text = "...";
            // 
            // FrmBanhangs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gr_chonsanpham);
            this.Name = "FrmBanhangs";
            this.Text = "FrmBanhangs";
            this.gr_chonsanpham.ResumeLayout(false);
            this.gr_chonsanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_chitietgiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giaydachon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadondatao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_chonsanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_chitietgiay;
        private System.Windows.Forms.DataGridView dgrid_giaydachon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_taohoadon;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.DataGridView dgrid_hoadondatao;
        private System.Windows.Forms.TextBox txt_TienKhachDua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TienThua;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_MahoaDon;
    }
}