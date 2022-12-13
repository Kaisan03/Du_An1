namespace _3.PL.Views
{
    partial class Frmruttien
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
            this.tbx_makhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ruttien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_ruttien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_makhau
            // 
            this.tbx_makhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_makhau.Location = new System.Drawing.Point(112, 77);
            this.tbx_makhau.Name = "tbx_makhau";
            this.tbx_makhau.Size = new System.Drawing.Size(362, 23);
            this.tbx_makhau.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mật khẩu:";
            // 
            // btn_ruttien
            // 
            this.btn_ruttien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ruttien.Location = new System.Drawing.Point(256, 211);
            this.btn_ruttien.Name = "btn_ruttien";
            this.btn_ruttien.Size = new System.Drawing.Size(75, 34);
            this.btn_ruttien.TabIndex = 2;
            this.btn_ruttien.Text = "Rút tiền";
            this.btn_ruttien.UseVisualStyleBackColor = true;
            this.btn_ruttien.Click += new System.EventHandler(this.btn_ruttien_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số tiền rút";
            // 
            // tbx_ruttien
            // 
            this.tbx_ruttien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_ruttien.Location = new System.Drawing.Point(112, 159);
            this.tbx_ruttien.Name = "tbx_ruttien";
            this.tbx_ruttien.Size = new System.Drawing.Size(362, 23);
            this.tbx_ruttien.TabIndex = 3;
            // 
            // Frmruttien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_ruttien);
            this.Controls.Add(this.btn_ruttien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_makhau);
            this.Name = "Frmruttien";
            this.Text = "Frmruttien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_makhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ruttien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_ruttien;
    }
}