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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public string chucnang = "";
        public frmKhachHang()
        {
            InitializeComponent();
            check();
        }

        void check()
        {
            if(Program.mGroup == "CHUCUAHANG")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
            }    
            if(Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
            }    
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM KHACHHANG");
            dgvKhachHang.Columns["HO"].Width = 200;
            dgvKhachHang.Columns["TEN"].Width = 170;
            dgvKhachHang.Columns["EMAIL"].Width = 250;
            dgvKhachHang.Columns["DIACHI"].Width = 150;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MAKH"].Value.ToString();
                txtHo.Text = row.Cells["HO"].Value.ToString();
                txtTen.Text = row.Cells["TEN"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            txtMaKH.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if(chucnang == "them")
            {
                if (txtMaKH.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" )
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataTable dtb1 = new DataTable();
                    dtb1 = Program.ExecSqlDataTable("SELECT * FROM KHACHHANG WHERE MAKH = '" + txtMaKH.Text.Trim() + "'");
                    if (dtb1.Rows.Count > 0)
                        MessageBox.Show("Mã khách hàng đã tồn tại!\nVui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK);
                    else
                    {
                        DialogResult rs = MessageBox.Show("Bạn muốn thêm khách hàng mới này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            Program.ExecSqlNonQuery("INSERT INTO KHACHHANG(MAKH, HO, TEN, SDT, EMAIL, DIACHI) VALUES('" + txtMaKH.Text.Trim() + "', '" + txtHo.Text.Trim() + "', '" + txtTen.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + txtDiaChi.Text.Trim() + "')");
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            dgvKhachHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM KHACHHANG");
                            dgvKhachHang.Columns["HO"].Width = 200;
                            dgvKhachHang.Columns["TEN"].Width = 170;
                            dgvKhachHang.Columns["EMAIL"].Width = 250;
                            dgvKhachHang.Columns["DIACHI"].Width = 150;
                        }
                    }
                }    
            }
            if(chucnang == "sua")
            {
                if (txtMaKH.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn chỉnh sửa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("UPDATE KHACHHANG SET HO = '" + txtHo.Text.Trim() + "', TEN = '" + txtTen.Text.Trim() + "', DIACHI = '" + txtDiaChi.Text.Trim() + "', SDT = '" + txtSDT.Text.Trim() + "', EMAIL = '" + txtEmail.Text.Trim() + "' WHERE MAKH = '" + txtMaKH.Text.Trim() + "';");
                        MessageBox.Show("Đã hiệu chỉnh thành công!");
                        dgvKhachHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM KHACHHANG");
                        dgvKhachHang.Columns["HO"].Width = 200;
                        dgvKhachHang.Columns["TEN"].Width = 170;
                        dgvKhachHang.Columns["EMAIL"].Width = 250;
                        dgvKhachHang.Columns["DIACHI"].Width = 150;
                    }
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM PHIEUDAT WHERE MAKH = '" + txtMaKH.Text.Trim() + "'");
            if (dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Khách hàng đã có đặt phiếu!\nKhông thể xóa khách hàng!");

            }
            else
            {
                    DialogResult rs = MessageBox.Show("Bạn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM KHACHHANG WHERE MAKH = '" + txtMaKH.Text.Trim() + "'");
                    MessageBox.Show("Đã xóa thành công");
                    dgvKhachHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM KHACHHANG");
                    dgvKhachHang.Columns["HO"].Width = 200;
                    dgvKhachHang.Columns["TEN"].Width = 170;
                    dgvKhachHang.Columns["EMAIL"].Width = 250;
                    dgvKhachHang.Columns["DIACHI"].Width = 150;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            txtMaKH.Enabled = false;
        }
    }
}
