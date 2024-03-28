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
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1.FormUI
{
    public partial class fmDoiPass : Form
    {
        string user;
        public fmDoiPass(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Accounts WHERE UserName='" + user + "'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);


            string pass = dt.Rows[0][1].ToString().Trim();
            string pass_old = MyFunctions.CreateMD5(txtPassword_Old.Text).Trim();
           

            if (pass_old == pass)
            {
                if (txtPassword_New.Text == txtPassword_ReNew.Text)
                {
                    string password = MyFunctions.CreateMD5(txtPassword_New.Text);

                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con;
                    cmd1.CommandText = "UPDATE Accounts SET Password='" + pass + "' WHERE UserName='" + user + "'";
                    SqlDataReader sdr1;
                    sdr1 = cmd1.ExecuteReader();
                }
                else
                    MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Mật khẩu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
        }

        private void txtPassword_Old_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_New_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_ReNew_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
