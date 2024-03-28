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
    public partial class fmSuaPhong : Form
    {
        string maPhong;
        public fmSuaPhong(string maphong)
        {
            InitializeComponent();
            maPhong = maphong;
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPhong.Text != "" && txtViTri.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE Phong SET TenPhong=N'" + txtTenPhong.Text + "',DienTich='"+txtDienTich.Value+"',ViTri=N'"+txtViTri.Text+"' WHERE MaPhong='" + maPhong + "'";
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

        private void fmSuaPhong_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT * FROM Phong WHERE MaPhong='"+maPhong+"'";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            if (dt.Rows.Count > 0)
            {
                txtTenPhong.Text = dt.Rows[0][1].ToString();
                txtViTri.Text = dt.Rows[0][3].ToString();
                txtDienTich.Value =Convert.ToInt32( dt.Rows[0][2].ToString());

            }
            else
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            con.Close();
        }
    }
}
