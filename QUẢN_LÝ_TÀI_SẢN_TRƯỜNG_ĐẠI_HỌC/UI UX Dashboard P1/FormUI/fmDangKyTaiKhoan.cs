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
    public partial class fmDangKyTaiKhoan : Form
    {
        public fmDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();


            DataTable ds = new DataTable();
            string getEmpSQL = "SELECT COUNT(*) AS dem FROM Accounts WHERE UserName='" + txtUsername.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, con);
            sda.Fill(ds);

            string result = ds.Rows[0][0].ToString();
           
            




            if (result=="0")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Accounts VALUES('" + txtUsername.Text + "',N'" + MyFunctions.CreateMD5(txtPassword.Text) + "','" + txtDisplayname.Text + "')";
                int result1 = cmd.ExecuteNonQuery();
                if (result1 > 0)
                {
                    MessageBox.Show("Đăng kí tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   
                }
                else
                    MessageBox.Show("Đăng kí tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
