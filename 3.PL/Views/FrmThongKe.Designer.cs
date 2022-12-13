namespace _3.PL.Views
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SoHDDangGiao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SoHDTaiQuay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DoanhThuHomNay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrid_ThongKe = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_LocNam = new System.Windows.Forms.ComboBox();
            this.cmb_LocThang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_LocTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.date_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.date_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThongKe)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1414, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu trong ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.lbl_SoHDDangGiao);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_SoHDTaiQuay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(560, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 199);
            this.panel2.TabIndex = 1;
            // 
            // lbl_SoHDDangGiao
            // 
            this.lbl_SoHDDangGiao.AutoSize = true;
            this.lbl_SoHDDangGiao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SoHDDangGiao.Location = new System.Drawing.Point(460, 114);
            this.lbl_SoHDDangGiao.Name = "lbl_SoHDDangGiao";
            this.lbl_SoHDDangGiao.Size = new System.Drawing.Size(22, 21);
            this.lbl_SoHDDangGiao.TabIndex = 2;
            this.lbl_SoHDDangGiao.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(240, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số hóa đơn đang giao:";
            // 
            // lbl_SoHDTaiQuay
            // 
            this.lbl_SoHDTaiQuay.AutoSize = true;
            this.lbl_SoHDTaiQuay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SoHDTaiQuay.Location = new System.Drawing.Point(460, 63);
            this.lbl_SoHDTaiQuay.Name = "lbl_SoHDTaiQuay";
            this.lbl_SoHDTaiQuay.Size = new System.Drawing.Size(22, 21);
            this.lbl_SoHDTaiQuay.TabIndex = 1;
            this.lbl_SoHDTaiQuay.Text = "...";
            this.lbl_SoHDTaiQuay.TextChanged += new System.EventHandler(this.lbl_SoHDTaiQuay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số hóa đơn tại quầy:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::_3.PL.Properties.Resources.icons8_bills_66;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(99, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 73);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_DoanhThuHomNay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 199);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(360, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "VND";
            // 
            // lbl_DoanhThuHomNay
            // 
            this.lbl_DoanhThuHomNay.AutoSize = true;
            this.lbl_DoanhThuHomNay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DoanhThuHomNay.Location = new System.Drawing.Point(231, 122);
            this.lbl_DoanhThuHomNay.Name = "lbl_DoanhThuHomNay";
            this.lbl_DoanhThuHomNay.Size = new System.Drawing.Size(22, 21);
            this.lbl_DoanhThuHomNay.TabIndex = 2;
            this.lbl_DoanhThuHomNay.Text = "...";
            this.lbl_DoanhThuHomNay.TextChanged += new System.EventHandler(this.lbl_DoanhThuHomNay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng doanh thu hôm nay";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_3.PL.Properties.Resources.icons8_expensive_price_80;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(80, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrid_ThongKe);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1414, 527);
            this.panel3.TabIndex = 1;
            // 
            // dgrid_ThongKe
            // 
            this.dgrid_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_ThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrid_ThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_ThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_ThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_ThongKe.EnableHeadersVisualStyles = false;
            this.dgrid_ThongKe.GridColor = System.Drawing.Color.LightGray;
            this.dgrid_ThongKe.Location = new System.Drawing.Point(0, 74);
            this.dgrid_ThongKe.Name = "dgrid_ThongKe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_ThongKe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_ThongKe.RowHeadersVisible = false;
            this.dgrid_ThongKe.RowTemplate.Height = 25;
            this.dgrid_ThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ThongKe.Size = new System.Drawing.Size(1414, 453);
            this.dgrid_ThongKe.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmb_LocNam);
            this.panel4.Controls.Add(this.cmb_LocThang);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.date_LocTheoNgay);
            this.panel4.Controls.Add(this.btn_TimKiem);
            this.panel4.Controls.Add(this.date_NgayKT);
            this.panel4.Controls.Add(this.date_NgayBD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1414, 74);
            this.panel4.TabIndex = 0;
            // 
            // cmb_LocNam
            // 
            this.cmb_LocNam.FormattingEnabled = true;
            this.cmb_LocNam.Location = new System.Drawing.Point(695, 32);
            this.cmb_LocNam.Name = "cmb_LocNam";
            this.cmb_LocNam.Size = new System.Drawing.Size(121, 23);
            this.cmb_LocNam.TabIndex = 5;
            this.cmb_LocNam.SelectedValueChanged += new System.EventHandler(this.cmb_LocNam_SelectedValueChanged);
            // 
            // cmb_LocThang
            // 
            this.cmb_LocThang.FormattingEnabled = true;
            this.cmb_LocThang.Location = new System.Drawing.Point(419, 31);
            this.cmb_LocThang.Name = "cmb_LocThang";
            this.cmb_LocThang.Size = new System.Drawing.Size(121, 23);
            this.cmb_LocThang.TabIndex = 5;
            this.cmb_LocThang.SelectedIndexChanged += new System.EventHandler(this.cmb_LocThang_SelectedIndexChanged);
            this.cmb_LocThang.SelectedValueChanged += new System.EventHandler(this.cmb_LocThang_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(603, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Theo năm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Theo tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Theo ngày:";
            // 
            // date_LocTheoNgay
            // 
            this.date_LocTheoNgay.Location = new System.Drawing.Point(105, 31);
            this.date_LocTheoNgay.Name = "date_LocTheoNgay";
            this.date_LocTheoNgay.Size = new System.Drawing.Size(151, 23);
            this.date_LocTheoNgay.TabIndex = 3;
            this.date_LocTheoNgay.ValueChanged += new System.EventHandler(this.date_LocTheoNgay_ValueChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::_3.PL.Properties.Resources.icons8_search_64;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Location = new System.Drawing.Point(1313, 6);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(78, 62);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // date_NgayKT
            // 
            this.date_NgayKT.Location = new System.Drawing.Point(965, 45);
            this.date_NgayKT.Name = "date_NgayKT";
            this.date_NgayKT.Size = new System.Drawing.Size(342, 23);
            this.date_NgayKT.TabIndex = 0;
            // 
            // date_NgayBD
            // 
            this.date_NgayBD.Location = new System.Drawing.Point(965, 6);
            this.date_NgayBD.Name = "date_NgayBD";
            this.date_NgayBD.Size = new System.Drawing.Size(342, 23);
            this.date_NgayBD.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 745);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThongKe)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DoanhThuHomNay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_SoHDDangGiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SoHDTaiQuay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrid_ThongKe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DateTimePicker date_NgayKT;
        private System.Windows.Forms.DateTimePicker date_NgayBD;
        private System.Windows.Forms.DateTimePicker date_LocTheoNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_LocNam;
        private System.Windows.Forms.ComboBox cmb_LocThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}