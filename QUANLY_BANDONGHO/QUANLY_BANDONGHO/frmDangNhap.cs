using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_BANDONGHO
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private bool isNhanVien = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isNhanVien == false)
            {
                if(txtTenDN.Text == "" || txtMK.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    if(txtTenDN.Text == "CHUCUAHANG" || txtTenDN.Text == "chucuahang" && txtMK.Text == "123")
                    {
                        Program.mlogin = "CHUKN";
                        Program.password = "123";
                        if (Program.KetNoi() == 0)
                            return;
                        else
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                            Program.mHoten = "CHỦ CỦA HÀNG";
                            Program.mGroup = "CHUCUAHANG";
                            this.Close();
                        }
                    }  
                    else
                    {
                        MessageBox.Show("Tên đăng nhâp hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK);
                    }    
                }    

            }
            else
            {
                if(txtTenDN.Text == "" || txtMK.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được trống", "", MessageBoxButtons.OK);
                }    
                else
                {
                    Program.mlogin = "NVKN";
                    Program.password = "123";
                    if (Program.KetNoi() == 0)
                        return;
                    DataTable dr = Program.ExecSqlDataTable("select MANV, HOTEN = HO + ' ' + TEN FROM NHANVIEN WHERE MANV = '" + txtTenDN.Text.Trim() + "' AND PASSWORD = '" + txtMK.Text.Trim() + "';");
                    if(dr.Rows.Count <= 0)
                    {
                        MessageBox.Show("Đăng nhập thất bại!");
                        Program.conn.Close();
                        return;
                    }    
                    else
                    {
                        Program.manv = txtTenDN.Text.Trim();
                        Program.mGroup = "NHANVIEN";
                        Program.mHoten = dr.Rows[0]["HOTEN"].ToString();
                        MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK);
                        this.Close();
                    }    
                }    
            }  
            
        }

        private void cbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            isNhanVien = !isNhanVien;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain f = new frmMain();
            f.Show();
        }
    }
}