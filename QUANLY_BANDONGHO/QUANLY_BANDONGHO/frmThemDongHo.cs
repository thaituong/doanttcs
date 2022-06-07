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
    public partial class frmThemDongHo : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDongHo()
        {
            InitializeComponent();
        }

        private void frmThemDongHo_Load(object sender, EventArgs e)
        {
            cbbHang.DataSource = Program.ExecSqlDataTable("SELECT * FROM HANG");
            cbbHang.DisplayMember = "TENHANG";
            cbbHang.ValueMember = "MAHANG";

            cbbLoai.DataSource = Program.ExecSqlDataTable("SELECT * FROM LOAI");
            cbbLoai.DisplayMember = "TENLOAI";
            cbbLoai.ValueMember = "MALOAI";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMaDH.Text == "" || txtTenDH.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                DataTable dtb1 = new DataTable("SELECT * FROM DONGHO WHERE MADH = '" + txtMaDH.Text.Trim() + "'");
                if(dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Mã đồng hồ đã tồn tại!");
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm đồng hồ này?","Thông báo", MessageBoxButtons.OKCancel);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO DONGHO VALUES('" + txtMaDH.Text.Trim() + "', '" + txtTenDH.Text.Trim() + "', " + txtGiaBan.Text.Trim() + ", " + txtGiaNhap.Text.Trim() + ", 0, '" + cbbHang.SelectedValue.ToString() + "', '" + cbbLoai.SelectedValue.ToString() + "')");
                        MessageBox.Show("Đã thêm thành công!");
                        this.Close();
                    }    
                }    
            }    
        }
    }
}