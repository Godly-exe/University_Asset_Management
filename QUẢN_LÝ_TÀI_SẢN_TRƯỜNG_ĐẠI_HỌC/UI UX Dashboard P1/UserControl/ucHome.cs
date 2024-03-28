using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UI_UX_Dashboard_P1.Library;

namespace UI_UX_Dashboard_P1
{
    public partial class ucHome : UserControl
    {
        SqlConnection conn = new SqlConnection(ConnectDB.str);
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            loadCount();
        }

        private void loadCount()
        {
            
            DataTable dt = new DataTable();
            string getEmpSQL = "SELECT COUNT (*) FROM TaiSan";
            SqlDataAdapter sda = new SqlDataAdapter(getEmpSQL, conn);

            DataTable dt1 = new DataTable();
            string getEmpSQL1 = "SELECT COUNT (*) FROM NhanVien";
            SqlDataAdapter sda1 = new SqlDataAdapter(getEmpSQL1, conn);

            DataTable dt2 = new DataTable();
            string getEmpSQL2 = "SELECT COUNT (*) FROM NhaCungCap";
            SqlDataAdapter sda2 = new SqlDataAdapter(getEmpSQL2, conn);

            DataTable dt3 = new DataTable();
            string getEmpSQL3 = "SELECT COUNT (*) FROM PhongBan";
            SqlDataAdapter sda3 = new SqlDataAdapter(getEmpSQL3, conn);

            DataTable dt4 = new DataTable();
            string getEmpSQL4 = "SELECT COUNT (*) FROM PhieuThanhLy";
            SqlDataAdapter sda4 = new SqlDataAdapter(getEmpSQL4, conn);

            try
            {
                conn.Open();
                sda.Fill(dt);

                sda1.Fill(dt1);
                sda2.Fill(dt2);
                sda3.Fill(dt3);
                sda4.Fill(dt4);


            }
            catch (SqlException se)
            {
                MessageBox.Show("An error occured while connecting to database" + se.ToString());
            }
            finally
            {
                conn.Close();
            }

            lbTongTaiSan.Text = dt.Rows[0][0].ToString();
            lbTongNhanVien.Text = dt1.Rows[0][0].ToString();
            lbTongNhaCungCap.Text = dt2.Rows[0][0].ToString();
            lbTongPhongBan.Text = dt3.Rows[0][0].ToString();

            lbTongThanhLy.Text = dt4.Rows[0][0].ToString();

        }
    }
}
