using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1.FormUI
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
           

            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void dangnhap()
        {
            string tentaikhoan = txtUserName.Text;
            string matkhau = MyFunctions.CreateMD5(txtPassword.Text);

            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM Accounts WHERE UserName='" + tentaikhoan + "' AND Password='" + matkhau + "'";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            if (ds.Tables[0].Rows.Count == 1)
            {
                string displayname = ds.Tables[0].Rows[0][2].ToString();
                string username = ds.Tables[0].Rows[0][0].ToString();
                MessageBox.Show("Xin Chào '" + ds.Tables[0].Rows[0][2].ToString() + "' ", "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowHome(displayname, username);
                this.Close(); //đóng Form Login
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowHome(string displayname, string username)
        {
            fmMain f = new fmMain(displayname,username);
            f.ShowDialog();
        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void fmLogin_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {

            fmDangKyTaiKhoan fm = new fmDangKyTaiKhoan();
            fm.ShowDialog();
        }
    }
}
