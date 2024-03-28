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
    public partial class fmChuyenPhong : Form
    {
        string ma;
        public fmChuyenPhong(string mataisan)
        {
            InitializeComponent();
            ma = mataisan;
        }

        private void fmChuyenPhong_Load(object sender, EventArgs e)
        {
            loadDataCombobox();
        }

        private void loadDataCombobox()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM Phong;";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataSet ds1 = new DataSet();
            string getEmpSQL1 = "SELECT MaPhong FROM TaiSan WHERE MaTaiSan='" + ma + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            try
            {
                conn.Open();
                sda.Fill(ds);
                sda1.Fill(ds1);
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            cbbPhongBan.DataSource = ds.Tables[0];
            cbbPhongBan.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbPhongBan.ValueMember = ds.Tables[0].Columns[0].ToString();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString() == ds1.Tables[0].Rows[0][0].ToString())
                    cbbPhongBan.SelectedValue = ds.Tables[0].Rows[i][0].ToString();

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                string phongban = cbbPhongBan.SelectedValue.ToString();

                if (phongban != "") 
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    
                    cmd.CommandText = " UPDATE TaiSan SET MaPhong='"+phongban+"' WHERE MaTaiSan='"+ma+"'";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Chuyển Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Chuyển Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Bạn chưa chọn vị trí chuyển", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
