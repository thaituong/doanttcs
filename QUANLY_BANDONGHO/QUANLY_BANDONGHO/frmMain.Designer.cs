
namespace QUANLY_BANDONGHO
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.btnPhieuDat = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.btnDongHo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackUp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(146, 24);
            this.btnBackUp.Text = "BACKUP & RESTORE";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Location = new System.Drawing.Point(0, 168);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1143, 581);
            this.pnMain.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Location = new System.Drawing.Point(12, 46);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(131, 46);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDangXuat.Location = new System.Drawing.Point(149, 46);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(131, 46);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(286, 46);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 46);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Enabled = false;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPhieuNhap.Location = new System.Drawing.Point(9, 116);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(134, 46);
            this.btnPhieuNhap.TabIndex = 2;
            this.btnPhieuNhap.Text = "PHIẾU NHẬP";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Enabled = false;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNhanVien.Location = new System.Drawing.Point(554, 46);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(131, 46);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 774);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÊN:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(52, 774);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(42, 17);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "label1";
            this.lbHoTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHỨC VỤ:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(311, 774);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(42, 17);
            this.lbChucVu.TabIndex = 3;
            this.lbChucVu.Text = "label1";
            this.lbChucVu.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPhieuDat
            // 
            this.btnPhieuDat.Enabled = false;
            this.btnPhieuDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPhieuDat.Location = new System.Drawing.Point(149, 116);
            this.btnPhieuDat.Name = "btnPhieuDat";
            this.btnPhieuDat.Size = new System.Drawing.Size(134, 46);
            this.btnPhieuDat.TabIndex = 2;
            this.btnPhieuDat.Text = "PHIẾU ĐẶT";
            this.btnPhieuDat.UseVisualStyleBackColor = true;
            this.btnPhieuDat.Click += new System.EventHandler(this.btnPhieuDat_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Enabled = false;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhachHang.Location = new System.Drawing.Point(715, 46);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(138, 46);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Enabled = false;
            this.btnNhaCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNhaCC.Location = new System.Drawing.Point(885, 46);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(138, 46);
            this.btnNhaCC.TabIndex = 2;
            this.btnNhaCC.Text = "NHÀ CUNG CẤP";
            this.btnNhaCC.UseVisualStyleBackColor = true;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            // 
            // btnDongHo
            // 
            this.btnDongHo.Enabled = false;
            this.btnDongHo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDongHo.Location = new System.Drawing.Point(289, 116);
            this.btnDongHo.Name = "btnDongHo";
            this.btnDongHo.Size = new System.Drawing.Size(134, 46);
            this.btnDongHo.TabIndex = 2;
            this.btnDongHo.Text = "ĐỒNG HỒ";
            this.btnDongHo.UseVisualStyleBackColor = true;
            this.btnDongHo.Click += new System.EventHandler(this.btnDongHo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 800);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhaCC);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnDongHo);
            this.Controls.Add(this.btnPhieuDat);
            this.Controls.Add(this.btnPhieuNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ BÁN ĐỒNG HỒ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBackUp;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Button btnPhieuDat;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhaCC;
        private System.Windows.Forms.Button btnDongHo;
    }
}

