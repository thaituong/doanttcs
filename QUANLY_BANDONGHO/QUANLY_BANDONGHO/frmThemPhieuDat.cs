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
    public partial class frmThemPhieuDat : DevExpress.XtraEditors.XtraForm
    {
        public frmThemPhieuDat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmThemPhieuDat_Load(object sender, EventArgs e)
        {
            cbbKhachHang.DataSource = Program.ExecSqlDataTable("SELECT MAKH, HOTEN = HO + ' ' + TEN FROM KHACHHANG");
            cbbKhachHang.DisplayMember = "HOTEN";
            cbbKhachHang.ValueMember = "MAKH";
            cbbKhachHang.SelectedIndex = 0;

            lbMaNV.Text = Program.manv;
            DataTable dtb = new DataTable();
            dtb = Program.ExecSqlDataTable("SELECT HOTEN = HO + ' ' + TEN FROM NHANVIEN WHERE MANV = '" + Program.manv + "'");
            lbTenNV.Text = dtb.Rows[0]["HOTEN"].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaPD.Text == "" || deNgayDat.Text == "")
            {
                MessageBox.Show("Bạn không được bỏ bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dtb1 = new DataTable();
                dtb1 = Program.ExecSqlDataTable("SELECT * FROM PHIEUDAT WHERE MAPD = '" + txtMaPD.Text.Trim() + "'");
                if (dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phiếu đặt đã tồn tại!\nVui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm phiếu đặt?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO PHIEUDAT VALUES('" + txtMaPD.Text.Trim() + "', '" + deNgayDat.Text.Trim() + "', '" + cbbKhachHang.SelectedValue.ToString() + "', '" + lbMaNV.Text + "', 0)");
                        MessageBox.Show("Đã thêm thành công!");
                        this.Close();
                    }
                }    
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}