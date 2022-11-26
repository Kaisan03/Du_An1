namespace _3.PL.Views
{
    partial class FrmImportExcel
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
            this.dgrid_AddExcel = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_AddExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_AddExcel
            // 
            this.dgrid_AddExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_AddExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_AddExcel.Location = new System.Drawing.Point(0, 256);
            this.dgrid_AddExcel.Name = "dgrid_AddExcel";
            this.dgrid_AddExcel.RowHeadersWidth = 51;
            this.dgrid_AddExcel.RowTemplate.Height = 29;
            this.dgrid_AddExcel.Size = new System.Drawing.Size(1020, 271);
            this.dgrid_AddExcel.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_TimKiem.Location = new System.Drawing.Point(0, 229);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(1020, 27);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(747, 101);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(94, 29);
            this.btn_OpenFile.TabIndex = 2;
            this.btn_OpenFile.Text = "Open";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(747, 163);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(94, 29);
            this.btn_Import.TabIndex = 2;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 527);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dgrid_AddExcel);
            this.Name = "FrmImportExcel";
            this.Text = "FrmImportExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_AddExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_AddExcel;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}