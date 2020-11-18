namespace FormQuanLyBanHang
{
    partial class FormDanhSachKhachHang
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
            this.dgvdanhsachkhachhang = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsachkhachhang
            // 
            this.dgvdanhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachkhachhang.Location = new System.Drawing.Point(0, -1);
            this.dgvdanhsachkhachhang.Name = "dgvdanhsachkhachhang";
            this.dgvdanhsachkhachhang.Size = new System.Drawing.Size(800, 226);
            this.dgvdanhsachkhachhang.TabIndex = 0;
            this.dgvdanhsachkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachkhachhang_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(349, 295);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // FormDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdanhsachkhachhang);
            this.Name = "FormDanhSachKhachHang";
            this.Text = "FormDanhSachKhachHang";
            this.Load += new System.EventHandler(this.FormDanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsachkhachhang;
        private System.Windows.Forms.Button btnthem;
    }
}