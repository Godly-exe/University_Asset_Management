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
    public partial class fmBaoHanh : Form
    {
        string ma;
        public fmBaoHanh( string mataisan)
        {
            InitializeComponent();
            ma = mataisan;
        }

        private void fmBaoHanh_Load(object sender, EventArgs e)
        {
            if (ma != "")
            {
                loadData();
                txtTenTaiSan.Enabled = false;
                txtTenTaiSan.Visible = true;

               
                loadNhanVien();
            }
            else
            {
                cbbTenTaiSan.Visible = true;
                loadComboboxTS();
                loadNhanVien();
            }
               


            
        }

        private void loadNhanVien()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT * FROM NhanVien;";
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

            cbbNguoiSua.DataSource = ds.Tables[0];
            cbbNguoiSua.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbNguoiSua.ValueMember = ds.Tables[0].Columns[0].ToString();
        }

        private void loadComboboxTS()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT MaTaiSan,TenTaiSan FROM TaiSan";
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
            cbbTenTaiSan.DataSource = ds.Tables[0];
            cbbTenTaiSan.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cbbTenTaiSan.ValueMember = ds.Tables[0].Columns[0].ToString();
        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(ConnectDB.str);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT MaTaiSan,TenTaiSan FROM TaiSan WHERE MaTaiSan='" + ma + "'";
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
            txtTenTaiSan.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btnRamdo_Click(object sender, EventArgs e)
        {
            string ten = "SC";
           txtMaSuaChua.Text= MyFunctions.RandomChar(ten);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ma == "")
            {
                luuKhongMa();
            }
            else
                luuCoMa();
        }

        private void luuCoMa()
        {
            try
            {

                if (txtMaSuaChua.Text != "")
                {
                    string trangthai = "";
                    if (rdbDaSua.Checked)
                        trangthai = "Đã sửa";
                    if (rdbDangChoSua.Checked)
                        trangthai = "Chờ xử lý";


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string nguoisua = cbbNguoiSua.SelectedValue.ToString();
                    string hinhthucsua = cbbHinhThucSua.SelectedText.ToString();
                    string giohientai = DateTime.Now.ToString();


                    cmd.CommandText = " INSERT INTO SuaChuaTaiSan VALUES('" + txtMaSuaChua.Text + "','" + ma + "','" + giohientai + "','" + txtGiaSuaChua.Value + "','" + nguoisua + "',N'" + hinhthucsua + "',N'" + rtbGhiChu.Text + "',N'" + trangthai + "')";
                    int result = cmd.ExecuteNonQuery();





                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTextBox();
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void luuKhongMa()
        {
            try
            {

                if (txtMaSuaChua.Text != "")
                {
                    string trangthai = "";
                    if (rdbDaSua.Checked)
                        trangthai = "Đã sửa";
                    if (rdbDangChoSua.Checked)
                        trangthai = "Chờ xử lý";


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConnectDB.str;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    string mataisan = cbbTenTaiSan.SelectedValue.ToString();
                    string nguoisua = cbbNguoiSua.SelectedValue.ToString();
                    string hinhthucsua = cbbHinhThucSua.SelectedItem.ToString();
                    string giohientai = DateTime.Now.ToString();


                    cmd.CommandText = " INSERT INTO SuaChuaTaiSan VALUES('" + txtMaSuaChua.Text + "','" + mataisan +"','" + giohientai + "','" + txtGiaSuaChua.Value + "','" + nguoisua + "',N'" + hinhthucsua + "',N'" + rtbGhiChu.Text + "',N'" + trangthai + "')";
                    int result = cmd.ExecuteNonQuery();





                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTextBox();

                    }
                    else
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTextBox();
                    }

                    con.Close();
                }
                else
                    MessageBox.Show("Không được để trống dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void clearTextBox()
        {
            txtMaSuaChua.Clear();
            txtTenTaiSan.Clear();
            txtGiaSuaChua.Value = 0;
            rtbGhiChu.Clear();
            cbbHinhThucSua.Refresh();
            rdbDangChoSua.Checked = false;
            rdbDaSua.Checked = false;
        }
    }
}
