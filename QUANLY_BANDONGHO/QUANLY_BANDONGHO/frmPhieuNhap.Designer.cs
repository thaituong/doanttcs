
namespace QUANLY_BANDONGHO
{
    partial class frmPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBangPhieu = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemPhieuNhap,
            this.btnThemDongHo});
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 24);
            this.btnThem.Text = "Thêm";
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(295, 26);
            this.btnThemPhieuNhap.Text = "Thêm phiếu nhập";
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // btnThemDongHo
            // 
            this.btnThemDongHo.Name = "btnThemDongHo";
            this.btnThemDongHo.Size = new System.Drawing.Size(295, 26);
            this.btnThemDongHo.Text = "Thêm đồng hồ vào phiếu nhập";
            this.btnThemDongHo.Click += new System.EventHandler(this.btnThemDongHo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaPhieuNhap,
            this.btnXoaDongHo});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(49, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(269, 26);
            this.btnXoaPhieuNhap.Text = "Xóa phiếu nhập";
            this.btnXoaPhieuNhap.Click += new System.EventHandler(this.btnXoaPhieuNhap_Click);
            // 
            // btnXoaDongHo
            // 
            this.btnXoaDongHo.Name = "btnXoaDongHo";
            this.btnXoaDongHo.Size = new System.Drawing.Size(269, 26);
            this.btnXoaDongHo.Text = "Xóa đồng hồ ở phiếu nhập";
            this.btnXoaDongHo.Click += new System.EventHandler(this.btnXoaDongHo_Click);
            // 
            // dgvBangPhieu
            // 
            this.dgvBangPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangPhieu.Location = new System.Drawing.Point(3, 47);
            this.dgvBangPhieu.Name = "dgvBangPhieu";
            this.dgvBangPhieu.RowHeadersWidth = 51;
            this.dgvBangPhieu.RowTemplate.Height = 24;
            this.dgvBangPhieu.Size = new System.Drawing.Size(902, 235);
            this.dgvBangPhieu.TabIndex = 1;
            this.dgvBangPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangPhieu_CellClick);
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(3, 297);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.RowHeadersWidth = 51;
            this.dgvChiTietPhieu.RowTemplate.Height = 24;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(902, 203);
            this.dgvChiTietPhieu.TabIndex = 2;
            this.dgvChiTietPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietBangPhieu_CellClick);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvChiTietPhieu);
            this.Controls.Add(this.dgvBangPhieu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPhieuNhap";
            this.Size = new System.Drawing.Size(909, 530);
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.DataGridView dgvBangPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
        private System.Windows.Forms.ToolStripMenuItem btnThemPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnThemDongHo;
        private System.Windows.Forms.ToolStripMenuItem btnXoaPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDongHo;
    }
}
