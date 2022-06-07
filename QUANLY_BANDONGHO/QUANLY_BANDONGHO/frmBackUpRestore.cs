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
    public partial class frmBackUpRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmBackUpRestore()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackUp.Text = dlg.SelectedPath;
                btnBackUp.Enabled = true;
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string db = Program.conn.Database.ToString();
            if (txtBackUp.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đường dẫn!");
            }
            else
            {
                string command = "BACKUP DATABASE [" + db + "] TO DISK= '" + txtBackUp.Text + @"\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm") + ".bak'";
                //                Program.conn.Close();
                //                Program.conn.Open();
                //                SqlCommand command1 = new SqlCommand(command, Program.conn);
                //                command1.ExecuteNonQuery();
                Program.ExecSqlNonQuery(command);
                MessageBox.Show("Thành công!");
                btnBackUp.Enabled = false;
                //                Program.conn.Close();
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            // ofl.Filter = "SQL SERVER database backup files|.bak";
            ofl.Title = "Database restore";
            if (ofl.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofl.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Program.KetNoi();

            try
            {
                string cmd = string.Format("ALTER DATABASE [BANDONGHO] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand command = new SqlCommand(cmd, Program.conn);
                command.ExecuteNonQuery();

                string cmd1 = "USE MASTER RESTORE DATABASE [BANDONGHO] FROM DISK='" + txtRestore.Text.Trim() + "' WITH REPLACE;";
                SqlCommand command1 = new SqlCommand(cmd1, Program.conn);
                command1.ExecuteNonQuery();

                string cmd2 = string.Format("ALTER DATABASE [BANDONGHO] SET MULTI_USER");
                SqlCommand command2 = new SqlCommand(cmd2, Program.conn);
                command2.ExecuteNonQuery();

                MessageBox.Show("Thành công!");
                // Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}