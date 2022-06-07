
namespace QUANLY_BANDONGHO
{
    partial class frmPhieuDat
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
            this.btnThemPhieuDat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaPhieuDat = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(892, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemPhieuDat,
            this.btnThemDongHo});
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 24);
            this.btnThem.Text = "Thêm";
            // 
            // btnThemPhieuDat
            // 
            this.btnThemPhieuDat.Name = "btnThemPhieuDat";
            this.btnThemPhieuDat.Size = new System.Drawing.Size(286, 26);
            this.btnThemPhieuDat.Text = "Thêm phiếu đặt";
            this.btnThemPhieuDat.Click += new System.EventHandler(this.btnThemPhieuDat_Click);
            // 
            // btnThemDongHo
            // 
            this.btnThemDongHo.Name = "btnThemDongHo";
            this.btnThemDongHo.Size = new System.Drawing.Size(286, 26);
            this.btnThemDongHo.Text = "Thêm Đồng hồ vào phiếu đặt";
            this.btnThemDongHo.Click += new System.EventHandler(this.btnThemDongHo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaPhieuDat,
            this.btnXoaDongHo});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(49, 24);
            this.btnXoa.Text = "Xóa";
            // 
            // btnXoaPhieuDat
            // 
            this.btnXoaPhieuDat.Name = "btnXoaPhieuDat";
            this.btnXoaPhieuDat.Size = new System.Drawing.Size(258, 26);
            this.btnXoaPhieuDat.Text = "Xóa phiếu đặt";
            this.btnXoaPhieuDat.Click += new System.EventHandler(this.btnXoaPhieuDat_Click);
            // 
            // btnXoaDongHo
            // 
            this.btnXoaDongHo.Name = "btnXoaDongHo";
            this.btnXoaDongHo.Size = new System.Drawing.Size(258, 26);
            this.btnXoaDongHo.Text = "Xóa đồng hồ ở phiếu đặt";
            this.btnXoaDongHo.Click += new System.EventHandler(this.btnXoaDongHo_Click);
            // 
            // dgvBangPhieu
            // 
            this.dgvBangPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangPhieu.Location = new System.Drawing.Point(3, 56);
            this.dgvBangPhieu.Name = "dgvBangPhieu";
            this.dgvBangPhieu.RowHeadersWidth = 51;
            this.dgvBangPhieu.RowTemplate.Height = 24;
            this.dgvBangPhieu.Size = new System.Drawing.Size(886, 244);
            this.dgvBangPhieu.TabIndex = 1;
            this.dgvBangPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangPhieu_CellClick);
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(3, 321);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.RowHeadersWidth = 51;
            this.dgvChiTietPhieu.RowTemplate.Height = 24;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(886, 230);
            this.dgvChiTietPhieu.TabIndex = 2;
            this.dgvChiTietPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieuBangPhieu_CellClick);
            // 
            // frmPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvChiTietPhieu);
            this.Controls.Add(this.dgvBangPhieu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPhieuDat";
            this.Size = new System.Drawing.Size(892, 617);
            this.Load += new System.EventHandler(this.frmPhieuDat_Load);
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
        private System.Windows.Forms.ToolStripMenuItem btnThemPhieuDat;
        private System.Windows.Forms.ToolStripMenuItem btnThemDongHo;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnXoaPhieuDat;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDongHo;
        private System.Windows.Forms.DataGridView dgvBangPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
    }
}
