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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public string mapn = "";
        public string madh = "";
        public frmPhieuNhap()
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PN.MAPN, PN.NGAYNHAP, HOTEN = NCC.HO + ' ' + NCC.TEN, PN.TONGTIEN"
                                                               + " FROM PHIEUNHAP PN, NHACUNGCAP NCC"
                                                               + " WHERE PN.MANCC = NCC.MANCC");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYNHAP"].Width = 200;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
        }

        private void dgvBangPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBangPhieu.Rows[e.RowIndex];
                mapn = row.Cells["MAPN"].Value.ToString();
                Program.idpn = mapn;
                dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPN.SOLUONG, DH.GIANHAP, SOTIEN = DH.GIANHAP*CTPN.SOLUONG"
                                                                    + " FROM DONGHO DH, CT_PHIEUNHAP CTPN, HANG H, LOAI L"
                                                                    + " WHERE CTPN.MAPN = '" + mapn +"' AND CTPN.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
                dgvChiTietPhieu.Columns["TENDH"].Width = 190;
                dgvChiTietPhieu.Columns["TENLOAI"].Width = 170;
            }    
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            frmThemPhieuNhap f = new frmThemPhieuNhap();
            f.ShowDialog();
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PN.MAPN, PN.NGAYNHAP, HOTEN = NCC.HO + ' ' + NCC.TEN, PN.TONGTIEN"
                                                               + " FROM PHIEUNHAP PN, NHACUNGCAP NCC"
                                                               + " WHERE PN.MANCC = NCC.MANCC");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYNHAP"].Width = 200;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
        }

        private void btnThemDongHo_Click(object sender, EventArgs e)
        {
            frmThemDongHoVaoPhieuNhap f = new frmThemDongHoVaoPhieuNhap();
            f.ShowDialog();
            dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PN.MAPN, PN.NGAYNHAP, HOTEN = NCC.HO + ' ' + NCC.TEN, PN.TONGTIEN"
                                                               + " FROM PHIEUNHAP PN, NHACUNGCAP NCC"
                                                               + " WHERE PN.MANCC = NCC.MANCC");
            dgvBangPhieu.Columns["HOTEN"].Width = 350;
            dgvBangPhieu.Columns["NGAYNHAP"].Width = 200;
            dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
            dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPN.SOLUONG, DH.GIANHAP, SOTIEN = DH.GIANHAP*CTPN.SOLUONG"
                                                    + " FROM DONGHO DH, CT_PHIEUNHAP CTPN, HANG H, LOAI L"
                                                    + " WHERE CTPN.MAPN = '" + mapn + "' AND CTPN.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
            dgvChiTietPhieu.Columns["TENDH"].Width = 190;
            dgvChiTietPhieu.Columns["TENLOAI"].Width = 170;
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUNHAP WHERE MAPN = '" + mapn + "'");
            if(dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập này!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel);
                if(rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM PHIEUNHAP WHERE MAPN = '" + mapn + "'");
                    MessageBox.Show("Đã xóa thành công!");
                    dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PN.MAPN, PN.NGAYNHAP, HOTEN = NCC.HO + ' ' + NCC.TEN, PN.TONGTIEN"
                                                               + " FROM PHIEUNHAP PN, NHACUNGCAP NCC"
                                                               + " WHERE PN.MANCC = NCC.MANCC");
                    dgvBangPhieu.Columns["HOTEN"].Width = 350;
                    dgvBangPhieu.Columns["NGAYNHAP"].Width = 200;
                    dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
                }    
            }    
        }

        private void btnXoaDongHo_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa đồng hồ từ phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            {
                Program.ExecSqlNonQuery("DELETE FROM CT_PHIEUNHAP WHERE MAPN = '" + mapn + "' AND MADH = '" + madh + "'");
                MessageBox.Show("Đã xóa thành công!");
                dgvBangPhieu.DataSource = Program.ExecSqlDataTable("SELECT PN.MAPN, PN.NGAYNHAP, HOTEN = NCC.HO + ' ' + NCC.TEN, PN.TONGTIEN"
                                                               + " FROM PHIEUNHAP PN, NHACUNGCAP NCC"
                                                               + " WHERE PN.MANCC = NCC.MANCC");
                dgvBangPhieu.Columns["HOTEN"].Width = 350;
                dgvBangPhieu.Columns["NGAYNHAP"].Width = 200;
                dgvBangPhieu.Columns["TONGTIEN"].Width = 200;
                dgvChiTietPhieu.DataSource = Program.ExecSqlDataTable("SELECT DH.MADH, DH.TENDH, H.TENHANG, L.TENLOAI, CTPN.SOLUONG, DH.GIANHAP, SOTIEN = DH.GIANHAP*CTPN.SOLUONG"
                                                    + " FROM DONGHO DH, CT_PHIEUNHAP CTPN, HANG H, LOAI L"
                                                    + " WHERE CTPN.MAPN = '" + mapn + "' AND CTPN.MADH = DH.MADH AND DH.MAHANG = H.MAHANG AND DH.MALOAI = L.MALOAI");
                dgvChiTietPhieu.Columns["TENDH"].Width = 190;
                dgvChiTietPhieu.Columns["TENLOAI"].Width = 170;
            }
        }

        private void dgvChiTietBangPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvChiTietPhieu.Rows[e.RowIndex];
                madh = row.Cells["MADH"].Value.ToString();
            }    
        }
    }
}
