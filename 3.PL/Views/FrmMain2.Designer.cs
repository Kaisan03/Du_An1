namespace _3.PL.Views
{
    partial class FrmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain2));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_caidat = new FontAwesome.Sharp.IconButton();
            this.btn_tuychon = new FontAwesome.Sharp.IconButton();
            this.btn_hoadon = new FontAwesome.Sharp.IconButton();
            this.btn_sanpham = new FontAwesome.Sharp.IconButton();
            this.btn_orders = new FontAwesome.Sharp.IconButton();
            this.btn_trangchu = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_change = new System.Windows.Forms.Label();
            this.IconChange = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_dektop = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconChange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panel_menu.Controls.Add(this.btn_caidat);
            this.panel_menu.Controls.Add(this.btn_tuychon);
            this.panel_menu.Controls.Add(this.btn_hoadon);
            this.panel_menu.Controls.Add(this.btn_sanpham);
            this.panel_menu.Controls.Add(this.btn_orders);
            this.panel_menu.Controls.Add(this.btn_trangchu);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(281, 670);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_caidat
            // 
            this.btn_caidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_caidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caidat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_caidat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_caidat.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btn_caidat.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_caidat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_caidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caidat.Location = new System.Drawing.Point(0, 379);
            this.btn_caidat.Name = "btn_caidat";
            this.btn_caidat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_caidat.Size = new System.Drawing.Size(281, 49);
            this.btn_caidat.TabIndex = 7;
            this.btn_caidat.Text = "Cài Đặt";
            this.btn_caidat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caidat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_caidat.UseVisualStyleBackColor = true;
            this.btn_caidat.Click += new System.EventHandler(this.btn_caidat_Click);
            // 
            // btn_tuychon
            // 
            this.btn_tuychon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tuychon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tuychon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tuychon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_tuychon.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btn_tuychon.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_tuychon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tuychon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tuychon.Location = new System.Drawing.Point(0, 330);
            this.btn_tuychon.Name = "btn_tuychon";
            this.btn_tuychon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_tuychon.Size = new System.Drawing.Size(281, 49);
            this.btn_tuychon.TabIndex = 6;
            this.btn_tuychon.Text = "Tùy chọn";
            this.btn_tuychon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tuychon.UseVisualStyleBackColor = true;
            this.btn_tuychon.Click += new System.EventHandler(this.btn_tuychon_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hoadon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_hoadon.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btn_hoadon.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_hoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 281);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_hoadon.Size = new System.Drawing.Size(281, 49);
            this.btn_hoadon.TabIndex = 5;
            this.btn_hoadon.Text = "Hóa đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sanpham.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btn_sanpham.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_sanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(0, 232);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_sanpham.Size = new System.Drawing.Size(281, 49);
            this.btn_sanpham.TabIndex = 4;
            this.btn_sanpham.Text = "Sản phẩm";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sanpham.UseVisualStyleBackColor = true;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_orders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_orders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_orders.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.Location = new System.Drawing.Point(0, 183);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_orders.Size = new System.Drawing.Size(281, 49);
            this.btn_orders.TabIndex = 3;
            this.btn_orders.Text = "Orders";
            this.btn_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_trangchu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_trangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_trangchu.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_trangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(0, 134);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_trangchu.Size = new System.Drawing.Size(281, 49);
            this.btn_trangchu.TabIndex = 2;
            this.btn_trangchu.Text = "Trang chủ";
            this.btn_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_trangchu.UseVisualStyleBackColor = true;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(281, 134);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            //this.pictureBox1.Image = global::_3.PL.Properties.Resources.icons8_shoes_641;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(281, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.lb_change);
            this.panel1.Controls.Add(this.IconChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 85);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lb_change
            // 
            this.lb_change.AutoSize = true;
            this.lb_change.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_change.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_change.Location = new System.Drawing.Point(122, 29);
            this.lb_change.Name = "lb_change";
            this.lb_change.Size = new System.Drawing.Size(52, 21);
            this.lb_change.TabIndex = 1;
            this.lb_change.Text = "Home";
            // 
            // IconChange
            // 
            this.IconChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.IconChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconChange.IconColor = System.Drawing.Color.Gainsboro;
            this.IconChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconChange.IconSize = 52;
            this.IconChange.Location = new System.Drawing.Point(60, 12);
            this.IconChange.Name = "IconChange";
            this.IconChange.Size = new System.Drawing.Size(56, 52);
            this.IconChange.TabIndex = 0;
            this.IconChange.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(281, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 9);
            this.panel2.TabIndex = 2;
            // 
            // panel_dektop
            // 
            this.panel_dektop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.panel_dektop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dektop.Location = new System.Drawing.Point(281, 94);
            this.panel_dektop.Name = "panel_dektop";
            this.panel_dektop.Size = new System.Drawing.Size(1114, 576);
            this.panel_dektop.TabIndex = 3;
            // 
            // FrmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 670);
            this.Controls.Add(this.panel_dektop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Name = "FrmMain2";
            this.Text = "FrmMain2";
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private FontAwesome.Sharp.IconButton btn_caidat;
        private FontAwesome.Sharp.IconButton btn_tuychon;
        private FontAwesome.Sharp.IconButton btn_hoadon;
        private FontAwesome.Sharp.IconButton btn_sanpham;
        private FontAwesome.Sharp.IconButton btn_orders;
        private FontAwesome.Sharp.IconButton btn_trangchu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox IconChange;
        private System.Windows.Forms.Label lb_change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_dektop;
    }
}