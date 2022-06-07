
namespace QUANLY_BANDONGHO
{
    partial class frmDongHo
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
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.suaLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.suaDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDongHo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemHang,
            this.btnThemLoai,
            this.btnThemDongHo});
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // btnThemHang
            // 
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(224, 26);
            this.btnThemHang.Text = "Thêm Hãng";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(224, 26);
            this.btnThemLoai.Text = "Thêm loại đồng hồ";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // btnThemDongHo
            // 
            this.btnThemDongHo.Name = "btnThemDongHo";
            this.btnThemDongHo.Size = new System.Drawing.Size(224, 26);
            this.btnThemDongHo.Text = "Thêm đồng hồ";
            this.btnThemDongHo.Click += new System.EventHandler(this.btnThemDongHo_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaHang,
            this.XoaLoai,
            this.XoaDongHo});
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // XoaHang
            // 
            this.XoaHang.Name = "XoaHang";
            this.XoaHang.Size = new System.Drawing.Size(224, 26);
            this.XoaHang.Text = "Xóa Hãng";
            this.XoaHang.Click += new System.EventHandler(this.XoaHang_Click);
            // 
            // XoaLoai
            // 
            this.XoaLoai.Name = "XoaLoai";
            this.XoaLoai.Size = new System.Drawing.Size(224, 26);
            this.XoaLoai.Text = "Xóa Loại đồng hồ";
            this.XoaLoai.Click += new System.EventHandler(this.XoaLoai_Click);
            // 
            // XoaDongHo
            // 
            this.XoaDongHo.Name = "XoaDongHo";
            this.XoaDongHo.Size = new System.Drawing.Size(224, 26);
            this.XoaDongHo.Text = "Xóa đồng hồ";
            this.XoaDongHo.Click += new System.EventHandler(this.XoaDongHo_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suaHang,
            this.suaLoai,
            this.suaDongHo});
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // suaHang
            // 
            this.suaHang.Name = "suaHang";
            this.suaHang.Size = new System.Drawing.Size(206, 26);
            this.suaHang.Text = "Sửa Hãng";
            // 
            // suaLoai
            // 
            this.suaLoai.Name = "suaLoai";
            this.suaLoai.Size = new System.Drawing.Size(206, 26);
            this.suaLoai.Text = "Sửa loại đồng hồ";
            // 
            // suaDongHo
            // 
            this.suaDongHo.Name = "suaDongHo";
            this.suaDongHo.Size = new System.Drawing.Size(206, 26);
            this.suaDongHo.Text = "Sửa đồng hồ";
            // 
            // dgvDongHo
            // 
            this.dgvDongHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongHo.Location = new System.Drawing.Point(0, 175);
            this.dgvDongHo.Name = "dgvDongHo";
            this.dgvDongHo.RowHeadersWidth = 51;
            this.dgvDongHo.RowTemplate.Height = 24;
            this.dgvDongHo.Size = new System.Drawing.Size(830, 295);
            this.dgvDongHo.TabIndex = 1;
            this.dgvDongHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDongHo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hãng:";
            // 
            // cbbHang
            // 
            this.cbbHang.FormattingEnabled = true;
            this.cbbHang.Location = new System.Drawing.Point(120, 70);
            this.cbbHang.Name = "cbbHang";
            this.cbbHang.Size = new System.Drawing.Size(196, 24);
            this.cbbHang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(120, 120);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(196, 24);
            this.cbbLoai.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(388, 92);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(116, 44);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Location = new System.Drawing.Point(564, 92);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(116, 44);
            this.btnHuyLoc.TabIndex = 4;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // frmDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuyLoc);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDongHo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDongHo";
            this.Size = new System.Drawing.Size(830, 548);
            this.Load += new System.EventHandler(this.frmDongHo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongHo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnThemHang;
        private System.Windows.Forms.ToolStripMenuItem btnThemLoai;
        private System.Windows.Forms.ToolStripMenuItem btnThemDongHo;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaHang;
        private System.Windows.Forms.ToolStripMenuItem XoaLoai;
        private System.Windows.Forms.ToolStripMenuItem XoaDongHo;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaHang;
        private System.Windows.Forms.ToolStripMenuItem suaLoai;
        private System.Windows.Forms.ToolStripMenuItem suaDongHo;
        private System.Windows.Forms.DataGridView dgvDongHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnHuyLoc;
    }
}
