using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_BANDONGHO
{
    public partial class frmDongHo : DevExpress.XtraEditors.XtraUserControl
    {
        public string frmDH_madh = "";
        public frmDongHo()
        {
            InitializeComponent();
            check();
        }
        void check()
        {
            if(Program.mGroup == "CHUCUAHANG")
            {
                btnThemHang.Enabled = false;
                btnThemLoai.Enabled = false;
                btnThemDongHo.Enabled = false;
                XoaHang.Enabled = false;
                XoaLoai.Enabled = false;
                XoaDongHo.Enabled = false;
                suaHang.Enabled = false;
                suaLoai.Enabled = false;
                suaDongHo.Enabled = false;
            }    
            if(Program.mGroup == "NHANVIEN")
            {
                btnThemHang.Enabled = true;
                btnThemLoai.Enabled = true;
                btnThemDongHo.Enabled = true;
                XoaHang.Enabled = true;
                XoaLoai.Enabled = true;
                XoaDongHo.Enabled = true;
                suaHang.Enabled = true;
                suaLoai.Enabled = true;
                suaDongHo.Enabled = true;
            }    
        }

        private void frmDongHo_Load(object sender, EventArgs e)
        {
            cbbHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM HANG");
            cbbHang.DisplayMember = "TENHANG";
            cbbHang.ValueMember = "MAHANG";

            cbbLoai.DataSource = Program.ExecSqlDataTable("SELECT * FROM LOAI");
            cbbLoai.DisplayMember = "TENLOAI";
            cbbLoai.ValueMember = "MALOAI";

            dgvDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH, GIABAN, GIANHAP, SOLUONGTON, TENHANG, TENLOAI"
                + " FROM DONGHO DH, HANG H, LOAI L"
                + " WHERE DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvDongHo.Columns["TENDH"].Width = 150;
            dgvDongHo.Columns["TENLOAI"].Width = 170;
            dgvDongHo.Columns["GIABAN"].Width = 80;
            dgvDongHo.Columns["GIANHAP"].Width = 80;
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            dgvDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH, GIABAN, GIANHAP, SOLUONGTON, TENHANG, TENLOAI"
                + " FROM DONGHO DH, HANG H, LOAI L"
                + " WHERE DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvDongHo.Columns["TENDH"].Width = 150;
            dgvDongHo.Columns["TENLOAI"].Width = 170;
            dgvDongHo.Columns["GIABAN"].Width = 80;
            dgvDongHo.Columns["GIANHAP"].Width = 80;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH, GIABAN, GIANHAP, SOLUONGTON, TENHANG, TENLOAI"
                + " FROM DONGHO DH, HANG H, LOAI L"
                + " WHERE DH.MAHANG = '" + cbbHang.SelectedValue.ToString() + "' AND DH.MALOAI = '" + cbbLoai.SelectedValue.ToString() + "' AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvDongHo.Columns["TENDH"].Width = 150;
            dgvDongHo.Columns["TENLOAI"].Width = 170;
            dgvDongHo.Columns["GIABAN"].Width = 80;
            dgvDongHo.Columns["GIANHAP"].Width = 80;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            frmThemHang f = new frmThemHang();
            f.ShowDialog();
            cbbHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM HANG");
            cbbHang.DisplayMember = "TENHANG";
            cbbHang.ValueMember = "MAHANG";
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemLoai f = new frmThemLoai();
            f.ShowDialog();
            cbbLoai.DataSource = Program.ExecSqlDataTable("SELECT * FROM LOAI");
            cbbLoai.DisplayMember = "TENLOAI";
            cbbLoai.ValueMember = "MALOAI";
        }

        private void btnThemDongHo_Click(object sender, EventArgs e)
        {
            frmThemDongHo f = new frmThemDongHo();
            f.ShowDialog();
            dgvDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH, GIABAN, GIANHAP, SOLUONGTON, TENHANG, TENLOAI"
                + " FROM DONGHO DH, HANG H, LOAI L"
                + " WHERE DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvDongHo.Columns["TENDH"].Width = 150;
            dgvDongHo.Columns["TENLOAI"].Width = 170;
            dgvDongHo.Columns["GIABAN"].Width = 80;
            dgvDongHo.Columns["GIANHAP"].Width = 80;
        }

        private void XoaHang_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM DONGHO WHERE MAHANG = '" + cbbHang.SelectedValue.ToString() + "'");
            if(dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa hãng này vì dữ liệu đồng hồ về hãng này vẫn còn!","Thông báo",MessageBoxButtons.OK);
            }    
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa hãng này?", "Thông báo", MessageBoxButtons.OKCancel);
                if(rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM HANG WHERE MAHANG = '" + cbbHang.SelectedValue.ToString() + "'");
                    MessageBox.Show("Đã xóa thành công!","Thông báo", MessageBoxButtons.OK);
                    cbbHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM HANG");
                    cbbHang.DisplayMember = "TENHANG";
                    cbbHang.ValueMember = "MAHANG";
                }    
            }    
        }

        private void XoaLoai_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM DONGHO WHERE MALOAI = '" + cbbLoai.SelectedValue.ToString() + "'");
            if(dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa loại này vì dữ liệu đồng hồ về loại này vẫn còn!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa loại này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM LOAI WHERE MALOAI = '" + cbbLoai.SelectedValue.ToString() + "'");
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    cbbLoai.DataSource = Program.ExecSqlDataTable("SELECT * FROM LOAI");
                    cbbLoai.DisplayMember = "TENLOAI";
                    cbbLoai.ValueMember = "MALOAI";
                }    
            }    
        }

        private void dgvDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDongHo.Rows[e.RowIndex];
                frmDH_madh = row.Cells["MADH"].Value.ToString();
            }    
        }

        private void XoaDongHo_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUNHAP WHERE MADH = '" + frmDH_madh + "'");
            if(dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa đồng hồ vì có dữ liệu từ phiếu nhập!","Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                DataTable dtb2 = new DataTable();
                dtb2 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUDAT WHERE MADH = '" + frmDH_madh + "'");
                if(dtb2.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đồng hồ vì có dữ liệu từ phiếu đặt!", "Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn xóa dữ liệu đồng hồ này?", "Thông báo", MessageBoxButtons.OKCancel);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("DELETE FROM DONGHO WHERE MADH = '" + frmDH_madh + "'");
                        MessageBox.Show("Đã xóa thành công","Thông báo",MessageBoxButtons.OK);
                        dgvDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH, GIABAN, GIANHAP, SOLUONGTON, TENHANG, TENLOAI"
                            + " FROM DONGHO DH, HANG H, LOAI L"
                            + " WHERE DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
                        dgvDongHo.Columns["TENDH"].Width = 150;
                        dgvDongHo.Columns["TENLOAI"].Width = 170;
                        dgvDongHo.Columns["GIABAN"].Width = 80;
                        dgvDongHo.Columns["GIANHAP"].Width = 80;
                    }    
                }    
            }    
        }
    }
}
