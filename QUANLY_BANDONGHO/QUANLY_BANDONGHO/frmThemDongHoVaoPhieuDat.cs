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
    public partial class frmThemDongHoVaoPhieuDat : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDongHoVaoPhieuDat()
        {
            InitializeComponent();
        }


        private void frmThemDongHoVaoPhieuDat_Load(object sender, EventArgs e)
        {
            cbbTenDH.DataSource = Program.ExecSqlDataTable("SELECT MADH, TENDH FROM DONGHO");
            cbbTenDH.DisplayMember = "TENDH";
            cbbTenDH.ValueMember = "MADH";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dtb1 = new DataTable();
                dtb1 = Program.ExecSqlDataTable("SELECT * FROM CT_PHIEUDAT WHERE MAPD = '" + Program.idpd + "' AND MADH = '" + cbbTenDH.SelectedValue.ToString() + "'");
                if (dtb1.Rows.Count > 0)
                {
                    MessageBox.Show("Phiếu này đã có loại đồng hồ này\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn muốn thêm đồng hồ " + cbbTenDH.Text.Trim() + " vào phiếu này?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        Program.ExecSqlNonQuery("INSERT INTO CT_PHIEUDAT VALUES('" + Program.idpd + "', '" + cbbTenDH.SelectedValue.ToString() + "', " + txtSoLuong.Text.Trim() + ")");
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