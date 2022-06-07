using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLY_BANDONGHO
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            if(Program.mGroup == "NHANVIEN" || Program.mGroup == "CHUCUAHANG")
            {
                this.Show();
                lbHoTen.Text = Program.mHoten;
                lbChucVu.Text = Program.mGroup;
                btnDangNhap.Enabled = false;
                btnNhanVien.Enabled = true;
                btnKhachHang.Enabled = true;
                btnNhaCC.Enabled = true;
                btnPhieuNhap.Enabled = true;
                btnPhieuDat.Enabled = true;
                btnDongHo.Enabled = true;
                btnDangXuat.Enabled = true;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn rời khỏi của hàng?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
                Application.Exit();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmNhanVien f = new frmNhanVien();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmKhachHang f = new frmKhachHang();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmNhaCungCap f = new frmNhaCungCap();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmPhieuNhap f = new frmPhieuNhap();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnPhieuDat_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmPhieuDat f = new frmPhieuDat();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnDongHo_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            frmDongHo f = new frmDongHo();
            this.pnMain.Controls.Add(f);
            pnMain.Tag = f;
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            {
                btnDangXuat.Enabled = false;
                btnDangNhap.Enabled = true;
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnNhaCC.Enabled = false;
                btnPhieuDat.Enabled = false;
                btnPhieuNhap.Enabled = false;
                btnDongHo.Enabled = false;
                lbHoTen.Text = "";
                lbChucVu.Text = "";
                Program.mGroup = "";
                if (pnMain.Controls.Count > 0)
                    pnMain.Controls.RemoveAt(0);
            }    
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            frmBackUpRestore f = new frmBackUpRestore();
            f.ShowDialog();
        }
    }
}
