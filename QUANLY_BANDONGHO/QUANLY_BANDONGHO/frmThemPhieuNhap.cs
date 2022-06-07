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
    public partial class frmThemPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmThemPhieuNhap()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemPhieuNhap_Load(object sender, EventArgs e)
        {
            cbbNhaCC.DataSource = Program.ExecSqlDataTable("SELECT MANCC, HOTEN = HO + ' ' + TEN FROM NHACUNGCAP");
            cbbNhaCC.DisplayMember = "HOTEN";
            cbbNhaCC.ValueMember = "MANCC";
            cbbNhaCC.SelectedIndex = 0;

            lbMaNV.Text = Program.manv;
            DataTable dtb = new DataTable();
            dtb = Program.ExecSqlDataTable("SELECT HOTEN = HO + ' ' + TEN FROM NHANVIEN WHERE MANV = '" + Program.manv + "'");
            lbTenNV.Text = dtb.Rows[0]["HOTEN"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMaPN.Text == "" || deNgayLap.Text == "")
            {
                MessageBox.Show("Bạn không được bỏ bất kì thông tin nào!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                DataTable dtb1 = new DataTable();
                dtb1 = Program.ExecSqlDataTable("SELECT * FROM PHIEUNHAP WHERE MAPN = '" + txtMaPN.Text.Trim() + "'");
                if (dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!\nVui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO PHIEUNHAP VALUES('" + txtMaPN.Text.Trim() + "', '" + deNgayLap.Text.Trim() + "', '" + cbbNhaCC.SelectedValue.ToString() + "', '" + lbMaNV.Text + "', 0)");
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