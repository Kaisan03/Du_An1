namespace _3.PL.Views
{
    partial class FrmAnh
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_duongDan = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.cbx_KhongHD = new System.Windows.Forms.CheckBox();
            this.cbx_HoatDong = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_Images = new System.Windows.Forms.PictureBox();
            this.btn_fileName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_Anh = new System.Windows.Forms.DataGridView();
            this.txt_DuongDan1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Anh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Location = new System.Drawing.Point(626, 529);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(416, 28);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Location = new System.Drawing.Point(626, 462);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(416, 28);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_duongDan
            // 
            this.txt_duongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_duongDan.Location = new System.Drawing.Point(107, 493);
            this.txt_duongDan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_duongDan.Name = "txt_duongDan";
            this.txt_duongDan.Size = new System.Drawing.Size(252, 23);
            this.txt_duongDan.TabIndex = 3;
            this.txt_duongDan.TextChanged += new System.EventHandler(this.txt_duongDan_TextChanged);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Ten.Location = new System.Drawing.Point(107, 460);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(252, 23);
            this.txt_Ten.TabIndex = 3;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Ma.Location = new System.Drawing.Point(107, 428);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(252, 23);
            this.txt_Ma.TabIndex = 3;
            // 
            // cbx_KhongHD
            // 
            this.cbx_KhongHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_KhongHD.AutoSize = true;
            this.cbx_KhongHD.Location = new System.Drawing.Point(107, 560);
            this.cbx_KhongHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_KhongHD.Name = "cbx_KhongHD";
            this.cbx_KhongHD.Size = new System.Drawing.Size(119, 19);
            this.cbx_KhongHD.TabIndex = 2;
            this.cbx_KhongHD.Text = "Không hoạt động";
            this.cbx_KhongHD.UseVisualStyleBackColor = true;
            this.cbx_KhongHD.CheckedChanged += new System.EventHandler(this.cbx_KhongHD_CheckedChanged);
            // 
            // cbx_HoatDong
            // 
            this.cbx_HoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_HoatDong.AutoSize = true;
            this.cbx_HoatDong.Location = new System.Drawing.Point(107, 537);
            this.cbx_HoatDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_HoatDong.Name = "cbx_HoatDong";
            this.cbx_HoatDong.Size = new System.Drawing.Size(83, 19);
            this.cbx_HoatDong.TabIndex = 2;
            this.cbx_HoatDong.Text = "Hoạt động";
            this.cbx_HoatDong.UseVisualStyleBackColor = true;
            this.cbx_HoatDong.CheckedChanged += new System.EventHandler(this.cbx_HoatDong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(626, 562);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(416, 28);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Red;
            this.btn_TimKiem.Location = new System.Drawing.Point(960, 436);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(82, 22);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.Location = new System.Drawing.Point(626, 433);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(320, 23);
            this.txt_TimKiem.TabIndex = 11;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Location = new System.Drawing.Point(626, 496);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(416, 28);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đường dẫn:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // pic_Images
            // 
            this.pic_Images.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_Images.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Images.Location = new System.Drawing.Point(314, 518);
            this.pic_Images.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Images.Name = "pic_Images";
            this.pic_Images.Size = new System.Drawing.Size(131, 72);
            this.pic_Images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Images.TabIndex = 5;
            this.pic_Images.TabStop = false;
            this.pic_Images.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_Images_DragDrop);
            this.pic_Images.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_Images_DragEnter);
            // 
            // btn_fileName
            // 
            this.btn_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_fileName.Location = new System.Drawing.Point(369, 493);
            this.btn_fileName.Name = "btn_fileName";
            this.btn_fileName.Size = new System.Drawing.Size(76, 23);
            this.btn_fileName.TabIndex = 4;
            this.btn_fileName.Text = "Chọn file";
            this.btn_fileName.UseVisualStyleBackColor = true;
            this.btn_fileName.Click += new System.EventHandler(this.btn_fileName_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // dgrid_Anh
            // 
            this.dgrid_Anh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_Anh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Anh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Anh.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_Anh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Anh.Location = new System.Drawing.Point(0, 0);
            this.dgrid_Anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_Anh.Name = "dgrid_Anh";
            this.dgrid_Anh.RowHeadersVisible = false;
            this.dgrid_Anh.RowHeadersWidth = 51;
            this.dgrid_Anh.RowTemplate.Height = 29;
            this.dgrid_Anh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Anh.Size = new System.Drawing.Size(1045, 397);
            this.dgrid_Anh.TabIndex = 10;
            this.dgrid_Anh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Anh_CellClick);
            // 
            // txt_DuongDan1
            // 
            this.txt_DuongDan1.AllowDrop = true;
            this.txt_DuongDan1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_DuongDan1.Location = new System.Drawing.Point(107, 401);
            this.txt_DuongDan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DuongDan1.Name = "txt_DuongDan1";
            this.txt_DuongDan1.Size = new System.Drawing.Size(338, 23);
            this.txt_DuongDan1.TabIndex = 15;
            this.txt_DuongDan1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_DuongDan1_DragDrop);
            this.txt_DuongDan1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DuongDan1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic_Images);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.txt_DuongDan1);
            this.panel1.Controls.Add(this.btn_fileName);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.txt_duongDan);
            this.panel1.Controls.Add(this.dgrid_Anh);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txt_Ten);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.txt_Ma);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.cbx_KhongHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_HoatDong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 597);
            this.panel1.TabIndex = 16;
            // 
            // FrmAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 597);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnh";
            this.Load += new System.EventHandler(this.FrmAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Anh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_duongDan;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.CheckBox cbx_KhongHD;
        private System.Windows.Forms.CheckBox cbx_HoatDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_Anh;
        private System.Windows.Forms.Button btn_fileName;
        private System.Windows.Forms.PictureBox pic_Images;
        private System.Windows.Forms.TextBox txt_DuongDan1;
        private System.Windows.Forms.Panel panel1;
    }
}