
namespace _3.PL.Views
{
    partial class FrmHoaDonChiTiet
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
            this.dgrid_hoaDonCT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.rbtn_thanhToan = new System.Windows.Forms.RadioButton();
            this.rbtn_chuaThanhToan = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDonCT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid_hoaDonCT
            // 
            this.dgrid_hoaDonCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoaDonCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_hoaDonCT.Location = new System.Drawing.Point(0, 0);
            this.dgrid_hoaDonCT.Name = "dgrid_hoaDonCT";
            this.dgrid_hoaDonCT.RowTemplate.Height = 25;
            this.dgrid_hoaDonCT.Size = new System.Drawing.Size(1020, 269);
            this.dgrid_hoaDonCT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_chuaThanhToan);
            this.panel1.Controls.Add(this.rbtn_thanhToan);
            this.panel1.Controls.Add(this.txt_thanhTien);
            this.panel1.Controls.Add(this.txt_donGia);
            this.panel1.Controls.Add(this.txt_soLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 297);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(121, 25);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(249, 23);
            this.txt_soLuong.TabIndex = 2;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(121, 62);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(249, 23);
            this.txt_donGia.TabIndex = 2;
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Location = new System.Drawing.Point(121, 97);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(249, 23);
            this.txt_thanhTien.TabIndex = 2;
            // 
            // rbtn_thanhToan
            // 
            this.rbtn_thanhToan.AutoSize = true;
            this.rbtn_thanhToan.Location = new System.Drawing.Point(121, 139);
            this.rbtn_thanhToan.Name = "rbtn_thanhToan";
            this.rbtn_thanhToan.Size = new System.Drawing.Size(103, 19);
            this.rbtn_thanhToan.TabIndex = 3;
            this.rbtn_thanhToan.TabStop = true;
            this.rbtn_thanhToan.Text = "Đã thanh toán ";
            this.rbtn_thanhToan.UseVisualStyleBackColor = true;
            // 
            // rbtn_chuaThanhToan
            // 
            this.rbtn_chuaThanhToan.AutoSize = true;
            this.rbtn_chuaThanhToan.Location = new System.Drawing.Point(121, 164);
            this.rbtn_chuaThanhToan.Name = "rbtn_chuaThanhToan";
            this.rbtn_chuaThanhToan.Size = new System.Drawing.Size(114, 19);
            this.rbtn_chuaThanhToan.TabIndex = 3;
            this.rbtn_chuaThanhToan.TabStop = true;
            this.rbtn_chuaThanhToan.Text = "Chưa thanh toán";
            this.rbtn_chuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_them.Location = new System.Drawing.Point(0, 189);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(495, 36);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sua.Location = new System.Drawing.Point(0, 261);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(495, 36);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_xoa.Location = new System.Drawing.Point(0, 225);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(495, 36);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_thanhToan.Location = new System.Drawing.Point(0, 153);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(495, 36);
            this.btn_thanhToan.TabIndex = 3;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_timKiem);
            this.panel2.Controls.Add(this.btn_thanhToan);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.txt_timKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(525, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 297);
            this.panel2.TabIndex = 4;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(50, 25);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(291, 23);
            this.txt_timKiem.TabIndex = 2;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(371, 26);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timKiem.TabIndex = 4;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrid_hoaDonCT);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoaDonCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_hoaDonCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_chuaThanhToan;
        private System.Windows.Forms.RadioButton rbtn_thanhToan;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
    }
}