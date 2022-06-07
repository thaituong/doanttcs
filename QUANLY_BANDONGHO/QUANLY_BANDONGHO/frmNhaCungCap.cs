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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        public string chucnang = "";
        public frmNhaCungCap()
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
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
            }
            if (Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = Program.ExecSqlDataTable("SELECT * FROM NHACUNGCAP");
            dgvNhaCungCap.Columns["HO"].Width = 170;
            dgvNhaCungCap.Columns["TEN"].Width = 130;
            dgvNhaCungCap.Columns["EMAIL"].Width = 200;
            dgvNhaCungCap.Columns["DIACHI"].Width = 150;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MANCC"].Value.ToString();
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
            txtMaNCC.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMaNCC.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (chucnang == "them")
            {
                if (txtMaNCC.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataTable dtb1 = new DataTable();
                    dtb1 = Program.ExecSqlDataTable("SELECT * FROM NHACUNGCAP WHERE MANCC = '" + txtMaNCC.Text.Trim() + "'");
                    if (dtb1.Rows.Count > 0)
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại!\nVui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK);
                    else
                    {
                        DialogResult rs = MessageBox.Show("Bạn muốn thêm nhà cung cấp mới này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            Program.ExecSqlNonQuery("INSERT INTO NHACUNGCAP(MANCC, HO, TEN, SDT, EMAIL, DIACHI) VALUES('" + txtMaNCC.Text.Trim() + "', '" + txtHo.Text.Trim() + "', '" + txtTen.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + txtDiaChi.Text.Trim() + "')");
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            dgvNhaCungCap.DataSource = Program.ExecSqlDataTable("SELECT * FROM NHACUNGCAP");
                            dgvNhaCungCap.Columns["HO"].Width = 170;
                            dgvNhaCungCap.Columns["TEN"].Width = 130;
                            dgvNhaCungCap.Columns["EMAIL"].Width = 200;
                            dgvNhaCungCap.Columns["DIACHI"].Width = 150;
                        }
                    }
                }
            }
            if (chucnang == "sua")
            {
                if (txtMaNCC.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn chỉnh sửa nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("UPDATE NHACUNGCAP SET HO = '" + txtHo.Text.Trim() + "', TEN = '" + txtTen.Text.Trim() + "', DIACHI = '" + txtDiaChi.Text.Trim() + "', SDT = '" + txtSDT.Text.Trim() + "', EMAIL = '" + txtEmail.Text.Trim() + "' WHERE MANCC = '" + txtMaNCC.Text.Trim() + "';");
                        MessageBox.Show("Đã hiệu chỉnh thành công!");
                        dgvNhaCungCap.DataSource = Program.ExecSqlDataTable("SELECT * FROM NHACUNGCAP");
                        dgvNhaCungCap.Columns["HO"].Width = 170;
                        dgvNhaCungCap.Columns["TEN"].Width = 130;
                        dgvNhaCungCap.Columns["EMAIL"].Width = 200;
                        dgvNhaCungCap.Columns["DIACHI"].Width = 150;
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            txtMaNCC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM PHIEUNHAP WHERE MANCC = '" + txtMaNCC.Text.Trim() + "'");
            if (dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Nhà cung cấp đã có phiếu nhập!\nKhông thể xóa nhà cung cấp!");

            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    Program.ExecSqlNonQuery("DELETE FROM NHACUNGCAP WHERE MANCC = '" + txtMaNCC.Text.Trim() + "'");
                    MessageBox.Show("Đã xóa thành công");
                    dgvNhaCungCap.DataSource = Program.ExecSqlDataTable("SELECT * FROM NHACUNGCAP");
                    dgvNhaCungCap.Columns["HO"].Width = 170;
                    dgvNhaCungCap.Columns["TEN"].Width = 130;
                    dgvNhaCungCap.Columns["EMAIL"].Width = 200;
                    dgvNhaCungCap.Columns["DIACHI"].Width = 150;
                }
            }
        }
    }
}
