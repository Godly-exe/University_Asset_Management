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
    public partial class fmThongTinCaNhan : Form
    {
        string user;
        public fmThongTinCaNhan(string username)
        {
            InitializeComponent();
             user = username;
        }

        private void fmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectDB.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Accounts WHERE UserName='"+user+"'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            txtDisplayName.Text = dt.Rows[0][2].ToString();
            txtUserName.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
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
         
           
            string pass =  dt.Rows[0][1].ToString().Trim();
            string pass_old = MyFunctions.CreateMD5(txtPassword.Text).Trim();

            if (pass_old == pass)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "UPDATE Accounts SET DisplayName='" + txtDisplayName.Text + "' WHERE UserName='" + user + "'";
                int kq= cmd1.ExecuteNonQuery();
                if(kq>0)
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Mật khẩu sai","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);

            con.Close();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            fmDoiPass fm = new fmDoiPass(user);
            fm.ShowDialog();
        }

        private void xuiSuperButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
