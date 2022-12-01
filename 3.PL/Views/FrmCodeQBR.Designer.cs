namespace _3.PL.Views
{
    partial class FrmCodeQBR
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
            this.btn_Addbarcode = new System.Windows.Forms.Button();
            this.txt_qrcode = new System.Windows.Forms.TextBox();
            this.btn_Savebarcode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Addbarcode
            // 
            this.btn_Addbarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Addbarcode.Location = new System.Drawing.Point(246, 35);
            this.btn_Addbarcode.Name = "btn_Addbarcode";
            this.btn_Addbarcode.Size = new System.Drawing.Size(94, 29);
            this.btn_Addbarcode.TabIndex = 1;
            this.btn_Addbarcode.Text = "Add";
            this.btn_Addbarcode.UseVisualStyleBackColor = true;
            this.btn_Addbarcode.Click += new System.EventHandler(this.btn_addbarcode_Click);
            // 
            // txt_qrcode
            // 
            this.txt_qrcode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_qrcode.Location = new System.Drawing.Point(246, 106);
            this.txt_qrcode.Name = "txt_qrcode";
            this.txt_qrcode.Size = new System.Drawing.Size(282, 31);
            this.txt_qrcode.TabIndex = 5;
            // 
            // btn_Savebarcode
            // 
            this.btn_Savebarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Savebarcode.Location = new System.Drawing.Point(434, 35);
            this.btn_Savebarcode.Name = "btn_Savebarcode";
            this.btn_Savebarcode.Size = new System.Drawing.Size(94, 29);
            this.btn_Savebarcode.TabIndex = 4;
            this.btn_Savebarcode.Text = "Save";
            this.btn_Savebarcode.UseVisualStyleBackColor = true;
            this.btn_Savebarcode.Click += new System.EventHandler(this.btn_saveqrcode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "QRCode";
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Location = new System.Drawing.Point(231, 158);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(323, 256);
            this.pic_qrcode.TabIndex = 6;
            this.pic_qrcode.TabStop = false;
            // 
            // FrmCodeQBR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Addbarcode);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.txt_qrcode);
            this.Controls.Add(this.btn_Savebarcode);
            this.Controls.Add(this.label2);
            this.Name = "FrmCodeQBR";
            this.Text = "FrmCodeQBR";
            this.Load += new System.EventHandler(this.FrmCodeQBR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Addbarcode;
        private System.Windows.Forms.TextBox txt_qrcode;
        private System.Windows.Forms.Button btn_Savebarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_qrcode;
    }
}