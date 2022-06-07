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
    public partial class frmPhieuDat : DevExpress.XtraEditors.XtraUserControl
    {
        public string mapd = "";
        public string madh = "";
        public frmPhieuDat()
        {
            InitializeComponent();
            check();
        }

        void check()
        {
            if (Program.mGroup == "CHUCUAHANG")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void frmPhieuDat_Load(object sender, EventArgs e)
        {
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PD.MAPD, PD.NGAYDAT, HOTEN = KH.HO + ' ' + KH.TEN, PD.TONGTIEN"
                                                               + " FROM PHIEUDAT PD, KHACHHANG KH"
                                                               + " WHERE PD.MAKH = KH.MAKH");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYDAT"].Width = 180;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
        }

        private void dgvBangPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBangPhieu.Rows[e.RowIndex];
                mapd = row.Cells["MAPD"].Value.ToString();
                Program.idpd = mapd;
                dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPD.SOLUONG, DH.GIABAN, SOTIEN = DH.GIABAN*CTPD.SOLUONG"
                                                                    + " FROM DONGHO DH, CT_PHIEUDAT CTPD, HANG H, LOAI L"
                                                                    + " WHERE CTPD.MAPD = '" + mapd + "' AND CTPD.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
                dgvChiTietPhieu.Columns["TENDH"].Width = 190;
                dgvChiTietPhieu.Columns["TENLOAI"].Width = 150;
            }
        }

        private void btnThemPhieuDat_Click(object sender, EventArgs e)
        {
            frmThemPhieuDat f = new frmThemPhieuDat();
            f.ShowDialog();
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PD.MAPD, PD.NGAYDAT, HOTEN = KH.HO + ' ' + KH.TEN, PD.TONGTIEN"
                                                               + " FROM PHIEUDAT PD, KHACHHANG KH"
                                                               + " WHERE PD.MAKH = KH.MAKH");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYDAT"].Width = 180;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
        }

        private void btnThemDongHo_Click(object sender, EventArgs e)
        {
            frmThemDongHoVaoPhieuDat f = new frmThemDongHoVaoPhieuDat();
            f.ShowDialog();
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PD.MAPD, PD.NGAYDAT, HOTEN = KH.HO + ' ' + KH.TEN, PD.TONGTIEN"
                                                               + " FROM PHIEUDAT PD, KHACHHANG KH"
                                                               + " WHERE PD.MAKH = KH.MAKH");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYDAT"].Width = 180;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
            dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPD.SOLUONG, DH.GIABAN, SOTIEN = DH.GIABAN*CTPD.SOLUONG"
                                                                    + " FROM DONGHO DH, CT_PHIEUDAT CTPD, HANG H, LOAI L"
                                                                    + " WHERE CTPD.MAPD = '" + mapd + "' AND CTPD.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvChiTietPhieu.Columns["TENDH"].Width = 190;
            dgvChiTietPhieu.Columns["TENLOAI"].Width = 150;
        }

        private void btnXoaPhieuDat_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUDAT WHERE MAPD = '" + mapd + "'");
            if (dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu đặt này!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa phiếu đặt này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM PHIEUDAT WHERE MAPD = '" + mapd + "'");
                    MessageBox.Show("Đã xóa thành công!");
                    dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PD.MAPD, PD.NGAYDAT, HOTEN = KH.HO + ' ' + KH.TEN, PD.TONGTIEN"
                                                               + " FROM PHIEUDAT PD, KHACHHANG KH"
                                                               + " WHERE PD.MAKH = KH.MAKH");
                    dgvBangPhieu.Columns["HOTEN"].Width = 350;
                    dgvBangPhieu.Columns["NGAYDAT"].Width = 180;
                    dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
                }
            }
        }

        private void dgvChiTieuBangPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvChiTietPhieu.Rows[e.RowIndex];
                madh = row.Cells["MADH"].Value.ToString();
            }
        }

        private void btnXoaDongHo_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa đồng hồ từ phiếu đặt này?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                Program.ExecSqlNonQuery("DELETE FROM CT_PHIEUDAT WHERE MAPD = '" + mapd + "' AND MADH = '" + madh + "'");
                MessageBox.Show("Đã xóa thành công!");
                dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PD.MAPD, PD.NGAYDAT, HOTEN = KH.HO + ' ' + KH.TEN, PD.TONGTIEN"
                                                               + " FROM PHIEUDAT PD, KHACHHANG KH"
                                                               + " WHERE PD.MAKH = KH.MAKH");
                dgvBangPhieu.Columns["HOTEN"].Width = 350;
                dgvBangPhieu.Columns["NGAYDAT"].Width = 180;
                dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
                dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPD.SOLUONG, DH.GIABAN, SOTIEN = DH.GIABAN*CTPD.SOLUONG"
                                                                        + " FROM DONGHO DH, CT_PHIEUDAT CTPD, HANG H, LOAI L"
                                                                        + " WHERE CTPD.MAPD = '" + mapd + "' AND CTPD.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
                dgvChiTietPhieu.Columns["TENDH"].Width = 190;
                dgvChiTietPhieu.Columns["TENLOAI"].Width = 150;
            }
        }
    }
}
