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
    public partial class frmThemHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "" || txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
            }    
            else
            {
                DataTable dtb1 = new DataTable();
                dtb1 = Program.ExecSqlDataTable("SELECT * FROM HANG WHERE MAHANG = '" + txtMaHang.Text.Trim() + "'");
                if(dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hãng đã tồn tại.\nVui lòng nhập mã khác!","Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm hãng này?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO HANG VALUES('" + txtMaHang.Text.Trim() + "', '" + txtTenHang.Text.Trim() + "')");
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