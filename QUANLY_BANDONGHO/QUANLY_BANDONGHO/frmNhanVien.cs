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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public string chucnang = "";
        public frmNhanVien()
        {
            InitializeComponent();
            check();
        }

        void check()
        {
            if (Program.mGroup == "NHANVIEN")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
            }
            if (Program.mGroup == "CHUCUAHANG")
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = Program.ExecSqlDataTable("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, SDT, EMAIL FROM NHANVIEN;");
            dgvNhanVien.Columns["HO"].Width = 170;
            dgvNhanVien.Columns["TEN"].Width = 100;
            dgvNhanVien.Columns["EMAIL"].Width = 200;
            dgvNhanVien.Columns["DIACHI"].Width = 150;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MANV"].Value.ToString();
                txtHo.Text = row.Cells["HO"].Value.ToString();
                txtTen.Text = row.Cells["TEN"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                deNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            dtb1 = Program.ExecSqlDataTable("SELECT * FROM PHIEUDAT WHERE MANV = '" + txtMaNV.Text.Trim() + "'");
            DataTable dtb2 = new DataTable();
            dtb2 = Program.ExecSqlDataTable("SELECT * FROM PHIEUNHAP WHERE MANV = '" + txtMaNV.Text.Trim() + "'");
            if(dtb1.Rows.Count > 0)
            {
                MessageBox.Show("Nhân viên có lập phiếu đặt!\nKhông thể xóa nhân viên!");

            }   
            else
            {
                if(dtb2.Rows.Count > 0)
                {
                    MessageBox.Show("Nhân viên có lập phiếu nhập!\nKhông thể xóa nhân viên");
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn xóa nhân viên này?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("DELETE FROM NHANVIEN WHERE MANV = '" + txtMaNV.Text.Trim() + "'");
                        MessageBox.Show("Đã xóa thành công");
                        dgvNhanVien.DataSource = Program.ExecSqlDataTable("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, SDT, EMAIL FROM NHANVIEN;");
                        dgvNhanVien.Columns["HO"].Width = 170;
                        dgvNhanVien.Columns["TEN"].Width = 100;
                        dgvNhanVien.Columns["EMAIL"].Width = 200;
                        dgvNhanVien.Columns["DIACHI"].Width = 150;
                    }    
                }    
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            chucnang = "them";
            deNgaySinh.Text = "";
            txtMaNV.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if(chucnang == "them")
            {
                if (txtMaNV.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || deNgaySinh.Text == "")
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataTable dtb1 = new DataTable();
                    dtb1 = Program.ExecSqlDataTable("SELECT * FROM NHANVIEN WHERE MANV = '" + txtMaNV.Text.Trim() + "'");
                    if (dtb1.Rows.Count > 0)
                        MessageBox.Show("Mã nhân viên đã tồn tại!\nVui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK);
                    else
                    {
                        DialogResult rs = MessageBox.Show("Bạn muốn thêm nhân viên mới này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(rs == DialogResult.OK)
                        {
                            Program.ExecSqlNonQuery("INSERT INTO NHANVIEN VALUES('" +txtMaNV.Text.Trim() + "', '" + txtHo.Text.Trim() + "', '" + txtTen.Text.Trim() + "', '" + deNgaySinh.Text + "', '" + txtDiaChi.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '123');");
                            MessageBox.Show("Đã thêm thành công","Thông báo", MessageBoxButtons.OK);
                            dgvNhanVien.DataSource = Program.ExecSqlDataTable("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, SDT, EMAIL FROM NHANVIEN;");
                            dgvNhanVien.Columns["HO"].Width = 170;
                            dgvNhanVien.Columns["TEN"].Width = 100;
                            dgvNhanVien.Columns["EMAIL"].Width = 200;
                            dgvNhanVien.Columns["DIACHI"].Width = 150;
                        }    
                    }    
                }    
            }
            if(chucnang == "sua")
            {
                if (txtMaNV.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || deNgaySinh.Text == "")
                    MessageBox.Show("Bạn không được để trống bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn chỉnh sửa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("UPDATE NHANVIEN SET HO = '" + txtHo.Text.Trim() + "', TEN = '" + txtTen.Text.Trim() + "', NGAYSINH = '" + deNgaySinh.Text + "', DIACHI = '" + txtDiaChi.Text.Trim() + "', SDT = '" + txtSDT.Text.Trim() + "', EMAIL = '" + txtEmail.Text.Trim() + "' WHERE MANV = '" + txtMaNV.Text.Trim() + "';");
                        MessageBox.Show("Đã hiệu chỉnh thành công!");
                        dgvNhanVien.DataSource = Program.ExecSqlDataTable("SELECT MANV, HO, TEN, NGAYSINH, DIACHI, SDT, EMAIL FROM NHANVIEN;");
                        dgvNhanVien.Columns["HO"].Width = 170;
                        dgvNhanVien.Columns["TEN"].Width = 100;
                        dgvNhanVien.Columns["EMAIL"].Width = 200;
                        dgvNhanVien.Columns["DIACHI"].Width = 150;
                    }    
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            txtMaNV.Enabled = false;
        }
    }
}
