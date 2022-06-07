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
    public partial class frmThemDongHoVaoPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDongHoVaoPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmThemDongHoVaoPhieuNhap_Load(object sender, EventArgs e)
        {
            cbbTenDongHo.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH FROM DONGHO");
            cbbTenDongHo.DisplayMember = "TENDH";
            cbbTenDongHo.ValueMember = "MADH";
            //cbbTenDongHo.SelectedIndex = 0;
        }

        private void cbbTenDongHo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                DataTable dtb1 = new DataTable();
                dtb1 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUNHAP WHERE MAPN = '" + Program.idpn + "' AND MADH = '" + cbbTenDongHo.SelectedValue.ToString() + "'");
                if(dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Phiếu này đã có loại đồng hồ này\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm đồng hồ " + cbbTenDongHo.Text.Trim() + " vào phiếu này?", "Thông báo", MessageBoxButtons.OKCancel);
                    if(rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO CT_PHIEUNHAP VALUES('" + cbbTenDongHo.SelectedValue.ToString() + "', '" + Program.idpn + "', " + txtSoLuong.Text.Trim() + ")");
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
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