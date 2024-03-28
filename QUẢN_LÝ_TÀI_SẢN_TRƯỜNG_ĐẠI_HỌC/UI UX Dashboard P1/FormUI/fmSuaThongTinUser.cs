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
    public partial class fmSuaThongTinUser : Form
    {
        string UserName;
        public fmSuaThongTinUser(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void fmSuaThongTinUser_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM Accounts WHERE UserName='"+UserName+"'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            txtUserName.Text = dt.Rows[0][0].ToString().Trim();
            txtDisplayname.Text = dt.Rows[0][2].ToString().Trim();
            txtPassword.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                luuKhongCoPass();
            else
                luuCoPass();
        }

        private void luuKhongCoPass()
        {
            try
            {
                if (txtUserName.Text != "" && txtDisplayname.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Accounts SET UserName='" + txtUserName.Text + "',Displayname='"+txtDisplayname.Text+"' WHERE UserName='" + UserName+ "'";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                   
                    }
                    else
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void luuCoPass()
        {
            try
            {
                if (txtUserName.Text != "" && txtDisplayname.Text != "" && txtPassword.Text!="")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Accounts SET UserName='" + txtUserName.Text + "',Displayname='" + txtDisplayname.Text+ "', Password='"+MyFunctions.CreateMD5(txtPassword.Text)+"' WHERE UserName='" + UserName + "'";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Sửa Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
